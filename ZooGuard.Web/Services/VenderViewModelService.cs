using System.Threading.Tasks;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Interfaces;
using ZooGuard.Web.Interfaces;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Services
{
    public class VenderViewModelService : IVenderViewModelService
    {
        private readonly IVenderService venderService;

        public VenderViewModelService(IVenderService venderService)
        {
            this.venderService = venderService;
        }
        public async Task<bool> AddAsync(VenderViewModel vender)
        {
            return await venderService.AddAsync(ConvertToModel(vender));
        }

        public async Task<bool> EditAsync(VenderViewModel vender)
        {
            return await venderService.UpdateAsync(ConvertToModel(vender));
        }
        public async Task<VenderViewModel> GetByIdAsync(int id)
        {
            var vender = await venderService.GetAsync(id); 
            return vender != null ? ConvertToViewModel(vender) : null; 
        }
        public async Task<bool> DeleteAsync(int id)
        {
           return await venderService.DeleteAsync(id);
        }
        private VenderViewModel ConvertToViewModel (Vender vender) //для формировани модели, для возврата
        {
            return new VenderViewModel
            {
                Id = vender.Id,
                Name = vender.Name,
                FirstNameRepresentative = vender.FirstNameRepresentative,
                LastNameRepresentative = vender.LastNameRepresentative,
                PhoneRepresentative = vender.PhoneRepresentative,
                EmailRepresentative = vender.EmailRepresentative,
                MailingAddress = vender.MailingAddress,
                Сomment = vender.Comment
            };
        }

        private Vender ConvertToModel(VenderViewModel venderViewModel)
        {
            return new Vender
            {
                Id = venderViewModel.Id.HasValue ? venderViewModel.Id.Value : 0,
                Name = venderViewModel.Name,
                FirstNameRepresentative= venderViewModel.FirstNameRepresentative,
                LastNameRepresentative= venderViewModel.LastNameRepresentative,
                PhoneRepresentative= venderViewModel.PhoneRepresentative,
                EmailRepresentative= venderViewModel.EmailRepresentative,
                MailingAddress= venderViewModel.MailingAddress,
                Comment = venderViewModel.Сomment
            };
        }
    }
}
