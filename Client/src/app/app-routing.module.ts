import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { PageNotFoundComponent } from './pages/page-not-found.component';
import { MainPageComponent } from './pages/main-page.component';

const routes: Routes = [
    { path: "", component: MainPageComponent },
    { path: "**", component: PageNotFoundComponent, pathMatch: "full" }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
