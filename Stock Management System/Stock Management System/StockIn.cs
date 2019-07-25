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
    public partial class StockIn : Form
    {
        public StockIn()
        {
            InitializeComponent();

        }

        private void StockIn_Load(object sender, EventArgs e)
        {
            LoadToDisplayDataGridViewFunction();
            LoadToCategoryComboBox();
            LoadToCompanyComboBox();
            LoadToItemComboBox();
            ReorderLevelTextBoxFunction();
            AvailableQuantityFunction();

        }
        private void LoadToDisplayDataGridViewFunction()
        {
            try
            {
                //connectionString
                string connectionString = @"Server =DESKTOP-3K97P4H\SQLEXPRESS; Database =StockManagementSystem; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;

                string commandString = "Select * from  StockIn";
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = commandString;
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();


                //commandSting for Existing Category Checked


                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                //
                DisplayDataGridView.DataSource = datatable;

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
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
                CategoryComboBox.DataSource = datatable;

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
                CompanyComboBox.DataSource = datatable;

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void LoadToItemComboBox()
        {
            try
            {
                //connectionString
                string connectionString = @"Server =DESKTOP-3K97P4H\SQLEXPRESS; Database =StockManagementSystem; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;

                string commandStringFind = "Select * from  Items";
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = commandStringFind;
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();


                //commandSting for Existing Category Checked

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                //
                ItemComboBox.DataSource = datatable;

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void AvailableQuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ReorderLevelTextBoxFunction()
        {
            try
            {
                //connectionString
                string connectionString = @"Server =DESKTOP-3K97P4H\SQLEXPRESS; Database =StockManagementSystem; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;

                string commandStringFind = "Select * from  Items Where CategoryName = '" + CategoryComboBox.Text + "' and CompanyName = '" + CompanyComboBox.Text + "' and ItemName = '" + ItemComboBox.Text + "'";
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = commandStringFind;
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();


                //commandSting for Existing Category Checked

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable datatable = new DataTable();
                int count = 0;
                count = adapter.Fill(datatable);
                //
                if (count > 0)
                {
                    ReorderLevelTextBox.Text = datatable.Rows[0]["ReorderLevel"].ToString();

                }
                else
                {
                    ReorderLevelTextBox.Text ="0";

                }


                // ReorderLevelTextBox.Text = "2109";
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void AvailableQuantityFunction()
        {
            try
            {
                //connectionString
                string connectionString = @"Server =DESKTOP-3K97P4H\SQLEXPRESS; Database =StockManagementSystem; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;

                string commandStringFind = "Select * from StockIn Where CategoryName = '" + CategoryComboBox.Text + "' and CompanyName = '" + CompanyComboBox.Text + "' and ItemName = '" + ItemComboBox.Text + "'";
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = commandStringFind;
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();


                //commandSting for Existing Category Checked

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable datatable = new DataTable();
                int count = 0;
                count = adapter.Fill(datatable);
                //
                if (count >0 )
                {
                    int quantity = (Convert.ToInt32(datatable.Rows[0]["AvailableQuantity"].ToString()) - Convert.ToInt32(ReorderLevelTextBox.Text.ToString()));
                    if(quantity >-1)
                    {
                        AvailableQuantityTextBox.Text = quantity.ToString();
                    }
                    else
                    {
                        AvailableQuantityTextBox.Text = "Unavailable";
                    }

                }
                else
                {
                    AvailableQuantityTextBox.Text = "0";

                }


                // ReorderLevelTextBox.Text = "2109";
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void ItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReorderLevelTextBoxFunction();
            AvailableQuantityFunction();

        }

        private void CompanyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReorderLevelTextBoxFunction();
            AvailableQuantityFunction();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReorderLevelTextBoxFunction();
            AvailableQuantityFunction();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(CategoryComboBox.Text))
            {
                MessageBox.Show("Select a Category Name");
                return;
            }
            if (String.IsNullOrEmpty(CompanyComboBox.Text))
            {
                MessageBox.Show("Select a Company Name");
                return;
            }
            if (String.IsNullOrEmpty(ItemComboBox.Text))
            {
                MessageBox.Show("Select a Item Name");
                return;
            }

            if (String.IsNullOrEmpty(StockInQuantityTextBox.Text))
            {
                MessageBox.Show("Enter Stock in Quantity !!");
                return;
            }

            try
            {
                //connectionString
                string connectionString = @"Server =DESKTOP-3K97P4H\SQLEXPRESS; Database =StockManagementSystem; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;
                sqlConnection.Open();

                //commandSting for Existing Category Checked
                string commandStringFind = "Select * from  StockIn Where CategoryName = '"+CategoryComboBox.Text+"' and CompanyName = '"+CompanyComboBox.Text+"' and ItemName = '"+ItemComboBox.Text+"'";
                SqlDataAdapter adapter = new SqlDataAdapter(commandStringFind, sqlConnection);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);

                if (datatable.Rows.Count > 0)
                {

                    int quantity =Convert.ToInt32(StockInQuantityTextBox.Text) +Convert.ToInt32(datatable.Rows[0]["AvailableQuantity"].ToString());
                    // commandString for insert Category in Database
                    string commandString = "Update StockIn Set AvailableQuantity = " + quantity+" Where CategoryName = '" + CategoryComboBox.Text + "' and CompanyName = '" + CompanyComboBox.Text + "' and ItemName = '" + ItemComboBox.Text + "'";
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = commandString;
                    sqlCommand.Connection = sqlConnection;

                    int count = 0;
                    count = sqlCommand.ExecuteNonQuery();

                    if (count > 0)
                    {
                        MessageBox.Show(" Data Update Successful !!");
                    }
                    else
                    {
                        MessageBox.Show(" Update Failed \n Try Again");
                    }
                }
                else {
                    // commandString for insert Category in Database
                    string commandString = "insert into StockIn Values('" + CategoryComboBox.Text + "','" + CompanyComboBox.Text + "','" + ItemComboBox.Text + "'," + StockInQuantityTextBox.Text + "," + ReorderLevelTextBox.Text + ",GETDATE())";
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = commandString;
                    sqlCommand.Connection = sqlConnection;

                    int count = 0;
                    count = sqlCommand.ExecuteNonQuery();

                    if (count > 0)
                    {
                        MessageBox.Show(" Data Save Successful !!");
                    }
                    else
                    {
                        MessageBox.Show(" Save Failed \n Try Again");
                    }


                }

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
            
            //Display DridView function call after Press Save Button
            LoadToDisplayDataGridViewFunction();

        }
    }
}
