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
    public partial class MobileUi : Form
    {
        public MobileUi()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(IdTextbox.Text))
            {
                MessageBox.Show("Id cannot empty!!");
                return;
            }
            if (String.IsNullOrEmpty(ModelNameTexbox.Text))
            {
                MessageBox.Show("Model Name cannot empty!!");
                return;
            }
            if (String.IsNullOrEmpty(IMEITextbox.Text))
            {
                MessageBox.Show("IMEI cannot empty!!");
                return;
            }
            if (String.IsNullOrEmpty(PriceTextbox.Text))
            {
                MessageBox.Show("Price cannot empty!!");
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
                string commandString = "Insert into Mobiles Values("+IdTextbox.Text+",'"+ModelNameTexbox.Text+"',"+IMEITextbox.Text+","+PriceTextbox.Text+")";
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = commandString;
                sqlCommand.Connection = sqlConnection;

                //execute
                int count = 0;
                count = sqlCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Data Insert Successful !!");
                }
                else
                {
                    MessageBox.Show("Failed to Isert \n Try again");
                }
                //connection closed
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void InformationLabel_Click(object sender, EventArgs e)
        {
            IndexUi indexUi = new IndexUi();
            indexUi.Show();
            this.Hide();
        }

        private void SearchIMEILabel_Click(object sender, EventArgs e)
        {
            SearchByIMEI searchByIMEI = new SearchByIMEI();
            searchByIMEI.Show();
            this.Hide();
        }

        private void SearchPriceabel_Click(object sender, EventArgs e)
        {
            SearchByPrice searchByPrice = new SearchByPrice();
            searchByPrice.Show();
            this.Hide();
        }
    }
}
