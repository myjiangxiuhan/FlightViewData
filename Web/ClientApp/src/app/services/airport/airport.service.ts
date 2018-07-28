import { Injectable } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import {Observable} from "rxjs/internal/Observable";
import {Airport} from "../models/airport";

@Injectable({
  providedIn: 'root'
})
export class AirportService {

  constructor(private http: HttpClient) { }
  getAirports(): Observable<Airport[]> {
    return this.http.get<Airport[]>("/api/admin/airport/all");
  }
  getAirportList(body: any): Observable<Airport[]> {
    return this.http.post<Airport[]>("/api/admin/airport/list",body);
  }
}
