using System.Collections.Generic;
using System.Threading.Tasks;
using ZooGuard.Core.Entities.TeamEntities;

namespace ZooGuard.Core.Interfaces.InterfaciesForTeamServicies
{
    public interface ICompanyService
    {
        Task<bool> AddAsync(Company company);
        Task<bool> DeleteAsync(int id);
        Task<bool> UpdateAsync(Company company);
        Task<Company> GetAsync(int id);
        Task<IList<Company>> GetAllAsync();

    }
}
