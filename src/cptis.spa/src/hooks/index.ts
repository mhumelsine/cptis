import { AbortableRestApi, ApiOptions, defaultApiOptions, GetEndpoint, ListEndpoint } from "./api";
import { useMemo } from 'react';

export const useListEndpoint = <T>(
    route: string,
    options: ApiOptions = defaultApiOptions
): ListEndpoint<T> => useEndpoint<unknown, T, unknown>(route, options);

export const useGetEndpoint = <T>(
    route: string,
    options: ApiOptions = defaultApiOptions
): GetEndpoint<T> => useEndpoint<T, unknown, unknown>(route, options);

export const useEndpoint = <TGet, TSearch, TCreated>(
    route: string,
    options: ApiOptions = defaultApiOptions
) => {

    const api = useMemo(() => new AbortableRestApi<TGet, TSearch, TCreated>(
        `${options.basePath ?? defaultApiOptions.basePath}/${route}`,
        new Map<string, AbortController>()
    ), [route, options]);

    //abort calls in progress when component unmounts
    //useEffect(() => api.abort);

    return api;
}