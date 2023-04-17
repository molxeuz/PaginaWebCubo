using Microsoft.AspNetCore.Mvc;

namespace MVC_cubo.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
