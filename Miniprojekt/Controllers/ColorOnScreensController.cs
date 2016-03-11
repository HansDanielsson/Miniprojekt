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
    public class ColorOnScreensController : Controller
    {
        private ItemContext db = new ItemContext();

        // GET: ColorOnScreens
        public ActionResult Index()
        {
            return View(db.ColorOnScreen.ToList());
        }

        // GET: ColorOnScreens/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ColorOnScreen colorOnScreen = db.ColorOnScreen.Find(id);
            if (colorOnScreen == null)
            {
                return HttpNotFound();
            }
            return View(colorOnScreen);
        }

        // GET: ColorOnScreens/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ColorOnScreens/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,rgb")] ColorOnScreen colorOnScreen)
        {
            if (ModelState.IsValid)
            {
                db.ColorOnScreen.Add(colorOnScreen);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(colorOnScreen);
        }

        // GET: ColorOnScreens/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ColorOnScreen colorOnScreen = db.ColorOnScreen.Find(id);
            if (colorOnScreen == null)
            {
                return HttpNotFound();
            }
            return View(colorOnScreen);
        }

        // POST: ColorOnScreens/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,rgb")] ColorOnScreen colorOnScreen)
        {
            if (ModelState.IsValid)
            {
                db.Entry(colorOnScreen).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(colorOnScreen);
        }

        // GET: ColorOnScreens/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ColorOnScreen colorOnScreen = db.ColorOnScreen.Find(id);
            if (colorOnScreen == null)
            {
                return HttpNotFound();
            }
            return View(colorOnScreen);
        }

        // POST: ColorOnScreens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ColorOnScreen colorOnScreen = db.ColorOnScreen.Find(id);
            db.ColorOnScreen.Remove(colorOnScreen);
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
