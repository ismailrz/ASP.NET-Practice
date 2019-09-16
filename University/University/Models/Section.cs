using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Models
{
    public class Section
    {
        public string Course_id { get; set; }
        public string Section_id { get; set; }
        public string Semester { get; set; }
        public double Year { get; set; }
        public string Building { get; set; }
        public string Room_number { get; set; }
        public string Time_slot_id { get; set; }
    }
}
