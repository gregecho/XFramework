using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using XFramework.Models;
using XFramework.Services.Interfaces;

namespace XFramework.SPA.Provider
{
    public class SimpleAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        private readonly IUserService userService;
        public SimpleAuthorizationServerProvider(IUserService userService)
        {
            this.userService = userService;
        }
        /// <summary>
        ///  Responsible for validating the “Client”, 
        ///  in our case we have only one client so we’ll always return that its validated successfully
        /// </summary>
        /// <param name="context"></param>
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }
        /// <summary>
        ///  Responsible to validate the username and password sent to the authorization server’s token endpoint
        /// </summary>
        /// <param name="context"></param>
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });
            var user = userService.Find(new User { Name=context.UserName, Password= context.Password});
            if (user == null)
            {
                context.SetError("invalid_grant", "The user name or password is incorrect.");
                return;
            }

            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            identity.AddClaim(new Claim("sub", context.UserName));
            identity.AddClaim(new Claim("role", "user"));

            context.Validated(identity);
        }
    }
}