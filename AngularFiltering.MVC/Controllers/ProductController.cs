using System.Linq;
using System.Web.Mvc;

namespace AngularFiltering.MVC.Controllers
{
    public class ProductController : LazyLoaderController
    {
        public ActionResult List()
        {
            var products = Ctx.Products.ToList();
            ViewBag.Products = products;
            return View(products);
        }
	}
}