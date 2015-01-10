using System.Web.Http;
using AngularFiltering.DAL;

namespace AngularFiltering.MVC.Controllers
{
    public class LazyLoaderApiController : ApiController
    {
        private AngularDbContext _ctx;
        protected AngularDbContext Ctx
        {
            get { return _ctx ?? (_ctx = new AngularDbContext()); }
        }
    }
}
