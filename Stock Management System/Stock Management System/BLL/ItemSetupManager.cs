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
    class ItemSetupManager
    {
        ItemSetupRepository _itemSetupRepository, _ItemSetupRepository2;

        public ItemSetupManager()
        {
            _itemSetupRepository = new ItemSetupRepository();
            _ItemSetupRepository2 = new ItemSetupRepository();
        }
        public string IsExistOrInsert(ItemModel item)
        {

            return _itemSetupRepository.IsExistOrInsert(item);
        }

        public DataTable LoadToCategoryComboBox()
        {
            return _itemSetupRepository.LoadToCategoryComboBox();
        }
        public DataTable LoadToCompanyComboBox()
        {
            return _ItemSetupRepository2.LoadToCompanyComboBox();
        }
        
    }
}
