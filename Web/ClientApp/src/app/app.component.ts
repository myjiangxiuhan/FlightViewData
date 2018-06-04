import {Component} from '@angular/core';
import {BreakpointObserver, Breakpoints} from "@angular/cdk/layout";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  public isHandset: boolean;
  constructor(breakpointObserve: BreakpointObserver) {
    //响应式监视器
    breakpointObserve.observe('(max-width:599px)').subscribe(v => this.isHandset = v.matches);
  }
}
