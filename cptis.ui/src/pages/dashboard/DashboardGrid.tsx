import { FC, useState } from "react";
import {
    DetailsList,
    DetailsListLayoutMode,
    IColumn,
    SelectionMode,
    PrimaryButton,
    DetailsRow,
    IDetailsRowProps,
    IDetailsRowStyles,
    Icon,
} from '@fluentui/react';

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
    { key: 'toggle', name: '', fieldName: 'toggle', minWidth: 20, maxWidth: 30 },
    { key: 'ClientID', name: 'ClientID', fieldName: 'ClientID', minWidth: 50, maxWidth: 75, isResizable: true },
    { key: 'Name', name: 'Name', fieldName: 'Name', minWidth: 100, maxWidth: 200, isResizable: true },
    { key: 'DateOfBirth', name: 'Date of Birth', fieldName: 'DateOfBirth', minWidth: 100, maxWidth: 150, isResizable: true },
    { key: 'Gender', name: 'Gender', fieldName: 'Gender', minWidth: 50, maxWidth: 75, isResizable: true },
    { key: 'Info', name: 'Info', fieldName: 'Info', minWidth: 200, maxWidth: 300, isResizable: true }
];

const reportColumns: IColumn[] = [
    { key: 'ReportNumber', name: 'Report number', fieldName: 'ReportNumber', minWidth: 100, maxWidth: 150, isResizable: true },
    { key: 'DateReported', name: 'Date reported', fieldName: 'DateReported', minWidth: 100, maxWidth: 150, isResizable: true },
    { key: 'CptReviewDate', name: 'CPT review date', fieldName: 'CptReviewDate', minWidth: 100, maxWidth: 150, isResizable: true },
    { key: 'ReportCounty', name: 'Report county', fieldName: 'ReportCounty', minWidth: 100, maxWidth: 150, isResizable: true }
];

const pageSize = 5;

const DashboardGrid: FC = () => {
    const [currentPage, setCurrentPage] = useState<number>(1);
    const [expandedClients, setExpandedClients] = useState<Record<number, boolean>>({});

    const totalPages = Math.ceil(items.length / pageSize);
    const startIndex = (currentPage - 1) * pageSize;
    const paginatedItems = items.slice(startIndex, startIndex + pageSize);

    const goToPage = (page: number) => {
        if (page > 0 && page <= totalPages) {
            setCurrentPage(page);
        }
    };

    const toggleClientExpansion = (clientId: number) => {
        setExpandedClients((prev) => ({ ...prev, [clientId]: !prev[clientId] }));
    };

    return (<>
        <div className="flex flex-col items-center" >
            <div className="w-full overflow-auto" >
                <DetailsList
                    items={paginatedItems}
                    columns={columns}
                    setKey="set"
                    layoutMode={DetailsListLayoutMode.justified}
                    selectionMode={SelectionMode.none}
                    onRenderRow={(props?: IDetailsRowProps) => {
                        if (!props) return null;

                        const rowStyles: Partial<IDetailsRowStyles> = { root: { borderBottom: '1px solid #eaeaea' } };

                        const isExpanded = expandedClients[props.item.ClientID];
                        const toggleIcon = isExpanded ? 'ChevronDown' : 'ChevronRight';

                        return (
                            <div>
                                <div className="flex items-center bg-white pl-2" >

                                    <Icon
                                        iconName={toggleIcon}
                                        className="cursor-pointer mr-2 bg-white"
                                        onClick={() => toggleClientExpansion(props.item.ClientID)
                                        }
                                    />
                                    < DetailsRow {...props} styles={rowStyles} />
                                </div>

                                {
                                    isExpanded && (
                                        <div className="m-4" >
                                            <div className="text-xl font-bold mb-2 ml-1" >
                                                Active Abuse Reports
                                            </div>
                                            < DetailsList
                                                items={(props.item as ClientItem).Reports
                                                }
                                                columns={reportColumns}
                                                setKey="subGrid"
                                                layoutMode={DetailsListLayoutMode.justified}
                                                selectionMode={SelectionMode.none}
                                            />
                                        </div>
                                    )}
                            </div>
                        );
                    }}
                />
            </div>

            {/* Pagination controls */}
            <div className="flex items-center justify-center space-x-4 mt-4" >
                <PrimaryButton
                    text="« First"
                    onClick={() => goToPage(1)}
                    disabled={currentPage === 1}
                />
                < PrimaryButton
                    text="‹ Prev"
                    onClick={() => goToPage(currentPage - 1)}
                    disabled={currentPage === 1}
                />

                {/* Page number input */}
                <span>
                    Page
                    < input
                        type="number"
                        value={currentPage}
                        onChange={(e) => goToPage(Number(e.target.value))}
                        min="1"
                        max={totalPages}
                        className="mx-2 w-16 p-1 text-center border border-gray-300 rounded-md"
                    />
                    of {totalPages}
                </span>

                < PrimaryButton
                    text="Next ›"
                    onClick={() => goToPage(currentPage + 1)}
                    disabled={currentPage === totalPages}
                />
                < PrimaryButton
                    text="Last »"
                    onClick={() => goToPage(totalPages)}
                    disabled={currentPage === totalPages}
                />
            </div>
        </div>
    </>);
};

export default DashboardGrid;