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
            bundles.Add(new ScriptBundle("~/bundles/angular-app").Include(
                "~/Content/app/js/app.js",
                "~/Content/app/js/resources/*.js",
                "~/Content/app/js/controllers/*.js"
            ));

			var emberBundle = new ScriptBundle("~/bundles/ember")
				.Include( new[] {
					  "~/Scripts/Vendor/jquery-{version}.js"
					, "~/Scripts/Vendor/handlebars-{version}.js"	
					, "~/Scripts/Vendor/ember-{version}.js"	
					, "~/Scripts/Vendor/ember-model.js"	
				})
				;

	        var foundationScriptsBundle = new ScriptBundle("~/bundles/foundation")
				.Include("~/Scripts/Vendor/Foundation/foundation.js")
		        .IncludeDirectory("~/Scripts/Vendor/Foundation/", "*.js");

			var appBundle = new ScriptBundle("~/bundles/ember-app")
				.Include(new[]
				{
					"~/Scripts/app.js"
					, "~/Scripts/models.js"
				})
				.IncludeDirectory("~/Scripts/Pages/", "*.js")
				;

	        var styleBundle = new StyleBundle("~/Content/css")
		        .IncludeDirectory("~/Content/Foundation/", "*.css")
				.Include("~/Content/styles.css")
		        ;

			bundles.Add(emberBundle);
			bundles.Add(appBundle);
			bundles.Add(foundationScriptsBundle);
			bundles.Add(styleBundle);
        }
    }
}