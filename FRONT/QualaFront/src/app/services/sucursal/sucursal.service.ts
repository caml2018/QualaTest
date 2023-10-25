import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { SucursalModel } from 'src/app/models/sucursal.model';

@Injectable({
  providedIn: 'root'
})
export class SucursalService {

  public formData!: SucursalModel;

  urlGet:string;

  constructor(private http:HttpClient) {
    this.urlGet="https://localhost:44301/api/" + "Sucursal";
   }

   get():Observable<Response>{
    return this.http.get<Response>(this.urlGet);
   }

   getAll():Observable<Response>{
      return this.http.get<Response>(`${this.urlGet}`);
   }

   SaveOrUpdateAutor(): Observable<Response> {
    var body = {
      ...this.formData,
    }
    return this.http.post<Response>(this.urlGet, body);
  }
}
