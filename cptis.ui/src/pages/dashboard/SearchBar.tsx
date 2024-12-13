import React from "react";
import { ActionIcon, Select, TextInput } from "@mantine/core";
import { LuFolderSearch, LuSearch } from "react-icons/lu";

const SearchBar: React.FC = () => {
  const cardStyle =
    "tw-p-4 tw-border tw-border-gray-300 tw-rounded-lg tw-bg-white tw-mb-4";

  return (
    <form
      onSubmit={(e) => {
        e.preventDefault();
        console.log(e, "SUBMITTING");
      }}
    >
      <div
        className={`${cardStyle} tw-grid md:tw-grid-cols-[10%_80%_10%] sm:tw-grid-cols-1 tw-flex`}
      >
        <div className="tw-flex tw-items-center tw-text-6xl tw-pt-2 ">
          <LuFolderSearch />
        </div>

        <div className="tw-flex-1">
          <div className="tw-text-sm tw-font-semibold tw-text-left tw-mb-2">
            Search Abuse
          </div>

          <div className="tw-grid xl:tw-grid-cols-2 tw-gap-2">
            <div className=" ">
              <TextInput
                id="abuseNumbers"
                label=""
                placeholder="Abuse Numbers"
              />
            </div>

            <div>
              <Select
                id="abuseReview"
                placeholder="Select an Abuse Review"
                label=""
              />
            </div>
          </div>
        </div>

        <div className="tw-flex tw-items-center tw-justify-end tw-pt-6">
          <ActionIcon size={42} variant="default" aria-label="search abuse">
            <LuSearch />
          </ActionIcon>
        </div>
      </div>
    </form>
  );
};

export default SearchBar;
