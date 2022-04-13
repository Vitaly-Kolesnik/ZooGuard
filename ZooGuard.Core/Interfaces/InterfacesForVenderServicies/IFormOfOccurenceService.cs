using System.Collections.Generic;
using System.Threading.Tasks;
using ZooGuard.Core.Entities.VenderEntities;

namespace ZooGuard.Core.Interfaces.InterfacesForVenderServicies
{
    public interface IFormOfOccurenceService
    {
        Task<bool> AddAsync(FormOfOccurence formOfOccurence);
        Task<bool> DeleteAsync(int id);
        Task<bool> UpdateAsync(FormOfOccurence formOfOccurence);
        Task<FormOfOccurence> GetAsync(int id);
        Task<IList<FormOfOccurence>> GetAllAsync();
    }
}
