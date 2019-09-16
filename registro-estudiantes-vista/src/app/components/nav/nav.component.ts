import { Component, OnInit, ViewChild } from '@angular/core';
import { RegistroEstudiantesComponent } from "../registro-estudiantes/registro-estudiantes.component";

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.sass']
})
export class NavComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }
  registro:boolean = false;
  lista:boolean = false;
  home:boolean = true;

  principal() {
    if (this.registro || this.lista) {
      this.lista = false;
      this.registro = false;
      this.home = true;
    }
  }
  estudiantes(){
    if (this.home || this.lista) {
      this.lista = false;
      this.home = false;
      this.registro = true;
    }
    

  }
  admin(){
    if (this.home || this.registro) {
      this.home = false;
      this.registro = false;
      this.lista = true;
    }
    
  }

}
