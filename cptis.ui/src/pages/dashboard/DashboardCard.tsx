import React from "react";
import { IconType } from "react-icons";

interface DashboardCardProps {
  number: number;
  text: string;
  icon: IconType;
  bgColor: string;
  className?: string;
}

const DashboardCard: React.FC<DashboardCardProps> = ({
  number,
  text,
  icon,
  bgColor,
  className,
}) => {
  const Icon = icon;
  const cardSize: string =
    "tw-h-[125px] tw-w-[250px] tw-sm:w-[140px] tw-sm:h-[120px] tw-md:w-[250px] tw-md:h-[125px]";

  return (
    <div
      className={`tw-flex tw-flex-col ${cardSize} tw-rounded-lg ${bgColor} tw-text-white tw-pl-2 tw-shadow-xl ${className}`}
    >
      <div className="tw-flex tw-items-center tw-pt-4  tw-w-full">
        <Icon className="tw-text-6xl tw-sm:text-5xl tw-md:text-6xl tw-ml-4" />
        <span className="tw-text-7xl tw-sm:text-5xl tw-md:text-7xl tw-m-auto tw-font-bold">
          {number}
        </span>
      </div>

      <div className="tw-flex tw-w-full">
        <span className="tw-text-sm tw-text-right tw-pt-2 tw-truncate">
          {text}
        </span>
      </div>
    </div>
  );
};

export default DashboardCard;
