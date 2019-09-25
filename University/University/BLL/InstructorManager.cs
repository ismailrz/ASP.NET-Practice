using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Models;
using University.Repository;

namespace University.BLL
{

    class InstructorManager
    {
        InstructorRepository instructorRepository;

        public InstructorManager()
        {
            instructorRepository = new InstructorRepository();
        }

        public string IsExistOrInsert(Instructor instructor)
        {
            return instructorRepository.IsExistOrInsert(instructor);
        }
        public DataTable GetDepartmentTocomboBox()
        {
            return instructorRepository.GetDepartmentTocomboBox();

        }
    }
}
