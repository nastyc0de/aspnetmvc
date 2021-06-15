using Microsoft.AspNetCore.Mvc;

namespace empty.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome()
        {
            return View();
        }
    }
}