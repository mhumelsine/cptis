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

        <div className="flex flex-1 overflow-hidden">
            <SideMenu />            

            {/* Main Content */}
            <main className={`${styles.mainContent} flex-1 p-6 bg-gray-100 overflow-auto`}>
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
