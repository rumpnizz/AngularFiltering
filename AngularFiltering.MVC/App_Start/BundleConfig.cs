
using System.Web.Optimization;

namespace AngularFiltering.MVC
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new LessBundle("~/Content/less")
                .Include("~/Content/less/style.less"));

            bundles.Add(new ScriptBundle("~/bundles/app")
                .IncludeDirectory("~/Scripts/services", "*.js")
                .IncludeDirectory("~/Scripts/controllers", "*.js")
                .Include("~/Scripts/config.js")
                .Include("~/Scripts/app.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery")
                .Include("~/Scripts/libs/jquery-{version}.js"));
        }
    }
}