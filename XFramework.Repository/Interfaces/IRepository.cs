using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Linq.Expressions;

namespace XFramework.Repositories.Interfaces
{
    public interface IRepository
    {

    }
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(TEntity entity);
        TEntity Get(params object[] keys);
        bool Exists(params object[] keys);
        IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] pathes);
        TEntity Add(TEntity entity);
        void Add(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void Update(IEnumerable<TEntity> entities);
        void Delete(TEntity entity);
        void Delete(params object[] keys);
        void Delete(IEnumerable<TEntity> entities);
        void Delete(Expression<Func<TEntity, bool>> predicate);
    }
}
