using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ImagineCupBTrees.Models
{
    public class Sensor
    {
        public int Id { get; set; }
        [StringLength(500)]
        public string Name { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }

        public virtual ICollection<SensorReading> SensorReadings { get; set; }
    }
}