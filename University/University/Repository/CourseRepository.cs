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
    class CourseRepository
    {
        string connectionString;
        string commandString;
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;
        public CourseRepository()
        {
            connectionString = @"Server=DESKTOP-3K97P4H\SQLEXPRESS ;Database=University ; Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
        }

        public DataTable GetDepartmentsToComboBox()
        {
            try
            {
                commandString = "SELECT * FROM Departments";
                sqlCommand = new SqlCommand(commandString, sqlConnection);
                sqlConnection.Open();

                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);


                sqlConnection.Close();
            }
            catch (Exception ex)
            {

            }

            return dataTable;
        
        }
        public string IsExistOrInsert(Course course)
        {
            string exist = "";
            try
            {

                commandString = "SELECT * FROM Courses WHERE course_id = '"+course.Course_id+"'";
                sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();

                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    exist = course.Course_id+ " is exist \n\t Please enter a new course ID !!!";

                }
                sqlConnection.Close();

                if (String.IsNullOrEmpty(exist))
                {
                    commandString = "INSERT INTO Courses VALUES('"+course.Course_id+"','"+course.Title+"','"+course.Dept_name+"',"+course.Credit+")";
                    sqlCommand = new SqlCommand(commandString, sqlConnection);

                    sqlConnection.Open();

                    sqlCommand.ExecuteNonQuery();

                    sqlConnection.Close();
                }
            }
            catch (Exception exception)
            {

            }
            return exist;
        }



    }
}
