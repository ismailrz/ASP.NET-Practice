﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System.Models
{
    class StockInModel
    {
        public int Serial { set; get; }
        public string CategoryName { set; get; }
        public string CompanyName { set; get; }
        public string ItemName { set; get; }
        public int AvailableQuantity { set; get; }
        public string DT { set; get; }
    }
}
