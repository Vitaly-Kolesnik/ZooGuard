using System;
using System.Threading.Tasks;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Entities.InfoAboutPos;

namespace ZooGuard.Core.Interfaces
{
    public interface IUnitOfWork<T> : IDisposable 
        where T : InformationAboutPosition, new() 
    {
        IRepository<T> InformationAboutPositionRepository { get; }
        Task<bool> SaveAsync();
    }

    public interface IUnitOfWork : IDisposable
    {
        IRepository<Position> PositionRepository { get; }
        IRepository<Storage> StorageRepository { get; }
        IRepository<Vender> VenderRepository { get; }
        Task<bool> SaveAsync();
    }
}
