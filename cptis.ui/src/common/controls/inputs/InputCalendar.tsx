import * as React from "react";
import { Label, useId } from "@fluentui/react-components";
import { BaseInputProps, useInputStyles } from "./types";
import { DatePicker, DatePickerProps } from "@fluentui/react-datepicker-compat";

type Props = DatePickerProps & BaseInputProps;

export const InputText: React.FC<Props> = (props) => {
  const inputId = useId("inputCalendar");
  const styles = useInputStyles();

  return (
    <div className={`${styles.text}`}>
      <Label htmlFor={inputId} size={props.size} disabled={props.disabled}>
        {props.label}
      </Label>
      <DatePicker
        className={styles.maxWidth + " " + props.className}
        placeholder="Select a date..."
        {...props}
      />
    </div>
  );
};

export default InputText;
