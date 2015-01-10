using System;
using System.Web.Mvc;
using AngularFiltering.DAL.Models;

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