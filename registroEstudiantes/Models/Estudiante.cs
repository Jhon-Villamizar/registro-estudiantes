using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace registroEstudiantes.Models
{
    [Table("Tb_Estudiante")]
    public class Estudiante
    {
        [Key]
        public int id { get; set; }
        [MaxLength(255)]
        [Required]
        public string nombres { get; set; }
        [MaxLength(255)]
        [Required]
        public string apellidos { get; set; }
        [MaxLength(255)]
        [Required]
        public string tipoEstudiante { get; set; }
        [MaxLength(255)]
        [Required]
        public string programa { get; set; }
        [MaxLength(255)]
        [Required]
        public string correo { get; set; }
        [MaxLength(255)]
        public string direccion { get; set; }
        [MaxLength(255)]
        public string telefono { get; set; }
    }
}