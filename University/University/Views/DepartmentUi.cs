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
    public partial class DepartmentUi : Form
    {
        public DepartmentUi()
        {
            InitializeComponent();
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {

        }

        private void DepartmentSaveButton_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            department.Dept_Name = departmentNameTextBox.Text;
            department.Building = buildingTexBox.Text;
            department.Budget = Convert.ToDouble(budgetTexBox.Text);
        }
    }
}
