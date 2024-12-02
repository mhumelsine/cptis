import { PublicClientApplication } from "@azure/msal-browser";

export enum cptisRoutes {
    root = "/",
    newReport = "new-report",
    reports = "reports",
    dashboard = "dashboard",
    clientDemographic = "client-demographic",
    provider = "provider",
    administration = "administration",
    all = "*"
}

export interface MsalConfig {
    auth: {
        authority: string;
        clientId: string;
        redirectUri: string;
        postLogoutRedirectUri: string;
    };
    cache: {
        cacheLocation: string;
        storeAuthStateInCookie: boolean; // Set this to "true" if you are having issues on IE11 or Edge
    };
};

export interface LoginRequest {
    scopes: Array<string>;
};

export interface LogoutRequest {
    authority: string;
    onRedirectNavigate: (url: string) => boolean;
};

export interface AuthConfig {
    msalConfig: MsalConfig;
    loginRequest: LoginRequest;
    logoutRequest: LogoutRequest;
};

export interface UserInfo {
    userName: string;
    email: string;
};

export interface SessionInfo {
    userInfo: UserInfo;
    accessToken: string;
    msalInstance: PublicClientApplication;
    config: AuthConfig
};