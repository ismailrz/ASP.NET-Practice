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
    public partial class Category_Setup : Form
    {
        public Category_Setup()
        {
            InitializeComponent();

            // Category Functon Call
            LoadToCategoryFunction();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(categoryTextBox.Text))
            {
                MessageBox.Show("Enter a Category Name");
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
                string commandStringFind = "Select * from  Category where CategoryName = ('" + categoryTextBox.Text + "')";
                SqlDataAdapter adapter = new SqlDataAdapter(commandStringFind, sqlConnection);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);

                if (datatable.Rows.Count > 0)
                {
                    MessageBox.Show("Category " + categoryTextBox.Text + "  already Exist!!");
                    return;
                }
                else
                {
                    // commandString for insert Category in Database
                    string commandString = "insert into Category Values('" + categoryTextBox.Text + "')";
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = commandString;
                    sqlCommand.Connection = sqlConnection;

                    int count = 0;
                    count = sqlCommand.ExecuteNonQuery();

                    if (count > 0)
                    {
                        MessageBox.Show("Category Insert Successfully !!");
                    }
                    else
                    {
                        MessageBox.Show(" Insert Failed \n Try Again");
                    }

                }


                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            // Category Function call
            LoadToCategoryFunction();

        }

        private void LoadToCategoryFunction()
        {
            try
            {
                //connectionString
                string connectionString = @"Server =DESKTOP-3K97P4H\SQLEXPRESS; Database =StockManagementSystem; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;
                sqlConnection.Open();


                //commandSting for Existing Category Checked
                string commandStringFind = "Select * from  Category";
                SqlDataAdapter adapter = new SqlDataAdapter(commandStringFind, sqlConnection);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);

                categoryDataGridView.DataSource = datatable;


                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void CategoryDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)

            {

                //textBox1.Visible = textBox2.Visible = textBox3.Visible = true;

                //textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                //textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                categoryTextBox.Text = categoryDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                SaveButton.Text ="Update";

            }

        }
    }
}
