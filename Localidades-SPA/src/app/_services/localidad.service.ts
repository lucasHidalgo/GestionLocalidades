import { Localidades } from './../_models/localidades';
import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class LocalidadService {
  baseUrl: string = environment.apiUrl;
  constructor(private http: HttpClient) { }

  crearLocalidad(localidad: Localidades) {    
    return this.http.post(this.baseUrl + 'Localidades/AgregarLocalidad', localidad);
  }

  cargarLocalidades() {    
    return this.http.get<Localidades[]>(this.baseUrl + 'Localidades/ObtenerLocalidades');
  }

  borrarLocalidad(id: number) {    
    return this.http.delete(this.baseUrl + 'Localidades/BorrarLocalidad/' + id );
  }

  obtenerLocalidadPorId(id: number) {
    return this.http.get<Localidades[]>(this.baseUrl + 'Localidades/ObtenerLocalidadPorId/' + id);
  }
  editarLocalidad (id: number, localidad: Localidades) {
    return this.http.put(this.baseUrl + 'Localidades/EditarLocalidad/' + id, localidad);
  }
}
