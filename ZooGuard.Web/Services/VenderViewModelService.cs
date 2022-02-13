﻿using ZooGuard.Core.Entities;
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

        public int Add(VenderViewModel vender)
        {
            return venderService.Add(ConvertToModel(vender));
        }

        public void Edit(VenderViewModel vender)
        {
            venderService.Update(ConvertToModel(vender));
        }

        public VenderViewModel GetById(int id)
        {
            var vender = venderService.Get(id); //через сервис запрашиваем Vendera
            return vender != null ? ConvertToViewModel(vender) : null; //если Vender есть, грузим его в метод, в котором формируем модель
            //возвращаем сформмированную модель
        }

        public VenderViewModel GetEmpty()
        {
            throw new System.NotImplementedException();
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
