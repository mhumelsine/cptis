import { FluentIcon } from "@fluentui/react-icons";
import { FC } from "react";
import { cptisRoutes } from "../../common/types";
import { NavLink } from "react-router-dom";
import styles from "./Layout.module.css";

type BaseProps ={
    title?: string;
    icon: FluentIcon;
    text?: string;
    iconSize?: 50 | 30 | 15;
}

type ItemProps = BaseProps & { path: cptisRoutes; }
type ButtonProps = BaseProps & { onClick: () => void; }
const twStyles = "tw-py-2 tw-hover:bg-gray-200 tw-flex tw-items-center tw-justify-center tw-text-center";

const SideMenuItem: FC<ItemProps> = ({ title, icon, text, path, iconSize }) => {
    const Icon = icon;
    

    return <NavLink to={path}>
        {({ isActive }) => (
            <li className={`${twStyles} ${isActive ? `${styles.activeMenuItem}` : ""}`} style={{height:'100px'}} title={title} >
                <div>
                    <Icon fontSize={iconSize ?? 15} />
                    <div>{text}</div>
                </div>
            </li>
        )}
    </NavLink>
};

export default SideMenuItem;

export const SideMenuItemButton: FC<ButtonProps> = ({ title, icon, text, iconSize, onClick }) => {
    const Icon = icon;

    return <li className={`${twStyles}`} title={title} >
        <button onClick={onClick}>
            <Icon fontSize={iconSize ?? 15} />
            <div>{text}</div>
        </button>
    </li>
};