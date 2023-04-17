using Microsoft.AspNetCore.Mvc;

namespace MVC_cubo.Controllers
{
    public class EmpresaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
