using Microsoft.AspNetCore.Mvc;

namespace ZooGuard.Web.Areas.Controllers
{
    [Area("admin")]
    public class HomeController : Controller
    {
        [HttpGet("StartPage")]
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
