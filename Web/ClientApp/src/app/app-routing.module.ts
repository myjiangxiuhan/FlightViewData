import {NgModule} from "@angular/core";
import {RouterModule, Routes} from "@angular/router";

const routes: Routes = [
  {
    path: 'admin',
    loadChildren: './components/admin/admin.module#AdminModule'
  },
  {
    path: 'display',
    loadChildren: './components/display/display.module#DisplayModule'
  },
  {
    path: '',
    pathMatch: 'full',
    redirectTo: 'display/data'
  }
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes)
  ],
  exports: [
    RouterModule
  ]
})
export class AppRoutingModule {

}
