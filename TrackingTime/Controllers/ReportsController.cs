using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TrackingTime.DAL;
using TrackingTime.Models;

namespace TrackingTime.Controllers
{
    public class ReportsController : Controller
    {
        private TrackerContext db = new TrackerContext();

        // GET: Reports
        
        public ActionResult Index()
        {
            var vmReport = new Report {Activities = db.TimeActivities.ToList()};
            return View(vmReport);
        }

        // POST: Reports
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Report report)
        {
            report.Activities = db.TimeActivities.Where(x=>x.StartDateTime > report.StarDateTime && x.FinishDateTime < report.EndDateTime ).ToList();
            return View(report);
        }

        // GET: Reports/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Report report = db.Reports.Find(id);
            if (report == null)
            {
                return HttpNotFound();
            }
            return View(report);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
