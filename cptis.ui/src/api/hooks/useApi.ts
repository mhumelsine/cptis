import { useMemo } from 'react';
import { useMutation, UseMutationOptions, useQuery, UseQueryOptions } from '@tanstack/react-query';
import { useMsalAuthentication, InteractionType } from '@azure/msal-react';
import { API_ENDPOINTS } from './endpoints';
import { ApiFunctions, HttpMethod, ApiKey } from './types';

const useApi = (): ApiFunctions => {
  const { result, error: msalError } = useMsalAuthentication(InteractionType.Popup, {
    scopes: ["User.Read"],
    redirectUri: '/redirect'
  });

  const fetchData = async <T>(url: string, method: HttpMethod, body?: any, contentType: string = "application/json"): Promise<T> => {
    const headers = new Headers();
    const bearer = `Bearer ${result?.accessToken}`;
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

  const buildUrl = (key: ApiKey, params?: string | number): string => {
    const baseUrl = API_ENDPOINTS[key];
    return params ? `${baseUrl}/${params}` : baseUrl;
  };

  return useMemo(() => ({
    GET: <T>(key: ApiKey, params?: string | number, options?: UseQueryOptions<T, Error>) =>
      useQuery<T, Error>({
        queryKey: [buildUrl(key, params)], 
        queryFn: async () => fetchData<T>(buildUrl(key, params), "GET"), 
        ...options,
      }),
  
    POST: <T>(key: ApiKey, body: any, options?: UseMutationOptions<T, Error>, contentType?: string) =>
      useMutation<T, Error>({
        mutationFn: () => fetchData<T>(buildUrl(key), "POST", body, contentType),
        ...options
  }),
  
    PUT: <T>(key: ApiKey, body: any, options?: UseMutationOptions<T, Error, any>, contentType?: string) =>
      useMutation<T, Error, any>({
        mutationFn: () => fetchData<T>(buildUrl(key), "PUT", body, contentType), 
        ...options
  }),
  
    PATCH: <T>(key: ApiKey, body: any, options?: UseMutationOptions<T, Error, any>, contentType?: string) =>
      useMutation<T, Error, any>({
        mutationFn: () => fetchData<T>(buildUrl(key), "PATCH", body, contentType),
        ...options
  }),
  }), [result]);
};

export default useApi;