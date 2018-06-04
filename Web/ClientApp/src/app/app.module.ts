import {BrowserModule} from '@angular/platform-browser';
import {NgModule} from '@angular/core';

import {AppComponent} from './app.component';
import {NgxEchartsModule} from "ngx-echarts";
import {BrowserAnimationsModule} from "@angular/platform-browser/animations";
import {MatButtonModule, MatIconModule, MatSidenavModule, MatToolbarModule} from "@angular/material";
import {PublicModule} from "./components/public/public.module";
import {AppRoutingModule} from "./app-routing.module";
import {FormsModule} from "@angular/forms";

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    FormsModule,
    NgxEchartsModule,
    MatToolbarModule,
    MatSidenavModule,
    MatButtonModule,
    MatIconModule,
    PublicModule,
    AppRoutingModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {
}
