using System.Collections.Generic;
using System.Threading.Tasks;
using ZooGuard.Core.Entities.InfoAboutPos;

namespace ZooGuard.Core.Interfaces
{
    public interface IPositionInformationService <TInformation> 
        where TInformation : InformationAboutPosition, new()
    {
        Task<bool> AddAsync(TInformation informationAboutPosition);
        Task<TInformation> GetAsync(int id);
        Task<bool> DeleteAsync(int id); 
        Task<IList<TInformation>> ListAsync(string name);
        Task<bool> UpdateAsync(TInformation informationAboutPosition);
        Task<IList<TInformation>> GetAllAsync();
    }
}
