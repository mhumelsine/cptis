import React from "react";
import DashboardCard from "./DashboardCard";
import { DashboardItems } from "./types";
import {
  LuAlarmClock,
  LuCalendarClock,
  LuMessageSquareReply,
  LuOctagonAlert,
} from "react-icons/lu";

const DashboardBar: React.FC = () => {
  return (
    <div className="tw-flex tw-flex-wrap tw-gap-4 tw-p-4 tw-justify-center">
      <DashboardCard
        number={999}
        text={DashboardItems.ActiveCases}
        icon={LuAlarmClock}
        bgColor={"tw-bg-[var(--cptis-green)]"}
        className="tw-md:mr-4"
      />
      <DashboardCard
        number={99}
        text={DashboardItems.NeedsAttention}
        icon={LuOctagonAlert}
        bgColor="tw-bg-[var(--cptis-orange)]"
        className="tw-md:mr-4"
      />
      <DashboardCard
        number={9}
        text={DashboardItems.Priors}
        icon={LuMessageSquareReply}
        bgColor="tw-bg-[var(--cptis-yellow)]"
        className="tw-md:mr-4"
      />
      <DashboardCard
        number={1}
        text={DashboardItems.PastDue}
        icon={LuCalendarClock}
        bgColor="tw-bg-[var(--cptis-hard-orange)]"
        className="tw-md:mr-4"
      />
    </div>
  );
};

export default DashboardBar;
