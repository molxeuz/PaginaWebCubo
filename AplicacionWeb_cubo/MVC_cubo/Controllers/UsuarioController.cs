using Microsoft.AspNetCore.Mvc;

namespace MVC_cubo.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
