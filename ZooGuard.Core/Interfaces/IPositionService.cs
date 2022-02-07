using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooGuard.Core.Entities;

namespace ZooGuard.Core.Interfaces
{
    public interface IPositionService
    {
        int Add(Position position);
        Position Get(int id);
        IList<Position> List(string name);
        IList<Position> GetAll();
        void Delete(int id);
        int Update(Position position);
    }
}
