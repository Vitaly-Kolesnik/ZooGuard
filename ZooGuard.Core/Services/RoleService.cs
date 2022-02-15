using System.Collections.Generic;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Interfaces;

namespace ZooGuard.Core.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRepository<Role> roleRepository;

        public RoleService(IRepository<Role> roleRepository)
        {
            this.roleRepository = roleRepository;
        }

        public int Add(Role role)
        {
            roleRepository.Add(role);
            return role.Id;
        }

        public Role Get(int id)
        {
            return roleRepository.Get(id);
        }

        public IList<Role> GetAll()
        {
            return roleRepository.List();
        }

        public int Update(Role role)
        {
            roleRepository.Update(role);
            return role.Id;
        }

        public void Delete(int id)
        {
            roleRepository.Delete(new Role { Id = id});
        }
    }
}
