import React from "react";
import { FieldProps } from "@fluentui/react-components";
import withField from "./withField";
import { DatePicker, DatePickerProps } from "@fluentui/react-datepicker-compat";
import { BaseInputProps } from "./types";

type Props = BaseInputProps & Omit<FieldProps, "label"> & DatePickerProps;

const BaseInput: React.FC<Props> = (props) => {
  return <DatePicker placeholder="Select a date..." {...props} />;
};

const CustomCalendar = withField(BaseInput);

export default CustomCalendar;
