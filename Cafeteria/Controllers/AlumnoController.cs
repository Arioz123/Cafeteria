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
        [HttpGet]
        public IActionResult ListarAlumno(AlumnoModel model) //Esta es la pagina para registrar al alumno (No hay para empleado, se sube directamente desde la base de datos)
        {
            var respuesta = _UsuarioDatos.ListarAlumno();
            return View(respuesta);
        }
        [HttpGet]
        public IActionResult Registrarse() //Esto es para el inicio de sesión (Esta obviamente es la pagina principal)
        {
            //Esta es para mostrar el formulario
            return View();
        }
        [HttpPost]
        public IActionResult Registrarse(AlumnoModel model) //Esto es para el inicio de sesión (Esta obviamente es la pagina principal)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            bool respuesta = _UsuarioDatos.RegistrarAlumno(model);
            if(respuesta)
            {
                return RedirectToAction("ListarAlumno");
            } else
            {
                return View();
            }
        }
    }
}
