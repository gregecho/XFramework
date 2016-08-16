using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFramework.Repositories
{
    public static class DbContextExtensions
    {

        public static string[] GetEntityKeyNames<TEntity>(this DbContext dbContext) where TEntity : class
        {
            if (dbContext == null)
                throw new ArgumentNullException("dbContext");

            var objectSet = ((IObjectContextAdapter)dbContext).ObjectContext.CreateObjectSet<TEntity>();
            var entitySet = objectSet.EntitySet;
            return entitySet.ElementType.KeyMembers.Select(k => k.Name).ToArray();
        }
        public static IEnumerable<object> GetEntityKeys<TEntity>(this DbContext dbContext, TEntity entity)
          where TEntity : class
        {
            if (dbContext == null)
                throw new NullReferenceException("dbContext");

            var type = typeof(TEntity);

            var objectSet = ((IObjectContextAdapter)dbContext).ObjectContext.CreateObjectSet<TEntity>();
            var entitySet = objectSet.EntitySet;
            var keys = entitySet.ElementType.KeyMembers;
            var props = keys.Select(k => type.GetProperty(k.Name));
            return props.Select(p => p.GetValue(entity));
        }
    }
}
