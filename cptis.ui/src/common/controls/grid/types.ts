import { IColumn, IDetailsRowProps } from "@fluentui/react";

export type GridProps<T> = {
    items: T[];
    columns: IColumn[];
    enableFilters?: boolean;
    onFilterChange?: (filter: { [index: string]: string }) => void;
    onRenderRow?: (props?: IDetailsRowProps) => JSX.Element | null;
};

export type PaginatedGridProps<T> = {
    paginatedItems: PaginatedItems<T>;
    onGoToPage: (page: number) => void;
} & Omit<GridProps<T>, 'items'>;

export type PaginatedItems<T> = {
    items: T[];
    paging: Paging;
};

export type Paging = {
    totalItems: number,
    totalPages: number,
    pageNumber: number,
    pageSize: number,
    sort: string[],
    order: 'desc' | 'asc'
};
