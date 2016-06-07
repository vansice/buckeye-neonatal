using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NEO_natal.Models;

namespace NEO_natal.Controllers
{
    public class Mothers_DataController : Controller
    {
        private NEO_natalContext db = new NEO_natalContext();

        // GET: Mothers_Data
        public ActionResult Index()
        {
            return View(db.Mothers_Data.ToList());
        }

        // GET: Mothers_Data/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mothers_Data mothers_Data = db.Mothers_Data.Find(id);
            if (mothers_Data == null)
            {
                return HttpNotFound();
            }
            return View(mothers_Data);
        }

        // GET: Mothers_Data/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mothers_Data/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "mothersId,communityHealthWorkerID,firstName,lastName,dOb,address,zip,phone,email,dueDate")] Mothers_Data mothers_Data)
        {
            if (ModelState.IsValid)
            {
                db.Mothers_Data.Add(mothers_Data);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mothers_Data);
        }

        // GET: Mothers_Data/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mothers_Data mothers_Data = db.Mothers_Data.Find(id);
            if (mothers_Data == null)
            {
                return HttpNotFound();
            }
            return View(mothers_Data);
        }

        // POST: Mothers_Data/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "mothersId,communityHealthWorkerID,firstName,lastName,dOb,address,zip,phone,email,dueDate")] Mothers_Data mothers_Data)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mothers_Data).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mothers_Data);
        }

        // GET: Mothers_Data/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mothers_Data mothers_Data = db.Mothers_Data.Find(id);
            if (mothers_Data == null)
            {
                return HttpNotFound();
            }
            return View(mothers_Data);
        }

        // POST: Mothers_Data/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mothers_Data mothers_Data = db.Mothers_Data.Find(id);
            db.Mothers_Data.Remove(mothers_Data);
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
