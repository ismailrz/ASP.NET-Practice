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
    
    class CompanyManager
    {
        CompanyRepository _CompanyRepository;
        public CompanyManager()
        {
            _CompanyRepository = new CompanyRepository();
        }
        public string IsExistOrInsert(CompanyModel company)
        {

            return _CompanyRepository.IsExistOrInsert(company);
        }

        public DataTable LoadToCompanyFunction()
        {
            return _CompanyRepository.LoadToCompanyFunction();
        }

    }
}
