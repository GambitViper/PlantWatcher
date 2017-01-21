using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ImagineCupBTrees.Models
{
    public class SensorReadingContext : DbContext
    {
        public DbSet<SensorReading> SensorReadings { get; set; }
    }
}