import { EventType, InteractionRequiredAuthError } from "@azure/msal-browser";
import { fetchAuthConfig } from "../../api/AuthConfigApi";
import { useQuery } from "@tanstack/react-query";
import { useEffect, useState } from "react";

export interface UserInfo {
    userName: string;
    email: string;
}

const useAuthService = () => {
    const { data: auth } = useQuery({
        queryFn: fetchAuthConfig,
        queryKey: ["authorization"],
        staleTime: 1000 * 60 * 60 * 24 // cached for 1 day or refresh the page.
    });

    const [userInfo, setUserInfo] = useState<UserInfo | null>(null);

    useEffect(() => {
        if (!auth?.msalInstance) return;
            const callbackId = auth.msalInstance.addEventCallback((event:any) => {
                if (event?.eventType === EventType.LOGIN_SUCCESS) {
                    const account = event?.payload?.account;                   
                    if (account) {
                        console.log("account:", account);
                        setUserInfo({
                            userName: account.name ?? "",
                            email: account.username,
                        });
                    }
                } else if (event.eventType === EventType.LOGOUT_SUCCESS) {
                    setUserInfo(null); // Clear user info on logout
                }
            });
        
        // Cleanup event listener on unmount
        return () => {
            if (callbackId) {
                auth.msalInstance.removeEventCallback(callbackId);
            }
        };

    }, [auth?.msalInstance]);

    const login = async () => {
        auth?.msalInstance.loginRedirect(auth.jsonConfig.loginRequest)
            .catch((error) => console.log(error));
    };

    const logout = async () => {
        auth?.msalInstance.logoutRedirect(auth.jsonConfig.logoutRequest)
            .catch((error) => console.log(error));
    };

    
const getAccessTokenAsync = async () => {
    if (!auth?.msalInstance) return null;
  const account = auth.msalInstance.getActiveAccount();
  
  if (!account) return null;

  try {
    const tokenInfo = await auth.msalInstance.acquireTokenSilent({
      ...auth.jsonConfig.loginRequest,
      account,
    });
    return tokenInfo.accessToken;
  } catch (error) {
      if (error instanceof InteractionRequiredAuthError) {
          try {
            const tokenInfo = await auth.msalInstance.acquireTokenPopup({
              ...auth.jsonConfig.loginRequest,
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

    return { login, logout, userInfo, getAccessTokenAsync };
}

export default useAuthService;
