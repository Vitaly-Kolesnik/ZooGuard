using System.Threading.Tasks;
using ZooGuard.Core.Entities.TeamEntities;
using ZooGuard.Core.Interfaces.InterfaciesForTeamServicies;
using ZooGuard.Web.Interfaces.InterfacesForTeamViewModelServices;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Services
{
    public class ProjectViewModelService :IProjectViewModelService
    {
        private readonly IProjectService projectService;

        public ProjectViewModelService(IProjectService projectService)
        {
            this.projectService = projectService;
        }

        public async Task<bool> AddAsync(ProjectViewModel projectViewModel)
        {
            return await projectService.AddAsync(ConvertToModel(projectViewModel));
        }

        private Project ConvertToModel(ProjectViewModel projectViewModel)
        {
            return new Project
            {
                Id = projectViewModel.Id.HasValue ? projectViewModel.Id.Value : 0,
                Name = projectViewModel.Name,
                CompanyId = projectViewModel.CompanyId,

            };
        }
    }
}
