import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

// librerias necesarias para hacer peticiones http y formularios reactivos
import { FormsModule } from "@angular/forms";
import { HttpClientModule } from "@angular/common/http";

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavComponent } from './components/nav/nav.component';
import { RegistroEstudiantesComponent } from './components/registro-estudiantes/registro-estudiantes.component';
import { ListaEstudiantesComponent } from './components/lista-estudiantes/lista-estudiantes.component';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    RegistroEstudiantesComponent,
    ListaEstudiantesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
