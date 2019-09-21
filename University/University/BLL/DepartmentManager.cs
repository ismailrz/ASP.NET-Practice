using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Models;
using University.Repository;

namespace University.BLL
{
    class DepartmentManager
    {
        DepartmentRepository _departmentRepository;
        public DepartmentManager()
        {
            _departmentRepository = new DepartmentRepository();
        }
        public int Save(Department department)
        {
            return _departmentRepository.Save(department);
        }

        public string IsExistOrInsert(Department department)
        {
            return _departmentRepository.IsExistOrInsert(department);
          
        }
    }
}
