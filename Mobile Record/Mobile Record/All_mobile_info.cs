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

namespace Mobile_Record
{
    public partial class All_mobile_info : Form
    {
        public All_mobile_info()
        {
            InitializeComponent();

            try
            {
                //connectionString 
                string connectionString = @"Server =DESKTOP-3K97P4H\SQLEXPRESS; Database = MobileDB ; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;

                //connection open
                sqlConnection.Open();

                // commandString
                string commandString = "select * from Mobiles";
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = commandString;
                sqlCommand.Connection = sqlConnection;

                //execute

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);


                allDataGridView.DataSource = dataTable;



                //connection closed
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void AllDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
          

            try
            {
                //connectionString 
                string connectionString = @"Server =DESKTOP-3K97P4H\SQLEXPRESS; Database = MobileDB ; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;

                //connection open
                sqlConnection.Open();

                // commandString
               string commandString = "select * from Mobiles";
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = commandString;
                sqlCommand.Connection = sqlConnection;

                //execute

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);


                allDataGridView.DataSource = dataTable;



                //connection closed
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void SearchIMEILabel_Click(object sender, EventArgs e)
        {
            IndexUi indexUi = new IndexUi();
            indexUi.Show();
            this.Hide();
        }
    }
}
