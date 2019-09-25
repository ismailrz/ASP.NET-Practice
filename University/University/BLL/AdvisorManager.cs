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
    class AdvisorManager
    {
        AdvisorRepository advisorRepository;
        public AdvisorManager()
        {
            advisorRepository = new AdvisorRepository();

        }
        public string IsExistOrInsert(Advisor advisor)
        {
            return advisorRepository.IsExistOrInsert(advisor);
        }
        public DataTable GetInstructorIdTocomboBox()
        {
            return advisorRepository.GetInstructorIdTocomboBox();

        }

        public DataTable GetStudentIdTocomboBox()
        {
            return advisorRepository.GetStudentIdTocomboBox();

        }
    }
}
