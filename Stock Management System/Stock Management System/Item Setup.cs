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
    public partial class Item_Setup : Form
    {
        public Item_Setup()
        {
            InitializeComponent();
        }
        private void Item_Setup_Load(object sender, EventArgs e)
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
                categoryComboBox.DataSource = datatable;
                
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
                companyComboBox.DataSource = datatable;

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(categoryComboBox.Text))
            {
                MessageBox.Show("Select a Category Name !!");
                return;
            }
            if (String.IsNullOrEmpty(companyComboBox.Text))
            {
                MessageBox.Show("Select a Company Name !!");
                return;
            }

            if (String.IsNullOrEmpty(itemTextBox.Text))
            {
                MessageBox.Show("Enter an Item Name !!");
                return;
            }
            if (String.IsNullOrEmpty(ReorderLevelTextBox.Text))
            {
                MessageBox.Show(" Reorder cannot empty !!");
                return;
            }
            ItemModel itemModel;
            itemModel = new ItemModel();
            itemModel.CompanyName = companyComboBox.Text;
            itemModel.CategoryName = categoryComboBox.Text;
            itemModel.ItemName = itemTextBox.Text;
            itemModel.ReorderLevel = Convert.ToInt32(ReorderLevelTextBox.Text);
            try
            {
                //connectionString
                string connectionString = @"Server =DESKTOP-3K97P4H\SQLEXPRESS; Database =StockManagementSystem; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;
                sqlConnection.Open();

                //commandSting for Existing Category Checked
                string commandStringFind = "Select * from  Items where CategoryName = ('" + itemModel.CategoryName + "') AND CompanyName = ('" + itemModel.CompanyName + "') AND ItemName = ('" + itemModel.ItemName + "') ";
                SqlDataAdapter adapter = new SqlDataAdapter(commandStringFind, sqlConnection);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);

                if (datatable.Rows.Count > 0)
                {
                    MessageBox.Show("Item Name  " + itemTextBox.Text + "  already Exist!! \n Please inter a new Item !!");
                    return;
                }
                else
                {

                    // commandString for insert Category in Database
                    string commandString = "insert into Items Values('" + categoryComboBox.Text + "','" + companyComboBox.Text + "','" + itemTextBox.Text + "'," + ReorderLevelTextBox.Text + ")";
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = commandString;
                    sqlCommand.Connection = sqlConnection;

                    int count = 0;
                    count = sqlCommand.ExecuteNonQuery();

                    if (count > 0)
                    {
                        MessageBox.Show("Item Insert Successfully !!");
                    }
                    else
                    {
                        MessageBox.Show(" Insert Failed \n Try Again");
                    }


                }
                ///connection close
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

       
    }
}
