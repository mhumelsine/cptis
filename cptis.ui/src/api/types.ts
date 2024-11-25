import { useMutation, UseMutationOptions, useQuery, UseQueryOptions } from "@tanstack/react-query";
import { API_ENDPOINTS } from "./endpoints";

export type HttpMethod = "GET" | "POST" | "PUT" | "PATCH";

export interface UseApiOptions {
  baseUrl: string;
}

export interface ApiFunctions {
  GET<T>(
    url: string,
    params?: string | number,
    options?: UseQueryOptions<T, Error>
  ): ReturnType<typeof useQuery<T, Error>>;
  POST<T>(
    url: string,
    body: any,
    options?: UseMutationOptions<T, Error, any>,
    contentType?: string
  ): ReturnType<typeof useMutation<T, Error, any>>;
  PUT<T>(
    url: string,
    body: any,
    options?: UseMutationOptions<T, Error, any>,
    contentType?: string
  ): ReturnType<typeof useMutation<T, Error, any>>;
  PATCH<T>(
    url: string,
    body: any,
    options?: UseMutationOptions<T, Error, any>,
    contentType?: string
  ): ReturnType<typeof useMutation<T, Error, any>>;
};

export type ApiKey = keyof typeof API_ENDPOINTS;