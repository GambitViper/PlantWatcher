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

        public FileResult DownloadApp()
        {
            string filePath = Server.MapPath("~/Content/RaspberryPiHeadless_1.0.1.0_Test.zip");
            byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
            var response = new FileContentResult(fileBytes, "application/octet-stream");
            response.FileDownloadName = "RaspberryPiHeadless_1.0.1.0_Test.zip";
            return response;
        }
    }
}