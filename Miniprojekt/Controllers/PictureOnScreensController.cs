using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Miniprojekt.DataAccessLayer;

namespace Miniprojekt.Models
{
    public class PictureOnScreensController : Controller
    {
        private ItemContext db = new ItemContext();

        // GET: PictureOnScreens
        public ActionResult Index()
        {
            return View(db.PictureOnScreen.ToList());
        }

		public ActionResult Index2()
		{
			var result = from v in db.UserRecord
						 where v != null && (int)v.Category == 0 && v.UserID == 1
						 select v;
			foreach (UserRecord v in result)
			{
				v.Points = v.Points + 1;
			}
			db.SaveChanges();
			return RedirectToAction("Index");
		}

        // GET: PictureOnScreens/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PictureOnScreen pictureOnScreen = db.PictureOnScreen.Find(id);
            if (pictureOnScreen == null)
            {
                return HttpNotFound();
            }
            return View(pictureOnScreen);
        }

        // GET: PictureOnScreens/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PictureOnScreens/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Image")] PictureOnScreen pictureOnScreen)
        {
            if (ModelState.IsValid)
            {
                db.PictureOnScreen.Add(pictureOnScreen);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pictureOnScreen);
        }

        // GET: PictureOnScreens/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PictureOnScreen pictureOnScreen = db.PictureOnScreen.Find(id);
            if (pictureOnScreen == null)
            {
                return HttpNotFound();
            }
            return View(pictureOnScreen);
        }

        // POST: PictureOnScreens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Image")] PictureOnScreen pictureOnScreen)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pictureOnScreen).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pictureOnScreen);
        }

        // GET: PictureOnScreens/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PictureOnScreen pictureOnScreen = db.PictureOnScreen.Find(id);
            if (pictureOnScreen == null)
            {
                return HttpNotFound();
            }
            return View(pictureOnScreen);
        }

        // POST: PictureOnScreens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PictureOnScreen pictureOnScreen = db.PictureOnScreen.Find(id);
            db.PictureOnScreen.Remove(pictureOnScreen);
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
