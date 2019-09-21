using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private SqlDataAdapter sqlDataAdapter;
        private DataTable datatable;

        public DepartmentUi()
        {
            InitializeComponent();
            _departmentManager = new DepartmentManager();
        }

        

        private void DepartmentSaveButton_Click(object sender, EventArgs e)
        {
            
            if(String.IsNullOrEmpty(departmentNameTextBox.Text))
            {
                MessageBox.Show("Department Name is Empty");
                return ;
            }
           
            if (String.IsNullOrEmpty(buildingTexBox.Text))
            {
                MessageBox.Show("Building is Empty");
                return;
            }
           
            if (String.IsNullOrEmpty(budgetTexBox.Text))
            {
                MessageBox.Show("Budget is Empty");
                return;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(budgetTexBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Budget is only numeric");
                budgetTexBox.Text = budgetTexBox.Text.Remove(budgetTexBox.Text.Length - 1);
                return;
            }
            department = new Department();
            department.Dept_Name = departmentNameTextBox.Text;
            department.Building = buildingTexBox.Text;
            department.Budget = Convert.ToDouble(budgetTexBox.Text);

            
            string exist= _departmentManager.IsExistOrInsert(department);

            if(!String.IsNullOrEmpty(exist))
            {
                MessageBox.Show(exist);
                return;
            }

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
