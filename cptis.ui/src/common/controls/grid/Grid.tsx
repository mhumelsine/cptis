import { useCallback, useMemo } from "react";
import {
    DetailsList,
    DetailsListLayoutMode,
    SelectionMode,
    DetailsHeader,
    IDetailsHeaderProps,
    ITooltipHostProps,
    IDetailsListStyles,
} from "@fluentui/react";
import InputText from "../inputs/InputText";
import { GridProps } from "./types";

const Grid = <T,>(props: GridProps<T>) => {
    const { items, columns, onRenderRow, onFilterChange, enableFilters = false } = props;

    const handleFilterChange = useCallback((event: React.FormEvent<HTMLInputElement | HTMLTextAreaElement>, field: string) => {
        console.log("Filter Update - [" + field + " ] :: " + event.currentTarget.value);
        // Implement debounce/delay to avoid multiple calls HERE
        if (onFilterChange) {
            // TODO: missing other already existing inputs ?  fix it....
            onFilterChange({ [field]: event.currentTarget.value });
        }
    }, []);

    const gridStyles = useMemo<Partial<IDetailsListStyles>>(() => ({
        root: {
            overflowX: "auto",
            selectors: {
                "& [role=grid]": {
                    display: "flex",
                    flexDirection: "column",
                    alignItems: "normal",
                },
                ".ms-TextField": {
                    padding: "0px 3px;"
                }
            }
        },
        headerWrapper: {
            flex: "0 0 auto",
            selectors: {
                "& [role=presentation]": {
                    selectors: {
                        "& [role=row]": {
                            height: "82px;",
                            selectors: {
                                ".ms-DetailsHeader-cellIsCheck": {
                                    height: "82px;"
                                }
                            }
                        }
                    }
                }
            }
        },
        contentWrapper: {
            flex: "1 1 auto"
        }
    }), []);

    const renderCustomHeaderTooltip = useCallback((tooltipHostProps?: ITooltipHostProps) => {
        var column = (tooltipHostProps as any).column;
        if (column === undefined) {
            return (
                <div className={tooltipHostProps?.hostClassName}>
                    <span>{tooltipHostProps?.children}</span>
                </div>
            );
        } else {
            return (
                <div className={`${tooltipHostProps?.hostClassName} tw-ml-2`}>
                    <span>{tooltipHostProps?.children}</span>
                    <InputText
                        placeholder="Filter"
                        onChange={(event) => handleFilterChange(event, column.name)}
                        className="tw-ml-2"
                    />
                </div>
            );
        }
    }, [onFilterChange]);

    const renderDetailsHeader = useCallback((detailsHeaderProps?: IDetailsHeaderProps) => {
        if (detailsHeaderProps) {
            return (
                <DetailsHeader
                    {...detailsHeaderProps}
                    onRenderColumnHeaderTooltip={renderCustomHeaderTooltip}
                    className="tw-pl-4"
                />
            );
        }
        return null;
    }, [renderCustomHeaderTooltip]);

    return (
        <DetailsList
            items={items}
            onRenderDetailsHeader={enableFilters ? renderDetailsHeader : undefined}
            setKey={`grid`}
            layoutMode={DetailsListLayoutMode.justified}
            selectionMode={SelectionMode.none}
            onRenderRow={onRenderRow}
            columns={columns}
            styles={enableFilters ? gridStyles : undefined}
            useReducedRowRenderer={true}
        />
    );
};

export default Grid;
