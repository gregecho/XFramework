using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Optimization;

namespace XFramework.SPA
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/lib")
#if DEBUG
                .IncludeDirectory("~/Scripts/lib/Vendor_dev/Ring0", "*.js", true)
                .IncludeDirectory("~/Scripts/lib/Vendor_dev/Ring1", "*.js", true)
                .IncludeDirectory("~/Scripts/lib/Vendor_dev/Ring2", "*.js", true)
                .IncludeDirectory("~/Scripts/lib/Vendor_dev/Ring3", "*.js", true)
#else
                .IncludeDirectory("~/Scripts/lib/Vendor/Ring0", "*.js", true)
                .IncludeDirectory("~/Scripts/lib/Vendor/Ring1", "*.js", true)
                .IncludeDirectory("~/Scripts/lib/Vendor/Ring2", "*.js", true)
                .IncludeDirectory("~/Scripts/lib/Vendor/Ring3", "*.js", true)
#endif
.IncludeDirectory("~/Scripts/lib/Custom", "*.js", true)
                );

            bundles.Add(new ScriptBundle("~/bundles/app")
                .IncludeDirectory("~/Scripts/app", "*.js", true)
                );

            bundles.Add(new StyleBundle("~/Content/Styles/css")
               .Include("~/Content/bootstrap/bootstrap-3.3.5.css")
               .Include("~/Content/bootstrap-additions/bootstrap-additions.css")
               .Include("~/Content/fontawesome/font-awesome-4.4.0.css")
               .Include("~/Content/flag-icon/flag-icon.css")
               .Include("~/Content/toastr.css")
               .Include("~/Content/morris.core.css")
               .Include("~/Content/nProgress.css")
               .Include("~/Content/transitions.css")
               .Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/Styles/Ltecss")
                .Include("~/Content/bootstrap/bootstrap-3.3.5.css")
                .Include("~/Content/bootstrap-additions/bootstrap-additions.css")
                .Include("~/Content/fontawesome/font-awesome-4.4.0.css")
                .Include("~/Content/flag-icon/flag-icon.css")
                .Include("~/Content/ionicons/ionicons.css")
                .Include("~/Content/toastr.css")
                .Include("~/Content/morris.core.css")
                .Include("~/Content/nProgress.css")
                .Include("~/Content/fullcalendar.css")
                .Include("~/Content/transitions.css")
                .Include("~/Content/AdminLte-2.0.2/AdminLte.css")
                .Include("~/Content/AdminLte-2.0.2/skins/skin-blue.css")
                .Include("~/Content/site.css"));
            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            //BundleTable.EnableOptimizations = false;
        }
    }
}
