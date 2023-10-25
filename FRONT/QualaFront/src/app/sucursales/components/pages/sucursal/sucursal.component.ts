import { Component } from '@angular/core';
import { ModalSharedService } from 'src/app/services/Modal/modal-shared.service';

@Component({
  selector: 'app-sucursal',
  templateUrl: './sucursal.component.html',
  styleUrls: ['./sucursal.component.scss']
})
export class SucursalComponent {

  //TABLA  
  tableData:any[]=[];
  tblTitle:string ="Sucursal";
  displayedColumns: string[] = ['update', 'delete'];
  columns=['noIdentificacion', 'nombresTercero', 'apellidosTercero', 'emailTercero'];
  //MODAL
  ModalTitle:string=''
  
  //Boton Crear
  CreateLabel:string="Crear";
  constructor(private modalshared:ModalSharedService,){}

  onUpdateRegisterEvent(event:any){}

  onCreateRegister(){
    this.modalshared.change('Crear Moneda');
  }

  onUpdateRegister(element:any){}
    
  onDeleteRegister(element:any){}

}
