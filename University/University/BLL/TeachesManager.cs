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
    class TeachesManager
    {
        TeachesRepository teachesRepository;
        public TeachesManager()
        {
            teachesRepository = new TeachesRepository();

        }
        public string IsExistOrInsert(Teaches teaches)
        {
            return teachesRepository.IsExistOrInsert(teaches);
        }
        public DataTable GetInstructorIdTocomboBox()
        {
            return teachesRepository.GetInstructorIdTocomboBox();

        }

        public DataTable GetSectionsTableTocomboBox()
        {
            return teachesRepository.GetSectionsTableTocomboBox();

        }
    }
}
