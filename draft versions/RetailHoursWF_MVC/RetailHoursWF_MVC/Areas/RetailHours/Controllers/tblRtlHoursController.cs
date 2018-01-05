using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RetailHoursWF_MVC.Areas.RetailHours.Models;

namespace RetailHoursWF_MVC.Areas.RetailHours.Controllers
{
    public class tblRtlHoursController : Controller
    {
        private RetailWebEntities db = new RetailWebEntities();

        // GET: RetailHours/tblRtlHours
        public ActionResult Index()
        {
            return View(db.tblRtlHours.ToList());
        }

        // GET: RetailHours/tblRtlHours/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblRtlHour tblRtlHour = db.tblRtlHours.Find(id);
            if (tblRtlHour == null)
            {
                return HttpNotFound();
            }
            return View(tblRtlHour);
        }

        // GET: RetailHours/tblRtlHours/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RetailHours/tblRtlHours/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HoursID,Type,WeekdayHours,WeekendHours,FromDate,ToDate")] tblRtlHour tblRtlHour)
        {
            if (ModelState.IsValid)
            {
                db.tblRtlHours.Add(tblRtlHour);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tblRtlHour);
        }

        // GET: RetailHours/tblRtlHours/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblRtlHour tblRtlHour = db.tblRtlHours.Find(id);
            if (tblRtlHour == null)
            {
                return HttpNotFound();
            }
            return View(tblRtlHour);
        }

        // POST: RetailHours/tblRtlHours/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HoursID,Type,WeekdayHours,WeekendHours,FromDate,ToDate")] tblRtlHour tblRtlHour)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblRtlHour).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tblRtlHour);
        }

        // GET: RetailHours/tblRtlHours/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblRtlHour tblRtlHour = db.tblRtlHours.Find(id);
            if (tblRtlHour == null)
            {
                return HttpNotFound();
            }
            return View(tblRtlHour);
        }

        // POST: RetailHours/tblRtlHours/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblRtlHour tblRtlHour = db.tblRtlHours.Find(id);
            db.tblRtlHours.Remove(tblRtlHour);
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
