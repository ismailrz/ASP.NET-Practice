using Stock_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System.Repository
{
    class CategoryRepository
    {
        string connectionString;
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        string commandString;
        SqlDataAdapter adapter;
        DataTable datatable;
        public CategoryRepository()
        {
            connectionString = @"Server =DESKTOP-3K97P4H\SQLEXPRESS; Database =StockManagementSystem; Integrated Security = true";
            sqlConnection = new SqlConnection(connectionString);
        }
        public bool IsCategoryUnique(CategoryModel category)
        {
            bool isUnique = true;
            try
            {
                
                //connectionString
                commandString = "Select * from  Category where CategoryName = '" + category.CategoryName + "'";
                sqlCommand = new SqlCommand(commandString,sqlConnection);                
                sqlConnection.Open();
                //commandSting for Existing Category Checked            
                adapter = new SqlDataAdapter(sqlCommand);
                datatable = new DataTable();
                adapter.Fill(datatable);

                if (datatable.Rows.Count > 0)
                {
                    isUnique = false;
                }
                sqlConnection.Close();
                
            }catch(Exception e)
            {
                
            }
            return isUnique;
        }
        public string InsertCategory(CategoryModel category)
        {
            try
            {              
                // commandString for insert Category in Database
                commandString = "insert into Category Values('" + category.CategoryName + "')";
                sqlCommand = new SqlCommand(commandString, sqlConnection);               
                sqlConnection.Open();
                int count = 0;
                count = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                if (count > 0)
                {
                    return "Category Insert Successfully !!";
                }
                else
                {
                    return " Insert Failed \n Try Again";
                }
                
            }catch(Exception e)
            {
                return e.Message;
            }

        }
        public DataTable LoadCategoryToComboBox()
        {
            DataTable datatable = new DataTable();
            try
            {
                //connectionString
                commandString = "Select * from  Category";
                sqlCommand = new SqlCommand(commandString, sqlConnection);
                sqlConnection.Open();
                //commandSting for Existing Category Checked               
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);               
                adapter.Fill(datatable);

                //categoryDataGridView.DataSource = datatable;
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.Message);
            }
            return datatable;
        }
    }
}
