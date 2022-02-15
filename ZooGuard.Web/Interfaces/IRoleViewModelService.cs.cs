using ZooGuard.Core.Entities;
using ZooGuard.Web.Models;
using System.Collections.Generic;

namespace ZooGuard.Web.Interfaces
{
    public interface IRoleViewModelService
    {
        int Add(RoleViewModel roleViewModel);
        RoleViewModel GetById(int value);
        void Edit(RoleViewModel role);
        RoleViewModel GetEmpty();
    }
}
