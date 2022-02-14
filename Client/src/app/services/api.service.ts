import { HttpClient, HttpErrorResponse, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Subscription } from "rxjs";

import { RequestMethod } from "src/app/models/enums";
import { IApiResponse, IParamModel } from "src/app/models/interfaces";

@Injectable({ providedIn: "root" })
export class ApiService {
    private defaultHeaders = new HttpHeaders({ "Content-Type": "application/json" });

    private activeRequests: Subscription[] = [];

    private baseUrl = "http://localhost:32680/"

    protected constructor(private httpClient: HttpClient) {
    }

    get<T>(url: string, params?: IParamModel): Promise<IApiResponse<T>> {
        return this.request<T>("GET", params != null ? this.formatQueryParameters(url, params) : url, null);
    }

    post<T>(url: string, requestBody?: any): Promise<IApiResponse<T>> {
        return this.request<T>("POST", url, requestBody);
    }

    put<T>(url: string, requestBody?: any): Promise<IApiResponse<T>> {
        return this.request<T>("PUT", url, requestBody);
    }

    delete<T>(url: string, requestBody?: any): Promise<IApiResponse<T>> {
        return this.request<T>("DELETE", url, requestBody);
    }

    protected request<T>(method: RequestMethod, url: string, data?: any): Promise<IApiResponse<T>> {
        const promise = new Promise<IApiResponse<T>>((resolve, reject) => {
            const subscription = this.httpClient.request<IApiResponse<T>>(method, this.baseUrl + url, { body: data, withCredentials: undefined, headers: this.defaultHeaders }).subscribe(response => {
                const indexToRemove = this.activeRequests.indexOf(subscription);
                this.activeRequests.splice(indexToRemove, 1);

                return resolve(response);
            }, reason => reject(reason));

            this.activeRequests.push(subscription);
        });

        return promise
            .then(response => this.handleResponse<T>(response))
            .catch(reason => this.handleErrors(reason));
    }

    private formatQueryParameters(url: string, queryParams: IParamModel) : string {
        return `${url}?` + (Object.keys(queryParams).map(key => `${key}=${queryParams[key]}`)).toString().replace(",", "&");
    }

    private handleResponse<T>(response: IApiResponse<T>) {
        // Custom response handling code here

        return response;
    }

    private handleErrors(reason: HttpErrorResponse) {
        // Error handling code here
        console.error(reason);

        return Promise.reject(reason || "Unknown error");
    }
}
