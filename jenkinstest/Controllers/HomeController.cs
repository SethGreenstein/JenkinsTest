using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jenkinstest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "This is a demonstration projest to show the capabilities of Continuous Integration";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Williams Forrest Continous Integration Demo";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
