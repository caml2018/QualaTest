import { Component, OnInit, ViewChild } from '@angular/core';
import { FormControl, FormGroup, FormGroupDirective, Validators } from '@angular/forms';
import { Observable,debounceTime, distinctUntilChanged, map, startWith, switchMap } from 'rxjs';
import { ModalSharedService } from 'src/app/services/Modal/modal-shared.service';
import { MonedaService } from 'src/app/services/moneda/moneda.service';
import { SucursalService } from 'src/app/services/sucursal/sucursal.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-sucursal',
  templateUrl: './sucursal.component.html',
  styleUrls: ['./sucursal.component.scss']
})
export class SucursalComponent implements OnInit {

  @ViewChild('formDirective') formRef!: FormGroupDirective;

  //
  monedaId:number=0;
  valfechaOk:boolean=true;

  //FILTROS
  filteredOptions: Observable<any[]>=new Observable<any[]>();
  
  //TABLA  
  tableData:any[]=[];
  tblTitle:string ="Sucursal";
  displayedColumns: string[] = ['update', 'delete'];
  columns=['codigo', 'descripcion', 'direccion', 'identificacion','fechacreacion'];
  //MODAL
  ModalTitle:string=''
  
  //Boton Crear
  CreateLabel:string="Crear";

  sucursalform = new FormGroup({
    codigo : new FormControl('', [Validators.required]),
    descripcion : new FormControl('', [Validators.required]),
    direccion: new FormControl('', [Validators.required]),
    identificacion: new FormControl('', [Validators.required]),
    fechaCreacion:new FormControl('',[Validators.required]),
    selectMoneda: new FormControl('', [Validators.required]),
  });

  constructor(private modalshared:ModalSharedService,
    private _sucursalService:SucursalService,
    private _monedaService:MonedaService){
      this.cleanEntityService()
  }

  ngOnInit(){
    this._sucursalService.getAll().subscribe(res=>{
      if(res.exito==1){
        this.tableData=res.data;
      }
    });

    this.filteredOptions = this.sucursalform.controls.selectMoneda.valueChanges.pipe(
      startWith(''),
      debounceTime(400),
      distinctUntilChanged(),
      switchMap(val => {
            return this.filter(val || '')
      }) 
    )
  }

  private filter(valori: string): Observable<any[]> {
    var val=valori.toString();
     return this._monedaService.getAll()
      .pipe(
        map(response => response.data.filter((option:any) => {
          return (option.codigo+option.nombre).toLowerCase().indexOf(val.toLowerCase()) !== -1
        }))
      )
   }

  onUpdateRegisterEvent(event:any){}
  onDeleteRegisterEvent(event:any){}

  onCreateRegister(){
    this.modalshared.change('Crear Sucursal');
  }

  onUpdateRegister(element:any){}
    
  onDeleteRegister(element:any){}

  onOptionsMonedaSelected(event: any){
    this.monedaId=event.id;
    this.sucursalform.controls.selectMoneda.setValue(event.codigo);
  }

  cleanForm(){
    this.monedaId=0
    this.sucursalform.controls.codigo.setValue('')
    this.sucursalform.controls.descripcion.setValue('')
    this.sucursalform.controls.direccion.setValue('')
    this.sucursalform.controls.identificacion.setValue('')
    this.sucursalform.controls.fechaCreacion.setValue('')
  }

  cleanEntityService(){
    this._sucursalService.formData={
      id:0,
      codigo:0,
      descripcion:'',
      direccion:'',
      identificacion:'',
      Fechacreacion:new Date(),
      monedaId:0
    }
  }

  cleanMoneda(){
    this.sucursalform.controls.selectMoneda.setValue('');
  }
  updateCalcs(){
    
    var fecha=new Date();
    var fechain= new Date(this.sucursalform.controls.fechaCreacion.value!)
    if(fechain<fecha && this.valfechaOk){
      this.sucursalform.controls.fechaCreacion.setValue('');
      Swal.fire({
        position: 'top-end',
        icon: 'error',
        title: 'El fecha no puede ser menor al día de hoy',
        showConfirmButton: false,
        timer: 1500
      })
    }
  }

  onSave(){
  debugger;
    this._sucursalService.formData.codigo=Number(this.sucursalform.controls.codigo.value);
    this._sucursalService.formData.descripcion=this.sucursalform.controls.descripcion.value;
    this._sucursalService.formData.direccion=this.sucursalform.controls.direccion.value;
    this._sucursalService.formData.identificacion=this.sucursalform.controls.identificacion.value
    this._sucursalService.formData.Fechacreacion= new Date(this.sucursalform.controls.fechaCreacion.value!)
    this._sucursalService.formData.monedaId=this.monedaId

    this._sucursalService.SaveOrUpdateSucursal().subscribe(res=>{
      if(res.exito==1){
        Swal.fire({
          position: 'top-end',
          icon: 'success',
          title: 'La Sucursal fué guardada correctamente',
          showConfirmButton: false,
          timer: 1500
        })
        this.valfechaOk=false;
        this.formRef.resetForm();
        this._sucursalService.getAll().subscribe(res=>{
          debugger;
          if(res.exito==1){
            this.tableData=res.data;
          }
        });
        this.valfechaOk=true;
      }
    });
  }
}




