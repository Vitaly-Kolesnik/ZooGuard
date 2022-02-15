using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooGuard.Core.Entities;

namespace ZooGuard.Core.Interfaces
{
    public interface IRoleService
    {
        int Add(Role role);
        Role Get(int id);
        IList<Role> GetAll();
        void Delete(int id);
        int Update(Role role);
    }
}
