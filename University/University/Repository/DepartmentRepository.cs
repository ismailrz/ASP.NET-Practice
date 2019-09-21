using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Models;
namespace University.Repository
{
    class DepartmentRepository
    {
        string connectionString;
        string commandString;
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;
        public DepartmentRepository()
        {
            connectionString = @"Server=DESKTOP-3K97P4H\SQLEXPRESS ;Database=University ; Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
        }
        public int Save(Department department)
        {
            int isExecuted = 0;
            sqlConnection.Open();
            try
            {
                commandString = "INSERT INTO Departments VALUES('" + department.Dept_Name + "','" + department.Building + "'," + department.Budget + ")";
                sqlCommand = new SqlCommand(commandString, sqlConnection);            
                isExecuted=sqlCommand.ExecuteNonQuery();
            }catch(Exception e)
            {

            }
            sqlConnection.Close();
            return isExecuted;
        }

        public string IsExistOrInsert(Department department)
        {
            string check = "";
            try
            {

                //commandSting for Existing Company Checked
                commandString = "SELECT * From Departments WHERE dept_name = '" + department.Dept_Name + "'";
                sqlCommand = new SqlCommand(commandString, sqlConnection);

                // connection open
                sqlConnection.Open();

                //Execute
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                //connection close
                sqlConnection.Close();

                if (dataTable.Rows.Count > 0)
                {
                    // if company exists
                    check = department.Dept_Name + " Item already Exists!! \n Please insert new Item !!";

                }
                //else
                //{
                //    // connection open
                //    sqlConnection.Open();

                //    // commandString for insert Category in Database
                //    commandString = "insert into Items Values('"+Item.CategoryName+",'"+Item.CompanyName+"','"+Item.ItemName+"',"+Item.ReorderLevel+")";
                //    sqlCommand = new SqlCommand(commandString, sqlConnection);
                //    int count = 0;
                //    count = sqlCommand.ExecuteNonQuery();
                //    if (count > 0)
                //    {
                //        check = Item.ItemName + " Item Insert Successfull !!";
                //    }
                //    else
                //    {
                //        check = "Data Insert Failed \n try Again !!";
                //    }
                //}

                //connection close
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                check = exception.ToString();
            }
            return check;
        }
    }
 
}
