import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';

import {DisplayRoutingModule} from './display-routing.module';
import {DataComponent} from './data/data.component';
import {NgxEchartsModule} from "ngx-echarts";

@NgModule({
  imports: [
    CommonModule,
    DisplayRoutingModule,
    NgxEchartsModule
  ],
  declarations: [DataComponent]
})
export class DisplayModule {
}
