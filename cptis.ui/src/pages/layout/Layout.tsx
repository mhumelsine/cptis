import { FC, Fragment } from "react";
import styles from "./Layout.module.css";
import { Outlet } from "react-router-dom";
import { Button } from "@fluentui/react-components";
import { ArrowEnterFilled, ArrowExitFilled } from "@fluentui/react-icons";
import useAuthService from "../../useAuthService";
import LandingPage from "../../LandingPage";

const Layout: FC = () => {
    const { login, logout, checkAuth, getUserInfo } = useAuthService();

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
                    {checkAuth()
                        ? <Fragment>{getUserInfo()?.userName}
                            <Button
                                appearance="transparent"
                                icon={<ArrowExitFilled />}
                                onClick={logout}
                            >
                                Logout
                            </Button>
                        </Fragment>
                        : <Button
                            appearance="transparent"
                            icon={<ArrowEnterFilled />}
                            onClick={login}
                        >
                            Login
                        </Button>
                    }
                </div>
            </div>
        </header>
        {checkAuth()
            ? <Outlet />
            : <LandingPage />
        }
    </div>
};

export default Layout;
