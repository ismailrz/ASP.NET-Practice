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
    class StudentManager
    {
        StudentRepository studentRepository;
        public StudentManager()
        {
            studentRepository = new StudentRepository();
        }
        public string IsExistOrInsert(Student student)
        {
            return studentRepository.IsExistOrInsert(student);
        }
        public DataTable GetDepartmentTocomboBox()
        {
            return studentRepository.GetDepartmentTocomboBox();

        }
    }
}
