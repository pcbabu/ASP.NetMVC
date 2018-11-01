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
    public class AnsController : Controller
    {
        private Survey db = new Survey();

        // GET: Ans
        public ActionResult Index()
        {
            return View(db.Anss.ToList());
        }

        // GET: Ans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ans ans = db.Anss.Find(id);
            if (ans == null)
            {
                return HttpNotFound();
            }
            return View(ans);
        }

        // GET: Ans/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ans")] Ans ans)
        {
            if (ModelState.IsValid)
            {
                db.Anss.Add(ans);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ans);
        }

        // GET: Ans/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ans ans = db.Anss.Find(id);
            if (ans == null)
            {
                return HttpNotFound();
            }
            return View(ans);
        }

        // POST: Ans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ans")] Ans ans)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ans).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ans);
        }

        // GET: Ans/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ans ans = db.Anss.Find(id);
            if (ans == null)
            {
                return HttpNotFound();
            }
            return View(ans);
        }

        // POST: Ans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ans ans = db.Anss.Find(id);
            db.Anss.Remove(ans);
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
