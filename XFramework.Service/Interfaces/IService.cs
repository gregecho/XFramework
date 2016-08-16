using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace XFramework.Services.Interfaces
{
    public interface IService
    {

    }

    public interface IService<TEntity> where TEntity : class
    {
        void Add(IEnumerable<TEntity> entities);
        TEntity Add(TEntity entity);
        void Delete(IEnumerable<TEntity> entities);
        void Delete(Expression<Func<TEntity, bool>> predicate);
        void Delete(TEntity entity);
        void Delete(params object[] keys);
        bool Exists(params object[] keys);
        TEntity Get(params object[] keys);
        TEntity Get(TEntity entity);
        List<TEntity> Query(params Expression<Func<TEntity, object>>[] pathes);
        void Update(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        
    }
}
