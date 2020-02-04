import { Localidades } from './../../_models/localidades';
import { Provincias } from './../../_models/provincias';
import { Paises } from './../../_models/paises';
import { ProvinciaService } from './../../_services/provincia.service';
import { PaisService } from './../../_services/pais.service';
import { LocalidadService } from './../../_services/localidad.service';
import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute  } from '@angular/router';

@Component({
  selector: 'app-crear-localidad',
  templateUrl: './crear-localidad.component.html',
  styleUrls: ['./crear-localidad.component.css']
})
export class CrearLocalidadComponent implements OnInit {
  paises: Paises[];
  provincias: Provincias[];
  paisSelected: any;
  localidad: any = {};
  constructor(private localidadService: LocalidadService, private paisService: PaisService, private provinciaService: ProvinciaService, private router: Router, private routes: ActivatedRoute) {}

  ngOnInit() {
    var localidadId = this.routes.snapshot.params['id'];
    if(localidadId){
      this.prepararFormularioParaEditar(localidadId);
    }
    this.cargarPaises();
  }

  cargarPaises() {
    this.paisService.cargarPaises().subscribe((result: Paises[]) => {
      this.paises = result;
    }, error => console.log(error));
  }

  onSelectPais(paisId: number) {
    this.provinciaService.cargarProvinciasPorPaisId(paisId).subscribe((result: Provincias[]) => {
      this.provincias = result;
    }, error => console.log(error));
  }

  agregarLocalidad() {
    this.localidadService.crearLocalidad(this.localidad).subscribe((response: any) => {
      if (response) {
        this.router.navigate(['/localidades']);
      }
    }, err => console.log(err));
  }
  prepararFormularioParaEditar(localidadId: number) {
    this.localidadService.obtenerLocalidadPorId(localidadId).subscribe((response: any) => {
      this.localidad = response;
      this.paisSelected = response.Provincias.PaisId;
      // cargar las provincias por pais seleccionado.
      this.onSelectPais(this.paisSelected);
    }, err => console.log(err));
  }

}
