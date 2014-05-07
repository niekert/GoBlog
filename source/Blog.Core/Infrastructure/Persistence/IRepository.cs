﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Blog.Core.Infrastructure.Persistence
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Single(Expression<Func<TEntity, bool>> predicate);
        TEntity Find(params object[] id);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        IQueryable<TEntity> All();
        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity, object key);
        void Delete(TEntity entity);
    }
}