using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaspberryPiHeadless
{
    class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsOn { get; set; }
        public bool? SetState { get; set; }
        public DateTime DateRecorded { get; set; }
    }
}
