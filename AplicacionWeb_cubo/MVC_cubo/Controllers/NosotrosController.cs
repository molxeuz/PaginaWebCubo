using Microsoft.AspNetCore.Mvc;

namespace MVC_cubo.Controllers
{
    public class NosotrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
