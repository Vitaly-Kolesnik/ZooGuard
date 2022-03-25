using System.Collections.Generic;
using System.Threading.Tasks;
using ZooGuard.Core.Entities.InfoAboutPos;
using ZooGuard.Core.Interfaces;
using ZooGuard.Core.Specifications;

namespace ZooGuard.Core.Services
{
    public class PositionInformationService<TInformation> : IPositionInformationService<TInformation> 
        where TInformation : InformationAboutPosition, new()
    {
        private readonly IRepository<TInformation> informationPositionRepository;

        public PositionInformationService(IRepository<TInformation> informationPositionRepository)
        {
            this.informationPositionRepository = informationPositionRepository;
        }

        public async Task<bool> AddAsync(TInformation informationAboutPosition)
        {
            return await informationPositionRepository.AddAsync(informationAboutPosition);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await informationPositionRepository.DeleteAsync(new TInformation { Id = id });
        }

        public async Task<TInformation> GetAsync(int id)
        {
            return await informationPositionRepository.GetAsync(id);
        }

        public async Task<IList<TInformation>> GetAllAsync()
        {
            return await informationPositionRepository.ListAsync();
        }

        public async Task<IList<TInformation>> ListAsync(string name)
        {
            return await informationPositionRepository.ListAsync(new PositionInformationSpecification<TInformation>(name)); 
        }
        public async Task<bool> UpdateAsync(TInformation informationAboutPosition)
        {
            return await informationPositionRepository.UpdateAsync(informationAboutPosition);
        }
    }
}
