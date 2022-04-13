using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ZooGuard.Web.Areas.Admin.Controllers
{
    [Area("admin")]
    public class ServerController : Controller
    {
        [HttpGet("srv")]
        public async Task<IActionResult> Servers()
        {
            return View("Servers");
        }
    }
}
