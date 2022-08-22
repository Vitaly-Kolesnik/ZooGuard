using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ZooGuard.Core.Interfaces.InterfaciesForTeamServicies;
using ZooGuard.Web.Interfaces.InterfacesForTeamViewModelServices;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Areas.Admin.Controllers
{
    [Area("admin")]
    public class ProjectController : Controller
    {
        private readonly IProjectService projectService;
        private readonly IProjectViewModelService projectViewModelService;

        public ProjectController(IProjectService projectService, IProjectViewModelService projectViewModelService)
        {
            this.projectService = projectService;
            this.projectViewModelService = projectViewModelService;
        }

        [HttpGet("prj")]
        public async Task<IActionResult> Projects()
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
            var model = projectViewModelService.GetEmpty();

            return View("GetFormAddProject", model);
        }

        [HttpPost]
        public async Task<IActionResult> AddProject(ProfileProjectViewModel projectViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            await projectViewModelService.AddAsync(projectViewModel);

            return RedirectToAction("Projects");
        }

        [HttpGet("prj/del/{id}")]
        public async Task<IActionResult> DeleteProject(int id) 
        {
           await projectViewModelService.DeleteProjectAsync(id);

           return RedirectToAction("Projects", "Project");
        }

        [HttpGet]
        public async Task <IActionResult> UpdateProject(int id) 
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var project = await projectViewModelService.GetProjectByIdAsync(id);

            return View("UpdateProject", project);
        }
    }
}