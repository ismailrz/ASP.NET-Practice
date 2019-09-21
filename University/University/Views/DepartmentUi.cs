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
    public partial class DepartmentUi : Form
    {
        Department department;
        DepartmentManager _departmentManager;
        public DepartmentUi()
        {
            InitializeComponent();
            _departmentManager = new DepartmentManager();
        }

        

        private void DepartmentSaveButton_Click(object sender, EventArgs e)
        {
            department = new Department();
            if(String.IsNullOrEmpty(departmentNameTextBox.Text))
            {
                MessageBox.Show("Department Name is Empty");
                return ;
            }
            department.Dept_Name = departmentNameTextBox.Text;
            if (String.IsNullOrEmpty(buildingTexBox.Text))
            {
                MessageBox.Show("Building is Empty");
                return;
            }
            department.Building = buildingTexBox.Text;
            if (String.IsNullOrEmpty(budgetTexBox.Text))
            {
                MessageBox.Show("Budget is Empty");
                return;
            }
            if(System.Text.RegularExpressions.Regex.IsMatch(budgetTexBox.Text,@[0-9]))           
            {

            }
            department.Budget = Convert.ToDouble(budgetTexBox.Text);
            int isExecuted=_departmentManager.Save(department);
            if(isExecuted>0)
            {
                MessageBox.Show("Saved Successfully");
            }
            else
            {
                MessageBox.Show("Saved Failed");
            }
        }

        private void DepartmentUi_Load(object sender, EventArgs e)
        {

        }
    }
}
