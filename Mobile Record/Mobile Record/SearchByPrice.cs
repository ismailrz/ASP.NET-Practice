using Mobile_Record.Models;
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
    public partial class SearchByPrice : Form
    {
        
        public SearchByPrice()
        {
            InitializeComponent();          
            
        }
        private void SearchButton_Click(object sender, EventArgs e)        
        {
            if (String.IsNullOrEmpty(minPriceTextBox1.Text))
            {
                MessageBox.Show("minimux  range empty!!");
                return;

            }
            if (String.IsNullOrEmpty(maxPriveTextBox.Text))
            {
                MessageBox.Show("Maximum range cannot empty!!");
                return;
            }
            
            
            try
            {
                //connectionString 
                string connectionString = @"Server =DESKTOP-3K97P4H\SQLEXPRESS; Database = MobileDB ; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;

                //connection open
                sqlConnection.Open();

                // commandString
                string commandString = "select * from Mobiles where Price >="+minPriceTextBox1.Text+" and  Price <="+maxPriveTextBox.Text+" ";
                //string commandString = "select * from Mobiles";

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = commandString;
                sqlCommand.Connection = sqlConnection;

                //execute

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                //int i = dataTable.Rows.Count;
                //string allInfor = "Sl#\t\tModel Name\tIMEI\t\tPrice";
                //if (dataTable.Rows.Count > 0)
                //{
                //    while (i > 0)
                //    {
                //        allInfor += "\n"+ dataTable.Rows[i - 1]["id"].ToString() + "\t\t" + dataTable.Rows[i - 1]["ModelName"].ToString() + "\t\t"+ dataTable.Rows[i - 1]["IMEI"].ToString() + "\t\t"+ dataTable.Rows[i - 1]["Price"].ToString() ;
                //        i--;
                //    }

                //    // MessageBox.Show(allInfor);
                //   // RichTextBox.Text = allInfor;
                //}
                //else
                //{
                //    MessageBox.Show("Data show Failed");
                //}

                displayDataGridView.DataSource = dataTable;
               


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
            SearchByIMEI searchByIMEI = new SearchByIMEI();
            searchByIMEI.Show();
            this.Hide();
        }

        private void InformationLabel_Click(object sender, EventArgs e)
        {
            MobileUi mobileUi = new MobileUi();
            mobileUi.Show();
            this.Hide();
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            IndexUi indexUi = new IndexUi();
            indexUi.Show();
            this.Hide();
        }

       
    }
}
