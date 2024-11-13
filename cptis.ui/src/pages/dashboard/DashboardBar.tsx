import React from 'react';
import DashboardCard from './DashboardCard';
import { DashboardItems } from './types';
import {
    CalendarArrowCounterclockwiseRegular,
    ClipboardNoteRegular,
    ShiftsCheckmarkRegular,
    WarningRegular
} from '@fluentui/react-icons';

const DashboardBar: React.FC = () => {
    return (
        <div className="tw-flex tw-flex-wrap tw-gap-4 tw-p-4 tw-justify-center">
            <DashboardCard
                number={999}
                text={DashboardItems.ActiveCases}
                icon={ShiftsCheckmarkRegular}
                bgColor={"tw-bg-[var(--cptis-green)]"}
                className="tw-md:mr-4"
            />
            <DashboardCard
                number={99}
                text={DashboardItems.NeedsAttention}
                icon={WarningRegular}
                bgColor="tw-bg-[var(--cptis-orange)]"
                className="tw-md:mr-4"
            />
            <DashboardCard
                number={9}
                text={DashboardItems.Priors}
                icon={ClipboardNoteRegular}
                bgColor="tw-bg-[var(--cptis-yellow)]"
                className="tw-md:mr-4"
            />
            <DashboardCard
                number={1}
                text={DashboardItems.PastDue}
                icon={CalendarArrowCounterclockwiseRegular}
                bgColor="tw-bg-[var(--cptis-hard-orange)]"
                className="tw-md:mr-4"
            />
        </div>
    );
};

export default DashboardBar;
