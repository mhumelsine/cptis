import { FC } from "react";
import { IconType } from "react-icons";
import { FaUser } from "react-icons/fa";

type PersonaProps = {
  primaryText: string;
  secondaryText: string;
  icon?: IconType;
  avatarId?: string;
};

const Persona: FC<PersonaProps> = ({
  primaryText,
  secondaryText,
  icon: Icon = FaUser,
}) => {
  return (
    <div className="tw-flex tw-items-center tw-gap-2">
      <div>
        <div className="tw-text-white tw-font-bold tw-text-right">
          {primaryText}
        </div>
        <div className="tw-text-gray-300 tw-font-medium tw-text-sm tw-mt-[-5px]">
          {secondaryText}
        </div>
      </div>
      <div className="tw-ml-auto">
        <Icon fontSize={35} className="tw-text-white" />
      </div>
    </div>
  );
};

export default Persona;
