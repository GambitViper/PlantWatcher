using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ImagineCupBTrees.Models;

namespace ImagineCupBTrees.Controllers
{
    public class PlantgroupsController : Controller
    {
        private PlantgroupContext db = new PlantgroupContext();

        // GET: Plantgroups
        public ActionResult Index()
        {
            return View(db.Plantgroups.ToList());
        }

        // GET: Plantgroups/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Plantgroup plantgroup = db.Plantgroups.Find(id);
            if (plantgroup == null)
            {
                return HttpNotFound();
            }
            return View(plantgroup);
        }

        // GET: Plantgroups/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Plantgroups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,PlantName,TemperatureF,Humidity,Lux,SoilMoisture,FoggerOn,BoilerOn,BonsaiOn")] Plantgroup plantgroup)
        {
            if (ModelState.IsValid)
            {
                db.Plantgroups.Add(plantgroup);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(plantgroup);
        }

        // GET: Plantgroups/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Plantgroup plantgroup = db.Plantgroups.Find(id);
            if (plantgroup == null)
            {
                return HttpNotFound();
            }
            return View(plantgroup);
        }

        // POST: Plantgroups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,PlantName,TemperatureF,Humidity,Lux,SoilMoisture,FoggerOn,BoilerOn,BonsaiOn")] Plantgroup plantgroup)
        {
            if (ModelState.IsValid)
            {
                db.Entry(plantgroup).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(plantgroup);
        }

        // GET: Plantgroups/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Plantgroup plantgroup = db.Plantgroups.Find(id);
            if (plantgroup == null)
            {
                return HttpNotFound();
            }
            return View(plantgroup);
        }

        // POST: Plantgroups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Plantgroup plantgroup = db.Plantgroups.Find(id);
            db.Plantgroups.Remove(plantgroup);
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
