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
    class PreReqManager
    {
        PreReqRepository prereqRepository;
        public PreReqManager()
        {
            prereqRepository = new PreReqRepository();

        }
        public string IsExistOrInsert(Prereq prereq)
        {
            return prereqRepository.IsExistOrInsert(prereq);
        }
        public DataTable GetCourseIdTocomboBox()
        {
            return prereqRepository.GetCourseIdTocomboBox();

        }
    }
}
