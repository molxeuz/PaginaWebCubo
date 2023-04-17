using Microsoft.AspNetCore.Mvc;

namespace MVC_cubo.Controllers
{
    public class GeneralController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
