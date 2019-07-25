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
    public partial class Search_and_View_Items_Summary : Form
    {
        string commandStringFind = "";
        public Search_and_View_Items_Summary()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            

            if (String.IsNullOrEmpty(CategoryNameComboBox.Text) && String.IsNullOrEmpty(CompanyNameComboBox.Text))
            {
                MessageBox.Show("Select Category Name and/or Company Name !!");
            }
         
            try
            {
                //connectionString
                string connectionString = @"Server =DESKTOP-3K97P4H\SQLEXPRESS; Database =StockManagementSystem; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;

               // commandSting for Existing Category Checked

                if (!String.IsNullOrEmpty(CategoryNameComboBox.Text) && !String.IsNullOrEmpty(CompanyNameComboBox.Text))
                    {
                        commandStringFind = "Select * from  StockIn Where CategoryName = '" + CategoryNameComboBox.Text + "' and CompanyName = '" + CompanyNameComboBox.Text + "'";

                    }
                    else if (!String.IsNullOrEmpty(CategoryNameComboBox.Text) || !String.IsNullOrEmpty(CompanyNameComboBox.Text))
                    {
                        commandStringFind = "Select * from  StockIn Where CategoryName = '" + CategoryNameComboBox.Text + "' or CompanyName = '" + CompanyNameComboBox.Text + "'";

                    }

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = commandStringFind;
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                if (datatable.Rows.Count > 0)
                {
                    DisplayDataGridView.DataSource = datatable;

                }
                else
                {
                    DisplayDataGridView.DataSource = "Data Not Available";
                }

                ///connection close
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Search_and_View_Items_Summary_Load(object sender, EventArgs e)
        {
            LoadToCategoryComboBox();
            LoadToCompanyComboBox();
          
        }
        private void LoadToCategoryComboBox()
        {
            try
            {
                //connectionString
                string connectionString = @"Server =DESKTOP-3K97P4H\SQLEXPRESS; Database =StockManagementSystem; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;

                string commandString = "Select * from  Category";
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = commandString;
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();


                //commandSting for Existing Category Checked


                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                //
                CategoryNameComboBox.DataSource = datatable;

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void LoadToCompanyComboBox()
        {
            try
            {
                //connectionString
                string connectionString = @"Server =DESKTOP-3K97P4H\SQLEXPRESS; Database =StockManagementSystem; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;

                string commandStringFind = "Select * from  Company";
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = commandStringFind;
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();


                //commandSting for Existing Category Checked

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                //
               CompanyNameComboBox.DataSource = datatable;

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

    }
}
