using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenithDataLib.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string CreatedBy { get; set; }
        public bool IsActive { get; set; }

        public int ActivityId { get; set; }     // TODO: According to the critiera, this should be CreationDate? 
        public Activity Activity { get; set; }
    }
}
