using Stock_Management_System.Models;
using Stock_Management_System.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System.BLL
{
   

    
    class StockInManager
    {
        StockInRepository _stockInRepositiory, _stockInRepositiory2, _stockInRepositiory3, _stockInRepositiory4, _stockInRepositiory5;

        public StockInManager()
        {
            _stockInRepositiory = new StockInRepository();
            _stockInRepositiory2 = new StockInRepository();
            _stockInRepositiory3 = new StockInRepository();
            _stockInRepositiory4 = new StockInRepository();
            _stockInRepositiory5 = new StockInRepository();
        }



        public DataTable LoadToCategoryComboBox()
        {
            return _stockInRepositiory.LoadToCategoryComboBox();
        }
        public DataTable LoadToCompanyComboBox()
        {
            return _stockInRepositiory2.LoadToCompanyComboBox();
        }
        public DataTable LoadToItemSetupComboBox()
        {
            return _stockInRepositiory3.LoadToItemSetupComboBox();
            
        }
        public string ReorderLevelTextBoxFunction(ItemModel itemModel)
        {
            return _stockInRepositiory4.ReorderLevelTextBoxFunction( itemModel);
        }
    }
}
