import { FC, Fragment } from "react";
import useAuthService from '../../useAuthService';
import { AuthenticatedTemplate, UnauthenticatedTemplate } from '@azure/msal-react';
import { AddSquare48Regular, ArrowEnterFilled, ArrowExitFilled } from '@fluentui/react-icons';
import { Button } from '@fluentui/react-components';
import styles from "./Layout.module.css";
import { Link } from "react-router-dom";

const SideMenu: FC = () => {
    const { login, logout } = useAuthService();

    return <aside className={`${styles.sidebar} w-[125px] flex flex-col border-r-2 border-black-600`}>
        <nav className="flex flex-col h-full">
            <AuthenticatedTemplate>
                <ul>
                    <li className="py-2 hover:bg-gray-200 flex items-center justify-center" title="Add Abuse Report">
                        <Link to="/new-report">
                            <AddSquare48Regular />
                        </Link>
                    </li>
                    <li className="py-2 hover:bg-gray-700 rounded">Dashboard</li>
                    <li className="py-2 hover:bg-gray-700 rounded">Client Demographic</li>
                    <li className="py-2 hover:bg-gray-700 rounded">Provider</li>
                    <li className="py-2 hover:bg-gray-700 rounded">Rports</li>
                    <li className="py-2 hover:bg-gray-700 rounded">Admin</li>
                </ul>
            </AuthenticatedTemplate>
            <div className="mt-auto">
                <ul>
                    <li className="py-2 hover:bg-gray-700 rounded">
                        <AuthenticatedTemplate>
                            <Fragment>
                                <Button appearance="transparent" icon={<ArrowExitFilled />} onClick={logout}>
                                    Logout
                                </Button>
                            </Fragment>
                        </AuthenticatedTemplate>
                        <UnauthenticatedTemplate>
                            <Button appearance="transparent" icon={<ArrowEnterFilled />} onClick={login}>
                                Login
                            </Button>
                        </UnauthenticatedTemplate>
                    </li>
                </ul>
            </div>
        </nav>
    </aside>
};

export default SideMenu;
