import { Component, OnInit } from '@angular/core';
import { ModalSharedService } from 'src/app/services/Modal/modal-shared.service';
import { MonedaService } from 'src/app/services/moneda/moneda.service';

@Component({
  selector: 'app-moneda',
  templateUrl: './moneda.component.html',
  styleUrls: ['./moneda.component.scss']
})
export class MonedaComponent implements OnInit {

  lstMonedas:any[]=[];

  //TABLA  
  tableData:any[]=[];
  tblTitle:string ="Moneda";
  displayedColumns: string[] = ['update', 'delete'];
  columns=['codigo', 'nombre'];
  //MODAL
  ModalTitle:string=''
  
  //Boton Crear
  CreateLabel:string="Crear"

  constructor(private modalshared:ModalSharedService,private _monedaService:MonedaService){}

  ngOnInit(): void {
    this._monedaService.getAll().subscribe(res=>{
      if(res.exito==1){
        debugger;
        this.tableData=res.data
      }
    })
  }

  onUpdateRegisterEvent(event:any){}

  onCreateRegister(){
    this.modalshared.change('Crear Moneda');
  }

  onUpdateRegister(element:any){}
    
  onDeleteRegister(element:any){}

}
