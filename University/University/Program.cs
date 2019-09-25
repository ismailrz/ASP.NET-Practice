using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using University.Views;

namespace University
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ClassRoomForm());
           // Application.Run(new DepartmentUi());
            //Application.Run(new ClassRoomUi());
           // Application.Run(new CourseUi());
            //Application.Run(new InstructorUi());
           // Application.Run(new StudentUi());
          //  Application.Run(new SectionUi());
            //Application.Run(new TakesUi());
           // Application.Run(new TeachesUi());
           // Application.Run(new AdvisorUi());
            Application.Run(new PrereqUi());

        }
    }
}
