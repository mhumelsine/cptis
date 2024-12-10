import React from "react";
import { Checkbox, CheckboxProps } from "@fluentui/react-components";
import withField from "./withField";
import { BaseInputProps } from "./types";

type CustomInputProps = BaseInputProps & Omit<CheckboxProps, "id">;

const BaseInput: React.FC<CustomInputProps> = (props) => {
  return <Checkbox {...props} id={props.id} name={props.name ?? props.id} />;
};

const CustomCheckbox = withField(BaseInput);

export default CustomCheckbox;
