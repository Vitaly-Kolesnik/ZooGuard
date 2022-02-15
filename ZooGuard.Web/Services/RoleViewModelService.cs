using ZooGuard.Core.Entities;
using ZooGuard.Core.Interfaces;
using ZooGuard.Web.Interfaces;
using ZooGuard.Web.Models;

namespace ZooGuard.Web.Services
{
    public class RoleViewModelService : IRoleViewModelService
    {
        private readonly IRoleService roleService;

        public RoleViewModelService(IRoleService roleService)
        {
            this.roleService = roleService;
        }

        public int Add(RoleViewModel role)
        {
            return roleService.Add(ConvertToModel(role));
        }

        public void Edit(RoleViewModel role)
        {
            throw new System.NotImplementedException();
        }

        public RoleViewModel GetById(int id)
        {
            var role = roleService.Get(id); //через сервис запрашиваем Vendera
            return role != null ? ConvertToViewModel(role) : null; //если Vender есть, грузим его в метод, в котором формируем модель
            //возвращаем сформмированную модель
        }

        public RoleViewModel GetEmpty()
        {
            throw new System.NotImplementedException();
        }

        private Role ConvertToModel(RoleViewModel role)
        {
            return new Role
            {
                Id = role.Id.HasValue ? role.Id.Value : 0,
                Name = role.Name,
                Description = role.Description,
            };
        }

        private RoleViewModel ConvertToViewModel(Role role) //для формировани модели, для возврата
        {
            return new RoleViewModel
            {
                Id = role.Id,
                Name = role.Name,
                Description = role.Description,
            };
        }
    }
}
