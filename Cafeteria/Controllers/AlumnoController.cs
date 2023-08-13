using Cafeteria.Datos;
using Cafeteria.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cafeteria.Controllers
{
    public class AlumnoController : Controller
    {
        UsuarioDatos _UsuarioDatos = new UsuarioDatos();
        public IActionResult Index() //Esto es para el inicio de sesión (Esta obviamente es la pagina principal)
        {
            return View();
        }

        public IActionResult RegistrarAlumno(AlumnoModel model) //Esta es la pagina para registrar al alumno (No hay para empleado, se sube directamente desde la base de datos)
        {
            var respuesta = _UsuarioDatos.ListarAlumno();
            return View();
        }
        [HttpGet]
        public IActionResult Index1() //Esto es para el inicio de sesión (Esta obviamente es la pagina principal)
        {
            return View();
        }
    }
}
