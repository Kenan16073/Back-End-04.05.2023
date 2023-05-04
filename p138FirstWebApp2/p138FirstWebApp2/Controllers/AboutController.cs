using Microsoft.AspNetCore.Mvc;

namespace p138FirstWebApp2.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult test()
        {
            return View();
        }
    }
}
