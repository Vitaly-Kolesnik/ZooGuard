using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ZooGuard.Core.Interfaces.InterfaciesForWorkerServicies;

namespace ZooGuard.Web.Areas.Admin.Controllers
{
    [Area("admin")]
    public class WorkerController : Controller
    {
        private readonly IWorkerService workerService;

        public WorkerController(IWorkerService workerService)
        {
            this.workerService = workerService;
        }

        [HttpGet("wk")]
        public async Task<IActionResult> Worker()
        {
            var list = await workerService.GetAllAsync();

            if(list.Count < 1)
            {
                return View("WorkerListEmpty");
            }
            return View("Workers");
        }
    }
}
