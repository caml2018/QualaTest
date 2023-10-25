import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LayoutComponent } from './components/layout/layout.component';
import { SucursalComponent } from './components/pages/sucursal/sucursal.component';
import { MonedaComponent } from './components/pages/moneda/moneda.component';

const routes: Routes = [
  {
    path:'',
    component:LayoutComponent,
    children:[
      {
        path:'',
        redirectTo:"/sucursal",
        pathMatch:'full'
      },
      {
        path:'sucursal',
        component:SucursalComponent
      },
      {
        path:'moneda',
        component:MonedaComponent
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class SucursalesRoutingModule { }
