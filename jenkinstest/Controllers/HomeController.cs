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
            var ts = new TestService();
            ViewBag.Message = ts.GetMessage();

          

            return View();
        }

        public ActionResult About()
        {
            var ts = new TestService();
            ViewBag.Message = ts.GetMessage();

        
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}
