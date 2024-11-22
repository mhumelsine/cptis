import React from "react";
import { FieldProps } from "@fluentui/react-components";
import withField from "./withField";
import { Dropdown, Option, DropdownProps } from "@fluentui/react-components";
import { BaseInputProps } from "./types";

type Props = {
  options?: string[];
  disabledOption?: string;
} & BaseInputProps &
  Omit<FieldProps, "label"> &
  DropdownProps;

const BaseInput: React.FC<Props> = (props) => {
  return (
    <Dropdown placeholder={props.placeholder} {...props}>
      {props?.options?.map((option) => (
        <Option key={option} disabled={option === props.disabledOption}>
          {option}
        </Option>
      ))}
    </Dropdown>
  );
};

const CustomDropdown = withField(BaseInput);

export default CustomDropdown;
