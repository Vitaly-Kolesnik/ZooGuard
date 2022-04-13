using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ZooGuard.Web.Areas.Admin.Controllers
{
    [Area("admin")]
    public class PlaceController : Controller
    {
        [HttpGet("pl")]
        public async Task<IActionResult> Placies()
        {
            return View("Placies");
        }
    }
}
