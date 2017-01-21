using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImagineCupBTrees.Models
{
    public class SensorReading
    {
        public long Id { get; set; }
        public double TemperatureF { get; set; }
        public double Humidity { get; set; }
        public double Lux { get; set; }
        public double SoilMoisture { get; set; }
        public bool FoggerOn { get; set; }
        public bool BoilerOn { get; set; }
        public bool BonsaiOn { get; set; }
        public DateTime DateAdded { get; set; }
    }
}