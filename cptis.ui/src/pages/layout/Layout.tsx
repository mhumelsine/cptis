import { FC, Fragment } from "react";
import styles from "./Layout.module.css";
import { Outlet } from "react-router-dom";
import { Button } from "@fluentui/react-components";
import { ArrowEnterFilled, ArrowExitFilled } from "@fluentui/react-icons";
import useAuthService from "../../useAuthService";
import LandingPage from "../../LandingPage";
import { AuthenticatedTemplate, UnauthenticatedTemplate } from "@azure/msal-react";

const Layout: FC = () => {
    const { login, logout,userInfo } = useAuthService();

    return <div className={styles.layout}>
        <header className={styles.header} role={"banner"}>
            <div className={styles.headerContainer}>
                <h3 className={styles.headerTitle}>
                    <span className={styles.verticalAlign}>
                        <img src="./flhealthLogo.svg" className={styles.logoStyle} width={"50px"} height={"50px"} />
                        <div >Child Protection Team Information System</div>
                    </span>
                </h3>

                <div>
                    <AuthenticatedTemplate>
                        <Fragment>{userInfo?.userName}
                            <Button
                                appearance="transparent"
                                icon={<ArrowExitFilled />}
                                onClick={logout}
                            >
                                Logout
                            </Button>
                        </Fragment>
                    </AuthenticatedTemplate>
                    <UnauthenticatedTemplate>
                        <Button
                            appearance="transparent"
                            icon={<ArrowEnterFilled />}
                            onClick={login}
                        >
                            Login
                        </Button>
                    </UnauthenticatedTemplate>
                </div>
            </div>
        </header>
        <AuthenticatedTemplate>
            <Outlet />
        </AuthenticatedTemplate>
        <UnauthenticatedTemplate>
            <LandingPage />
        </UnauthenticatedTemplate>
    </div>
};

export default Layout;
