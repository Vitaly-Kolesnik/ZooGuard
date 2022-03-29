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
        private readonly IUnitOfWork unitOfWork;

        public PositionInformationService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<bool> AddAsync(TInformation informationAboutPosition)
        {
            using (unitOfWork)
            {
                await unitOfWork.GetRepository<TInformation>().AddAsync(informationAboutPosition);

                await unitOfWork.SaveAsync();

                return true;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            using (unitOfWork)
            {
                await unitOfWork.GetRepository<TInformation>().DeleteAsync(new TInformation { Id = id });

                await unitOfWork.SaveAsync();

                return true;
            }
        }

        public async Task<bool> UpdateAsync(TInformation informationAboutPosition)
        {
            using(unitOfWork)
            {
                await unitOfWork.GetRepository<TInformation>().UpdateAsync(informationAboutPosition);

                await unitOfWork.SaveAsync();

                return true;
            }
        }

        public async Task<TInformation> GetAsync(int id)
        {
            using(unitOfWork)
            {
                TInformation entity = await unitOfWork.GetRepository<TInformation>().GetAsync(id);

                return entity;
            }
        }

        public async Task<IList<TInformation>> GetAllAsync()
        {
            var list = await unitOfWork.GetRepository<TInformation>().ListAsync();

            return list;
        }

        public async Task<IList<TInformation>> ListAsync(string name)
        {
            using (unitOfWork)
            {
                var list = await unitOfWork.GetRepository<TInformation>().ListAsync(new PositionInformationSpecification<TInformation>(name));

                return list;
            }
        }
        
    }
}
