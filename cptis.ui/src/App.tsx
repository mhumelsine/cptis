import { createBrowserRouter, RouterProvider } from "react-router-dom";
import Layout from "./pages/layout/Layout";
import { initializeIcons } from "@fluentui/react";
import { PublicClientApplication } from "@azure/msal-browser";
import { MsalProvider } from "@azure/msal-react";
import CptisHomePage from "./pages/CptisHomePage";
import NotFound from "./pages/NotFound";
import "./index.css";
import AbuseReportPage from "./pages/abuse-report/AbuseReportPage";
import Dashboard from "./pages/dashboard/Dashboard";
import { cptisRoutes } from "./common/types";
import { FluentProvider, webLightTheme } from "@fluentui/react-components";
import useAuthentication from "./common/hooks/useAuthentication";
import FluentuiFormStateless from "./pages/form-test/fluentui-form";
import MantineFormStateless from "./pages/form-test/mantine-fom";
import { createTheme, MantineProvider } from "@mantine/core";
import "@mantine/core/styles.css";

initializeIcons();

const router = createBrowserRouter([
  {
    path: cptisRoutes.root,
    element: <Layout />,
    children: [
      {
        index: true,
        element: <CptisHomePage />,
      },
      {
        path: cptisRoutes.newReport,
        element: <AbuseReportPage />,
      },
      {
        path: cptisRoutes.dashboard,
        element: <Dashboard />,
      },
      {
        path: cptisRoutes.clientDemographic,
        element: (
          <> TODO: Create component for: {cptisRoutes.clientDemographic} </>
        ),
      },
      {
        path: cptisRoutes.provider,
        element: <> TODO: Create component for: {cptisRoutes.provider} </>,
      },
      {
        path: cptisRoutes.reports,
        element: <> TODO: Create component for: {cptisRoutes.reports} </>,
      },
      {
        path: cptisRoutes.administration,
        element: (
          <> TODO: Create component for: {cptisRoutes.administration} </>
        ),
      },
      {
        path: "fluentui-form",
        element: <FluentuiFormStateless />,
      },
      {
        path: "mantine-form",
        element: (
          <MantineProvider theme={createTheme({})}>
            <MantineFormStateless />
          </MantineProvider>
        ),
      },
      {
        path: cptisRoutes.all,
        element: <NotFound />,
      },
    ],
  },
]);

const App = () => {
  const { data, isFetching } = useAuthentication();

  if (isFetching) {
    return <div>Logging you in...</div>;
  }

  return (
    <FluentProvider theme={webLightTheme}>
      <MsalProvider instance={data?.msalInstance as PublicClientApplication}>
        {" "}
        <RouterProvider router={router} />
      </MsalProvider>
    </FluentProvider>
  );
};

export default App;
