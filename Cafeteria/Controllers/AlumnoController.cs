using Microsoft.AspNetCore.Mvc;

namespace Cafeteria.Controllers
{
    public class AlumnoController : Controller
    {
        public IActionResult Index() //Esto es para el inicio de sesión (Esta obviamente es la pagina principal)
        {
            return View();
        }

        public IActionResult RegistrarAlumno() //Esta es la pagina para registrar al alumno (No hay para empleado, se sube directamente desde la base de datos)
        {
            return View();
        }
    }
}
