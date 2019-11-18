using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using projekcik;
using projekcik.Models;

namespace projekcik.Controllers
{
    public class DanieglownesController : Controller
    {
        private Daniaglowne db = new Daniaglowne();

        // GET: Danieglownes
        public ActionResult Index()
        {
            return View(db.Dania.ToList());
        }

        // GET: Danieglownes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Danieglowne danieglowne = db.Dania.Find(id);
            if (danieglowne == null)
            {
                return HttpNotFound();
            }
            return View(danieglowne);
        }

        // GET: Danieglownes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Danieglownes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Nazwa,Skladniki,Wykonanie,Iloscporcji")] Danieglowne danieglowne)
        {
            if (ModelState.IsValid)
            {
                db.Dania.Add(danieglowne);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(danieglowne);
        }

        // GET: Danieglownes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Danieglowne danieglowne = db.Dania.Find(id);
            if (danieglowne == null)
            {
                return HttpNotFound();
            }
            return View(danieglowne);
        }

        // POST: Danieglownes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Nazwa,Skladniki,Wykonanie,Iloscporcji")] Danieglowne danieglowne)
        {
            if (ModelState.IsValid)
            {
                db.Entry(danieglowne).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(danieglowne);
        }

        // GET: Danieglownes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Danieglowne danieglowne = db.Dania.Find(id);
            if (danieglowne == null)
            {
                return HttpNotFound();
            }
            return View(danieglowne);
        }

        // POST: Danieglownes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Danieglowne danieglowne = db.Dania.Find(id);
            db.Dania.Remove(danieglowne);
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
