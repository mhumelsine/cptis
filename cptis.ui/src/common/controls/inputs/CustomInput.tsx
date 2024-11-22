import React from "react";
import { Input, InputProps } from "@fluentui/react-components";
import withField from "./withField";
import { BaseInputProps } from "./types";

type CustomInputProps = BaseInputProps & Omit<InputProps, "id">;

const BaseInput: React.FC<CustomInputProps> = (props) => {
  return <Input {...props} id={props.id} name={props.name ?? props.id} />;
};

const CustomInput = withField(BaseInput);

export default CustomInput;
