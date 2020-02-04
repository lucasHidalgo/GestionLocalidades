import { Paises } from './../_models/paises';
import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class PaisService {
  baseUrl: string = environment.apiUrl;
  constructor(private http: HttpClient) { }

  cargarPaises() {
    return this.http.get<Paises[]>(this.baseUrl + 'Paises/ObtenerPaises');
  }
}
