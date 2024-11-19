import {
    makeStyles,
} from "@fluentui/react-components";

export const useInputStyles = makeStyles({
    root: {
        display: "grid",
        gridTemplateRows: "repeat(1fr)",
        justifyItems: "start",
        gap: "2px",
       
    },
    text: {
        display: "flex",
        flexDirection: "column",
        gap: "2px",
    },
    maxWidth: {
        maxWidth: "300px",
      },
    // TODO: change label orientation?  
});

export type BaseInputProps = {
    label?: string;
};