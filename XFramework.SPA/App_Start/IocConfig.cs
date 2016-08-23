using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Microsoft.Owin.Security.OAuth;
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
using XFramework.SPA.Provider;

namespace XFramework.SPA
{
    public class IocConfig
    {
        public static IContainer Container { get; set; }
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

            //http://stackoverflow.com/questions/25871392/autofac-dependency-injection-in-implementation-of-oauthauthorizationserverprovid
            builder.RegisterType<SimpleAuthorizationServerProvider>()
                    .As<IOAuthAuthorizationServerProvider>()
                    //.PropertiesAutowired()
                    .SingleInstance(); // you only need one instance of this provider

            //builder
            //    .RegisterType<SimpleRefreshTokenProvider>()
            //    .As<IAuthenticationTokenProvider>()
            //    //.PropertiesAutowired()
            //    .SingleInstance();  // you only need one instance of this provider

            // Set the dependency resolver to be Autofac.
            Container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(Container));
            config.DependencyResolver = new AutofacWebApiDependencyResolver(Container);
        }

        //public static void TearDown()
        //{
        //    _container.Dispose();
        //}
    }
}