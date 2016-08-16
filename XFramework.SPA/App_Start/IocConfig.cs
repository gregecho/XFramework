using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using XFramework.Repositories;
using XFramework.Repositories.Implementation;
using XFramework.Repositories.Interfaces;
using XFramework.Services.Implementation;
using XFramework.Services.Interfaces;

namespace XFramework.SPA
{
    public class IocConfig
    {

        private static IContainer _container;
        /// <summary>
        /// For more info see 
        /// :http://docs.autofac.org/en/latest/integration/mvc.html
        /// </summary>
        public static void SetUp()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<AmbientDbContextLocator>().As<IAmbientDbContextLocator>();
            builder.RegisterType<DbContextScopeFactory>().As<IDbContextScopeFactory>();
            // Get HttpConfiguration.
            var config = GlobalConfiguration.Configuration;
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            // Register Web API controllers.
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

            // OPTIONAL: Register the Autofac filter provider.
            builder.RegisterWebApiFilterProvider(config);

            // Register repositories/services
            //builder.RegisterType<TodoRepository>().As<ITodoRepository>();
            //builder.RegisterType<TodoService>().As<ITodoService>();
            builder.RegisterAssemblyTypes(typeof(TodoRepository).Assembly)
                   .Where(t => t.Name.EndsWith("Repository"))
                   .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(typeof(TodoService).Assembly)
                   .Where(t => t.Name.EndsWith("Service"))
                   .AsImplementedInterfaces();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        public static void TearDown()
        {
            _container.Dispose();
        }
    }
}