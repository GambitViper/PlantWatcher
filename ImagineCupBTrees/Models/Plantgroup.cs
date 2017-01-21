using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ImagineCupBTrees.Models
{
    public class Plantgroup
    {
        [Key]
        public int Id { get; set; }
        public string PlantName { get; set; }
        //public Light Light { get; set; }
        //public Soil Soil { get; set; }
        //public Temp Temp { get; set; }
        //public Humidity Humidity { get; set; }
        public bool AutoDeviceManagement { get; set; }

    }
}