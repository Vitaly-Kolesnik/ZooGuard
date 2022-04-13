using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZooGuard.Core.Entities.TeamEntities;
using ZooGuard.Core.Interfaces;
using ZooGuard.Core.Interfaces.InterfaciesForTeamServicies;

namespace ZooGuard.Core.Services.TeamServices
{
    public class ProjectService : IProjectService
    {
        private readonly IUnitOfWork unitOfWork;

        public ProjectService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<bool> AddAsync(Project project)
        {
            using(unitOfWork)
            {
                await unitOfWork.ProjectRepository.AddAsync(project);

                await unitOfWork.SaveAsync();

                return true;
            }
        }
        public async Task<bool> DeleteAsync(int id)
        {
            using (unitOfWork)
            {
                await unitOfWork.ProjectRepository.DeleteAsync(new Project { Id = id });

                await unitOfWork.SaveAsync();

                return true;
            }
        }
        public async Task<IList<Project>> GetAll()
        {
            using (unitOfWork)
            {
                return await unitOfWork.ProjectRepository.ListAsync();
            }
        }
        public async Task<Project> GetAsync(int id)
        {
            using (unitOfWork)
            {
                return await unitOfWork.ProjectRepository.GetAsync(id);
            }
        }
        public async Task<bool> UpdateAsync(Project project)
        {
            using (unitOfWork)
            {
                await unitOfWork.ProjectRepository.UpdateAsync(project);

                await unitOfWork.SaveAsync();

                return true;
            }
        }
    }
}
