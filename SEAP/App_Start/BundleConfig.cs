using System.Web;
using System.Web.Optimization;

namespace SEAP
{
	public class BundleConfig
	{
		// For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
						"~/Scripts/jquery-{version}.js"));

			bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
						"~/Scripts/jquery.validate*"));

			// Use the development version of Modernizr to develop with and learn from. Then, when you're
			// ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
			bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
						"~/Scripts/modernizr-*"));

			bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
					  "~/Scripts/bootstrap.js"));

			bundles.Add(new StyleBundle("~/Content/css").Include(
					  "~/Content/bootstrap.css",
					  "~/Content/site.css"));

			//LAYOUT
			bundles.Add(new StyleBundle("~/Content/Layout").Include(
					 "~/Content/Layout/open-iconic-bootstrap.min.css",
					 "~/Content/Layout/animate.css",
					 "~/Content/Layout/owl.carousel.min.css",
					 "~/Content/Layout/owl.theme.default.min.css",
					 "~/Content/Layout/magnific-popup.css",
					 "~/Content/Layout/aos.css",
					 "~/Content/Layout/ionicons.min.css",
					 "~/Content/Layout/bootstrap-datepicker.css",
					 "~/Content/Layout/jquery.timepicker.css",
					 "~/Content/Layout/flaticon.css",
					 "~/Content/Layout/icomoon.css",
					 "~/Content/Layout/style.css"));

			bundles.Add(new ScriptBundle("~/Scripts/Layout").Include(
					 "~/Scripts/jquery.min.js",
					 "~/Scripts/jquery-migrate-3.0.1.min.js",
					 "~/Scripts/popper.min.js",
					 "~/Scripts/bootstrap.min.js",
					 "~/Scripts/jquery.easing.1.3.js",
					 "~/Scripts/jquery.waypoints.min.js",
					 "~/Scripts/jquery.stellar.min.js",
					 "~/Scripts/owl.carousel.min.js",
					 "~/Scripts/jquery.magnific-popup.min.js",
					 "~/Scripts/aos.js",
					 "~/Scripts/jquery.animateNumber.min.js",
					 "~/Scripts/bootstrap-datepicker.js",
					 "~/Scripts/jquery.timepicker.min.js",
					 "~/Scripts/scrollax.min.js",
					 "~/Scripts/google-map.js",
					 "~/Scripts/main.js"));
		}
	}
}
