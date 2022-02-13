import { ResponseMessageCode } from "./enums";

export interface IApiResponse<T> {
    response: T;
    messages: string[];
}

export interface IResponseMessage {
    type: ResponseMessageCode;
    text: string;
}
