using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImagineCupBTrees.Models
{
    public class DeviceCommand
    {
        public long Id { get; set; }
        public int DeviceId { get; set; }
        public bool? SetState { get; set; }

        public virtual Device Device { get; set; }
    }
}