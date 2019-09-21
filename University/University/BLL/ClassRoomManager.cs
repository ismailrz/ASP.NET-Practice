using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Models;
using University.Repository;

namespace University.BLL
{
    public class ClassRoomManager
    {
        ClassRoomRepository classRoomRepository;

       public ClassRoomManager()
        {
            classRoomRepository = new ClassRoomRepository();
        }

        public string IsExistOrInsert(Classroom classroom)
        {
            return classRoomRepository.IsExistOrInsert(classroom);
        }

    }
}
