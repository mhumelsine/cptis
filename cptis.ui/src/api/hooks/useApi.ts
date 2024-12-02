import { useMutation, UseMutationOptions, useQuery, useQueryClient, UseQueryOptions } from '@tanstack/react-query';
import { ApiEndpoints } from '../endpoints';
import { ApiFunctions, HttpMethod, QueryOptions, UpdateType } from '../types';
import useAuthentication from '../../common/hooks/useAuthentication';

const useApi = (): ApiFunctions => {

const { data } = useAuthentication();
const ONE_HOUR = 1000 * 60 * 60;

  const fetchData = async <T>(url: string, method: HttpMethod, body?: any, contentType: string = "application/json"): Promise<T> => {
    const headers = new Headers();
    const bearer = `Bearer ${await  data?.accessToken}`;
    headers.append("Authorization", bearer);
    headers.append("Content-Type", contentType);

    const response = await fetch(url, {
      method,
      headers,
      body: body ? JSON.stringify(body) : undefined,
    });

    if (!response.ok) {
      throw new Error(`Error: ${response.status} ${response.statusText}`);
    }

    return response.json();
  };

  const buildUrl = (key: ApiEndpoints, params?: string | number): string => {
    return params 
     ? `${key}${params}`
     : key;
  };

  const  GET = <T>(key: ApiEndpoints, params?: string | number, options?: QueryOptions<T>) =>
    useQuery<T, Error>({
      queryKey: [buildUrl(key, params)], 
      queryFn: () => fetchData<T>(buildUrl(key, params), "GET"), 
      ...options, 
      staleTime: options?.staleTime ?? ONE_HOUR
    });

  const POST= <T>(key: ApiEndpoints, options?: UseMutationOptions<T, Error>, contentType?: string) => 
    useMutation<T, Error, any>({
        mutationFn: (params: UpdateType<T>) => fetchData<T>(buildUrl(key, params.params), "POST", params.body, contentType), 
        ...options
    }); 

  const PUT= <T>(key: ApiEndpoints, options?: UseMutationOptions<T, Error, any>, contentType?: string) =>
    useMutation<T, Error, any>({
      mutationFn: (params: UpdateType<T>) => fetchData<T>(buildUrl(key, params.params), "PUT", params.body, contentType), 
      ...options
    }); 

  const  PATCH= <T>(key: ApiEndpoints, options?: UseMutationOptions<T, Error, any>, contentType?: string) =>
    useMutation<T, Error, any>({
      mutationFn: (params: UpdateType<T>) => fetchData<T>(buildUrl(key, params.params), "PATCH", params.body, contentType), 
      ...options
    }); 

  return {GET, POST, PUT, PATCH}; 
};

export default useApi;
