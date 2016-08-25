using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using XFramework.Services.Interfaces;

namespace XFramework.SPA.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        private readonly ITodoService todoService;
        public HomeController(ITodoService todoService)
        {
            this.todoService = todoService;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
    }
}
