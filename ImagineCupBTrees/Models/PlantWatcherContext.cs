using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ImagineCupBTrees.Models
{
    public class PlantWatcherContext : DbContext
    {
        public DbSet<SensorReading> SensorReadings { get; set; }
        public DbSet<DeviceReading> Devices { get; set; }
    }
}