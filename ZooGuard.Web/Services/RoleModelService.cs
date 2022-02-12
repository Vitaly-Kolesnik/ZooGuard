using ZooGuard.Core.Entities;
using ZooGuard.Core.Interfaces;
using ZooGuard.Web.Interfaces;
using ZooGuard.Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace ZooGuard.Web.Services
{
    public class RoleModelService : IRoleModelService
    {
        private readonly IRepository<Role> roleRepository;

        public RoleModelService(IRepository<Role> roleRepository)
        {
            this.roleRepository = roleRepository;
        }

        public int Add(RoleModel role)
        {
            var entity = ConvertToEntity(role);
            roleRepository.Add(entity);

            return entity.Id;
        }

        public void Delete(int id)
        {
            roleRepository.Delete(new Role { Id = id });
        }

        public IEnumerable<RoleModel> Get()
        {
            return roleRepository.List().Select(ConvertToModel);
        }

        public RoleModel Get(int id)
        {
            return ConvertToModel(roleRepository.Get(id));
        }

        public void Update(RoleModel role)
        {
            roleRepository.Update(ConvertToEntity(role));
        }

        private Role ConvertToEntity(RoleModel roleModel)
        {
            return roleModel != null
                ? new Role
                {
                    Id = roleModel.Id ?? 0,
                    Name = roleModel.Name,
                    Description = roleModel.Description
                }
                : null;
        }

        private RoleModel ConvertToModel(Role role)
        {
            return role != null
                ? new RoleModel
                {
                    Id = role.Id,
                    Name = role.Name,
                    Description = role.Description
                }
                : null;
        }
    }
}
