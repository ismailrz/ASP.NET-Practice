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
    public partial class StudentUi : Form
    {
        public StudentUi()
        {
            InitializeComponent();
        }

        private void StudentUi_Load(object sender, EventArgs e)
        {

        }

        private void StudentySaveButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();

            student.ID = idTexbox.Text;
            student.Name = nameTexbox.Text;
            student.Dept_name = departmentNameCombobox.Text;
            student.Total_credit =Convert.ToDouble( totalCreditsTexbox.Text);
        }
    }
}
