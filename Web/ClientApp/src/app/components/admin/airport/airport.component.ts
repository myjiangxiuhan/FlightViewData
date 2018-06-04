import { Component, OnInit } from '@angular/core';
import {Airport} from "../../../models/airport";

@Component({
  selector: 'app-admin-airport',
  templateUrl: './airport.component.html',
  styleUrls: ['./airport.component.css']
})
export class AirportComponent implements OnInit {
  AirportColumns = ['id','name','city','couutry','iata','icao','latitude','longitude','altitude','timezone','dst','tz','type','source'];
  data = DATA;
  constructor() { }

  ngOnInit() {
  }
}
const DATA: Airport[] = [
  {
    Id: 2,
    Name: 'xvdeqiang',
    Altitude: 20,
    Iata: 'xx',
    Icao: 'xxx',
    City: 'sss',
    Dst: 'lll',
    Source: 'ppp',
    Latitude: 0.5,
    Longitude: 1.1111,
    Timezone: 'gz',
    Type: 'xx',
    Tz: '555'
  },
  {
    Id: 2,
    Name: 'xvdeqiang',
    Altitude: 20,
    Iata: 'xx',
    Icao: 'xxx',
    City: 'sss',
    Dst: 'lll',
    Source: 'ppp',
    Latitude: 0.5,
    Longitude: 1.1111,
    Timezone: 'gz',
    Type: 'xx',
    Tz: '555'
  }
]
