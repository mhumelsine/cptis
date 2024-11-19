import { FC } from "react";
import styles from "./Layout.module.css";
import { Persona } from "@fluentui/react";
import { Field, SearchBox } from "@fluentui/react-components";
import { PersonRegular } from "@fluentui/react-icons";
import { AuthenticatedTemplate } from "@azure/msal-react";

const TopMenu: FC = () => {

    return <header className={styles.header} role="banner">
        <div className={styles.headerContainer}>
            <h3 className={styles.headerTitle}>
                <span className={styles.verticalAlign}>
                    <img src="./flhealthLogo.svg" className={styles.logoStyle} width="50px" height="50px" />
                    <div>Child Protection Team Information System</div>
                </span>
            </h3>
            <AuthenticatedTemplate>
                <div className="tw-flex tw-flex-inline">
                    <div className="">
                        <Field className="tw-mr-4 tw-mt-2">
                            <SearchBox
                                className={"tw-text-black tw-mx-1"}
                                contentBefore={<PersonRegular />}
                                placeholder="        search client"
                                style={{
                                    borderRadius: '100px',
                                    borderBottom: '0',
                                }}
                            />
                        </Field>

                    </div>
                    <Persona />
                </div>
            </AuthenticatedTemplate>
        </div>
    </header >
};
export default TopMenu;
