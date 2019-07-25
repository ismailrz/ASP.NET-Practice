using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System.Models
{
    class StockOutModel
    {
        public int Serial { set; get; }
        public string ItemName { set; get; }
        public string CompanyName { set; get; }
        public int QuantityOut { set; get; }

    }
}
