using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ImagineCupBTrees.Models
{
    public class DeviceReading
    {
        public long Id { get; set; }
        public int DeviceId { get; set; }
        public long ReadingId { get; set; }
        public double Value { get; set; }

        public virtual Device Device { get; set; }
        public virtual Reading Reading { get; set; }
    }
}