import { useMutation, UseMutationOptions, useQuery, UseQueryOptions } from "@tanstack/react-query";

export type HttpMethod = "GET" | "POST" | "PUT" | "PATCH";

export interface UseApiOptions {
  baseUrl: string;
}

export type QueryOptions<T> = Omit<UseQueryOptions<T, Error>, 'queryKey' | 'queryFn'>;

export interface ApiFunctions {
  GET<T>(
    url: string,
    params?: string | number,
    options?: QueryOptions<T>
  ): ReturnType<typeof useQuery<T, Error>>;
  POST<T>(
    url: string,   
    options?: UseMutationOptions<T, Error, any>,
    contentType?: string
  ): ReturnType<typeof useMutation<T, Error, any>>;
  PUT<T>(
    url: string,
    options?: UseMutationOptions<T, Error, any>,
    contentType?: string
  ): ReturnType<typeof useMutation<T, Error, any>>;
  PATCH<T>(
    url: string,
    options?: UseMutationOptions<T, Error, any>,
    contentType?: string
  ): ReturnType<typeof useMutation<T, Error, any>>;
};

export interface UpdateType<T> {
  body : T, 
  params?: string | number
};