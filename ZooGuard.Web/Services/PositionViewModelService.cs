using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
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
        private readonly IRepository<User> user;
        private readonly IRepository<StatusLabel> statusLabel;
        private readonly IRepository<Storage> storage;

        public PositionViewModelService(IPositionService positionService, IRepository<Vender> vender, IRepository<FormOfOccurence> formOfOccurence, IRepository<User> user, IRepository<StatusLabel> statusLabel, IRepository<Storage> storage)
        {
            this.positionService = positionService;
            this.vender = vender;
            this.formOfOccurence = formOfOccurence;
            this.user = user;
            this.statusLabel = statusLabel;
            this.storage = storage;
        }

        public int Add(PositionViewModel positionViewModel)
        {
            return positionService.Add(ConvertToModel(positionViewModel));
        }

        public void Edit(PositionViewModel position)
        {
            positionService.Update(ConvertToModel(position));
        }

        public Position GetPositionById(int id)
        {
            var position = positionService.Get(id);
            return position ?? null;
        }

        public PositionViewModel GetModelById(int id)
        {
            var position = positionService.Get(id);
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
                Name = position.Name,
                Date = position.Date,
                RegistrationDocument = position.RegistrationDocument,
                AccountingNumber = position.AccountingNumber,
                Information = position.Information,
                Venders = vender.List().Select(r => new SelectListItem(r.Name, r.Id.ToString())).ToList(),
                Storages = storage.List().Select(r => new SelectListItem(r.Name, r.Id.ToString())).ToList(),
                FormOfOccurences = formOfOccurence.List().Select(r => new SelectListItem(r.Name, r.Id.ToString())).ToList(),
                StatusLabels = statusLabel.List().Select(r => new SelectListItem(r.Name, r.Id.ToString())).ToList(),
                Users = user.List().Select(r => new SelectListItem(r.LastName, r.Id.ToString())).ToList(),
            };
        }

        private Position ConvertToModel(PositionViewModel position)
        {
            return new Position
            {
                Id = position.Id.HasValue ? position.Id.Value : 0,
                Name = position.Name,
                Date = position.Date,
                RegistrationDocument = position.RegistrationDocument,
                AccountingNumber = position.AccountingNumber,
                Information = position.Information,
                VenderId = position.VenderId,
                StorageId = position.StorageId,
                FormOfOccurenceId = position.FormOfOccurenceId,
                StatusLabelId = position.StatusLabelId,
                UserId = position.UserId,
            };
        }
    }
}
