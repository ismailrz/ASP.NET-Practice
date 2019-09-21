using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University.Models;

namespace University.Views
{
    public partial class CourseUi : Form
    {
        public CourseUi()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CourseForm_Load(object sender, EventArgs e)
        {

        }

        private void CourseSaveButton_Click(object sender, EventArgs e)
        {
            Course course = new Course();

            course.Course_id = courseIdTexbox.Text;
            course.Title = titleTexbox.Text;
            course.Dept_name = departmentNameCombobox.Text;
            course.Credit =Convert.ToDouble( creditsTexbox.Text);



        }
    }
}
