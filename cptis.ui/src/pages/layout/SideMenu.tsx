import { FC } from "react";
import useAuthService from '../../common/hooks/useAuthService';
import { AuthenticatedTemplate, UnauthenticatedTemplate } from '@azure/msal-react';
import {
    AddSquareRegular,
    ArrowEnterFilled,
    DataPieRegular,
    PersonCircleRegular,
    BuildingPeopleRegular,
    DocumentBulletListMultipleRegular,
    SettingsFilled,
    PowerFilled

} from '@fluentui/react-icons';
import styles from "./Layout.module.css";
import SideMenuItem, { SideMenuItemButton } from "./SideMenuItem";
import { cptisRoutes } from "../../common/types";

const SideMenu: FC = () => {
    const { login, logout } = useAuthService();

    return <aside className={`${styles.sidebar} tw-w-[125px] tw-flex tw-flex-col tw-border-r-2 tw-border-black-600`}>
        <nav className="tw-flex tw-flex-col tw-h-full">
            <AuthenticatedTemplate>
                <ul>
                    <SideMenuItem
                        title="Add Abuse Report"
                        icon={AddSquareRegular}
                        iconSize={50}
                        path={cptisRoutes.newReport}
                    />
                    <SideMenuItem
                        title="Dashboard"
                        text="Dashboard"
                        icon={DataPieRegular}
                        iconSize={50}
                        path={cptisRoutes.dashboard}
                    />
                    <SideMenuItem
                        title="Client Demographic"
                        text="Client Demographic"
                        icon={PersonCircleRegular}
                        iconSize={50}
                        path={cptisRoutes.clientDemographic}
                    />
                    <SideMenuItem
                        title="Provider"
                        text="Provider"
                        icon={BuildingPeopleRegular}
                        iconSize={50}
                        path={cptisRoutes.provider}
                    />
                    <SideMenuItem
                        title="Reports"
                        text="Reports"
                        icon={DocumentBulletListMultipleRegular}
                        iconSize={50}
                        path={cptisRoutes.reports}
                    />
                    <SideMenuItem
                        title="Admin"
                        text="Admin"
                        icon={SettingsFilled}
                        iconSize={50}
                        path={cptisRoutes.administration}
                    />
                </ul>
            </AuthenticatedTemplate>
            <div className="tw-mt-auto">
                <ul>
                    <AuthenticatedTemplate>
                        <SideMenuItemButton
                            title="Logout"
                            text="Logout"
                            icon={PowerFilled}
                            iconSize={50}
                            onClick={logout}
                        />
                    </AuthenticatedTemplate>
                    <UnauthenticatedTemplate>
                        <SideMenuItemButton
                            title="Login"
                            text="Login"
                            icon={ArrowEnterFilled}
                            iconSize={50}
                            onClick={login}
                        />
                    </UnauthenticatedTemplate>

                </ul>
            </div>
        </nav>
    </aside>
};

export default SideMenu;
