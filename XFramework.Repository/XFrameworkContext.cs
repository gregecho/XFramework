using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XFramework.Models;
using XFramework.Repositories.Interfaces;

namespace XFramework.Repositories
{
    public class XFrameworkContext : DbContext
    {
        public XFrameworkContext()
            : base("name=XFrameworkContext")
        {
            // Lazy, Eager, and Explicit Loading of Related Data
            // For more information please see: http://www.asp.net/mvc/overview/getting-started/getting-started-with-ef-using-mvc/reading-related-data-with-the-entity-framework-in-an-asp-net-mvc-application
            this.Configuration.LazyLoadingEnabled = false;
            //this.Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<Todo> Todos { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Prevents table names from being pluralize
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
