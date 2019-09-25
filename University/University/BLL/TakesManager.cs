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
    class TakesManager
    {
        TakesRepository takesRepository;
        public TakesManager()
        {
            takesRepository = new TakesRepository();

        }
        public string IsExistOrInsert(Takes takes)
        {
            return takesRepository.IsExistOrInsert(takes);
        }
        public DataTable GetStudentIdTocomboBox()
        {
            return takesRepository.GetStudentIdTocomboBox();

        }

        public DataTable GetSectionsTableTocomboBox()
        {
            return takesRepository.GetSectionsTableTocomboBox();

        }
    }
}
