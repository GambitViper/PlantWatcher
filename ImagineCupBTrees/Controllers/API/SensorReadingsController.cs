using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ImagineCupBTrees.Models;

namespace ImagineCupBTrees.Controllers.API
{
    public class SensorReadingsController : ApiController
    {
        private SensorReadingContext db = new SensorReadingContext();

        // GET: api/SensorReadings
        public IQueryable<SensorReading> GetSensorReadings()
        {
            return db.SensorReadings;
        }

        // GET: api/SensorReadings/5
        [ResponseType(typeof(SensorReading))]
        public IHttpActionResult GetSensorReading(long id)
        {
            SensorReading sensorReading = db.SensorReadings.Find(id);
            if (sensorReading == null)
            {
                return NotFound();
            }

            return Ok(sensorReading);
        }

        // PUT: api/SensorReadings/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSensorReading(long id, SensorReading sensorReading)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sensorReading.Id)
            {
                return BadRequest();
            }

            db.Entry(sensorReading).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SensorReadingExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/SensorReadings
        [ResponseType(typeof(SensorReading))]
        public IHttpActionResult PostSensorReading(SensorReading sensorReading)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SensorReadings.Add(sensorReading);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = sensorReading.Id }, sensorReading);
        }

        // DELETE: api/SensorReadings/5
        [ResponseType(typeof(SensorReading))]
        public IHttpActionResult DeleteSensorReading(long id)
        {
            SensorReading sensorReading = db.SensorReadings.Find(id);
            if (sensorReading == null)
            {
                return NotFound();
            }

            db.SensorReadings.Remove(sensorReading);
            db.SaveChanges();

            return Ok(sensorReading);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SensorReadingExists(long id)
        {
            return db.SensorReadings.Count(e => e.Id == id) > 0;
        }
    }
}