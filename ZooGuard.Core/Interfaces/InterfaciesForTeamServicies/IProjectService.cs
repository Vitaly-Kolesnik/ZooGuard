using System.Collections.Generic;
using System.Threading.Tasks;
using ZooGuard.Core.Entities.TeamEntities;

namespace ZooGuard.Core.Interfaces.InterfaciesForTeamServicies
{
    public interface IProjectService
    {
        Task<bool> AddAsync(Project project);
        Task<bool> DeleteAsync(int id);
        Task<bool> UpdateAsync(Project project);
        Task<Project> GetAsync(int id);
        Task<IList<Project>> GetAll();
    }
}
