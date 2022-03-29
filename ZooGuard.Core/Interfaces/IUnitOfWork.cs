using System;
using System.Threading.Tasks;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Entities.InfoAboutPos;

namespace ZooGuard.Core.Interfaces
{

    public interface IUnitOfWork : IDisposable
    {
        public IRepository<Position> PositionRepository { get; }
        public IRepository<Storage> StorageRepository { get; }
        public IRepository<Vender> VenderRepository { get; }
        public IRepository<T> GetRepository<T>() where T : InformationAboutPosition;
        Task<bool> SaveAsync();
    }
}
