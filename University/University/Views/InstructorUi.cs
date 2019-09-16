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
    public partial class InstructorUi : Form
    {
        public InstructorUi()
        {
            InitializeComponent();
        }

        private void InstructorSaveButton_Click(object sender, EventArgs e)
        {
            Instructor instructor = new Instructor();

            instructor.ID = idTexbox.Text;
            instructor.Name = nameTexbox.Text;
            instructor.Dept_name = departmentNameCombobox.Text;
            instructor.Salary =Convert.ToDouble( salaryTexbox.Text);
        }
    }
}
