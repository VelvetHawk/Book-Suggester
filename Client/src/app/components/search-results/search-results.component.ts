import { Component } from "@angular/core";
import { ISubjectViewModel } from "src/app/models/interfaces";
import { routes } from "src/app/models/route-constants";
import { ApiService } from "src/app/services/api.service";
import { GlobalEventsService } from "src/app/services/global-events.service";

@Component({
    selector: "search-results",
    templateUrl: "./search-results.component.html",
    styleUrls: ["./search-results.component.scss"]
})
export class SearchResultsComponent {
    searchResults?: ISubjectViewModel;

    offset = 0;

    readonly limit = 10;

    constructor(protected apiService: ApiService, protected globalEventService: GlobalEventsService) {
        apiService.get<ISubjectViewModel>(routes.books, { offset: this.offset, limit: this.limit}).then(response => {
            if (response != null) {
                this.searchResults = response.data;
            }
            else {
                // Any errors would be already detected by API service, but any additional
                // component-specific handling code could be dealt with here
            }
        });

        globalEventService.scrollEvents.subscribe(event => {
            console.debug("Event emitted");
            if (event === "scrolledToBottom") {
                apiService.get<ISubjectViewModel>(routes.books, { offset: this.offset, limit: this.limit }).then(response => {
                    if (response.data?.works != null) {
                        this.searchResults?.works?.push(...response.data.works);
                        this.offset += response.data?.workCount ?? 0;
                    }
                });
            }
        });
    }
}
