import { createBrowserRouter } from "react-router-dom";
import CptisHomePage from "./CptisHomePage";

const router = createBrowserRouter([
    {
        path: '/',
        element: <CptisHomePage />
    },
]);

export default router;
