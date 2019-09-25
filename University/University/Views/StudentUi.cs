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
    public partial class StudentUi : Form
    {
        StudentManager studentManager;
        Student student;
        public StudentUi()
        {
            InitializeComponent();
            studentManager = new StudentManager();
            student = new Student();
        }

        private void StudentUi_Load(object sender, EventArgs e)
        {
            departmentNameCombobox.DataSource = studentManager.GetDepartmentTocomboBox();

        }

        private void StudentySaveButton_Click(object sender, EventArgs e)
        {
            

            if (String.IsNullOrEmpty(idTexbox.Text))
            {
                MessageBox.Show("Enter an ID");
                return;
            }

            if (String.IsNullOrEmpty(nameTexbox.Text))
            {
                MessageBox.Show("Enter a name");
                return;
            }

            if (String.IsNullOrEmpty(departmentNameCombobox.Text))
            {
                MessageBox.Show("Select a department name");
                return;
            }

            if (String.IsNullOrEmpty(totalCreditsTexbox.Text))
            {
                MessageBox.Show("Enter total credits ");
                return;
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(totalCreditsTexbox.Text, "[^0-9]"))
            {
                MessageBox.Show("Credit is numeric");
                totalCreditsTexbox.Text = totalCreditsTexbox.Text.Remove(totalCreditsTexbox.Text.Length - 1);
                return;
            }

            student.ID = idTexbox.Text;
            student.Name = nameTexbox.Text;
            student.Dept_name = departmentNameCombobox.Text;
            student.Total_credit = Convert.ToDouble(totalCreditsTexbox.Text);

            string exist = studentManager.IsExistOrInsert(student);
            if (!String.IsNullOrEmpty(exist))
            {
                MessageBox.Show("student ID is exist \n Please enter a new instructor ID");
            }
            else
            {
                MessageBox.Show("Student Inserted successfully.");
            }


        }
    }
}
