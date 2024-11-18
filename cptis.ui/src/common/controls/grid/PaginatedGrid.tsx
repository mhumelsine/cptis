import { useState, useCallback, MouseEvent } from "react";
import { CompoundButton } from '@fluentui/react-components';
import { FastForwardRegular, NextRegular, PreviousRegular, RewindRegular } from "@fluentui/react-icons";
import { PaginatedGridProps } from "./types";
import Grid from "./Grid";

const PaginatedGrid = <T,>(props: PaginatedGridProps<T>) => {
    const {
        paginatedItems: {
            items,
            paging: { totalPages, pageSize }
        },
        onGoToPage,
        ...rest
    } = props;
    const [currentPage, setCurrentPage] = useState(1);

    const handleGotToPage = useCallback((event: MouseEvent<HTMLButtonElement>) => {
        const page = parseInt(event.currentTarget.value);
        setCurrentPage(page);
        onGoToPage(page);
    }, [pageSize, items]);
     
    return (
        <div>
            <Grid items={items} {...rest} />
            <div className="tw-flex tw-items-center tw-justify-center tw-space-x-4 tw-mt-4">

                <CompoundButton
                    id="firstPage"
                    icon={<small><RewindRegular /></small>}
                    onClick={handleGotToPage}
                    disabled={currentPage === 1 || totalPages === 0}
                    style={{
                        paddingTop: '0',
                        paddingBottom: '0',
                        paddingLeft: '0',
                        border: '0',
                        backgroundColor: 'transparent'
                    }}
                    value={1}
                >
                    First
                </CompoundButton>

                <CompoundButton
                    id="previousPage"
                    icon={<PreviousRegular fontSize="25px" />}
                    onClick={handleGotToPage}
                    disabled={currentPage === 1 || totalPages === 0}
                    style={{
                        paddingTop: '0',
                        paddingBottom: '0',
                        paddingLeft: '0',
                        border: '0',
                        backgroundColor: 'transparent'
                    }}
                    value={currentPage - 1}
                >
                    Previous
                </CompoundButton>

                <span className="tw-shrink-0">
                    [ Page {currentPage} of {totalPages} ]
                </span>

                <CompoundButton
                    id="nextPage"
                    icon={<NextRegular fontSize="25px" />}
                    onClick={handleGotToPage}
                    disabled={totalPages === 0 || currentPage === totalPages}
                    style={{
                        paddingTop: '0',
                        paddingBottom: '0',
                        paddingRight: '0',
                        border: '0',
                        backgroundColor: 'transparent'
                    }}
                    iconPosition="after"
                    value={currentPage + 1}
                >
                    Next
                </CompoundButton>

                <CompoundButton
                    id="lastPage"
                    icon={<small><FastForwardRegular /></small>}
                    onClick={handleGotToPage}
                    disabled={currentPage === totalPages || totalPages === 0}
                    style={{
                        paddingTop: '0',
                        paddingBottom: '0',
                        paddingRight: '0',
                        border: '0',
                        backgroundColor: 'transparent'
                    }}
                    iconPosition="after"
                    value={totalPages}
                >
                    Last
                </CompoundButton>
            </div>
        </div>
    );
};

export default PaginatedGrid;
