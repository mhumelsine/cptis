import { FC, useState, useCallback, MouseEvent } from "react";
import {
    DetailsList,
    DetailsListLayoutMode,
    IColumn,
    SelectionMode,
    DetailsRow,
    IDetailsRowProps,
    IDetailsRowStyles,
    Icon
} from '@fluentui/react';
import PaginatedGrid from "../../common/controls/grid/PaginatedGrid";
import { PaginatedItems } from "../../common/controls/grid/types";

interface ClientItem {
    ClientID: number;
    Name: string;
    DateOfBirth: string;
    Gender: string;
    Info: string;
    Reports: ReportItem[];
}

interface ReportItem {
    ReportNumber: string;
    DateReported: string;
    CptReviewDate: string;
    ReportCounty: string;
}

const columns: IColumn[] = [
    { key: 'ClientID', name: 'ClientID', fieldName: 'ClientID', minWidth: 50, maxWidth: 75, isResizable: false },
    { key: 'Name', name: 'Name', fieldName: 'Name', minWidth: 100, maxWidth: 200, isResizable: false },
    { key: 'DateOfBirth', name: 'Date of Birth', fieldName: 'DateOfBirth', minWidth: 100, maxWidth: 150, isResizable: false },
    { key: 'Gender', name: 'Gender', fieldName: 'Gender', minWidth: 50, maxWidth: 75, isResizable: false },
    { key: 'Info', name: 'Info', fieldName: 'Info', minWidth: 200, isResizable: false }
];

const subGridColumns: IColumn[] = [
    { key: 'ReportNumber', name: 'Report number', fieldName: 'ReportNumber', minWidth: 100, maxWidth: 150, isResizable: false },
    { key: 'DateReported', name: 'Date reported', fieldName: 'DateReported', minWidth: 100, maxWidth: 150, isResizable: false },
    { key: 'CptReviewDate', name: 'CPT review date', fieldName: 'CptReviewDate', minWidth: 100, maxWidth: 150, isResizable: false },
    { key: 'ReportCounty', name: 'Report county', fieldName: 'ReportCounty', minWidth: 100, maxWidth: 150, isResizable: false }
];

const defaultPaginatedItems: PaginatedItems<any> = {
    items: [],
    paging: {
        totalItems: 0,
        totalPages: 0,
        pageNumber: 1,
        pageSize: 10,
        sort: [],
        order: 'asc'
    }
};

const DashboardGrid: FC = () => {
    const [expandedClients, setExpandedClients] = useState<Record<any, boolean>>({});
  
    const toggleClientExpansion = useCallback((event: MouseEvent<HTMLButtonElement>) => {
        event.preventDefault();
        const clientId = event.currentTarget.id;

        setExpandedClients((prev) => ({ ...prev, [clientId]: !prev[clientId] }));
    }, []);

    const onRenderRow = useCallback((props?: IDetailsRowProps) => {
        if (!props) return null;

        const rowStyles: Partial<IDetailsRowStyles> = { root: { borderBottom: '1px solid #eaeaea', paddingLeft: '0' } };

        const isExpanded = expandedClients[props.item.ClientID];
        const toggleIcon = isExpanded ? 'ChevronDown' : 'ChevronRight';

        return (
            <div key={props.item.ClientID}> {/* Use key based on the ClientID */}
                <div className="tw-flex tw-items-center tw-bg-white tw-pl-2">
                    <Icon
                        id={props.item.ClientID.toString()}
                        iconName={toggleIcon}
                        className="tw-cursor-pointer tw-mr-2 tw-bg-white"
                        onClick={toggleClientExpansion}
                    />
                    <DetailsRow key={`${props.item.ClientID}-${isExpanded}`} {...props} styles={rowStyles} />
                </div>

                {isExpanded && (
                    <div className="tw-m-4">
                        <div className="tw-text-xl tw-font-bold tw-mb-2 tw-ml-1">
                            Active Abuse Reports
                        </div>
                        <DetailsList
                            items={(props.item as ClientItem).Reports}
                            columns={subGridColumns}
                            setKey={'subGrid'}
                            layoutMode={DetailsListLayoutMode.justified}
                            selectionMode={SelectionMode.none}
                        />
                    </div>
                )}
            </div>
        );
    }, [expandedClients, toggleClientExpansion]);

    return <PaginatedGrid
        key={JSON.stringify(expandedClients)}
        columns={columns}
        paginatedItems={defaultPaginatedItems}
        onGoToPage={(page: number) => {
            console.log(`Fetch data get page ${page}`);
        }}
        enableFilters
        onRenderRow={onRenderRow}
    />;
};

export default DashboardGrid;
