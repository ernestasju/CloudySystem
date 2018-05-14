using Microsoft.AspNetCore.Mvc;

namespace CloudySystem
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NotIndex()
        {
            return Ok("Hello World from a controller (NotIndex)");
        }

        public IActionResult NotNotNotIndex()
        {
            return Ok("Hello World from a controller (NotNotNotIndex)???");
        }
    }
}