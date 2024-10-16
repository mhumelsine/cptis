import { createHashRouter, RouterProvider } from "react-router-dom";
import Layout from "./pages/layout/Layout";
import { initializeIcons } from "@fluentui/react";
import { Configuration, PublicClientApplication } from "@azure/msal-browser";
import { MsalProvider } from "@azure/msal-react";
import { useQuery } from "@tanstack/react-query";
import { AuthConfig } from "./authTypes";
import { fetchAuthConfig } from "./api/AuthConfigApi";
import CptisHomePage from "./pages/CptisHomePage";
import NotFound from "./pages/NotFound";

initializeIcons();

const router = createHashRouter([
    {
        path: "/",
        element: <Layout />,
        children: [
            {
                index: true,
                element: <CptisHomePage />
            },
            {
                path: "first-route",
                element: <div>First Route</div>
            },
            {
                path: "*",
                element: <NotFound />
            }
        ]
    }
]);

const App = () => {
    const { data: auth, isPending } = useQuery({
        queryFn: fetchAuthConfig,
        queryKey: ["authorization"],
        staleTime: 1000 * 60 * 60 * 24 // cached for 1 day or refresh the page.
    });

    if (isPending) {
        return <div>Loading...</div>
    };

    const authData = auth ?? {
        msalInstance: new PublicClientApplication({} as Configuration),
        jsonConfig: {} as AuthConfig
    };

    return <MsalProvider instance={authData.msalInstance}>
        <RouterProvider router={router} />
    </MsalProvider>
};

export default App;
