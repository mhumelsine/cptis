import {
    FieldProps
} from "@fluentui/react-components";


export type BaseInputProps = {
    id: string;
  label: string;
  info?: string;
}& Omit<FieldProps, "label">;