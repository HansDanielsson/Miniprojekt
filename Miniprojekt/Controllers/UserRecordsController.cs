using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Miniprojekt.DataAccessLayer;
using Miniprojekt.Models;

namespace Miniprojekt.Controllers
{
    public class UserRecordsController : Controller
    {
        private ItemContext db = new ItemContext();

        // GET: UserRecords
        public ActionResult Index()
        {
            var userRecord = db.UserRecord.Include(u => u.username);
            return View(userRecord.ToList());
        }
		


        // GET: UserRecords/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserRecord userRecord = db.UserRecord.Find(id);
            if (userRecord == null)
            {
                return HttpNotFound();
            }
            return View(userRecord);
        }

        // GET: UserRecords/Create
        public ActionResult Create()
        {
            ViewBag.UserID = new SelectList(db.UserName, "UserID", "NickName");
            return View();
        }

        // POST: UserRecords/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RecordID,Category,UserID,Points")] UserRecord userRecord)
        {
            if (ModelState.IsValid)
            {
                db.UserRecord.Add(userRecord);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserID = new SelectList(db.UserName, "UserID", "NickName", userRecord.UserID);
            return View(userRecord);
        }

        // GET: UserRecords/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserRecord userRecord = db.UserRecord.Find(id);
            if (userRecord == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserID = new SelectList(db.UserName, "UserID", "NickName", userRecord.UserID);
            return View(userRecord);
        }

        // POST: UserRecords/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RecordID,Category,UserID,Points")] UserRecord userRecord)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userRecord).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserID = new SelectList(db.UserName, "UserID", "NickName", userRecord.UserID);
            return View(userRecord);
        }

        // GET: UserRecords/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserRecord userRecord = db.UserRecord.Find(id);
            if (userRecord == null)
            {
                return HttpNotFound();
            }
            return View(userRecord);
        }

        // POST: UserRecords/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserRecord userRecord = db.UserRecord.Find(id);
            db.UserRecord.Remove(userRecord);
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
