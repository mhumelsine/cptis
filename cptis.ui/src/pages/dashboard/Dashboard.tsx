import { FC } from "react";
import DashboardBar from "./DashboardBar";
import DashboardGrid from "./DashboardGrid";
import SearchBar from "./SearchBar";

const Dashboard: FC = () => {
    console.log("Dashboard");
    return (<>
        <DashboardBar />
        <SearchBar />
        <DashboardGrid />
    </>);
};

export default Dashboard;
