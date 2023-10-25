import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {FormsModule, ReactiveFormsModule}from '@angular/forms';

import { SucursalesRoutingModule } from './sucursales-routing.module';
import { LayoutComponent } from './components/layout/layout.component';
import { ModalComponent } from './components/modal/modal.component';
import { SucursalComponent } from './components/pages/sucursal/sucursal.component';
import { MonedaComponent } from './components/pages/moneda/moneda.component';
import { TableComponent } from './components/table/table.component';

import {TextFieldModule} from '@angular/cdk/text-field';
import {MatButtonModule} from '@angular/material/button';
import {MatIconModule} from '@angular/material/icon';
import {MatInputModule} from '@angular/material/input';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatTableModule} from '@angular/material/table';
import {MatPaginatorModule} from '@angular/material/paginator';
import {MatSelectModule} from '@angular/material/select';
import {MatDatepickerModule} from '@angular/material/datepicker';
import {MatNativeDateModule} from '@angular/material/core';
import {MatCheckboxModule} from '@angular/material/checkbox';
import {MatAutocompleteModule} from '@angular/material/autocomplete';
import {MatChipsModule} from '@angular/material/chips';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatListModule } from '@angular/material/list';
import { MatExpansionModule } from '@angular/material/expansion';
import{MatSnackBarModule} from '@angular/material/snack-bar';


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
    FormsModule,
    ReactiveFormsModule,
    SucursalesRoutingModule,
    TextFieldModule,
    MatIconModule,
    MatInputModule,
    MatFormFieldModule,
    MatButtonModule,
    MatTableModule,
    MatPaginatorModule,
    MatSelectModule,
    MatDatepickerModule,
    MatNativeDateModule,
    MatCheckboxModule,
    MatAutocompleteModule,
    MatChipsModule,
    MatSidenavModule,
    MatListModule,
    MatExpansionModule,
    MatSnackBarModule,
  ]
})
export class SucursalesModule { }
