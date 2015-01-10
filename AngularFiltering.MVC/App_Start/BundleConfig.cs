
using System.Web.Optimization;

namespace AngularFiltering.MVC
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new LessBundle("~/Content/less")
                .Include("~/Content/less/style.less"));

            bundles.Add(new ScriptBundle("~/bundles/angularjs")
                .Include("~/Scripts/libs/angular.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery")
                .Include("~/Scripts/libs/jquery-{version}.js"));
        }
    }
}