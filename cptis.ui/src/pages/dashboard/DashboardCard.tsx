import React from 'react';
import { FluentIcon } from '@fluentui/react-icons';

interface DashboardCardProps {
    number: number;
    text: string;
    icon: FluentIcon;
    bgColor: string;
}

const DashboardCard: React.FC<DashboardCardProps> = ({ number, text, icon, bgColor }) => {
    const Icon = icon;

    return (
        <div className={`flex flex-col h-[125px] w-[200px] sm:w-[140px] sm:h-[110px] md:w-[200px] md:h-[125px] rounded-lg ${bgColor} text-white pl-2 shadow-xl`}>
           
            <div className="flex items-center pt-4  w-full">
                <Icon className="text-6xl ml-4" />
                <span className="text-7xl font-bold">{number}</span>
            </div>
           
            <div className="flex w-full">
                <span className="text-sm text-right pt-2 truncate">{text}</span>
            </div>
        </div>
    );
};

export default DashboardCard;
