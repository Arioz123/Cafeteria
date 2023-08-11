using Cafeteria.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cafeteria.Controllers
{
    public class EmpleadoController : Controller
    {
        EmpleadoModel _empleadoModel= new EmpleadoModel();
       
        public IActionResult Index()
        {
            var Consulta_trabajador = _empleadoModel.Puesto(), _empleadoModel.Salario();
            //Devolvera el puesto y el salario del empleado
            return View(Consulta_trabajador);

            
        }

    }
}
