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
