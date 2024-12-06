import { FC } from "react";
import DashboardBar from "./DashboardBar";
import DashboardGrid from "./DashboardGrid";
import SearchBar from "./SearchBar";
import useApi from "../../api/hooks/useApi";
import { ApiEndpoints } from "../../api/endpoints";

const Dashboard: FC = () => {
  const api = useApi();

  const { data, isFetched } = api.GET<any>(ApiEndpoints.dashboard, "/test");

  if (!isFetched) return <div>Loading...</div>;

  console.log(data);
  return (
    <>
      <DashboardBar />
      <SearchBar />
      <DashboardGrid />
    </>
  );
};

export default Dashboard;
