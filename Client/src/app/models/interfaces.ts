import { ResponseMessageCode } from "./enums";

export interface IApiResponse<T> {
    data: T;
    messages: string[];
}

export interface IResponseMessage {
    type: ResponseMessageCode;
    text: string;
}

export interface IParamModel {
    [key: string]: any;
}

export interface ISubjectViewModel {
    key?: string;
    name?: string;
    subjectType?: string;
    workCount?: number;
    ebookCount?: number;
    works?: IWorkViewModel[];
}

export interface IWorkViewModel {
    key?: string;
    title?: string;
    editionCount?: number;
    coverId?: number;
    coverEditionKey?: number;
    subject?: string[];
    iaCollection?: string[];
    lendingLibrary?: boolean;
    printDisabled?: boolean;
    lendingEdition?: string;
    authors?: IAuthorViewModel[];
    firstPublishYear?: string[];
    ia?: string;
    publicScan?: boolean;
    hasFullText?: boolean;
    availability?: IAvailabilityViewModel;
}

export interface IAuthorViewModel {
    key?: string;
    name?: string;
}

export interface IAvailabilityViewModel {
    status?: string;
    availableToBrowse?: boolean;
    availableToBorrow?: boolean;
    availableToWaitlist?: boolean;
    isPrintDisabled?: boolean;
    isReadable?: boolean;
    isLendable?: boolean;
    isPreviewable?: boolean;
    identifier?: string;
    isbn?: string;
    oclc?: string;
    openLibraryWork?: string;
    openLibraryEdition?: string;
    lastLoanDate?: string;
    isRestricted?: boolean;
    isBrowseable?: boolean;
}
