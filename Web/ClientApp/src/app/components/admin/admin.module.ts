import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';
import {AirportComponent} from './airport/airport.component';
import {FlightComponent} from './flight/flight.component';
import {AdminRoutingModule} from "./admin-routing.module";
import {MatFormFieldModule, MatInputModule, MatPaginatorModule, MatSortModule, MatTableModule} from "@angular/material";
import {HttpClientModule} from "@angular/common/http";

@NgModule({
  imports: [
    CommonModule,
    HttpClientModule,
    AdminRoutingModule,
    MatTableModule,
    MatSortModule,
    MatPaginatorModule,
    MatInputModule,
    MatFormFieldModule
  ],
  declarations: [AirportComponent, FlightComponent]
})
export class AdminModule {
}
