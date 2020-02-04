import { PaisService } from './_services/pais.service';
import { ProvinciaService } from './_services/provincia.service';
import { LocalidadService } from './_services/localidad.service';
import { CrearLocalidadComponent } from './localidades/crear-localidad/crear-localidad.component';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { HttpClientModule} from '@angular/common/http';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';

import { AppComponent } from './app.component';
import { ListaLocalidadesComponent } from './localidades/lista-localidades/lista-localidades.component';
import { appRoutes } from './routes';
import { NavComponent } from './nav/nav.component';


@NgModule({
   declarations: [
      AppComponent,
      ListaLocalidadesComponent,
      CrearLocalidadComponent,
      NavComponent
   ],
   imports: [
      BrowserModule,
      HttpClientModule,
      RouterModule.forRoot(appRoutes),
      FormsModule,
      ReactiveFormsModule
   ],
   providers: [
      LocalidadService,
      ProvinciaService,
      PaisService
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
