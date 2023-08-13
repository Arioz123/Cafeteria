using System.ComponentModel.DataAnnotations;

namespace Cafeteria.Models
{
    public class AlumnoModel
    {
        public int Nss { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Correo { get; set; }
        [Required]
        public string Carrera { get; set; }
        [Required]
        public int Matricula { get; set; }
        [Required]
        public string Contraseña { get; set; }
        [Required]
        public int Semestre { get; set; }
    }
}
