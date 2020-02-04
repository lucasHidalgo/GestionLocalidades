import { Provincias } from './../_models/provincias';
import { environment } from './../../environments/environment';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ProvinciaService {
  baseUrl: string = environment.apiUrl;
  constructor(private http: HttpClient) { }

  cargarProvinciasPorPaisId(id: number) {
    return this.http.get<Provincias[]>(this.baseUrl + 'Provincias/ObtenerProvinciasPorPais/' + id);
  }
}
