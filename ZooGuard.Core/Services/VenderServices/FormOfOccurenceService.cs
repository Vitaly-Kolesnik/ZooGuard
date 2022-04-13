using System.Collections.Generic;
using System.Threading.Tasks;
using ZooGuard.Core.Entities.VenderEntities;
using ZooGuard.Core.Interfaces;
using ZooGuard.Core.Interfaces.InterfacesForVenderServicies;

namespace ZooGuard.Core.Services.VenderServices
{
    public class FormOfOccurenceService : IFormOfOccurenceService
    {
        private readonly IUnitOfWork unitOfWork;

        public FormOfOccurenceService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<bool> AddAsync(FormOfOccurence formOfOccurence)
        {
            using(unitOfWork)
            {
                await unitOfWork.FormOfOccurenceRepository.AddAsync(formOfOccurence);

                await unitOfWork.SaveAsync();

                return true;
            }
        }
        public async Task<bool> DeleteAsync(int id)
        {
            using(unitOfWork)
            {
                await unitOfWork.FormOfOccurenceRepository.DeleteAsync(new FormOfOccurence { Id = id });

                await unitOfWork.SaveAsync();

                return true;
            }
        }
        public async Task<bool> UpdateAsync(FormOfOccurence formOfOccurence)
        {
            using (unitOfWork)
            {
                await unitOfWork.FormOfOccurenceRepository.UpdateAsync(formOfOccurence);

                await unitOfWork.SaveAsync();

                return true;
            }
        }
        public async Task<IList<FormOfOccurence>> GetAllAsync()
        {
            using (unitOfWork)
            {
                return await unitOfWork.FormOfOccurenceRepository.ListAsync();
            }
        }
        public async Task<FormOfOccurence> GetAsync(int id)
        {
            using (unitOfWork)
            {
                return await unitOfWork.FormOfOccurenceRepository.GetAsync(id);
            }
        }

        
    }
}
