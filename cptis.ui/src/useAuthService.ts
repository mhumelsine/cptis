import { AccountInfo } from "@azure/msal-browser";
import { fetchAuthConfig } from "./api/AuthConfigApi";
import { useQuery } from "@tanstack/react-query";

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

    const login = async () => {

        auth?.msalInstance.loginRedirect(auth.jsonConfig.loginRequest)
            .catch((error) => console.log(error));
    };

    const logout = async () => {

        auth?.msalInstance.logoutRedirect(auth.jsonConfig.logoutRequest)
            .catch((error) => console.log(error));
    };

    const checkAuth = (): boolean => {
        if (auth?.msalInstance) {
            const accounts: AccountInfo[] = auth.msalInstance.getAllAccounts();
            return accounts && accounts.length > 0;
        }
        return false
    };

    const getUserInfo = (): UserInfo | null => {
        if (auth?.msalInstance) {
            const accounts: AccountInfo[] = auth?.msalInstance.getAllAccounts();
            const account = accounts[0];

            return accounts && accounts.length > 0
                ? {
                    userName: account.name,
                    email: account.username
                } as UserInfo
                : null;
        }

        return null
    };

    return { login, logout, checkAuth, getUserInfo };
}

export default useAuthService;
