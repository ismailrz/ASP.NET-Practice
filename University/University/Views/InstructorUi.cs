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
    public partial class InstructorUi : Form
    {
        Instructor instructor;
        InstructorManager instructorManager;
        public InstructorUi()
        {
            InitializeComponent();
            instructor = new Instructor();
            instructorManager = new InstructorManager();
        }

        private void InstructorSaveButton_Click(object sender, EventArgs e)
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
            
            if (String.IsNullOrEmpty(salaryTexbox.Text))
            {
                MessageBox.Show("Enter amount of  salary");
                return;
            }
            
            if (System.Text.RegularExpressions.Regex.IsMatch(salaryTexbox.Text,"[^0-9]"))
            {
                MessageBox.Show("Salary is numeric");
                salaryTexbox.Text = salaryTexbox.Text.Remove(salaryTexbox.Text.Length - 1);
                return;
            }

            instructor.ID = idTexbox.Text;
            instructor.Name = nameTexbox.Text;
            instructor.Dept_name = departmentNameCombobox.Text;
            instructor.Salary =Convert.ToDouble( salaryTexbox.Text);

           string exist= instructorManager.IsExistOrInsert(instructor);
            if (!String.IsNullOrEmpty(exist))
            {
                MessageBox.Show("Instructor ID is exist \n Please enter a new instructor ID");
            }
            else
            {
                MessageBox.Show("Instructor Inserted successfully.");
            }


        }

        private void InstructorUi_Load(object sender, EventArgs e)
        {
            departmentNameCombobox.DataSource = instructorManager.GetDepartmentTocomboBox();
        }
    }
}
