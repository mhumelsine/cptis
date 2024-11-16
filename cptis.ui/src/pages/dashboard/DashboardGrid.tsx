import React, { FC, useState, useCallback, MouseEvent } from "react";
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

/*  MOCKING DATA FOR TESTING */
const items: ClientItem[] = Array.from({ length: 20 }, (_, i) => ({
    ClientID: i + 1,
    Name: `Client ${i + 1}`,
    DateOfBirth: new Date(1980 + i % 20, i % 12, i % 28 + 1).toLocaleDateString(),
    Gender: i % 2 === 0 ? 'Male' : 'Female',
    Info: `Info about Client ${i + 1}`,
    Reports: Array.from({ length: 3 }, (__, j) => ({
        ReportNumber: `RPT-${i + 1}-${j + 1}`,
        DateReported: new Date().toLocaleDateString(),
        CptReviewDate: new Date().toLocaleDateString(),
        ReportCounty: `County ${j + 1}`
    }))
}));

const columns: IColumn[] = [
    { key: 'ClientID', name: 'ClientID', fieldName: 'ClientID', minWidth: 50, maxWidth: 75, isResizable: false },
    { key: 'Name', name: 'Name', fieldName: 'Name', minWidth: 100, maxWidth: 200, isResizable: false },
    { key: 'DateOfBirth', name: 'Date of Birth', fieldName: 'DateOfBirth', minWidth: 100, maxWidth: 150, isResizable: false },
    { key: 'Gender', name: 'Gender', fieldName: 'Gender', minWidth: 50, maxWidth: 75, isResizable: false },
    { key: 'Info', name: 'Info', fieldName: 'Info', minWidth: 200, isResizable: false }
];

const reportColumns: IColumn[] = [
    { key: 'ReportNumber', name: 'Report number', fieldName: 'ReportNumber', minWidth: 100, maxWidth: 150, isResizable: false },
    { key: 'DateReported', name: 'Date reported', fieldName: 'DateReported', minWidth: 100, maxWidth: 150, isResizable: false },
    { key: 'CptReviewDate', name: 'CPT review date', fieldName: 'CptReviewDate', minWidth: 100, maxWidth: 150, isResizable: false },
    { key: 'ReportCounty', name: 'Report county', fieldName: 'ReportCounty', minWidth: 100, maxWidth: 150, isResizable: false }
];

const pItems: PaginatedItems<ClientItem> = {
    items: items.slice(0, 5),
    paging: {
        totalItems: items.length,
        totalPages: Math.ceil(items.length / 5),
        pageNumber: 1,
        pageSize: 5,
        sort: [],
        order: 'asc'
    }
};
/*  MOCKING DATA FOR TESTING  */


const DashboardGrid: FC = () => {
    const [expandedClients, setExpandedClients] = useState<Record<any, boolean>>({});
    const [paginatedItems, setPaginatedItems] = useState<PaginatedItems<ClientItem>>(pItems);

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
                            columns={reportColumns}
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
        paginatedItems={paginatedItems}
        onGoToPage={(page: number) => {
            const slicedItems = items.slice((page - 1) * pItems.paging.pageSize, page * pItems.paging.pageSize);
           
            setPaginatedItems({
                ...paginatedItems,
                items: slicedItems,
                paging: {
                    ...paginatedItems.paging,
                    pageNumber: page
                }
            });
            console.log(`Fetch data get page ${page}`);
        }}
        enableFilters
        onRenderRow={onRenderRow}
    />;
};

export default DashboardGrid;
