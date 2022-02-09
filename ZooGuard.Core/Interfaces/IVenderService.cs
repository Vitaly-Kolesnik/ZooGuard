using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
