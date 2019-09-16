using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace registroEstudiantes.Models
{
    public class EstudianteContext: DbContext
    {
        public EstudianteContext() : base("EstudiantesConnection")
        {
                
        }

        public DbSet <Estudiante> Estudiantes { get; set; }
    }
}