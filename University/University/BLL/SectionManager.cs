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
    class SectionManager
    {
        SectionRepository sectionRepository;
        public SectionManager()
        {
            sectionRepository = new SectionRepository();
        }
        public string IsExistOrInsert(Section section)
        {
            return sectionRepository.IsExistOrInsert(section);
        }
        public DataTable GetBuildingAndRoomNumberTocomboBox()
        {
            return sectionRepository.GetBuildingAndRoomNumberTocomboBox();

        }

         public DataTable GetCourseTocomboBox()
        {
            return sectionRepository.GetCourseTocomboBox();

        }

    }
}
