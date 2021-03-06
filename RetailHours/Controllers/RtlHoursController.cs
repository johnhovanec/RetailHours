﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RetailHours.Models;

namespace RetailHours.Controllers
{
    public class RtlHoursController : Controller
    {
        private RetailWebEntities db = new RetailWebEntities();

        // GET: RtlHours
        public ActionResult Index()
        {
            return View(db.tblRtlHours.ToList());
        }

        // GET: RtlHours/Details/5
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

        // GET: RtlHours/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RtlHours/Create
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

        // GET: RtlHours/Edit/5
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

        // POST: RtlHours/Edit/5
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

        // GET: RtlHours/Delete/5
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

        // POST: RtlHours/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tblRtlHour tblRtlHour = db.tblRtlHours.Find(id);
            db.tblRtlHours.Remove(tblRtlHour);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult RedirectToPage()
        {
            return Redirect("http://10.1.1.42/Default.asp");
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
