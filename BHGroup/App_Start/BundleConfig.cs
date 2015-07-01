using System.Web;
using System.Web.Optimization;

namespace BHGroup
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                             "~/Scripts/jquery.validate.js").Include(
                             "~/Scripts/jquery.validate.unobtrusive.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery-boostrap").Include(
                                     "~/Scripts/bootstrap.min.js",
                                     "~/Scripts/jquery-ui-1.10.3.min.js",
                                     "~/Scripts/grid.locale-en.js",
                                     "~/Scripts/jquery.jqGrid.min.js",
                                     "~/Scripts/Common.js",
                                     "~/Scripts/bootstrap-datepicker.js",
                                     "~/Scripts/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js",
                                     "~/Scripts/jquery.showMessage.min.js",
                                     "~/Scripts/AdminLTE/app.js",
                                     "~/Scripts/chosen.jquery.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));


            bundles.Add(new StyleBundle("~/Content/assets/css/minified/css").Include(
                "~/Content/assets/css/minified/aui-production.min.css",
                "~/Content/assets/themes/minified/fides/color-schemes/dark-blue.min.css",
                "~/Content/assets/themes/minified/fides/common.min.css",
                "~/Content/assets/themes/minified/fides/responsive.min.css"

                ));

            // All integrated styles:
            bundles.Add(new StyleBundle("~/content/bundles/styles")
                .Include("~/Content/css/bootstrap.min.css", new CssRewriteUrlTransform())
                .Include("~/Content/css/font-awesome.min.css", new CssRewriteUrlTransform())
                .Include("~/Content/css/ionicons.min.css", new CssRewriteUrlTransform())
                .Include("~/Content/css/morris/morris.css", new CssRewriteUrlTransform())
                .Include("~/Content/css/daterangepicker/daterangepicker-bs3.css", new CssRewriteUrlTransform())
                .Include("~/Content/css/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css", new CssRewriteUrlTransform())
                .Include("~/Content/css/AdminLTE.css", new CssRewriteUrlTransform())
                .Include("~/Content/ui.jqgrid.css", new CssRewriteUrlTransform())
                .Include("~/Content/ui.jqgrid-bootstarp.css", new CssRewriteUrlTransform())
                .Include("~/Content/chosen.min.css", new CssRewriteUrlTransform())
                .Include("~/Content/showMessage.css", new CssRewriteUrlTransform())

                );
        }
    }
}