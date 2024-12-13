import React, { useState } from "react";
import {
  useReactTable,
  getCoreRowModel,
  getPaginationRowModel,
  getFilteredRowModel,
  flexRender,
} from "@tanstack/react-table";
import { FaPlus, FaMinus } from "react-icons/fa";

interface Report {
  ReportNumber: string;
  DateReported: string;
  CptReviewDate: string;
  ReportCounty: string;
}

interface Client {
  ClientID: number;
  Name: string;
  DateOfBirth: string;
  Gender: string;
  Info: string;
  Reports: Report[];
}

const data: Client[] = Array.from({ length: 20 }, (_, i) => ({
  ClientID: i + 1,
  Name: `Client ${i + 1}`,
  DateOfBirth: new Date(
    1980 + (i % 20),
    i % 12,
    (i % 28) + 1
  ).toLocaleDateString(),
  Gender: i % 2 === 0 ? "Male" : "Female",
  Info: `Info about Client ${i + 1}`,
  Reports: Array.from({ length: 3 }, (__, j) => ({
    ReportNumber: `RPT-${i + 1}-${j + 1}`,
    DateReported: new Date().toLocaleDateString(),
    CptReviewDate: new Date().toLocaleDateString(),
    ReportCounty: `County ${j + 1}`,
  })),
}));

const GridPOC = () => {
  const [expandedRows, setExpandedRows] = useState<{ [key: number]: boolean }>(
    {}
  );

  const toggleExpand = (clientId: number) => {
    setExpandedRows((prev) => ({
      ...prev,
      [clientId]: !prev[clientId],
    }));
  };

  const columns = [
    {
      header: "",
      id: "expander",
      cell: ({ row }: { row: any }) => (
        <button
          onClick={() => toggleExpand(row.original.ClientID)}
          className="p-2 text-gray-700"
        >
          {expandedRows[row.original.ClientID] ? <FaMinus /> : <FaPlus />}
        </button>
      ),
    },
    {
      header: "Client ID",
      accessorKey: "ClientID",
    },
    {
      header: "Name",
      accessorKey: "Name",
    },
    {
      header: "Date of Birth",
      accessorKey: "DateOfBirth",
    },
    {
      header: "Gender",
      accessorKey: "Gender",
    },
    {
      header: "Info",
      accessorKey: "Info",
    },
  ];

  const [columnFilters, setColumnFilters] = useState<any[]>([]);

  const table = useReactTable({
    data,
    columns,
    state: {
      columnFilters,
    },
    getCoreRowModel: getCoreRowModel(),
    getPaginationRowModel: getPaginationRowModel(),
    getFilteredRowModel: getFilteredRowModel(),
  });

  return (
    <div className="p-4">
      <table className="tw-min-w-full tw-table-auto tw-border-collapse tw-border tw-border-gray-300">
        <thead className="tw-bg-gray-100">
          {table.getHeaderGroups().map((headerGroup) => (
            <tr key={headerGroup.id}>
              {headerGroup.headers.map((header) => (
                <th key={header.id} className="tw-border tw-p-2 tw-text-left">
                  {header.isPlaceholder ? null : (
                    <>
                      {flexRender(
                        header.column.columnDef.header,
                        header.getContext()
                      )}
                      {header.column.getCanFilter() && (
                        <input
                          type="text"
                          onChange={(e) =>
                            setColumnFilters((prev) => [
                              ...prev.filter((f) => f.id !== header.column.id),
                              { id: header.column.id, value: e.target.value },
                            ])
                          }
                          className="tw-mt-1 tw-w-full tw-p-1 tw-border tw-rounded"
                          placeholder={`Filter ${header.column.columnDef.header}`}
                        />
                      )}
                    </>
                  )}
                </th>
              ))}
            </tr>
          ))}
        </thead>
        <tbody>
          {table.getRowModel().rows.map((row) => (
            <React.Fragment key={row.id}>
              <tr>
                {row.getVisibleCells().map((cell) => (
                  <td key={cell.id} className="tw-border tw-p-2">
                    {flexRender(cell.column.columnDef.cell, cell.getContext())}
                  </td>
                ))}
              </tr>
              {expandedRows[row.original.ClientID] && (
                <tr>
                  <td colSpan={columns.length} className="tw-bg-gray-50 tw-p-4">
                    <h3 className="tw-font-bold tw-mb-2">Reports</h3>
                    <table className="tw-w-full tw-table-auto tw-border-collapse tw-border tw-border-gray-200">
                      <thead className="tw-bg-gray-100">
                        <tr>
                          <th className="tw-border tw-p-2">Report Number</th>
                          <th className="tw-border tw-p-2">Date Reported</th>
                          <th className="tw-border tw-p-2">CPT Review Date</th>
                          <th className="tw-border tw-p-2">Report County</th>
                        </tr>
                      </thead>
                      <tbody>
                        {row.original.Reports.map((report) => (
                          <tr key={report.ReportNumber}>
                            <td className="tw-border tw-p-2">
                              {report.ReportNumber}
                            </td>
                            <td className="tw-border tw-p-2">
                              {report.DateReported}
                            </td>
                            <td className="tw-border tw-p-2">
                              {report.CptReviewDate}
                            </td>
                            <td className="tw-border tw-p-2">
                              {report.ReportCounty}
                            </td>
                          </tr>
                        ))}
                      </tbody>
                    </table>
                  </td>
                </tr>
              )}
            </React.Fragment>
          ))}
        </tbody>
      </table>

      <div className="tw-flex tw-items-center tw-gap-2 tw-mt-4">
        <button
          className="tw-p-2 tw-bg-gray-200 tw-rounded"
          onClick={() => table.previousPage()}
          disabled={!table.getCanPreviousPage()}
        >
          Previous
        </button>
        <span>
          Page {table.getState().pagination.pageIndex + 1} of{" "}
          {table.getPageCount()}
        </span>
        <button
          className="tw-p-2 tw-bg-gray-200 tw-rounded"
          onClick={() => table.nextPage()}
          disabled={!table.getCanNextPage()}
        >
          Next
        </button>
      </div>
    </div>
  );
};

export default GridPOC;
