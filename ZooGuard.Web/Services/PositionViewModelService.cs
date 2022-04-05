using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Entities.InfoAboutPos;
using ZooGuard.Core.Interfaces;
using ZooGuard.Web.Interfaces;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Services
{
    public class PositionViewModelService : IPositionViewModelService
    {
        private readonly IPositionService positionService;
        private readonly IRepository<Vender> vender;
        private readonly IRepository<FormOfOccurence> formOfOccurence;
        private readonly IRepository<StatusLabel> statusLabel;
        private readonly IRepository<Storage> storage;

        public PositionViewModelService(IPositionService positionService, IRepository<Vender> vender, IRepository<FormOfOccurence> formOfOccurence, IRepository<StatusLabel> statusLabel, IRepository<Storage> storage)
        {
            this.positionService = positionService;
            this.vender = vender;
            this.formOfOccurence = formOfOccurence;
            this.statusLabel = statusLabel;
            this.storage = storage;
        }

        public async Task<bool> AddAsync(PositionViewModel positionViewModel)
        {
            return await positionService.AddAsync(ConvertToModel(positionViewModel));
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await positionService.DeleteAsync(id);
        }

        public async Task<bool> EditAsync(PositionViewModel position)
        {
            return await positionService.UpdateAsync(ConvertToModel(position));
        }

        public async Task<Position> GetPositionByIdAsync(int id)
        {
            return await positionService.GetAsync(id);
        }

        public async Task<PositionViewModel> GetModelByIdAsync(int id)
        {
            var position = await positionService.GetAsync(id);
            return position != null ? ConvertToViewModel(position) : null;
        }

        public PositionViewModel GetEmpty()
        {
            return ConvertToViewModel(new Position());
        }

        private PositionViewModel ConvertToViewModel(Position position)
        {
            return new PositionViewModel
            {
                Id = position.Id,
                Name = position.FullName,
                Date = position.Date,
                RegistrationDocument = position.RegistrationDocument,
                AccountingNumber = position.AccountingNumber,
                Information = position.Information,
                Venders = vender.ListAsync().Result.Select(r => new SelectListItem(r.Name, r.Id.ToString())),
                Storages = storage.ListAsync().Result.Select(r => new SelectListItem(r.Name, r.Id.ToString())),
                FormOfOccurences = formOfOccurence.ListAsync().Result.Select(r => new SelectListItem(r.Name, r.Id.ToString())),
                StatusLabels = statusLabel.ListAsync().Result.Select(r => new SelectListItem(r.Name, r.Id.ToString())),
            };
        }

        private Position ConvertToModel(PositionViewModel position)
        {
            return new Position
            {
                Id = position.Id.HasValue ? position.Id.Value : 0,
                FullName = position.Name,
                Date = position.Date,
                RegistrationDocument = position.RegistrationDocument,
                AccountingNumber = position.AccountingNumber,
                Information = position.Information,
                VenderId = position.VenderId,
                StorageId = position.StorageId,
                FormOfOccurenceId = position.FormOfOccurenceId,
                StatusLabelId = position.StatusLabelId,
            };
        }
    }
}
