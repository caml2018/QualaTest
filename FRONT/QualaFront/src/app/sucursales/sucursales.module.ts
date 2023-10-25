import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { SucursalesRoutingModule } from './sucursales-routing.module';
import { LayoutComponent } from './components/layout/layout.component';
import { ModalComponent } from './components/modal/modal.component';
import { SucursalComponent } from './components/pages/sucursal/sucursal.component';
import { MonedaComponent } from './components/pages/moneda/moneda.component';
import { TableComponent } from './components/table/table.component';

import {MatTableModule} from '@angular/material/table';
import {MatPaginatorModule} from '@angular/material/paginator';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatSelectModule} from '@angular/material/select';
import { MatSidenavModule } from '@angular/material/sidenav';


@NgModule({
  declarations: [
    LayoutComponent,
    ModalComponent,
    SucursalComponent,
    MonedaComponent,
    TableComponent
  ],
  imports: [
    CommonModule,
    SucursalesRoutingModule,
    MatTableModule,
    MatPaginatorModule,
    MatFormFieldModule,
    MatSelectModule,
    MatSidenavModule
  ]
})
export class SucursalesModule { }
