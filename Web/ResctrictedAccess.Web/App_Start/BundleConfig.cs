using System.Web;
using System.Web.Optimization;

namespace ResctrictedAccess.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/tpl/vendor/jquery/jquery.js"));

            
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/tpl/vendor/bootstrap/js/bootstrap.js",
                      "~/tpl/dist/js/sb-admin-2.js",
                      "~/tpl/vendor/metisMenu/metisMenu.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/tpl/vendor/bootstrap/css/bootstrap.css",
                      "~/tpl/vendor/font-awesome/css/font-awesome.min.css",
                      "~/tpl/vendor/metisMenu/metisMenu.css",
                      "~/tpl/dist/css/sb-admin-2.css",
                      "~/Content/site.css"));
        }
    }
}
