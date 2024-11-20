import React from "react";
import { Field, Input, LabelProps } from "@fluentui/react-components";
import { InfoLabel } from "@fluentui/react-components";
import { UseFormRegisterReturn } from "react-hook-form";

interface CustomInputProps {
  label: string;
  placeholder?: string;
  type?: "text" | "email" | "number" | "password";
  errorMessage?: string;
  register: UseFormRegisterReturn;
  validationState?: "error" | "warning" | "success";
  required?: boolean;
  info?: string;
  disabled?: boolean;
}

const CustomInput: React.FC<CustomInputProps> = ({
  label,
  placeholder,
  type = "text",
  errorMessage,
  register,
  validationState,
  required = false,
  info,
  disabled,
}) => {
  return (
    <Field
      label={
        info
          ? ({
              children: (_: unknown, slotProps: LabelProps) => {
                return (
                  <InfoLabel {...slotProps} info={info}>
                    {label}
                  </InfoLabel>
                );
              },
            } as any)
          : label
      }
      validationState={validationState}
      validationMessage={errorMessage}
      required={required}
    >
      <Input
        {...register}
        type={type}
        placeholder={placeholder}
        disabled={disabled}
      />
    </Field>
  );
};

export default CustomInput;
