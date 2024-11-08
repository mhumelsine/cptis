import { FC } from "react";
import DashboardBar from "./DashboardBar";
import DashboardGrid from "./DashboardGrid";

const Dashboard: FC = () => {

    return (<>
        <DashboardBar />
        <DashboardGrid />
    </>);
};

export default Dashboard;
