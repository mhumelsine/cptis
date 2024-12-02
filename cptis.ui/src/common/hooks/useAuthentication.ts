import { EventType, InteractionRequiredAuthError, PublicClientApplication } from "@azure/msal-browser";
import { AuthConfig, SessionInfo } from "../types";
import { useQuery } from "@tanstack/react-query";


const useAuthentication = () => {
     const {data, isFetching} = useQuery<SessionInfo>({
         queryKey: ["SESSION"], 
         queryFn: async () => {

            const response = await fetch("/account/auth-config");

            if (!response.ok) {
                console.log(`auth config error: ${response.status}`);
            }
        
            const data: AuthConfig = await response.json();
 
            const msalInstance = new PublicClientApplication(data.msalConfig);

            await msalInstance.initialize();

            if (!msalInstance.getActiveAccount() && msalInstance.getAllAccounts().length > 0) {
                msalInstance.setActiveAccount(msalInstance.getAllAccounts()[0]);
            }
            msalInstance.enableAccountStorageEvents();
            
            msalInstance.addEventCallback((event: any) => {
                if (event.eventType === EventType.LOGIN_SUCCESS && event.payload.account) {
                    const account = event.payload.account;
                    msalInstance.setActiveAccount(account);
                }
            });
              const token = await getAccessTokenAsync(msalInstance, data);
              
              return {
                msalInstance, 
                config:  data,
                accessToken: token ?? "",
                userInfo: {
                    email: msalInstance.getActiveAccount()?.username ?? "",
                    userName: msalInstance.getActiveAccount()?.name ?? ""
                }
          }
        },
        staleTime: 1000 * 60 * 10
});
     
   /* 
    React.useEffect(() => {
       (async () => {      
            if (isFetched && data) {
            const msalInstance = new PublicClientApplication(data.msalConfig);

            await msalInstance.initialize();

            if (!msalInstance.getActiveAccount() && msalInstance.getAllAccounts().length > 0) {
                msalInstance.setActiveAccount(msalInstance.getAllAccounts()[0]);
            }
            msalInstance.enableAccountStorageEvents();
            
            msalInstance.addEventCallback((event: any) => {
                if (event.eventType === EventType.LOGIN_SUCCESS && event.payload.account) {
                    const account = event.payload.account;
                    msalInstance.setActiveAccount(account);
                }
            });
              const token = await getAccessTokenAsync(msalInstance, data);
              
              setSessionInfo({
                msalInstance, 
                accessToken: token ?? "",
                userInfo: {
                email: msalInstance.getActiveAccount()?.username ?? "",
                userName: msalInstance.getActiveAccount()?.name ?? ""
                }
              });
            }
        })();
    }, [isFetched]);
*/
     
const getAccessTokenAsync = async (msal: PublicClientApplication, config: AuthConfig) => {
    if (!msal || !config) return null;
  const account = msal.getActiveAccount();
  
  if (!account) return null;

  try {
    const tokenInfo = await msal.acquireTokenSilent({
      ...config.loginRequest,
      account,
    });
    return tokenInfo.accessToken;
  } catch (error) {
      if (error instanceof InteractionRequiredAuthError) {
          try {
            const tokenInfo = await msal.acquireTokenPopup({
              ...config.loginRequest,
              account,
            });
            return tokenInfo.accessToken;
          } catch (popupError) {
            console.error("Popup login failed:", popupError);
            throw popupError;
          }
        } else {
          console.error("Silent token acquisition failed:", error);
          throw error;
        }
      }
}; 

    const login = async () => {
        if (!data?.msalInstance) throw new Error("MSAL instance not initialized");
       await data.msalInstance?.loginRedirect(data?.config.loginRequest)
            .catch((error) => console.log(error));
    };

    const logout = async () => {
        if (!data?.msalInstance) throw new Error("MSAL instance not initialized");
       await data.msalInstance?.logoutRedirect(data?.config.logoutRequest)
            .catch((error) => console.log(error));
    };    

   return {
    isFetching, 
    data, 
    login, 
    logout
};
};

export default useAuthentication;
