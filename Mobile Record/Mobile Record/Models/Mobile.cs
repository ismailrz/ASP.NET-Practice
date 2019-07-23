using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Record.Models
{
    public class Mobile
    {
        public int Id { get; set; }        
        public string ModelName { get; set; }
        public int IMEI { get; set; }
        public int Price { get; set; }       
    }
}
