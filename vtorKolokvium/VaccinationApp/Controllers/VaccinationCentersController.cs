using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VaccinationApp.Models;

namespace VaccinationApp.Controllers
{
    
    public class VaccinationCentersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: VaccinationCenters
        [Authorize(Roles = "Doctor, User")]
        public ActionResult Index()
        {
            return View(db.VaccinationCenters.ToList());
        }

        // GET: VaccinationCenters/Details/5
        [Authorize(Roles = "Doctor")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VaccinationCenter vaccinationCenter = db.VaccinationCenters.Find(id);
            if (vaccinationCenter == null)
            {
                return HttpNotFound();
            }
            return View(vaccinationCenter);
        }

        // GET: VaccinationCenters/Create
        [Authorize(Roles = "Doctor")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: VaccinationCenters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Doctor")]
        public ActionResult Create([Bind(Include = "Id,Name,Address,MaxCapacity")] VaccinationCenter vaccinationCenter)
        {
            if (ModelState.IsValid)
            {
                db.VaccinationCenters.Add(vaccinationCenter);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vaccinationCenter);
        }

        // GET: VaccinationCenters/Edit/5
        [Authorize(Roles = "Doctor")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VaccinationCenter vaccinationCenter = db.VaccinationCenters.Find(id);
            if (vaccinationCenter == null)
            {
                return HttpNotFound();
            }
            return View(vaccinationCenter);
        }

        // POST: VaccinationCenters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Address,MaxCapacity")] VaccinationCenter vaccinationCenter)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vaccinationCenter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vaccinationCenter);
        }

        // GET: VaccinationCenters/Delete/5
        [Authorize(Roles = "Doctor")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VaccinationCenter vaccinationCenter = db.VaccinationCenters.Find(id);
            if (vaccinationCenter == null)
            {
                return HttpNotFound();
            }
            return View(vaccinationCenter);
        }

        // POST: VaccinationCenters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VaccinationCenter vaccinationCenter = db.VaccinationCenters.Find(id);
            db.VaccinationCenters.Remove(vaccinationCenter);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult AddVaccPatient(int id)
        {
            var model = new VaccinePatients();
            model.vaccinCenterID = id;
            model.VaccinationCenter = db.VaccinationCenters.Find(id);
            model.Vaccines = db.Vaccines.ToList();
            model.Patients = db.Patients.ToList();

            return View(model);
        }

        [HttpPost]
        public ActionResult AddVaccPatient(VaccinePatients model)
        {
            var center = db.VaccinationCenters.Find(model.vaccinCenterID);
            var patient = db.Patients.Find(model.patientID);
            Vaccine vaccine = new Vaccine();  
            vaccine.DateTaken = DateTime.Now;
            patient.Vaccines.Add(vaccine);
                                                
            center.Patients.Add(patient);
            db.SaveChanges();

            return View("Details", center);                                                    
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
