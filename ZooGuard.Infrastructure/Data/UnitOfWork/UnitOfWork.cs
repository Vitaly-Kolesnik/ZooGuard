using System;
using System.Threading.Tasks;
using ZooGuad.Infrastructure.Data.Repositories;
using ZooGuard.Core.Entities;
using ZooGuard.Core.Entities.InfoAboutPos;
using ZooGuard.Core.Interfaces;

namespace ZooGuard.Infrastructure.Data.UnitOfWork
{
    public class UnitOfWork<T>: IUnitOfWork<T> 
        where T : InformationAboutPosition, new()
    {
        private readonly PositionDbContext dbContext = new(); //создание пустого класса! Оче важно, что бы класс был пустой в дальнейшем туда запишется контекст
        private IRepository<T> informationAboutPositionRepository;

        public IRepository<T> InformationAboutPositionRepository
        {
            get
            {
                if (informationAboutPositionRepository == null)
                    informationAboutPositionRepository = new EfRepository<T>(dbContext);
                return informationAboutPositionRepository;
            }
        }

        public async Task<bool> SaveAsync()
        {
            await dbContext.SaveChangesAsync();
            return true;
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    dbContext.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

    public class UnitOfWork : IUnitOfWork
    {
        private readonly PositionDbContext dbContext = new();
        private IRepository<Position> positionRepository;
        private IRepository<Storage> storageRepository;
        private IRepository<Vender> venderRepository;

        public IRepository<Position> PositionRepository
        {
            get
            {
                if (this.positionRepository == null)
                {
                    this.positionRepository = new EfRepository<Position>(dbContext);
                }

                return positionRepository;
            }
        }

        public IRepository<Storage> StorageRepository
        {
            get
            {
                if (storageRepository == null)
                    storageRepository = new EfRepository<Storage>(dbContext);
                return storageRepository;
            }
        }

        public IRepository<Vender> VenderRepository
        {
            get
            {
                if (venderRepository == null)
                    venderRepository = new EfRepository<Vender>(dbContext);
                return venderRepository;
            }
        }

        public async Task<bool> SaveAsync()
        {
            await dbContext.SaveChangesAsync();
            return true;
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    dbContext.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
