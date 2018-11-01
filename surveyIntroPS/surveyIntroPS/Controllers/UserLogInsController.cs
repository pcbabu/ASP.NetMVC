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
    public class UserLogInsController : Controller
    {
        private Survey db = new Survey();

        public JsonResult IsUserExists(string Email)
        {
            //check if any of the UserName matches the UserName specified in the Parameter using the ANY extension method.  
            return Json(!db.UserLogIns.Any(x => x.Email == Email), JsonRequestBehavior.AllowGet);
        }
        
        // GET: UserLogIns
        public ActionResult Index()
        {
            return View(db.UserLogIns.ToList());
        }

        // GET: UserLogIns/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserLogIn userLogIn = db.UserLogIns.Find(id);
            if (userLogIn == null)
            {
                return HttpNotFound();
            }
            return View(userLogIn);
        }

        // GET: UserLogIns/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserLogIns/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Email,Password,ConfirmPassword")] UserLogIn userLogIn)
        {
            if (ModelState.IsValid)
            {
                db.UserLogIns.Add(userLogIn);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(userLogIn);
        }

        // GET: UserLogIns/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserLogIn userLogIn = db.UserLogIns.Find(id);
            if (userLogIn == null)
            {
                return HttpNotFound();
            }
            return View(userLogIn);
        }

        // POST: UserLogIns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Email,Password,ConfirmPassword")] UserLogIn userLogIn)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userLogIn).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(userLogIn);
        }

        // GET: UserLogIns/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserLogIn userLogIn = db.UserLogIns.Find(id);
            if (userLogIn == null)
            {
                return HttpNotFound();
            }
            return View(userLogIn);
        }

        // POST: UserLogIns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            UserLogIn userLogIn = db.UserLogIns.Find(id);
            db.UserLogIns.Remove(userLogIn);
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
