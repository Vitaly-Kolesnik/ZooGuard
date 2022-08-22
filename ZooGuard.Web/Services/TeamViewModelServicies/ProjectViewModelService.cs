using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;
using ZooGuard.Core.Entities.StorageEntities;
using ZooGuard.Core.Entities.TeamEntities;
using ZooGuard.Core.Interfaces;
using ZooGuard.Core.Interfaces.ForPosition;
using ZooGuard.Core.Interfaces.InterfaciesForTeamServicies;
using ZooGuard.Core.Interfaces.InterfaciesForWorkerServicies;
using ZooGuard.Web.Interfaces.InterfacesForTeamViewModelServices;
using ZooGuard.Web.Models;
using ZooGuard.Web.Models.TeamViewModels;

namespace ZooGuard.Web.Services
{
    public class ProjectViewModelService :IProjectViewModelService
    {
        private readonly IProjectService projectService;
        private readonly ICompanyService companyService;
        private readonly IPositionService positionService;
        private readonly IAllStorageService<Place> placeService;
        private readonly IWorkerService workerService;

        public ProjectViewModelService(IProjectService projectService, 
            ICompanyService companyService,
            IPositionService positionService,
            IAllStorageService<Place> allStorageService,
            IWorkerService workerService)
        {
            this.projectService = projectService;
            this.companyService = companyService;
            this.positionService = positionService;
            this.workerService = workerService;
            this.placeService = allStorageService;
        }

        public async Task<bool> AddAsync(ProfileProjectViewModel projectViewModel)
        {
            return await projectService.AddAsync(ConvertToModel(projectViewModel));
        }

        public ProfileProjectViewModel GetEmpty()
        {
            return ConvertToViewModel(new Project());
        }

        public async Task<bool> DeleteProjectAsync(int id) 
        {
            return await projectService.DeleteAsync(id);
        }

        public async Task<ProfileProjectViewModel> GetProjectByIdAsync(int id) 
        {
            var project = await projectService.GetAsync(id);

            return ConvertToViewModel(project);
        }

        private Project ConvertToModel(ProfileProjectViewModel projectViewModel)
        {
            return new Project
            {
                Id = projectViewModel.Id.HasValue ? projectViewModel.Id.Value : 0,
                Name = projectViewModel.Name,
                CompanyId = projectViewModel.CompanyId,

            };
        }

        private ProfileProjectViewModel ConvertToViewModel(Project project)
        {
            return new ProfileProjectViewModel
            {
                Id = project.Id,
                Name = project.Name,
                Companies = companyService.GetAllAsync().Result.Select(r => new SelectListItem(r.Name, r.Id.ToString())).ToList(),
            };
        }

        private AddProjectViewModel ConvertToAddViewModel(Project project)
        {
            return new ProfileProjectViewModel
            {
                Id = project.Id,
                Name = project.Name,
                Companies = companyService.GetAllAsync().Result.Select(r => new SelectListItem(r.Name, r.Id.ToString())).ToList(),
                Positions = positionService.GetAllAsync().Result.Select(r => new SelectListItem(r.ShortName, r.Id.ToString())).ToList(),
                Places = placeService.GetAllAsync().Result.Select(r => new SelectListItem(r.Name, r.Id.ToString())).ToList(),
                Workers = workerService.GetAllAsync().Result.Select(r => new SelectListItem(r.Name, r.Id.ToString())).ToList()
            };
        }
    }
}
