import { FC } from "react";
import {
  AuthenticatedTemplate,
  UnauthenticatedTemplate,
} from "@azure/msal-react";

import {
  PiPrinterThin,
  PiBuildingApartmentThin,
  PiMapPinAreaThin,
  PiChartBarThin,
  PiFilePlusThin,
  PiUserGearThin,
  PiPowerThin,
  PiArrowLineRightThin,
} from "react-icons/pi";

import styles from "./Layout.module.css";
import SideMenuItem, { SideMenuItemButton } from "./SideMenuItem";
import { cptisRoutes } from "../../common/types";
import useAuthentication from "../../common/hooks/useAuthentication";

const SideMenu: FC = () => {
  const { login, logout } = useAuthentication();

  return (
    <aside
      className={`${styles.sidebar} tw-w-[150px] tw-flex tw-flex-col tw-border-r-2 tw-border-black-600`}
    >
      <nav className="tw-flex tw-flex-col tw-h-full">
        <AuthenticatedTemplate>
          <ul>
            <SideMenuItem
              title="Add Abuse Report"
              icon={PiFilePlusThin}
              iconSize={60}
              path={cptisRoutes.newReport}
            />
            <SideMenuItem
              title="Dashboard"
              text="Dashboard"
              icon={PiChartBarThin}
              iconSize={45}
              path={cptisRoutes.dashboard}
            />
            <SideMenuItem
              title="Client Demographic"
              text="Client Demographic"
              icon={PiMapPinAreaThin}
              iconSize={45}
              path={cptisRoutes.clientDemographic}
            />
            <SideMenuItem
              title="Provider"
              text="Provider"
              icon={PiBuildingApartmentThin}
              iconSize={45}
              path={cptisRoutes.provider}
            />
            <SideMenuItem
              title="Reports"
              text="Reports"
              icon={PiPrinterThin}
              iconSize={45}
              path={cptisRoutes.reports}
            />
            <SideMenuItem
              title="Admin"
              text="Admin"
              icon={PiUserGearThin}
              iconSize={45}
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
                icon={PiPowerThin}
                iconSize={45}
                onClick={logout}
              />
            </AuthenticatedTemplate>
            <UnauthenticatedTemplate>
              <SideMenuItemButton
                title="Login"
                text="Login"
                icon={PiArrowLineRightThin}
                iconSize={45}
                onClick={login}
              />
            </UnauthenticatedTemplate>
          </ul>
        </div>
      </nav>
    </aside>
  );
};

export default SideMenu;
