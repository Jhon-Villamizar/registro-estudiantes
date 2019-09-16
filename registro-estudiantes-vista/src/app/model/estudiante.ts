export class Estudiante {
  constructor(id=0,nombres='',apellidos='',tipoEstudiante='',correo='',direccion='',telefono='',programa='')
  {
    this.id = id,
    this.nombres = nombres,
    this.apellidos = apellidos,
    this.tipoEstudiante = tipoEstudiante,
    this.correo = correo,
    this.direccion = direccion,
    this.telefono = telefono,
    this.programa = programa
  }

  id: number;
  nombres: string;
  apellidos: string;
  tipoEstudiante: string;
  correo: string;
  direccion: string;
  telefono: string;
  programa: string;
}
