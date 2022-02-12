using System.Collections.Generic;
using ZooGuard.Core.Entities;

namespace ZooGuard.Core.Interfaces
{
    public interface IStorageService
    {
        int Add(Storage storage);
        void Delete(int id);
        Storage Get(int id);
        IList<Storage> GetAll();
        int Update(Storage storage);
    }
}
