import { FC } from "react";
import { cptisRoutes } from "../../common/types";
import { NavLink } from "react-router-dom";
import styles from "./Layout.module.css";
import { IconType } from "react-icons/lib";

type BaseProps = {
  title?: string;
  icon: IconType;
  text?: string;
  iconSize?: number;
};

type ItemProps = BaseProps & { path: cptisRoutes };
type ButtonProps = BaseProps & { onClick: () => void };
const twStyles =
  "tw-py-2 tw-hover:bg-gray-200 tw-flex tw-items-center tw-justify-center tw-border";

const SideMenuItem: FC<ItemProps> = ({ title, icon, text, path, iconSize }) => {
  const Icon = icon;

  return (
    <NavLink to={path}>
      {({ isActive }) => (
        <li
          className={`${twStyles} ${
            isActive ? `${styles.activeMenuItem}` : ""
          }`}
          style={{ height: "100px" }}
          title={title}
        >
          <div className="tw-flex tw-flex-col tw-items-center tw-justify-center">
            <Icon
              fontSize={iconSize ?? 15}
              style={{
                filter: "drop-shadow(3px 2px 1px rgb(61, 61, 61))",
              }}
            />
            <div className="tw-font-bold tw-text-center">{text}</div>
          </div>
        </li>
      )}
    </NavLink>
  );
};

export default SideMenuItem;

export const SideMenuItemButton: FC<ButtonProps> = ({
  title,
  icon,
  text,
  iconSize,
  onClick,
}) => {
  const Icon = icon;

  return (
    <li className={`${twStyles}`} title={title}>
      <button onClick={onClick}>
        <Icon fontSize={iconSize ?? 15} />
        <div className="tw-font-medium">{text}</div>
      </button>
    </li>
  );
};
