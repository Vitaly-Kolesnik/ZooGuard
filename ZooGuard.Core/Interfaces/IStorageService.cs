using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooGuard.Core.Entities;

namespace ZooGuard.Core.Interfaces
{
    public interface IStorageService
    {
        int Add(Storage storage);
        void Delete(int id);
        Storage Get(int id);
        IList<Storage> List(string name);
        IList<Storage> GetAll();
        int Update(Storage storage);

    }
}
