using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using XFramework.Repositories.Interfaces;

namespace XFramework.Repositories.Implementation
{
    public abstract class Repository<TContext, TEntity> : IRepository<TEntity>
        where TContext : DbContext
        where TEntity : class
    {
        private readonly IAmbientDbContextLocator ambientDbContextLocator;

        protected TContext AmbientContext
        {
            get
            {
                var context = this.ambientDbContextLocator.Get<TContext>();
                if (context == null)
                {
                    throw new InvalidOperationException("No ambient DbContext found. A repository must only be accessed within the scope of a DbContextScope." +
                        "To fix this issue, use IDbContextScopeFactory in business logic service method to create a DbContextScope.");
                }
                return context as TContext;
            }
        }

        public Repository(IAmbientDbContextLocator ambientDbContextLocator)
        {
            if (ambientDbContextLocator == null)
            {
                throw new ArgumentNullException("ambientDbContextLocator");
            }

            this.ambientDbContextLocator = ambientDbContextLocator;
        }

        public TEntity Get(params object[] keys)
        {
            if (keys == null)
            {
                throw new ArgumentNullException("keys");
            }
            var entityContext = this.AmbientContext;
            var entitySet = entityContext.Set<TEntity>();
            return entitySet.Find(keys);
        }

        public bool Exists(params object[] keys)
        {
            return (this.Get(keys) != null);
        }

        public TEntity Get(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            var entityContext = this.AmbientContext;
            var keyValues = entityContext.GetEntityKeys<TEntity>(entity);
            var entitySet = entityContext.Set<TEntity>();
            return entitySet.Find(keyValues.ToArray());
        }

        public IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> predicate = null,
            params Expression<Func<TEntity, object>>[] pathes)
        {
            var entitySet = AmbientContext.Set<TEntity>();
            if (predicate == null) predicate = (o) => true;
            var entities = entitySet.Where(predicate);
            foreach (var path in pathes)
            {
                entities = entities.Include(path);
            }
            return entities;
        }

        public ObjectResult<TEntity> ExecuteStoreQuery(string commandText, params SqlParameter[] parameters)
        {
            if (commandText == null)
            {
                throw new ArgumentNullException("commandText");
            }

            if (parameters != null && parameters.Length > 0)
            {
                commandText = commandText + " " + parameters.Select(o => o.ParameterName).Aggregate((current, next) => current + ", @" + next);
            }

            return ((IObjectContextAdapter)this.AmbientContext).ObjectContext.ExecuteStoreQuery<TEntity>(commandText, parameters);
        }

        public TEntity Add(TEntity entity)
        {
            return this.InternalAdd(entity, this.AmbientContext.Set<TEntity>());
        }

        public void Add(IEnumerable<TEntity> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entity");
            }

            var entitySet = this.AmbientContext.Set<TEntity>();
            foreach (var entity in entities)
            {
                this.InternalAdd(entity, entitySet);
            }
        }

        public void Delete(TEntity entity)
        {
            var entitySet = AmbientContext.Set<TEntity>();
            this.InternalDelete(entity, entitySet);
        }

        public void Delete(params object[] keys)
        {
            if (keys == null)
            {
                throw new ArgumentNullException("keys");
            }
            var entitySet = AmbientContext.Set<TEntity>();
            entitySet.Remove(entitySet.Find(keys));
        }

        public void Delete(IEnumerable<TEntity> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entity");
            }
            var entitySet = AmbientContext.Set<TEntity>();
            this.InternalDelete(entities, entitySet);
        }

        public void Delete(Expression<Func<TEntity, bool>> predicate)
        {
            if (predicate == null)
            {
                throw new ArgumentNullException("predicate");
            }
            var entitySet = AmbientContext.Set<TEntity>();
            var entities = entitySet.Where(predicate);
            this.InternalDelete(entities, entitySet);
        }

        public void Update(TEntity entity)
        {
            var context = this.AmbientContext;
            var entitySet = context.Set<TEntity>();
            this.InternalUpdate(entity, context, entitySet);
        }

        public void Update(IEnumerable<TEntity> entities)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entity");
            }

            var context = this.AmbientContext;
            var entitySet = context.Set<TEntity>();
            foreach (var entity in entities)
            {
                this.InternalUpdate(entity, context, entitySet);
            }
        }

        protected TEntity InternalAdd(TEntity entity, IDbSet<TEntity> entitySet)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            return entitySet.Add(entity);
        }

        protected void InternalDelete(TEntity entity, IDbSet<TEntity> entitySet)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entitySet.Attach(entity);
            entitySet.Remove(entity);
        }
        protected void InternalDelete(IEnumerable<TEntity> entities, IDbSet<TEntity> entitySet)
        {
            foreach (var entity in entities)
            {
                InternalDelete(entity, entitySet);
            }
        }
        protected void InternalUpdate(TEntity entity, TContext context, IDbSet<TEntity> entitySet)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            entitySet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }

    }
}
