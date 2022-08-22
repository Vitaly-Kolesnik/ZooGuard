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
        private readonly DbSet<TEntity> dbSet;
        public EfRepository(PositionDbContext dbcontext)
        {
            dbSet = dbcontext.Set<TEntity>();
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
        public async Task<bool> UpdateAsync(TEntity entity)
        {
            await Task.Run(() => dbSet.Update(entity));

            return true;
        }
        public bool Find(ISpecification<TEntity> specification)
        {
            var result = specification.Apply(dbSet);

            return !result.Any();
        }
        public async Task <TEntity> GetAsync(int id) 
        {
            var entity = await dbSet.FindAsync(id);
            return entity;
        }
        public async Task <TEntity> GetAsync(ISpecification<TEntity> specification)
        {
            return await ApplySpecification(dbSet, specification).FirstOrDefaultAsync();
        }
        public async Task <IList<TEntity>> ListAsync() 
        {
            return await dbSet.ToListAsync(); 
        }
        public async Task< IList<TEntity>> ListAsync(ISpecification<TEntity> specification)
        {
            return await ApplySpecification(dbSet, specification).ToListAsync();
        }
        private IQueryable<TEntity> ApplySpecification(IQueryable<TEntity> source, ISpecification<TEntity> specification)
        {
            var result = specification.Apply(source);
            if (specification.Includes != null) 
            {
                foreach (var include in specification.Includes) 
                {
                    result = result.Include(include);
                }
            }
            return result;
        }
    }
}
