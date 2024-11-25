import { useQuery, useMutation, QueryFunctionContext, UseQueryOptions, UseMutationOptions } from "@tanstack/react-query";
import { useMemo } from "react";
import { ApiFunctions, ApiKey, HttpMethod } from "../types";
import { API_ENDPOINTS } from "../endpoints";

export function useApi(key: ApiKey): ApiFunctions {
  const baseUrl = API_ENDPOINTS[key];
  const buildUrl = (url: string, params?: string | number): string =>
    `${baseUrl}${url}${params ? `/${params}` : ""}`;

  const fetchData = async <T>({ queryKey, signal }: QueryFunctionContext): Promise<T> => {
    const [url] = queryKey;
    const response = await fetch(url as string, { method: "GET", signal });

    if (!response.ok) {
      throw new Error(`Error: ${response.status} ${response.statusText}`);
    }

    return response.json();
  };

  const postData = async <T>(url: string, body: any): Promise<T> => {
    const response = await fetch(url, {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify(body),
    });

    if (!response.ok) {
      throw new Error(`Error: ${response.status} ${response.statusText}`);
    }

    return response.json();
  };

  const updateData = async <T>(url: string, body: any, method: HttpMethod): Promise<T> => {
    const response = await fetch(url, {
      method,
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify(body),
    });

    if (!response.ok) {
      throw new Error(`Error: ${response.status} ${response.statusText}`);
    }

    return response.json();
  };

  return useMemo(() => ({
    GET: <T>(url: string, params?: string | number, options?: UseQueryOptions<T, Error>) =>
      useQuery<T, Error, T>(
        [buildUrl(url, params)],
        (context) => fetchData<T>(context),
        options
      ),

    POST: <T>(url: string, body: any, options?: UseMutationOptions<T, Error, any>) =>
      useMutation<T, Error, any>(() => postData<T>(buildUrl(url), body), options),

    PUT: <T>(url: string, body: any, options?: UseMutationOptions<T, Error, any>) =>
      useMutation<T, Error, any>(() => updateData<T>(buildUrl(url), body, "PUT"), options),

    PATCH: <T>(url: string, body: any, options?: UseMutationOptions<T, Error, any>) =>
      useMutation<T, Error, any>(() => updateData<T>(buildUrl(url), body, "PATCH"), options),
  }), [baseUrl]);
}
 