import { Injectable } from '@angular/core';
import { Estudiante } from "../model/estudiante";
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class EstudianteService {

  seleccionarEstudiante: Estudiante;
  estudiantes: {};
  readonly URL_API = 'https://localhost:44379/api/Estudiante/';
  constructor(private http: HttpClient) {
    this.seleccionarEstudiante = new Estudiante();
  }

  listarEstudiantes(){
    return this.http.get(this.URL_API);
  }

  crearEstudiante(estudiante: Estudiante){
    return this.http.post(this.URL_API, estudiante);
  }

  editarEstudiante(estudiante: Estudiante) {
    return this.http.put(this.URL_API + `/${estudiante.id}`, estudiante);
  }

  eliminarEstudiante(id: number) {
    return this.http.delete(this.URL_API + `/${id}`);
  }
}
