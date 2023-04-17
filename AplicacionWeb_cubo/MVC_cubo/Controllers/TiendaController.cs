using Microsoft.AspNetCore.Mvc;

namespace MVC_cubo.Controllers
{
    public class TiendaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
