import { ComboboxItem, Select, SelectProps } from '@mantine/core';
import { useGetEndpoint } from '../../hooks';
import { useEffect, useState } from 'react';

type Props = {
    codeSet: string;
} & Omit<SelectProps, 'data'>;

interface CodeSet {
    id: string;
    values: { id: string, description: string }[];
}

const CodeSelect = ({ codeSet, ...rest }: Props) => {
    const api = useGetEndpoint<CodeSet>('codes');
    const [options, setOptions] = useState<ComboboxItem[]>([]);

    //TODO: make hook
    useEffect(() => {
        (async () => {
            const response = await api.get(codeSet);
            setOptions(response.values.map(v => ({ label: v.description, value: v.id })));
        })();
    }, [codeSet]);

    return <Select
        {...rest}
        data={options}
    />;
};

export default CodeSelect;