using System.Web;
using System.Web.Optimization;

namespace MyTend
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                //"~/Scripts/bootstrap.js",
                "~/Scripts/respond.js",
                "~/Content/theme/assets/bootstrap/js/bootstrap.min.js",
                "~/Content/theme/js/html5shiv.js",
                "~/Scripts/jquery.validate.min.js",
                "~/Content/theme/js/jquery.cookie.js",
                "~/Content/theme/js/jquery.easing.js",
                "~/Content/theme/js/jquery.mousewheel-3.0.6.pack.js",
                "~/Content/theme/js/jquery.nod.validation.js",
                "~/Content/theme/js/jquery.wp.custom.js",
                "~/Content/theme/js/jquery.wp.switcher.js",
                "~/Content/theme/js/less.js",
                "~/Content/theme/js/modernizr.custom.js",
                "~/Content/theme/js/respond.min.js",
                "~/Content/lightbox/lightbox.min.js",
                "~/Content/te/jquery-te-1.4.0.min.js",
                "~/Content/common/md5.min.js",

                "~/Content/theme/assets/fancybox/jquery.fancybox.js",
                "~/Content/theme/assets/hover-dropdown/bootstrap-hover-dropdown.min.js",
                "~/Content/theme/assets/masonry/masonry.js",
                "~/Content/theme/assets/page-scroller/jquery.ui.totop.min.js",
                "~/Content/theme/assets/mixitup/jquery.mixitup.js",
                "~/Content/theme/assets/mixitup/jquery.mixitup.init.js",
                "~/Content/theme/assets/fancybox/jquery.fancybox.pack.js?v=2.1.5",
                "~/Content/theme/assets/easy-pie-chart/jquery.easypiechart.js",
                "~/Content/theme/assets/easy-pie-chart/jquery.easypiechart.js",
                "~/Content/theme/assets/waypoints/waypoints.min.js",
                "~/Content/theme/assets/sticky/jquery.sticky.js",
                //"~/Scripts/spin.min.js",
                "~/Scripts/kamati.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/theme/assets/bootstrap/css/bootstrap.min.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/theme/css/global-style.css",
                      "~/Content/theme/assets/fancybox/jquery.fancybox.css",
                      //"~/Content/ladda.min.css",
                      "~/Content/site.css"
                      ));


        }
    }
}
