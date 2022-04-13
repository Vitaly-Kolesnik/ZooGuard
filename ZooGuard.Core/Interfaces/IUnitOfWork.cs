using System;
using System.Threading.Tasks;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Entities.BaseEntities;
using ZooGuard.Core.Entities.PositionEntities;
using ZooGuard.Core.Entities.StorageEntities;
using ZooGuard.Core.Entities.TeamEntities;
using ZooGuard.Core.Entities.VenderEntities;
using ZooGuard.Core.Entities.WorkerEntities;

namespace ZooGuard.Core.Interfaces
{

    public interface IUnitOfWork : IDisposable
    {
        public IRepository<Position> PositionRepository { get; }
        public IRepository<Storage> StorageRepository { get; }
        public IRepository<Vender> VenderRepository { get; }
        public IRepository<Broken> BrokenRepository { get; }
        public IRepository<FormOfOccurence> FormOfOccurenceRepository { get; }
        public IRepository<Company> CompanyRepository { get; }
        public IRepository<Place> PlaceRepository { get; }
        public IRepository<PositionCategory> PositionCategoryRepository { get; }
        public IRepository<Project> ProjectRepository { get; }
        public IRepository<ServerRoom> ServerRoomRepository { get; }
        public IRepository<SpecialityWorker> SpecialityWorkerRepository { get; }
        public IRepository<Worker> WorkerRepository { get; }
        public IRepository<T> GetRepository<T>() where T : BaseStorageEntities;
        Task<bool> SaveAsync();
    }
}
