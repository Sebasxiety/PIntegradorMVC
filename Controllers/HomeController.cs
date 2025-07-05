using Microsoft.AspNetCore.Mvc;

namespace PIntegradorMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
