import {Flight} from "./flight";
import {Airport} from "./airport";

export class FlightCountView {
  public origAirport: Airport;
  public destAirport: Airport;
  public goCount: number = 0;
  public retCount: number = 0;
  public goFlights: Flight[] = [];
  public retFlights: Flight[] = [];
}
