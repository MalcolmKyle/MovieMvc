using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Description of my site and the progress.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Malcolm's contact page.";

            return View();
        }
    }
}