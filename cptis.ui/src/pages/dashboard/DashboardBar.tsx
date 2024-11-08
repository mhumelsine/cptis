import React from 'react';
import DashboardCard from './DashboardCard';
import { DashboardItems } from './types';
import {
    CalendarArrowCounterclockwiseRegular,
    ClipboardNoteRegular,
    ShiftsCheckmarkRegular,
    WarningRegular,

} from '@fluentui/react-icons';

const DashboardBar: React.FC = () => {
    return (
        <div className="flex flex-wrap gap-4 p-4 justify-center">
            <DashboardCard number={12} text={DashboardItems.ActiveCases} icon={ShiftsCheckmarkRegular} bgColor={"bg-[var(--cptis-green)]"} />
            <DashboardCard number={25} text={DashboardItems.NeedsAttention} icon={WarningRegular} bgColor="bg-[var(--cptis-orange)]" />
            <DashboardCard number={8} text={DashboardItems.Priors} icon={ClipboardNoteRegular} bgColor="bg-[var(--cptis-yellow)]" />
            <DashboardCard number={5} text={DashboardItems.PastDue} icon={CalendarArrowCounterclockwiseRegular} bgColor="bg-[var(--cptis-hard-orange)]" />
        </div>
    );
};

export default DashboardBar;
