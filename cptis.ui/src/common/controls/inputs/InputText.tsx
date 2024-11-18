import * as React from "react";
import {
    Input,
    InputProps,
    Label,
    useId,
} from "@fluentui/react-components";
import { BaseInputProps, useInputStyles } from "./types";

type Props = InputProps & BaseInputProps;

export const InputText: React.FC<Props> = (props) => {
    const inputId = useId("input");

    const styles = useInputStyles();
    return (
        <div className={`${styles.text}`}>
            <Label htmlFor={inputId} size={props.size} disabled={props.disabled}>
                {props.label}
            </Label>
            <Input id={inputId} {...props} />
        </div>
    );
};

export default InputText;

