using Microsoft.AspNetCore.Mvc;
using ProductoDatos

namespace Cafeteria.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
