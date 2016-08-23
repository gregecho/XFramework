using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using XFramework.SPA.Provider;
using XFramework.Services.Interfaces;
using Autofac;

[assembly: OwinStartup(typeof(XFramework.SPA.Startup))]

namespace XFramework.SPA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            IocConfig.SetUp(config);
            ConfigureAuth(app);
            WebApiConfig.Register(config);
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            app.UseWebApi(config);
        }

        /// <summary>
        /// Secure web api
        /// </summary>
        /// <param name="app"></param>
        /// <remarks>http://bitoftech.net/2014/06/01/token-based-authentication-asp-net-web-api-2-owin-asp-net-identity/</remarks>
        public void ConfigureAuth(IAppBuilder app)
        {
            IOAuthAuthorizationServerProvider authorizationServerProvider = null;
            using (var scope = IocConfig.Container.BeginLifetimeScope())
            {
                authorizationServerProvider = scope.Resolve<IOAuthAuthorizationServerProvider>();
            }

            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                //AuthorizeEndpointPath = new PathString("/api/Account/ExternalLogin"),
                // The path for generating tokens will be as :”http://localhost:port/token”
                TokenEndpointPath = new PathString("/token"),
                // Specified the expiry for token to be 24 hours, so if the user tried to use the same token for authentication after 24 hours from the issue time, his request will be rejected and HTTP status code 401 is returned
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                Provider = authorizationServerProvider
            };

            // Token Generation
            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

        }
    }
}
