import { Localidades } from './../../_models/localidades';
import { LocalidadService } from './../../_services/localidad.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-lista-localidades',
  templateUrl: './lista-localidades.component.html',
  styleUrls: ['./lista-localidades.component.css']
})
export class ListaLocalidadesComponent implements OnInit {
  localidades: Localidades[];
  constructor(private localidadService: LocalidadService) { }

  ngOnInit() {
    this.cargarLocalidades();
  }

  cargarLocalidades() {    
    this.localidadService.cargarLocalidades().subscribe((result: Localidades[]) => {      
      this.localidades = result;
     }, error => console.log(error));
  }
  borrarLocalidad(id: number) {
    this.localidadService.borrarLocalidad(id).subscribe(() => {
    }, err => console.log(err)
    , () => this.cargarLocalidades());    
  }

}
