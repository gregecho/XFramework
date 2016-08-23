using StackExchange.Profiling.EntityFramework6;
using System;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace XFramework.SPA
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            // MiniProfiler for more information please see http://miniprofiler.com/
            //MiniProfilerEF6.Initialize();

            //IocConfig.SetUp();
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            GlobalConfiguration.Configuration.Formatters.Remove(GlobalConfiguration.Configuration.Formatters.XmlFormatter);
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

            //Miniprofiler
            if (this.Request.IsLocal)
            {
                //StackExchange.Profiling.MiniProfiler.Start();
            }
        }

        protected void Application_EndRequest(object sender, EventArgs e)
        {
            //Miniprofiler
            //StackExchange.Profiling.MiniProfiler.Stop();
        }
    }
}
