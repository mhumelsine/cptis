import { createContext } from "react";

export const AuthConfigContext = createContext({
    msalConfig: {},
    loginRequest: {},
    logoutRequest: {}
});