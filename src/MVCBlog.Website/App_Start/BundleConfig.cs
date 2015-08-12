using System.Web;
using System.Web.Optimization;

namespace MVCBlog.Website
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts")
                .Include(
                    "~/js/jquery-1.11.1.min.js",
                    "~/js/jquery-migrate-1.2.1.min.js",
                    "~/css/bootstrap/js/bootstrap.min.js",
                    "~/js/css_browser_selector.js",
                    "~/js/jquery.easing-1.3.js",
                    "~/js/jquery.prettyPhoto.js",
                    "~/js/jquery.validate.js",
                    "~/js/jquery.address-1.5.min.js",
                    "~/js/jquery.isotope.min.js",
                    "~/js/jquery.circliful.min.js",
                    "~/js/wow.min.js",
                    "~/js/script.js"));

            bundles.Add(new StyleBundle("~/css/combined")
                .Include(
                    "~/css/prettyPhoto.css",
                    "~/css/animate.css",
                    "~/css/font-awesome/css/font-awesome.min.css",
                    "~/css/stylesheet.css"
                    ));
            
        }
    }
}
