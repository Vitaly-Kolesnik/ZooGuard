using ZooGuard.Core.Entities;
using ZooGuard.Web.Models;
using System.Collections.Generic;

namespace ZooGuard.Web.Interfaces
{
    public interface IRoleModelService
    {
        IEnumerable<RoleModel> Get();
        RoleModel Get(int id);
        int Add(RoleModel role);
        void Update(RoleModel role);
        void Delete(int id);
    }
}
