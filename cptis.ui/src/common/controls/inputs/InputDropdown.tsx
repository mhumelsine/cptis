import * as React from "react";
import {
    Dropdown,
    Option,
    useId,
    DropdownProps
} from "@fluentui/react-components";
import { BaseInputProps, useInputStyles } from "./types";

type Props = DropdownProps
    & BaseInputProps
    & {
        options?: string[],
        disabledOption?: string
    };

export const InputDropdown: React.FC<Props> = (props) => {
    const dropdownId = useId("dropdown-default");

    const styles = useInputStyles();
    return (
        <div className={styles.root}>
            <label id={dropdownId}>{props.label}</label>
            <Dropdown
                aria-labelledby={dropdownId}
                placeholder={props.placeholder}
                {...props}
            >
                {props?.options?.map((option) => (
                    <Option key={option} disabled={option === props.disabledOption}>
                        {option}
                    </Option>
                ))}
            </Dropdown>
        </div>
    );
};
