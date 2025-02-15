import qs from "query-string";
import { useEffect, useMemo } from "react";

export interface ApiOptions {
  version: string;
  basePath?: string;
  traceLocation: string;
}

export const defaultApiOptions = {
  version: "1.0",
  basePath: "/api",
  traceLocation: "default",
};

export interface ApiEndpoint<TGet, TSearch, TCreated>
  extends ListEndpoint<TSearch>,
    GetEndpoint<TGet> {
  post: (body: any, queryParam?: any) => Promise<TCreated>;
  put: (
    id: number | string,
    body: any,
    queryParam?: any,
  ) => Promise<TCreated | void>;
  patch: (
    id: number | string,
    patchDoc: any,
    queryParam?: any,
  ) => Promise<void>;
  delete: (id: number | string, queryParam?: any) => Promise<void>;
}

export interface ListEndpoint<TSearch> {
  list: (queryParam?: any) => Promise<TSearch[]>;
}

export interface GetEndpoint<TGet> {
  get: (id: number | string, queryParam?: any) => Promise<TGet>;
}

export class AbortableRestApi<TGet, TSearch, TCreated>
  implements ApiEndpoint<TGet, TSearch, TCreated>
{
  public callsInProgress: Map<string, AbortController>;

  public requestId: number;

  private readonly basePath: string;

  public constructor(
    basePath: string,
    callsInProgress: Map<string, AbortController>,
  ) {
    this.basePath = basePath;
    this.callsInProgress = callsInProgress;
    this.requestId = 0;
  }

  public abort = () => {
    this.callsInProgress.forEach((aborter, key) => {
      if (key.startsWith(this.basePath)) {
        aborter.abort();
        this.callsInProgress.delete(key);
      }
    });
  };

  public get = (id: number | string, queryParam?: any) =>
    this.send<TGet>(this.createRoute(id, queryParam));

  public list = (queryParam?: any) =>
    this.send<TSearch[]>(this.createRoute(undefined, queryParam));

  public post = (body: any, queryParam?: any) =>
    this.sendBody<TCreated>(
      "POST",
      this.createRoute(undefined, queryParam),
      body,
    );

  public put = (id: number | string, body: any, queryParam?: any) =>
    this.sendBody<void>("PUT", this.createRoute(id, queryParam), body);

  public patch = (id: number | string, body: any, queryParam?: any) =>
    this.sendBody<void>("PATCH", this.createRoute(id, queryParam), body);

  public delete = (id: number | string, body: any, queryParam?: any) =>
    this.sendBody<void>("DELETE", this.createRoute(id, queryParam), body);

  private createAbortController(): { key: string; signal: AbortSignal } {
    const abortController = new AbortController();

    const key = `${this.basePath}__${this.requestId++}`;

    this.callsInProgress.set(key, abortController);

    return {
      key,
      signal: abortController.signal,
    };
  }

  private createRoute = (id: string | number | undefined, query: any) => {
    let route = this.basePath;

    if (id !== undefined) {
      route = `${route}/${id}`;
    }

    if (
      query !== undefined &&
      query !== null &&
      Object.keys(query).length > 0
    ) {
      return `${route}?${qs.stringify(query)}`;
    }

    return route;
  };

  private async send<T>(url: string, nocache: boolean = false) {
    const { key, signal } = this.createAbortController();

    try {
      const response = await fetch(url, {
        cache: nocache ? "no-cache" : "default",
        signal,
        method: "GET",
        headers: this.getHeaders(),
        redirect: "error",
        credentials: "omit",
      });

      return await this.getJson<T>(response);
    } catch (errors) {
      // if the call was aborted, we do not want to display any errors so we will just reject with an empty object.
      if (signal?.aborted) {
        return Promise.reject({} as T);
      }
      throw errors;
    } finally {
      this.callsInProgress.delete(key);
    }
  }

  private async sendBody<T>(
    method: "POST" | "PUT" | "DELETE" | "PATCH",
    url: string,
    body: any,
  ) {
    const { key, signal } = this.createAbortController();

    const response = await fetch(url, {
      body: JSON.stringify(body),
      cache: "no-cache",
      method,
      headers: this.getHeaders(),
      signal,
      redirect: "error",
      credentials: "omit",
    });

    this.callsInProgress.delete(key);

    return await this.getJson<T>(response);
  }

  private getHeaders = () => ({
    "Content-Type": "application/json",
    Authorization: "TODO",
    Accept: "application/json",
  });

  private getErrors = (errors: any): Promise<any> => {
    // if the response is an error, we format it and return it
    // this can happen if the browser blocks the request
    if (errors instanceof Error) {
      if (errors.name === "AbortError") {
        return Promise.reject({});
      }

      return Promise.reject({ errors });
    }

    return Promise.reject(errors);
  };

  private getJson = async <T>(response: Response) => {
    try {
      // we get the body as text first, in case the response body is empty
      // response.json throws with an empty body
      // in this case, we want to return an empty json object if there is no body
      const text = await response.text();

      return (text && text.length > 0 ? JSON.parse(text) : {}) as T;
    } catch (err) {
      console.log(err);

      return Promise.reject({ error: err });
    }
  };
}
