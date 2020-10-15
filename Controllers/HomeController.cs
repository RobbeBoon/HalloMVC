using Microsoft.AspNetCore.Mvc;

namespace HalloMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About(int id)
        {
            return Content($"Hello from About{id}");
        }

        public IActionResult Contact()
        {
            return Content("Hello from Contact");
        }
    }
}
