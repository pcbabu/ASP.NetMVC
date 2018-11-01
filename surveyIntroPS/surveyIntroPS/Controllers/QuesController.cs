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
    public class QuesController : Controller
    {
        private Survey db = new Survey();

        // GET: Ques
        public ActionResult Index()
        {
            return View(db.Ques.ToList());
        }

        // GET: Ques/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Que que = db.Ques.Find(id);
            if (que == null)
            {
                return HttpNotFound();
            }
            return View(que);
        }

        // GET: Ques/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ques/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Ques,Op1,Op2,Op3,Op4,Ans")] Que que)
        {
            if (ModelState.IsValid)
            {
                db.Ques.Add(que);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(que);
        }

        // GET: Ques/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Que que = db.Ques.Find(id);
            if (que == null)
            {
                return HttpNotFound();
            }
            return View(que);
        }

        // POST: Ques/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Ques,Op1,Op2,Op3,Op4,Ans")] Que que)
        {
            if (ModelState.IsValid)
            {
                db.Entry(que).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(que);
        }

        // GET: Ques/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Que que = db.Ques.Find(id);
            if (que == null)
            {
                return HttpNotFound();
            }
            return View(que);
        }

        // POST: Ques/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Que que = db.Ques.Find(id);
            db.Ques.Remove(que);
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
