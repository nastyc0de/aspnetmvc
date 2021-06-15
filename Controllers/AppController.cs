using Microsoft.AspNetCore.Mvc;

namespace empty.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        [HttpGet("about")]
        public IActionResult About()
        {
            return View();
        }
    }
}