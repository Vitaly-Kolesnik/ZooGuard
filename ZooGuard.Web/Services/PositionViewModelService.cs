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

        public PositionViewModelService(IPositionService positionService)
        {
            this.positionService = positionService;
        }

        public int Add(PositionViewModel positionViewModel)
        {
            throw new System.NotImplementedException();
        }

        public void Edit(PositionViewModel position)
        {
            throw new System.NotImplementedException();
        }

        public PositionViewModel GetById(int id)
        {
            var position = positionService.Get(id);
            return position != null ? ConvertToViewModel(position) : null;
        }

        public PositionViewModel GetEmpty()
        {
            throw new System.NotImplementedException();
        }

        private PositionViewModel ConvertToViewModel(Position position) //формирует модель при ихспользовании метода GetById
        {
            return new PositionViewModel
            {
                Id = position.Id,
                Name = position.Name,
                Date = position.Date,
                RegistrationDocument = position.RegistrationDocument,
                AccountingNumber = position.AccountingNumber,
                RealityFlag = position.RealityFlag,
                Information = position.Information,
                Vender = position.Vender.Name,
                FormOfOccurence = position.FormOfOccurence.Name,
                User = string.Join(position.User.Name, position.User.LastName),
                StatusLabel = position.StatusLabel.Name,
            };
        }
    }
}
