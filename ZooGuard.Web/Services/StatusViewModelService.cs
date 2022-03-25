using System.Threading.Tasks;
using ZooGuard.Core.Entities.InfoAboutPos;
using ZooGuard.Core.Interfaces;
using ZooGuard.Web.Interfaces;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Services
{
    public class StatusViewModelService : IStatusViewModelService
    {
        private readonly IPositionInformationService<StatusLabel> positionInformationService;

        public StatusViewModelService(IPositionInformationService<StatusLabel> positionInformationService)
        {
            this.positionInformationService = positionInformationService;
        }

        public async Task<bool> AddAsync(StatusViewModel statusViewModel)
        {
            return await positionInformationService.AddAsync(ConvertToModel(statusViewModel));
        }

        public async Task<StatusViewModel> GetByIdAsync(int id)
        {
            var status = await positionInformationService.GetAsync(id); 
            return status != null ? ConvertToViewModel(status) : null; 
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await positionInformationService.DeleteAsync(id);
        }

        private StatusLabel ConvertToModel(StatusViewModel statusViewModel)
        {
            return new StatusLabel
            {
                Id = statusViewModel.Id.HasValue ? statusViewModel.Id.Value : 0,
                Name = statusViewModel.Name,
            };
        }

        private StatusViewModel ConvertToViewModel(StatusLabel statusLabelPos)
        {
            return new StatusViewModel
            {
                Id = statusLabelPos.Id,
                Name = statusLabelPos.Name,
            };
        }
    }
}
