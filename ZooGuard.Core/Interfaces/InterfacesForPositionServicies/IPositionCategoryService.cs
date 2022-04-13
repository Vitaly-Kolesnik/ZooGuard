using System.Collections.Generic;
using System.Threading.Tasks;
using ZooGuard.Core.Entities.PositionEntities;

namespace ZooGuard.Core.Interfaces.ForPosition
{
    public interface IPositionCategoryService
    {
        Task<bool> AddAsync(PositionCategory positionCategory);
        Task<bool> DeleteAsync(int id);
        Task<bool> UpdateAsync(PositionCategory positionCategory);
        Task<PositionCategory> GetAsync(int id);
        Task<IList<PositionCategory>> GetAllAsync();
    }
}
