import {NgModule} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';
import {AirportComponent} from "./airport/airport.component";
import {FlightComponent} from "./flight/flight.component";

const routes: Routes = [
  {
    path: 'airport',
    component: AirportComponent
  },
  {
    path: 'flight',
    component: FlightComponent
  }
];

@NgModule({
  imports: [
    RouterModule.forChild(routes)
  ],
  exports: [
    RouterModule
  ]
})
export class AdminRoutingModule {
}
