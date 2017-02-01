using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImagineCupBTrees.Models
{
    public class Reading
    {
        public long Id { get; set; }
        public DateTime DateRecorded { get; set; }
        public string UserName { get; set; }

        public virtual ICollection<SensorReading> SensorReadings { get; set; }
        public virtual ICollection<DeviceReading> DeviceReadings { get; set; }
    }
}