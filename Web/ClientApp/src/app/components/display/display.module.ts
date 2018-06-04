import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';

import {DisplayRoutingModule} from './display-routing.module';
import {DataComponent} from './data/data.component';

@NgModule({
  imports: [
    CommonModule,
    DisplayRoutingModule
  ],
  declarations: [DataComponent]
})
export class DisplayModule {
}
