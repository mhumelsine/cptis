import { EventType, PublicClientApplication } from "@azure/msal-browser";
import { AuthConfig } from "../authTypes";

export const fetchAuthConfig = async () => {

    const response = await fetch("/account/auth-config");

    if (!response.ok) {
        console.log(`auth config error: ${response.status}`);
    }

    const jsonConfig: AuthConfig = await response.json();

    const msalInstance = new PublicClientApplication(jsonConfig.msalConfig);

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

    return { msalInstance, jsonConfig };
};