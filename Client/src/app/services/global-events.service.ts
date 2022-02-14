import { EventEmitter, Injectable } from "@angular/core";

@Injectable({ providedIn: "root" })
export class GlobalEventsService {
    public scrollEvents: EventEmitter<string>;

    constructor() {
        this.scrollEvents = new EventEmitter();;
    }

    onScroll(eventName: string) {
        this.scrollEvents.emit(eventName);
    }
}
