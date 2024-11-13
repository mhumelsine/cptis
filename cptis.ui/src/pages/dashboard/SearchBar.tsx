import React from 'react';
import {
    ClipboardBulletListRtlRegular,
    SearchRegular
} from '@fluentui/react-icons';
import InputText from '../../common/controls/InputText';
import { InputDropdown } from '../../common/controls/InputDropdown';
import { CompoundButton } from '@fluentui/react-components';
const SearchBar: React.FC = () => {
    return (
        <div className="tw-flex tw-items-start tw-p-4 tw-border tw-border-gray-300 tw-rounded-lg tw-bg-white tw-mb-4">

            
            <div className="tw-flex tw-items-center tw-text-7xl tw-pt-2 tw-mr-4">
                <ClipboardBulletListRtlRegular />
            </div>

            
            <div className="tw-flex-1">
               
                <div className="tw-text-sm tw-font-semibold tw-text-left tw-mb-2">
                    Search Abuse
                </div>
                 
                <form onSubmit={(e) => { e.preventDefault(); console.log(e, "SUBMITTING") }}>
                    <div className="tw-flex tw-flex-wrap tw-items-center tw-space-x-2 md:tw-space-x-4">
                     
                        <div className=" ">
                            <InputText
                                id="searchText"
                                placeholder="Abuse Number"                                 
                            />
                        </div>
                         
                        <div className="  ">
                            <InputDropdown
                                placeholder="Select an Abuse Review"
                                options={[]}                                
                            />
                        </div>
                    </div>
                </form>
            </div>
            <div className="tw-flex-1">
                <div className="tw-flex tw-justify-end tw-w-full tw-pt-4 md:tw-w-auto md:tw-ml-auto">
                    <CompoundButton
                        type="submit"
                        appearance="transparent"
                        icon={<SearchRegular className="tw-p-1 tw-rounded-full tw-border tw-border-2 tw-shadow-lg" />}
                        className="tw-w-full md:tw-w-auto"
                    />
                </div>
            </div>
        </div>
    );
};

export default SearchBar;
