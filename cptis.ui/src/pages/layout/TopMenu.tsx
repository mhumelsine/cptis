import React, { FC } from "react";
import styles from "./Layout.module.css";
import { AuthenticatedTemplate } from "@azure/msal-react";
import useAuthentication from "../../common/hooks/useAuthentication";
import Persona from "../../common/controls/Persona";
import { Input } from "@mantine/core";
import { LuSearch } from "react-icons/lu";

const TopMenu: FC = () => {
  const { data } = useAuthentication();

  React.useEffect(() => {
    console.log(data);
  }, [data]);

  return (
    <header className={styles.header} role="banner">
      <div className={styles.headerContainer}>
        <h3 className={styles.headerTitle}>
          <span className={styles.verticalAlign}>
            <img
              title="CPTIS"
              src="./flhealthLogo.svg"
              className={styles.logoStyle}
              width="50px"
              height="50px"
            />
            <div>Child Protection Team Information System</div>
          </span>
        </h3>
        <AuthenticatedTemplate>
          <div className="tw-flex tw-flex-inline tw-gap-4">
            <div className="">
              <Input
                placeholder="Search client"
                radius="xl"
                leftSection={<LuSearch />}
              />
            </div>
            <Persona
              primaryText={data?.userInfo.userName ?? ""}
              secondaryText={data?.userInfo.email ?? ""}
            />
          </div>
        </AuthenticatedTemplate>
      </div>
    </header>
  );
};
export default TopMenu;
