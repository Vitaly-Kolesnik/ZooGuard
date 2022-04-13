using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ZooGuard.Web.Areas.Admin.Controllers
{
    [Area("admin")]
    public class HomeController : Controller
    {
        [HttpGet("hm")]
        public async Task<IActionResult> Home()
        {
            return View("Home");
        }
    }
}
