using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CoachingCenterManagement.DataContext;
using CoachingCenterManagement.Models;

namespace CoachingCenterManagement.Controllers
{
    public class AdmissionsController : Controller
    {
        private CoachingCenterDbContext db = new CoachingCenterDbContext();

        // GET: Admissions
        public ActionResult Index()
        {
            return View(db.Admission.ToList());
        }

        // GET: Admissions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admission admission = db.Admission.Find(id);
            if (admission == null)
            {
                return HttpNotFound();
            }
            return View(admission);
        }

        // GET: Admissions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admissions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SlNo,FirstName,LastName,DateOfBirth,Class,FatherName,MotherName,PermanentAddress,PhoneNumber")] Admission admission)
        {
            if (ModelState.IsValid)
            {
                db.Admission.Add(admission);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(admission);
        }

        // GET: Admissions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admission admission = db.Admission.Find(id);
            if (admission == null)
            {
                return HttpNotFound();
            }
            return View(admission);
        }

        // POST: Admissions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SlNo,FirstName,LastName,DateOfBirth,Class,FatherName,MotherName,PermanentAddress,PhoneNumber")] Admission admission)
        {
            if (ModelState.IsValid)
            {
                db.Entry(admission).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(admission);
        }

        // GET: Admissions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Admission admission = db.Admission.Find(id);
            if (admission == null)
            {
                return HttpNotFound();
            }
            return View(admission);
        }

        // POST: Admissions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Admission admission = db.Admission.Find(id);
            db.Admission.Remove(admission);
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
