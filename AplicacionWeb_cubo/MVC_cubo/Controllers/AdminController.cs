using Microsoft.AspNetCore.Mvc;

namespace MVC_cubo.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
