using Microsoft.AspNetCore.Mvc;

namespace EternaSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
