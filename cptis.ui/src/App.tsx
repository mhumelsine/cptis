import { createBrowserRouter, RouterProvider } from "react-router-dom";
import Layout from "./pages/layout/Layout";
import { initializeIcons } from "@fluentui/react";
import { Configuration, PublicClientApplication } from "@azure/msal-browser";
import { MsalProvider } from "@azure/msal-react";
import { useQuery } from "@tanstack/react-query";
import { AuthConfig } from "./authTypes";
import { fetchAuthConfig } from "./api/AuthConfigApi";
import CptisHomePage from "./pages/CptisHomePage";
import NotFound from "./pages/NotFound";
import "./index.css";
import AbuseReportPage from "./pages/abuse-report/AbuseReportPage";
import Dashboard from "./pages/dashboard/Dashboard";
import { cptisRoutes } from "./common/types";
import { FluentProvider, webLightTheme } from '@fluentui/react-components';

initializeIcons();

const router = createBrowserRouter([
    {
        path: cptisRoutes.root,
        element: <Layout />,
        children: [
            {
                index: true,
                element: <CptisHomePage />
            },
            {
                path: cptisRoutes.newReport,
                element: <AbuseReportPage />
            },
            {
                path: cptisRoutes.dashboard,
                element: <Dashboard />
            },
            {
                path: cptisRoutes.clientDemographic,
                element: <> TODO: Create component for: {cptisRoutes.clientDemographic } </>
            },
            {
                path: cptisRoutes.provider,
                element: <> TODO: Create component for: {cptisRoutes.provider} </>
            },
            {
                path: cptisRoutes.reports,
                element: <> TODO: Create component for: {cptisRoutes.reports} </>
            },
            {
                path: cptisRoutes.administration,
                element: <> TODO: Create component for: {cptisRoutes.administration} </>
            },
            {
                path: cptisRoutes.all,
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

    return <FluentProvider theme={webLightTheme}>
        <MsalProvider instance={authData.msalInstance}>
        <RouterProvider router={router} />
        </MsalProvider>
    </FluentProvider>
};

export default App;
