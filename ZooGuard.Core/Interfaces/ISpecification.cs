using System.Collections.Generic;
using System.Linq;

namespace ZooGuard.Core.Interfaces
{
    public interface ISpecification<TEntity> 
        where TEntity : class
    {
        IList<string> Includes { get; } //коллекция строк из базы

        IQueryable<TEntity> Apply (IQueryable<TEntity> query);
    }
}
