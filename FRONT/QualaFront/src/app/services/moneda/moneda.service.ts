import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { MonedaModel } from 'src/app/models/moneda.model';
import { Response } from 'src/app/models/response.model';

@Injectable({
  providedIn: 'root'
})
export class MonedaService {

  public formData!: MonedaModel;

  urlGet:string;

  constructor(private http:HttpClient) {
    this.urlGet="https://localhost:44301/api/" + "Moneda";
    //https://localhost:44301/api/Moneda/getAll
   }

   get():Observable<Response>{
    return this.http.get<Response>(this.urlGet);
   }

   getAll():Observable<Response>{
      return this.http.get<Response>(`${this.urlGet}/getAll`);
   }

   SaveOrUpdateAutor(): Observable<Response> {
    var body = {
      ...this.formData,
    }
    return this.http.post<Response>(this.urlGet, body);
  }
}
