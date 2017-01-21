using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ImagineCupBTrees.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Jesse Dahir-Kanehl & Zachary Baklund";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact us and tell us what you think.";

            return View();
        }
    }
}