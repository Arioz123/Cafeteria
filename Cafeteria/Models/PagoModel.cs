namespace Cafeteria.Models
{
    public class PagoModel
    {
        public int id { get; set; }
        public DateTime Fecha { get; set; }
        public int id_Alumno { get; set; }  
        public decimal Monto { get; set; }

        public AlumnoModel refAlumno { get; set; }
    }
}
