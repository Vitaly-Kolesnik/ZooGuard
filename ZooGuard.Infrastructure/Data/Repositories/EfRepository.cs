using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZooGuard.Core.Interfaces;
using ZooGuard.Infrastructure;

namespace ZooGuad.Infrastructure.Data.Repositories
{
    //Обощенный репозиторий для работы со всеми сущностями
    public class EfRepository<TEntity> : IRepository<TEntity>
      where TEntity : class
    {
        internal PositionDbContext dbContext;
        internal DbSet<TEntity> dbSet;
        public EfRepository(PositionDbContext dbContext)
        {
            this.dbContext = dbContext; 
            dbSet = dbContext.Set<TEntity>();

        }
        public async Task<bool> AddAsync(TEntity entity)
        {
            await dbSet.AddAsync(entity);
            return true;
        }
        public async Task<bool> DeleteAsync(TEntity entity)
        {
            await Task.Run (() => dbSet.Remove(entity));

            return true;
        }
        public async Task <TEntity> GetAsync(int id) 
        {
            var entity = await dbSet.FindAsync(id);
            return entity;
        }
        public async Task <TEntity> GetAsync(Specifications<TEntity> specification)
        {
            return await ApplySpecification(dbSet, specification).FirstOrDefaultAsync();
        }
        public async Task <IList<TEntity>> ListAsync() 
        {
            return await dbSet.ToListAsync(); 
        }
        public async Task< IList<TEntity>> ListAsync(Specifications<TEntity> specification)
        {
            return await ApplySpecification(dbSet, specification).ToListAsync();
        }
        public async Task <bool> UpdateAsync(TEntity entity)
        {
            await Task.Run (() => dbSet.Update(entity));

            return true;
        }
        private IQueryable<TEntity> ApplySpecification(IQueryable<TEntity> source, Specifications<TEntity> specification)
        {
            var result = specification.Apply(source);
            if (specification.Includes != null) 
            {
                foreach (var include in specification.Includes) 
                {
                    result = result.Include(include);
                }
            }
            return result.AsNoTracking();
        }
    }
}
