using Microsoft.AspNetCore.Mvc;

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
