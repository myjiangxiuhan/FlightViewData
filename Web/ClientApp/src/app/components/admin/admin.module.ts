import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';
import {AirportComponent} from './airport/airport.component';
import {FlightComponent} from './flight/flight.component';
import {AdminRoutingModule} from "./admin-routing.module";
import {MatTableModule} from "@angular/material";

@NgModule({
  imports: [
    CommonModule,
    AdminRoutingModule,
    MatTableModule
  ],
  declarations: [AirportComponent, FlightComponent]
})
export class AdminModule {
}
