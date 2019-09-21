using System;
using System.Collections.Generic;
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
    }
}
