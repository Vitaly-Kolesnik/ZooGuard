using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ZooGuard.Web.Areas.Controllers
{
    [Area("admin")]
    public class ResourcesController : Controller
    {
        [HttpGet("sp/teh")]
        public async Task<IActionResult> Positions()
        {
            return View("Tehnicals");
        }

        [HttpGet("sp/ser")]
        public async Task<IActionResult> Services()
        {
            return View("Services");
        }

        [HttpGet("sp/lic")]
        public async Task <IActionResult> Licenses()
        {
            return View("Licenses");
        }
    }
}
