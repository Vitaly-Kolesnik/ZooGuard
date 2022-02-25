using System;
using System.Collections.Generic;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Enum;

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
        public IList<Position> GetPosAtStorage(int id);
        public IList<Position> GetPosAtVender(int id);
        public IList<Position> GetPosAtUser(int id, InformTab informTab);
    }
}
