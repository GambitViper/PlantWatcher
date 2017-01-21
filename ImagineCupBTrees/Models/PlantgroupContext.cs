using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ImagineCupBTrees.Models
{
    public class PlantgroupContext:DbContext
    {
        public DbSet<Plantgroup> Plantgroups { get; set; }

    }
}