using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using XFramework.Repositories;
using XFramework.Repositories.Interfaces;
using XFramework.Services.Interfaces;

namespace XFramework.Services.Implementation
{
    public abstract class Service<TEntity> : IService<TEntity>
       where TEntity : class
    {
        protected IDbContextScopeFactory dbContextScopeFactory;
        private IRepository<TEntity> repository;

        public Service(IDbContextScopeFactory dbContextScopeFactory, IRepository<TEntity> repository)
        {
            if (dbContextScopeFactory == null)
            {
                throw new ArgumentNullException("dbContextScopeFactory");
            }
            if (repository == null)
            {
                throw new ArgumentNullException("repository");
            }
            this.dbContextScopeFactory = dbContextScopeFactory;
            this.repository = repository;
        }

        public void Add(IEnumerable<TEntity> entities)
        {
            using (var scope = dbContextScopeFactory.Create())
            {
                repository.Add(entities);
                scope.SaveChanges();
            }
        }

        public async Task AddAsync(IEnumerable<TEntity> entities)
        {
            using (var scope = dbContextScopeFactory.Create())
            {
                repository.Add(entities);
                await scope.SaveChangesAsync();
            }
        }

        public TEntity Add(TEntity entity)
        {
            using (var scope = dbContextScopeFactory.Create())
            {
                repository.Add(entity);
                scope.SaveChanges();
                return entity;
            }
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            using (var scope = dbContextScopeFactory.Create())
            {
                repository.Add(entity);
                await scope.SaveChangesAsync();
                return entity;
            }
        }

        public void Delete(IEnumerable<TEntity> entities)
        {
            using (var scope = dbContextScopeFactory.Create())
            {
                repository.Delete(entities);
                scope.SaveChanges();
            }
        }

        public void Delete(Expression<Func<TEntity, bool>> predicate)
        {
            using (var scope = dbContextScopeFactory.Create())
            {
                repository.Delete(predicate);
                scope.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var scope = dbContextScopeFactory.Create())
            {
                repository.Delete(entity);
                scope.SaveChanges();
            }
        }

        public void Delete(params object[] keys)
        {
            using (var scope = dbContextScopeFactory.Create())
            {
                repository.Delete(keys);
                scope.SaveChanges();
            }
        }


        public bool Exists(params object[] keys)
        {
            using (var scope = dbContextScopeFactory.CreateReadOnly())
            {
                return repository.Exists(keys);
            }
        }

        public TEntity Get(params object[] keys)
        {
            using (var scope = dbContextScopeFactory.CreateReadOnly())
            {
                return repository.Get(keys);
            }
        }

        public TEntity Get(TEntity entity)
        {
            using (var scope = dbContextScopeFactory.CreateReadOnly())
            {
                return repository.Get(entity);
            }
        }

        /// <summary>
        /// Return TEntity by predicate and pathes
        /// </summary>
        /// <param name="predicate">Expression predicate</param>
        /// <param name="pathes">Navigation properties</param>
        /// <returns>List of TEntity</returns>
        /// <remarks>
        /// The service layer should return List.
        /// 1. The expression should in service layer for reuable
        /// 2. The new service methods should be added when query TEntity
        /// 3. Just in case, make the Query method with predicate private, instead expose the Query without predicate
        /// For more information please see http://codetunnel.io/should-you-return-iqueryablet-from-your-repositories/
        /// </remarks>
        private List<TEntity> Query(Expression<Func<TEntity, bool>> predicate = null,
            params Expression<Func<TEntity, object>>[] pathes)
        {
            using (var scope = dbContextScopeFactory.CreateReadOnly())
            {
                return repository.Query(predicate, pathes).ToList();
            }
        }

        public List<TEntity> Query(params Expression<Func<TEntity, object>>[] pathes)
        {
            using (var scope = dbContextScopeFactory.CreateReadOnly())
            {
                return repository.Query(null,pathes).ToList();
            }
        }

        public void Update(IEnumerable<TEntity> entities)
        {
            using (var scope = dbContextScopeFactory.Create())
            {
                repository.Update(entities);
                scope.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (var scope = dbContextScopeFactory.Create())
            {
                repository.Update(entity);
                scope.SaveChanges();
            }
        }
    }

}
