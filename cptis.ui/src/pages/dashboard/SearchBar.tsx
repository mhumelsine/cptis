import React from "react";
import {
  ClipboardBulletListRtlRegular,
  SearchRegular,
} from "@fluentui/react-icons";
import { InputDropdown } from "../../common/controls/inputs/InputDropdown";
import { CompoundButton } from "@fluentui/react-components";
import CustomInput from "../../common/controls/inputs/CustomInput";

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
        <div className="tw-flex tw-items-center tw-text-7xl tw-pt-2 tw-mr-4">
          <ClipboardBulletListRtlRegular />
        </div>

        <div className="tw-flex-1">
          <div className="tw-text-sm tw-font-semibold tw-text-left tw-mb-2">
            Search Abuse
          </div>

          <div className="tw-grid xl:tw-grid-cols-2 tw-gap-2">
            <div className=" ">
              <CustomInput
                id="searchText"
                label=""
                placeholder="Abuse Numbers"
              />
            </div>

            <div>
              <InputDropdown
                placeholder="Select an Abuse Review"
                options={[]}
              />
            </div>
          </div>
        </div>

        <div className="tw-flex tw-items-center tw-justify-end">
          <CompoundButton
            type="submit"
            appearance="transparent"
            icon={
              <SearchRegular className="tw-p-1 tw-rounded-full tw-border tw-border-2 tw-shadow-lg" />
            }
            className="tw-w-full md:tw-w-auto"
          />
        </div>
      </div>
    </form>
  );
};

export default SearchBar;
