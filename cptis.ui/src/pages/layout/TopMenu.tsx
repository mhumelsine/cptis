import { FC } from "react";
import styles from "./Layout.module.css";
import { Persona } from "@fluentui/react";
import { Field, SearchBox } from "@fluentui/react-components";
import { PersonRegular } from "@fluentui/react-icons";

const TopMenu: FC = () => {

    return <header className={styles.header} role="banner">
        <div className={styles.headerContainer}>
            <h3 className={styles.headerTitle}>
                <span className={styles.verticalAlign}>
                    <img src="./flhealthLogo.svg" className={styles.logoStyle} width="50px" height="50px" />
                    <div>Child Protection Team Information System</div>
                </span>
            </h3>
            <div className="flex flex-inline">
                <div className="">
                    <Field className=" bg-white rounded-full mr-4 mt-2">
                        <SearchBox
                            className={"text-black mx-1"}
                            contentBefore={<PersonRegular />}
                            placeholder="        search client"
                        />
                    </Field>
                </div>
                <Persona />
            </div>
        </div>
    </header>
};
export default TopMenu;
