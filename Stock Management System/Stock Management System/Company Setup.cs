using Stock_Management_System.BLL;
using Stock_Management_System.Models;
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

namespace Stock_Management_System
{
    public partial class Company_Setup : Form
    {
        CompanyManager _companyManager;
        CompanyModel company;

      
        public Company_Setup()
        {
            InitializeComponent();


            _companyManager = new CompanyManager();
            company = new CompanyModel();
            //company DataGridView  functoin call
            companyDataGridView.DataSource = _companyManager.LoadToCompanyFunction();

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            company.CompanyName = companyTextBox.Text;

            if (String.IsNullOrEmpty(companyTextBox.Text))
            {
                MessageBox.Show("Enter a Company Name");
                return;
            }

            // function call 
           MessageBox.Show( _companyManager.IsExistOrInsert(company));

            // Company DataGridView function call 
           
           companyDataGridView.DataSource = _companyManager.LoadToCompanyFunction();
        }

        

        private void CompanyDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)

            {

                //textBox1.Visible = textBox2.Visible = textBox3.Visible = true;

                //textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                //textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                companyTextBox.Text = companyDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                SaveButton.Text = "Update";

            }
        }
    }
}
