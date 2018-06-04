import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';
import {NavComponent} from "./nav/nav.component";
import {MatIconModule, MatListModule} from "@angular/material";
import {FormsModule} from "@angular/forms";
import {RouterModule} from "@angular/router";

@NgModule({
  imports: [
    CommonModule,
    RouterModule,
    MatIconModule,
    MatListModule
  ],
  declarations: [
    NavComponent
  ],
  exports:[
    NavComponent
  ]
})
export class PublicModule {
}
