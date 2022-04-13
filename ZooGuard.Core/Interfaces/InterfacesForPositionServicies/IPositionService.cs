using System.Collections.Generic;
using System.Threading.Tasks;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Entities.PositionEntities;
using ZooGuard.Core.Enum;

namespace ZooGuard.Core.Interfaces.ForPosition
{
    public interface IPositionService
    {
        Task<bool> AddAsync(Position position);
        Task<bool> DeleteAsync(int id);
        Task<bool> UpdateAsync(Position position);
        Task<Position> GetAsync(int id);
        Task<IList<Position>> ListAsync(string name);
        Task<IList<Position>> GetAllAsync();
        Task<IList<Position>> GetPosAtInformTabAsync(int id, InformTab informTab);
    }
}
