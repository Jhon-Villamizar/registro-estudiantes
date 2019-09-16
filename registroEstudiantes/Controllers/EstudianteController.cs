using registroEstudiantes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace registroEstudiantes.Controllers
{
    public class EstudianteController : ApiController
    {
        [HttpGet]
        public IEnumerable<Estudiante> Get()
        {
            using(var context = new EstudianteContext())
            {
                return context.Estudiantes.ToList();
            }
        }

        [HttpGet]
        public Estudiante Get(int id)
        {
            using(var context = new EstudianteContext())
            {
                return context.Estudiantes.FirstOrDefault(x=> x.id == id);
            }
        }

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
