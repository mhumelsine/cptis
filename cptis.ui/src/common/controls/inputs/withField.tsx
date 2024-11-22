import {
  Field,
  FieldProps,
  InfoLabel,
  LabelProps,
} from "@fluentui/react-components";
import React from "react";

type Props = {
  label: string;
  info?: string;
} & Omit<FieldProps, "label">;

export const withField = <P extends Props>(
  WrappedComponent: React.ComponentType<P>,
  additionalProps?: Partial<P>
) => {
  const HOC: React.FC<Omit<P, keyof typeof additionalProps>> = (props) => {
    return (
      <Field
        {...props}
        label={
          props.info
            ? ({
                children: (_: unknown, slotProps: LabelProps) => {
                  return (
                    <InfoLabel
                      {...slotProps}
                      info={props.info}
                      required={props.required}
                    >
                      {props.label}
                    </InfoLabel>
                  );
                },
              } as any)
            : props.label
        }
      >
        <WrappedComponent {...(props as P)} />
      </Field>
    );
  };

  return HOC;
};

export default withField;
