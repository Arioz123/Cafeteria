using Cafeteria.Datos;
using Cafeteria.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cafeteria.Controllers
{
    public class PagoController : Controller
    {
        PagoDatos _pagoDatos = new PagoDatos();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Registrarse()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Registrarse(PagoModel model)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            bool respuesta = _pagoDatos.Registrarpago(model);
            if (respuesta)
            {
                return RedirectToAction("ListarProducto");
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult EditarPago(int id)
        {
            //Para obtener y mostrar el contacto a modificar
            ProductosModel _Pago = _pagoDatos.BuscarPago(id);

            return View(_Pago);
        }
        [HttpPost]
        public IActionResult EditarPago(PagoModel model)
        {
            //para obtener los datos que se editaron del formulario y enviarlo en la base de datos
            if (!ModelState.IsValid)
            {
                return View();
            }
            var respuesta = _pagoDatos.EditarPago(model);
            if (respuesta)
            {
                return RedirectToAction("ListarPago");
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult EliminarPago(int id)
        {
            //Para obtener y mostrar el contacto a eliminar
            ProductosModel _Pago = _pagoDatos.BuscarPago(id);

            return View(_Pago);
        }
        [HttpPost]
        public IActionResult EliminarPago(PagoModel model)
        {
            //para obtener los datos que se van a eliminar del formulario y enviarlo en la base de datos
            var respuesta = _pagoDatos.EliminarPago(model.Id);
            if (respuesta)
            {
                return RedirectToAction("ListarPago");
            }
            else
            {
                return View();
            }
        }
    }
}
