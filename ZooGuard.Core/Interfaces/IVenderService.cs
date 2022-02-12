using System.Collections.Generic;
using ZooGuard.Core.Entities;

namespace ZooGuard.Core.Interfaces
{
    public interface IVenderService
    {
        int Add(Vender vender);
        Vender Get(int id);
        IList<Vender> List(string name);
        IList<Vender> GetAll();
        void Delete(int id);
        int Update(Vender position);
    }
}
