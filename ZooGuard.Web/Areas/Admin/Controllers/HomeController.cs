using Microsoft.AspNetCore.Mvc;

namespace ZooGuard.Web.Areas.Controllers
{
    [Area("admin")]
    public class HomeController : Controller
    {
        [HttpGet("sp")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpGet("sp/ser")]
        public IActionResult Services()
        {
            return View("Services");
        }

        [HttpGet("sp/lic")]
        public IActionResult Licenses()
        {
            return View("Licenses");
        }
    }
}
