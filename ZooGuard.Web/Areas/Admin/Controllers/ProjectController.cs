using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ZooGuard.Core.Interfaces.InterfaciesForTeamServicies;

namespace ZooGuard.Web.Areas.Admin.Controllers
{
    [Area("admin")]
    public class ProjectController : Controller
    {
        private readonly IProjectService projectService;

        public ProjectController(IProjectService projectService)
        {
            this.projectService = projectService;
        }

        [HttpGet("prj")]
        public async Task<IActionResult> Companies()
        {
            var list = await projectService.GetAllAsync();

            if (list.Count < 1)
            {
                return RedirectToAction("ProjectListEmpty");
            }

            return View("Projects", list);
        }

        [HttpGet("prj/emp")]
        public IActionResult ProjectListEmpty()
        {
            return View("ProjectListEmpty");
        }

        [HttpGet("prj/ad")]
        public IActionResult GetFormAddProject()
        {
            return View("GetFormAddProject");
        }
    }
}