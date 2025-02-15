import { StrictMode } from "react";
import { createRoot } from "react-dom/client";
import { BrowserRouter } from "react-router";
import "./index.css";
import App from "./App.tsx";
import "@mantine/core/styles.css";
import "@mantine/dates/styles.css";
import "@mantine/dropzone/styles.css";
import "@mantine/notifications/styles.css";
import { Container, createTheme, MantineProvider } from "@mantine/core";
import { DatesProvider } from "@mantine/dates";
import { Notifications } from "@mantine/notifications";
import "dayjs/locale/en";

const theme = createTheme({
  /** Put your mantine theme override here */
});

createRoot(document.getElementById("root")!).render(
  <StrictMode>
    <MantineProvider theme={theme}>
      <Notifications position="top-right" />
      <Container fluid>
        <DatesProvider
          settings={{
            locale: "en",
            firstDayOfWeek: 0,
            weekendDays: [0],
            timezone: "America/New_York",
          }}
        >
          <BrowserRouter>
            <App />
          </BrowserRouter>
        </DatesProvider>
      </Container>
    </MantineProvider>
  </StrictMode>,
);
