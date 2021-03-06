﻿using System;
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
    public class SensorReadingsController : Controller
    {
        private PlantWatcherContext db = new PlantWatcherContext();

        // GET: SensorReadings
        public ActionResult Index()
        {
            var readings = db.SensorReadings.OrderByDescending(reading => reading.DateAdded).Take(100).ToList();
            for (int i = readings.Count - 1; i >= 0; i--)
            {
                readings[i].DateAdded = readings[i].DateAdded.AddHours(-6);
            }
            return View(readings);
        }

        // GET: SensorReadings/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SensorReading sensorReading = db.SensorReadings.Find(id);
            if (sensorReading == null)
            {
                return HttpNotFound();
            }
            return View(sensorReading);
        }

        public ActionResult Chart()
        {
            return View();
        }

        //// GET: SensorReadings/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: SensorReadings/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id,TemperatureF,Humidity,Lux,SoilMoisture,FoggerOn,BoilerOn,BonsaiOn,DateAdded")] SensorReading sensorReading)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.SensorReadings.Add(sensorReading);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(sensorReading);
        //}

        //// GET: SensorReadings/Edit/5
        //public ActionResult Edit(long? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    SensorReading sensorReading = db.SensorReadings.Find(id);
        //    if (sensorReading == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(sensorReading);
        //}

        //// POST: SensorReadings/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Id,TemperatureF,Humidity,Lux,SoilMoisture,FoggerOn,BoilerOn,BonsaiOn,DateAdded")] SensorReading sensorReading)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(sensorReading).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(sensorReading);
        //}

        //// GET: SensorReadings/Delete/5
        //public ActionResult Delete(long? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    SensorReading sensorReading = db.SensorReadings.Find(id);
        //    if (sensorReading == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(sensorReading);
        //}

        //// POST: SensorReadings/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(long id)
        //{
        //    SensorReading sensorReading = db.SensorReadings.Find(id);
        //    db.SensorReadings.Remove(sensorReading);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

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
