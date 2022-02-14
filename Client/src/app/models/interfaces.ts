import { ResponseMessageCode } from "./enums";

export interface IApiResponse<T> {
    data: T;
    messages: string[];
}

export interface IResponseMessage {
    type: ResponseMessageCode;
    text: string;
}
