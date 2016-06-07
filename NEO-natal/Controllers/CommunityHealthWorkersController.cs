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
    public class CommunityHealthWorkersController : Controller
    {
        private NEO_natalContext db = new NEO_natalContext();

        // GET: CommunityHealthWorkers
        public ActionResult Index()
        {
            return View(db.CommunityHealthWorkers.ToList());
        }

        // GET: CommunityHealthWorkers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CommunityHealthWorker communityHealthWorker = db.CommunityHealthWorkers.Find(id);
            if (communityHealthWorker == null)
            {
                return HttpNotFound();
            }
            return View(communityHealthWorker);
        }

        // GET: CommunityHealthWorkers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CommunityHealthWorkers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "communityHealthWorkerID,loginName,passWord,firstName,lastName,email,phone,jobTitle,organization")] CommunityHealthWorker communityHealthWorker)
        {
            if (ModelState.IsValid)
            {
                db.CommunityHealthWorkers.Add(communityHealthWorker);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(communityHealthWorker);
        }

        // GET: CommunityHealthWorkers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CommunityHealthWorker communityHealthWorker = db.CommunityHealthWorkers.Find(id);
            if (communityHealthWorker == null)
            {
                return HttpNotFound();
            }
            return View(communityHealthWorker);
        }

        // POST: CommunityHealthWorkers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "communityHealthWorkerID,loginName,passWord,firstName,lastName,email,phone,jobTitle,organization")] CommunityHealthWorker communityHealthWorker)
        {
            if (ModelState.IsValid)
            {
                db.Entry(communityHealthWorker).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(communityHealthWorker);
        }

        // GET: CommunityHealthWorkers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CommunityHealthWorker communityHealthWorker = db.CommunityHealthWorkers.Find(id);
            if (communityHealthWorker == null)
            {
                return HttpNotFound();
            }
            return View(communityHealthWorker);
        }

        // POST: CommunityHealthWorkers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CommunityHealthWorker communityHealthWorker = db.CommunityHealthWorkers.Find(id);
            db.CommunityHealthWorkers.Remove(communityHealthWorker);
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
