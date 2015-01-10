using System.Web.Mvc;

namespace AngularFiltering.MVC.Controllers
{
    public class HomeController : LazyLoaderController
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}