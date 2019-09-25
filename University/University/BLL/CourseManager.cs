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
    class CourseManager
    {
        CourseRepository courseRepository;
        public CourseManager()
        {
            courseRepository = new CourseRepository();
        }
        public DataTable GetDepartmentsToComboBox()
        {
            return  courseRepository.GetDepartmentsToComboBox();
        }
        public string IsExistOrInsert(Course course)
        {
            return courseRepository.IsExistOrInsert(course);
        }
    }
}
