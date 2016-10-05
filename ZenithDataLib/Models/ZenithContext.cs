using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenithDataLib.Models
{
    public class ZenithContext : DbContext
    {
        public DbSet<Activity> Activity { get; set; }
        public DbSet<Event> Event { get; set; }
    }
}
