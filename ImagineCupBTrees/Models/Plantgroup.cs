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
        public double TemperatureF { get; set; }
        public double Humidity { get; set; }
        public double Lux { get; set; }
        public double SoilMoisture { get; set; }
        public bool FoggerOn { get; set; }
        public bool BoilerOn { get; set; }
        public bool BonsaiOn { get; set; }
        //public Light Light { get; set; }
        //public Soil Soil { get; set; }
        //public Temp Temp { get; set; }
        //public Humidity Humidity { get; set; }
        

    }
}