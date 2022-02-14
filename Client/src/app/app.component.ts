import { Component } from '@angular/core';
import { routes } from './models/route-constants';
import { ApiService } from './services/api.service';
import { GlobalEventsService } from './services/global-events.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
    title = 'web-client';

    demoText: string[] = [];

    constructor(apiService: ApiService, protected globalEventsService: GlobalEventsService) {
        apiService.get<string[]>(routes.books).then(response => this.demoText = response.data);
    }


}
