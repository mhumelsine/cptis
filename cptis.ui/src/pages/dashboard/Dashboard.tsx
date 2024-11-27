import { FC } from "react";
import DashboardBar from "./DashboardBar";
import DashboardGrid from "./DashboardGrid";
import SearchBar from "./SearchBar";
import useApi from "../../api/hooks/useApi";
import { ApiEndpoints } from "../../api/endpoints";
import { useQueryClient } from "@tanstack/react-query";

const Dashboard: FC = () => {
  const api = useApi();

  const { data, isLoading } = api.GET<string>(ApiEndpoints.dashboard, "/test");

  //const apiPut = api.PUT<string>(ApiEndpoints.dashboard);

  //const apiPost = api.POST<string>(ApiEndpoints.dashboard);

  const queryClient = useQueryClient();
  const queryCache = queryClient.getQueryCache();

  if (isLoading) return <div>isFetching...</div>;
  console.log(data, queryCache);

  return (
    <>
      <div
        onClick={() => {
          // apiPost.mutate({ body: { name: "test" }, params: "/test" });
        }}
      >
        {" "}
        CLICK ME !!!
      </div>
      <DashboardBar />
      <SearchBar />
      <DashboardGrid />
    </>
  );
};

export default Dashboard;
