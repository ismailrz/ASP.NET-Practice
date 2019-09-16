using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Models
{
   public class TimeSlot
    {
        public string Time_slot_id { get; set; }
        public string Day { get; set; }
        public string Start_time { get; set; }
        public string End_time { get; set; }
    }
}
