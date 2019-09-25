using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University.BLL;
using University.Models;

namespace University.Views
{
    public partial class CourseUi : Form
    {
        CourseManager courseManager;
        Course course;
        public CourseUi()
        {
            InitializeComponent();
            courseManager = new CourseManager();
           course = new Course();

        }

        

        private void CourseForm_Load(object sender, EventArgs e)
        {
            departmentNameCombobox.DataSource = courseManager.GetDepartmentsToComboBox();
        }

        private void CourseSaveButton_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(courseIdTexbox.Text))
            {
                MessageBox.Show("Enter a Course ID");
                return;
            }
              if (String.IsNullOrEmpty(titleTexbox.Text))
            {
                MessageBox.Show("Enter a course Title ");
                return;
            }
              if (String.IsNullOrEmpty(departmentNameCombobox.Text))
            {
                MessageBox.Show("Select a department name");
                return;
            }
              if (String.IsNullOrEmpty(creditsTexbox.Text))
            {
                MessageBox.Show("Enter a course Credits !");
                return;
            }
            
            if(System.Text.RegularExpressions.Regex.IsMatch(creditsTexbox.Text, "[^0-9]"))
            {
                MessageBox.Show("Credits is Numeric!!");
                creditsTexbox.Text = creditsTexbox.Text.Remove(creditsTexbox.Text.Length - 1);
                return;
            }

            

            course.Course_id = courseIdTexbox.Text;
            course.Title = titleTexbox.Text;
            course.Dept_name = departmentNameCombobox.Text;
            course.Credit =Convert.ToDouble( creditsTexbox.Text);


           

           string exist = courseManager.IsExistOrInsert(course);
            if (!String.IsNullOrEmpty(exist))
            {
                MessageBox.Show(exist);
            }
            else
            {
                MessageBox.Show("Course Insert Successfull !!");
            }

        }

        private void DepartmentNameCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
