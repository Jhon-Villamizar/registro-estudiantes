import { Component, OnInit, Input } from '@angular/core';
import { NgForm } from "@angular/forms";
import { EstudianteService } from "../../service/estudiante.service";

@Component({
  selector: 'app-registro-estudiantes',
  templateUrl: './registro-estudiantes.component.html',
  styleUrls: ['./registro-estudiantes.component.sass']
})
export class RegistroEstudiantesComponent implements OnInit {

  constructor(private estudianteService: EstudianteService) { }

  ngOnInit() {
  }

  @Input() home:boolean;
  formulario:boolean=true;
  respuesta: boolean = false;
  valtodo: boolean = false;
  valnombres: boolean = false;
  valapellidos: boolean = false;
  valtipo: boolean = false;
  valcorreo: boolean = false;
  valprograma: boolean = false;


  enviarRegistro(form?: NgForm) {
    if (form.value.nombres == "" || form.value.apellidos == "" || form.value.tipoEstudiante == "" || form.value.correo == "" || form.value.programa == "") {
      if (form.value.nombres == "") {
        this.valnombres = true;
      } else {
        this.valnombres = false;
      }
      if (form.value.apellidos == "") {
        this.valapellidos = true
      } else {
        this.valapellidos = false;
      }
      if (form.value.tipoEstudiante == "") {
        this.valtipo = true
      } else {
        this.valtipo = false;
      }
      if (form.value.correo == "") {
        this.valcorreo = true
      } else {
        this.valcorreo = false;
      }
      if (form.value.programa == "") {
        this.valprograma = true
      } else {
        this.valprograma = false;
      }

    } else {
      console.log(form.value);
      this.respuesta = true;
      this.formulario = false;
      this.estudianteService.crearEstudiante(form.value)
        .subscribe(res => {
          this.respuesta = true;

          console.log(form.value);
        });
    }

  }

  borrarForm(form?: NgForm) {
    if (form) {
      form.reset();
    }
  }



}
