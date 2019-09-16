import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { RegistroEstudiantesComponent } from './components/registro-estudiantes/registro-estudiantes.component';


const routes: Routes = [{ path: 'registro', component: RegistroEstudiantesComponent },];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
