import { Component, OnInit, Input } from '@angular/core';
import { EstudianteService } from "../../service/estudiante.service";
import { NgForm, EmailValidator } from '@angular/forms';

@Component({
  selector: 'app-lista-estudiantes',
  templateUrl: './lista-estudiantes.component.html',
  styleUrls: ['./lista-estudiantes.component.sass']
})
export class ListaEstudiantesComponent implements OnInit {

  constructor(private estudianteService: EstudianteService) { }

  ngOnInit() {
    this.listarEstudiantes();
  }

  listado:boolean=false;
  login:boolean=true;
  resperror:boolean=false;
  email = "";
  password = "";
  administrativos = [
    {
      email:'admin@uam.com',
      password: '1234'
    },
    {
      email:'jhon@uam.com',
      password: '1234'
    }
  ]

  listarEstudiantes(){
    this.estudianteService.listarEstudiantes()
      .subscribe(res => {
        this.estudianteService.estudiantes = res as {};
      })
  }
  enviarLogin(form?: NgForm) {
    console.log(form.value);
    this.email = form.value.email;
    this.password = form.value.password;
    this.administrativos.forEach(element => {
      if(element.email==this.email && element.password==this.password) {
        this.login=false;
        this.listado=true;
      }
      this.resperror=true;
    });
    
  }


}
