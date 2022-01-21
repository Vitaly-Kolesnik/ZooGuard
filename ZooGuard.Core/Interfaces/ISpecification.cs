﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooGuard.Core.Interfaces
{
    public interface ISpecification<TEntity> 
        where TEntity : class
    {
        IQueryable<TEntity> Apply (IQueryable<TEntity> query);
    }
}
