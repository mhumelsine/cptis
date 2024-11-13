import { FC } from "react";
import styles from "./Layout.module.css";
import { Outlet } from "react-router-dom";
import LandingPage from "../../LandingPage";
import { AuthenticatedTemplate, UnauthenticatedTemplate } from "@azure/msal-react";
import SideMenu from "./SideMenu";
import TopMenu from "./TopMenu";

const Layout: FC = () => {

    return <div className={styles.layout}>
        <TopMenu />       

        <div className="tw-flex tw-flex-1 tw-overflow-hidden">
            <SideMenu />            

            {/* Main Content */}
            <main className={`${styles.mainContent} tw-flex-1 tw-p-6 tw-bg-gray-100 tw-overflow-auto`}>
                <AuthenticatedTemplate>
                    <Outlet />
                </AuthenticatedTemplate>
                <UnauthenticatedTemplate>
                    <LandingPage />
                </UnauthenticatedTemplate>
            </main>
        </div>
    </div>
};

export default Layout;
