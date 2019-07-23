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
    public partial class SearchByIMEI : Form
    {
        public SearchByIMEI()
        {
            InitializeComponent();
            Mobile mobile = new Mobile();
            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(SearchIMEITextBox.Text))
            {
                MessageBox.Show("IMEI can`t empty!!");
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
                string commandString = "select * from Mobiles where IMEI= " + SearchIMEITextBox.Text + " ";
                //string commandString = "select * from Mobiles";

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = commandString;
                sqlCommand.Connection = sqlConnection;

                //execute

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
               
                if (dataTable.Rows.Count > 0)
                {  
                        mobileNameLable.Text = dataTable.Rows[0]["ModelName"].ToString();
                        imeiLabel.Text = dataTable.Rows[0]["IMEI"].ToString();
                        priceLabel.Text = dataTable.Rows[0]["Price"].ToString();                  
                }
                else
                {
                    MessageBox.Show("Data show Failed");
                }
                //connection closed
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void SearchPriceabel_Click(object sender, EventArgs e)
        {
            SearchByPrice searchByPrice = new SearchByPrice();
            searchByPrice.Show();
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
