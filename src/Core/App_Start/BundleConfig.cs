using System.Web;
using System.Web.Optimization;

namespace Core
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/Scripts/angular.js",
                "~/Scripts/angular-resource.js",
                "~/Scripts/angular-route.js"
            ));
            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Content/app/js/app.js",
                "~/Content/app/js/resources/*.js",
                "~/Content/app/js/controllers/*.js"
            ));
        }
    }
}