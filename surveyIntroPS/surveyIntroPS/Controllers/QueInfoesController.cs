using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using surveyIntroPS.Models;

namespace surveyIntroPS.Controllers
{
    public class QueInfoesController : Controller
    {
        private Survey db = new Survey();

        // GET: QueInfoes
        public ActionResult Index()
        {
            return View(db.QueInfos.ToList());
        }

        // GET: QueInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QueInfo queInfo = db.QueInfos.Find(id);
            if (queInfo == null)
            {
                return HttpNotFound();
            }
            return View(queInfo);
        }

        // GET: QueInfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QueInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,QueName")] QueInfo queInfo)
        {
            if (ModelState.IsValid)
            {
                db.QueInfos.Add(queInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(queInfo);
        }

        // GET: QueInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QueInfo queInfo = db.QueInfos.Find(id);
            if (queInfo == null)
            {
                return HttpNotFound();
            }
            return View(queInfo);
        }

        // POST: QueInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,QueName")] QueInfo queInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(queInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(queInfo);
        }

        // GET: QueInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QueInfo queInfo = db.QueInfos.Find(id);
            if (queInfo == null)
            {
                return HttpNotFound();
            }
            return View(queInfo);
        }

        // POST: QueInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            QueInfo queInfo = db.QueInfos.Find(id);
            db.QueInfos.Remove(queInfo);
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
