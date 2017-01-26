using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ImagineCupBTrees.Models
{
    public class Device
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public bool IsOn { get; set; }
        public bool? SetState { get; set; }
        public DateTime DateRecorded { get; set; }
    }
}