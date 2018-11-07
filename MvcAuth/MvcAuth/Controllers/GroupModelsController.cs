using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DataControl;

namespace MvcAuth.Controllers
{
    public class GroupModelsController : Controller
    {
        public GroupData dataControl = new GroupData();

        // GET: GroupModels
        public ActionResult Index()
        {
            return View(dataControl.GetAllGroupData());
        }

        // GET: GroupModels/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            if (dataControl.Find(id) == null)
            {
                return HttpNotFound();
            }
            return View(dataControl.GetGroupDetails(id));
        }

        // GET: GroupModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GroupModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(String id, String userID, String Name)
        {

            if (ModelState.IsValid)
            {
                dataControl.Create(id, userID, Name);
                return RedirectToAction("Index");
            }

            return View(dataControl.dataSet(id, userID, Name));
        }

        // GET: GroupModels/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            if (dataControl.Find(id) == null)
            {
                return HttpNotFound();
            }
            return View(dataControl.GetGroupDetails(id));
        }

        // POST: GroupModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(String id, String userID, String Name)
        {
            if (ModelState.IsValid)
            {
                dataControl.UpdateDB(id, userID, Name);
                return RedirectToAction("Index");
            }
            return View(dataControl.dataSet(id, userID, Name));
        }

        // GET: GroupModels/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            if (dataControl.Find(id) == null)
            {
                return HttpNotFound();
            }
            return View(dataControl.Find(id));
        }

        // POST: GroupModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            dataControl.DeleteGroup(id);

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                dataControl.dispose();
            }
            base.Dispose(disposing);
        }
    }
}
