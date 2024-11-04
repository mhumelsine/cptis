import { FC } from "react";
import styles from "./Layout.module.css";

const TopMenu: FC = () => {

    return <header className={styles.header} role="banner">
        <div className={styles.headerContainer}>
            <h3 className={styles.headerTitle}>
                <span className={styles.verticalAlign}>
                    <img src="./flhealthLogo.svg" className={styles.logoStyle} width="50px" height="50px" />
                    <div>Child Protection Team Information System</div>
                </span>
            </h3>
            <div>

            </div>
        </div>
    </header>
};
export default TopMenu;
