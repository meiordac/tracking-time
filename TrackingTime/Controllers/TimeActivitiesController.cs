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
    public class TimeActivitiesController : Controller
    {
        private TrackerContext db = new TrackerContext();

        // GET: TimeActivities
        public ActionResult Index()
        {
            return View(db.TimeActivities.ToList());
        }

        // GET: TimeActivities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimeActivity timeActivity = db.TimeActivities.Find(id);
            if (timeActivity == null)
            {
                return HttpNotFound();
            }
            return View(timeActivity);
        }

        // GET: TimeActivities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TimeActivities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TimeActivityId,ProjectId,Username,WorkType,Description,StartDateTime,FinishDateTime")] TimeActivity timeActivity)
        {
            if (ModelState.IsValid)
            {
                db.TimeActivities.Add(timeActivity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(timeActivity);
        }

        // GET: TimeActivities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimeActivity timeActivity = db.TimeActivities.Find(id);
            if (timeActivity == null)
            {
                return HttpNotFound();
            }
            return View(timeActivity);
        }

        // POST: TimeActivities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TimeActivityId,ProjectId,Username,WorkType,Description,StartDateTime,FinishDateTime")] TimeActivity timeActivity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(timeActivity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(timeActivity);
        }

        // GET: TimeActivities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimeActivity timeActivity = db.TimeActivities.Find(id);
            if (timeActivity == null)
            {
                return HttpNotFound();
            }
            return View(timeActivity);
        }

        // POST: TimeActivities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TimeActivity timeActivity = db.TimeActivities.Find(id);
            db.TimeActivities.Remove(timeActivity);
            db.SaveChanges();
            return RedirectToAction("Index");
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
