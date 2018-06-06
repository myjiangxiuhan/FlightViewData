///<reference path="../../../../../node_modules/rxjs/internal/operators/merge.d.ts"/>
import {Component, OnInit, ViewChild} from '@angular/core';
import {Airport} from "../../../models/airport";
import {MatPaginator, MatSort, MatTable, MatTableDataSource} from "@angular/material";
import {merge} from "rxjs";
import {AirportService} from "../../../services/airport.service";

@Component({
  selector: 'app-admin-airport',
  templateUrl: './airport.component.html',
  styleUrls: ['./airport.component.css'],
  providers: [AirportService]
})
export class AirportComponent implements OnInit {
  AirportColumns = ['id', 'name', 'city', 'country', 'icao'];
  data: Airport[] = [];


  constructor(private airportService: AirportService) {
  }

  ngOnInit() {
    this.airportService.getAirportList({pageSize: 10, pageIndex: 2}).subscribe(data => this.data = data);
  }
}
