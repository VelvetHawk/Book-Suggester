import { Component, HostListener } from "@angular/core";
import { textResources } from "src/app/models/text-resources";
import { GlobalEventsService } from "src/app/services/global-events.service";

@Component({
    selector: "main-page",
    templateUrl: "./main-page.component.html",
    styleUrls: ["./main-page.component.scss"]
})
export class MainPageComponent {
    resources = textResources.mainPage;

    constructor(protected globalEventsService: GlobalEventsService) {
    }

    @HostListener("window:scroll")
    onScroll(event: any) {
        console.debug("Scrolling");
        if ((window.innerHeight + window.pageYOffset) >= document.body.offsetHeight) {
            this.globalEventsService.onScroll("scrolledToBottom");
        }
    }
}
