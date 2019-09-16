using registroEstudiantes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace registroEstudiantes.Controllers
{
    //clase principal donde se declararn las funciones del CRUD
    public class EstudianteController : ApiController
    {
        //Funcion que trae la lista de los registros de la BD
        [HttpGet]
        public IEnumerable<Estudiante> Get()
        {
            using(var context = new EstudianteContext())
            {
                return context.Estudiantes.ToList();
            }
        }
        //Funcion que permite buscar un registro a traves de su id
        [HttpGet]
        public Estudiante Get(int id)
        {
            using(var context = new EstudianteContext())
            {
                return context.Estudiantes.FirstOrDefault(x=> x.id == id);
            }
        }
        //Funcion que crea nuevos registros
        [HttpPost]
        public IHttpActionResult Post(Estudiante estudiante)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            using (var context = new EstudianteContext())
            {
                context.Estudiantes.Add(estudiante);
                context.SaveChanges();
                return Ok (estudiante);
            }
        }
        //funcion que permite editar los registros
        [HttpPut]
        public IHttpActionResult Put(Estudiante estudiante)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            using (var context = new EstudianteContext())
            {
                var estudianteAct = context.Estudiantes.FirstOrDefault(x => x.id == estudiante.id);
                estudianteAct.nombres = estudiante.nombres;
                estudianteAct.apellidos = estudiante.apellidos;
                estudianteAct.tipoEstudiante = estudiante.tipoEstudiante;
                estudianteAct.correo = estudiante.correo;
                estudianteAct.direccion = estudiante.direccion;
                estudianteAct.telefono = estudiante.telefono;
                context.SaveChanges();
                return Ok(estudiante);
            }
        }
        //funcion que permite eliminar registros de la BD
        [HttpDelete]
        public bool Delete(int id)
        {
            using (var context = new EstudianteContext())
            {
                var estudianteDel = context.Estudiantes.FirstOrDefault(x => x.id == id);
                context.Estudiantes.Remove(estudianteDel);
                context.SaveChanges();
                return true;
            }
        }
            
    }
}
