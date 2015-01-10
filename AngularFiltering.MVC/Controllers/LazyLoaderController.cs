using System.Web.Mvc;
using AngularFiltering.DAL;

namespace AngularFiltering.MVC.Controllers
{
    public class LazyLoaderController : Controller
    {
        private AngularDbContext _ctx;
        protected AngularDbContext Ctx
        {
            get { return _ctx ?? (_ctx = new AngularDbContext()); }
        }
    }
}