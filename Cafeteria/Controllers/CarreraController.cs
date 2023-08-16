using Cafeteria.Datos;
using Cafeteria.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cafeteria.Controllers
{
    public class CarreraController : Controller
    {
        CarreraDatos _CarreraDatos = new CarreraDatos()
;
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ListarCarrera(CarreraModel model)
        {
            var respuesta = _CarreraDatos.ListarCarrera();
            return View(respuesta);
        }
        [HttpGet]
        public IActionResult Registrarse()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registrarse(CarreraModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            bool respuesta = _CarreraDatos.RegistrarCarrera(model);
            if (respuesta)
            {
                return RedirectToAction("ListarCarrera");
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult EditarProducto(int Codigo)
        {
            //Para obtener y mostrar el contacto a modificar
            ProductosModel _Carrera = _CarreraDatos.BuscarCarrera(Codigo);

            return View(_Carrera);
        }
        [HttpPost]
        public IActionResult EditarCarrera(CarreraModel model)
        {
            //para obtener los datos que se editaron del formulario y enviarlo en la base de datos
            if (!ModelState.IsValid)
            {
                return View();
            }
            var respuesta = _CarreraDatos.EditarCarrera(model);
            if (respuesta)
            {
                return RedirectToAction("ListarCarrera");
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult EliminarCarrera(int Codigo)
        {
            //Para obtener y mostrar el contacto a eliminar
            AlumnoModel _Carrera = _CarreraDatos.BuscarCarrera(Codigo);

            return View(_Carrera);
        }
        [HttpPost]
        public IActionResult EliminarCarrera(CarreraModel model)
        {
            //para obtener los datos que se van a eliminar del formulario y enviarlo en la base de datos
            var respuesta = _CarreraDatos.EliminarCarrera(model.Codigo);
            if (respuesta)
            {
                return RedirectToAction("ListarCarrera");
            }
            else
            {
                return View();
            }
        }
    }
}
