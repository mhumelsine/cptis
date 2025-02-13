import React from "react";
import { FiFilePlus } from "react-icons/fi";
import {
  MRT_Row,
  MRT_TableInstance,
  type MRT_ColumnDef,
} from "mantine-react-table";
import useApi from "../../api/hooks/useApi";
import "@mantine/core/styles.css";
import "@mantine/dates/styles.css";
import "mantine-react-table/styles.css";
import { NavLink } from "react-router-dom";
import { TableGridEditable } from "../../common/controls/TableGrid";
import { AbuseReview, AbuseReviewLabel } from "../abuse-review/types";

type SaveHandlerProps = {
  exitEditingMode: () => void;
  row: MRT_Row<Abusereview>;
  table: MRT_TableInstance<Abusereview>;
  // eslint-disable-next-line @typescript-eslint/no-explicit-any
  values: Record<string, any>;
};

const Grid = () => {
  const api = useApi("AbuseReview.Pending");

  const columns = React.useMemo<MRT_ColumnDef<Abusereview>[]>(
    () => [
      {
        accessorKey: "id",
        header: "Id",
        Cell: ({ cell }) => (
          <NavLink
            className="text-blue-600"
            to={`?id=${cell.getValue<number>()}`}
          >
            {cell.getValue<number>()}
          </NavLink>
        ),
      },
      {
        accessorKey: "reviewNumber",
        header: "Review number",
        filterFn: "equals",
      },
      {
        accessorKey: "hotlineDate",
        header: "Hotline date",
        filterFn: "",
      },
      {
        accessorKey: "receivedDate",
        header: "Received date",
        filterFn: "",
      },
      {
        accessorKey: "reviewedDate",
        header: "Reviewed date",
        filterFn: "",
      },
      {
        accessorKey: "mandatory",
        header: "Mandatory",
        filterFn: "",
      },
      {
        accessorKey: "ctpOffice",
        header: "Ctp office",
        filterFn: "",
      },
    ],
    [],
  );

  const handleSaveRow = async (props: SaveHandlerProps) => {
    const { row, table, values } = props;
    // call api updates here

    console.log(row);
    console.log(values);

    // close edit mode
    table.setEditingRow(null);
  };

  return (
    <div>
      <div
        className="flex text-left pb-2"
        title="Abusereview Pending"
        style={{ color: "var(--cptis-purple)" }}
      >
        <FiFilePlus fontSize={30} strokeWidth="2.75" />
        <div className="flex pl-3 self-end font-semibold">{text}</div>
      </div>

      <div className="bg-white w-100 border-2 rounded-lg border-gray shadow-md">
        <TableGridEditable
          data={data}
          isFetching={isFetching}
          isLoading={isLoading}
          labels={AbuseReviewLabel}
          onSave={handleSaveRow}
          columns={columns}
        />
      </div>
    </div>
  );
};

export default Grid;
