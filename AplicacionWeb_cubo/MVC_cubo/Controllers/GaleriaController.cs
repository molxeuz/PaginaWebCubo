using Microsoft.AspNetCore.Mvc;

namespace MVC_cubo.Controllers
{
    public class GaleriaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
