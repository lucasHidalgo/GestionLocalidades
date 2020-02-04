import { ListaLocalidadesComponent } from './localidades/lista-localidades/lista-localidades.component';
import { CrearLocalidadComponent } from './localidades/crear-localidad/crear-localidad.component';

import { Routes } from '@angular/router';

export const appRoutes: Routes = [
    { path: 'localidades', component: ListaLocalidadesComponent },
    { path: 'crearLocalidad', component: CrearLocalidadComponent },
    {path: 'localidad/:id', component: CrearLocalidadComponent },
    { path: '**', redirectTo: 'localidades', pathMatch: 'full'}
]