using Autofac;
using XFramework.Repositories;
using XFramework.Repositories.Implementation;
using XFramework.Repositories.Interfaces;
using XFramework.Services.Implementation;
using XFramework.Services.Interfaces;

namespace XFramework.SPA
{
    public class DefaultModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AmbientDbContextLocator>().As<IAmbientDbContextLocator>();
            builder.RegisterType<DbContextScopeFactory>().As<IDbContextScopeFactory>();

            builder.RegisterAssemblyTypes(typeof(TodoRepository).Assembly)
                   .Where(t => t.Name.EndsWith("Repository"))
                   .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(typeof(TodoService).Assembly)
                   .Where(t => t.Name.EndsWith("Service"))
                   .AsImplementedInterfaces();
                   //.InstancePerRequest();
        }

    }
}