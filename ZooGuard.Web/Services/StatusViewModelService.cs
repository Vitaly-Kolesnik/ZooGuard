using ZooGuard.Core.Entities.InfoAboutPos;
using ZooGuard.Core.Interfaces;
using ZooGuard.Web.Interfaces;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Services
{
    public class StatusViewModelService : IStatusViewModelService
    {
        private readonly IPositionInformationService<StatusLabelPos> positionInformationService;

        public StatusViewModelService(IPositionInformationService<StatusLabelPos> positionInformationService)
        {
            this.positionInformationService = positionInformationService;
        }

        public int Add(StatusViewModel statusViewModel)
        {
            return positionInformationService.Add(ConvertToModel(statusViewModel));
        }

        public void Edit(StatusViewModel user)
        {
            throw new System.NotImplementedException();
        }

        public StatusViewModel GetById(int id)
        {
            var status = positionInformationService.Get(id); 
            return status != null ? ConvertToViewModel(status) : null; 
        }

        public StatusViewModel GetEmpty()
        {
            throw new System.NotImplementedException();
        }

        private StatusLabelPos ConvertToModel(StatusViewModel statusViewModel)
        {
            return new StatusLabelPos
            {
                Id = statusViewModel.Id.HasValue ? statusViewModel.Id.Value : 0,
                Name = statusViewModel.Name,
            };
        }

        private StatusViewModel ConvertToViewModel(StatusLabelPos statusLabelPos)
        {
            return new StatusViewModel
            {
                Id = statusLabelPos.Id,
                Name = statusLabelPos.Name,
            };
        }
    }
}
