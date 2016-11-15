using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrackingTime.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Time Tracking Web Application";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact our developer.";

            return View();
        }
    }
}