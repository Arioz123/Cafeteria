﻿using System.ComponentModel.DataAnnotations;

namespace Cafeteria.Models
{
    public class AlumnoModel
    {
        public int Nss { get; set; }
        [Required(ErrorMessage = "El campo Nss Es obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo Nombre Es obligatorio")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El campo Apellido Es obligatorio")]
        public string Correo { get; set; }
        [Required(ErrorMessage = "El campo Correo Es obligatorio")]
        public string Carrera { get; set; }
        [Required(ErrorMessage = "El campo Carrera Es obligatorio")]
        public int Matricula { get; set; }
        [Required(ErrorMessage = "El campo Matricula Es obligatorio")]
        public string Contraseña { get; set; }
        [Required(ErrorMessage = "El campo Contraseña Es obligatorio")]
        public int Semestre { get; set; }
    }
}
