using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XFramework.Models;
using XFramework.Services.Interfaces;

namespace XFramework.SPA.Apis
{
    public class AccountController : ApiController
    {
        private readonly IUserService userService;
        public AccountController(IUserService userService)
        {
            this.userService = userService;
        }

        // POST api/Account/Register
        [AllowAnonymous]
        [HttpPost]
        public IHttpActionResult Register(User userModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = userService.Add(userModel);
            return Ok();
        }
    }
}
