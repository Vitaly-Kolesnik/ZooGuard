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
        private readonly IUnitOfWork<TInformation> unitOfWork;

        public PositionInformationService(IUnitOfWork<TInformation> unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<bool> AddAsync(TInformation informationAboutPosition)
        {
            await unitOfWork.InformationAboutPositionRepository.AddAsync(informationAboutPosition);

            await unitOfWork.SaveAsync();

            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            await unitOfWork.InformationAboutPositionRepository.DeleteAsync(new TInformation { Id = id });

            await unitOfWork.SaveAsync();

            return true;
        }

        public async Task<TInformation> GetAsync(int id)
        {
            TInformation entity =  await unitOfWork.InformationAboutPositionRepository.GetAsync(id);

            return entity;
        }

        public async Task<IList<TInformation>> GetAllAsync()
        {
           var list = await unitOfWork.InformationAboutPositionRepository.ListAsync();

            return list;
        }

        public async Task<IList<TInformation>> ListAsync(string name)
        {
            return await unitOfWork.InformationAboutPositionRepository.ListAsync(new PositionInformationSpecification<TInformation>(name)); 
        }
        public async Task<bool> UpdateAsync(TInformation informationAboutPosition)
        {
            await unitOfWork.InformationAboutPositionRepository.UpdateAsync(informationAboutPosition);

            await unitOfWork.SaveAsync();

            return true;
        }
    }
}
