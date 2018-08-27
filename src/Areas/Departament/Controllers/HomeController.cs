using Microsoft.AspNetCore.Mvc;

namespace NetCoreAppAreas.Areas.Departament.Controllers
{
    [Area("Departament")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}