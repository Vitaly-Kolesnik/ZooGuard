using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Interfaces;

namespace ZooGuard.Core.Services
{
    public class BrokenService : IBrokenService
    {
        private readonly IUnitOfWork unitOfWork;

        public BrokenService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<bool> AddAsync(Broken broken)
        {
            using (unitOfWork)
            {
                await unitOfWork.BrokenRepository.AddAsync(broken);

                await unitOfWork.SaveAsync();

                return true;
            }
        }
        public async Task<bool> DeleteAsync(int id)
        {
            using (unitOfWork)
            {
                await unitOfWork.BrokenRepository.DeleteAsync(new Broken { Id = id });

                await unitOfWork.SaveAsync();

                return true;
            }
        }
        public async Task<bool> UpdateAsync(Broken broken)
        {
            using (unitOfWork)
            {
                await unitOfWork.BrokenRepository.UpdateAsync(broken);

                await unitOfWork.SaveAsync();

                return true;
            }
        }
        public async Task<IList<Broken>> GetAllAsync()
        {
            using (unitOfWork)
            {
                return await unitOfWork.BrokenRepository.ListAsync();
            }
        }
        public async Task<Broken> GetAsync(int id)
        {
            using (unitOfWork)
            {
                return await unitOfWork.BrokenRepository.GetAsync(id);
            }
        }
        public Task<IList<Broken>> ListAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}
