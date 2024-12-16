import { FC } from "react";
import DashboardBar from "./DashboardBar";
import DashboardGrid from "./DashboardGrid";
import SearchBar from "./SearchBar";
import GridPOC from "./GridPOC";

const Dashboard: FC = () => {
  return (
    <>
      <DashboardBar />
      <SearchBar />
      <DashboardGrid />

      <div className="tw-container tw-mx-auto tw-mt-8">
        <h1 className="tw-text-2xl tw-font-bold tw-mb-4">Clients Table</h1>
        <GridPOC />
      </div>
    </>
  );
};

export default Dashboard;
