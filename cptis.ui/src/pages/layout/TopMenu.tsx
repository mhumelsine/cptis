import { FC } from "react";
import styles from "./Layout.module.css";
import { Field, SearchBox, Persona } from "@fluentui/react-components";
import { PersonRegular } from "@fluentui/react-icons";
import { AuthenticatedTemplate } from "@azure/msal-react";
import useAuthentication from "../../common/hooks/useAuthentication";

const TopMenu: FC = () => {
  const { data } = useAuthentication();

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
          <div className="tw-flex tw-flex-inline">
            <div className="">
              <Field className="tw-mr-8">
                <SearchBox
                  className={"tw-text-black tw-mx-1"}
                  contentBefore={<PersonRegular />}
                  placeholder="        search client"
                  style={{
                    borderRadius: "100px",
                    borderBottom: "0",
                  }}
                />
              </Field>
            </div>
            <Persona
              textPosition="before"
              primaryText={
                <span className="tw-text-white tw-font-bold">
                  {data?.userInfo.userName}
                </span>
              }
              secondaryText={
                <span className="tw-text-gray-300">{data?.userInfo.email}</span>
              }
            />
          </div>
        </AuthenticatedTemplate>
      </div>
    </header>
  );
};
export default TopMenu;
