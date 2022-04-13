using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ZooGuard.Web.Areas.Admin.Controllers
{
    [Area("admin")]
    public class WorkerController : Controller
    {
        [HttpGet("wk")]
        public async Task<IActionResult> Worker()
        {
            return View("Workers");
        }
    }
}
