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
    class InstructorRepository
    {
        string connectionString;
        string commadString;
        SqlCommand sqlCommand;
        SqlConnection sqlConnection;
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;

      public InstructorRepository()
        {

            connectionString = @"Server=DESKTOP-3K97P4H\SQLEXPRESS ;Database=University ; Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
        }

        public DataTable GetDepartmentTocomboBox()
        {
            commadString = "SELECT * FROM Departments";
            sqlCommand = new SqlCommand(commadString, sqlConnection);

            sqlConnection.Open();

            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);


            sqlConnection.Close();

            return dataTable;
        }
        public string IsExistOrInsert(Instructor instructor)
        {
            string exist="";

            try {
                commadString = "SELECT * FROM Instructors WHERE ID = '"+instructor.ID+"'";
                sqlCommand = new SqlCommand(commadString, sqlConnection);

                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if(dataTable.Rows.Count > 0)
                {
                    exist = instructor.ID + " is exist \n Please insert a new ID ";
                }
                sqlConnection.Close();

                if (String.IsNullOrEmpty(exist))
                {
                    commadString = "INSERT INTO Instructors VALUES('" + instructor.ID + "','" + instructor.Name + "','" + instructor.Dept_name + "'," + instructor.Salary + ")";
                    sqlCommand = new SqlCommand(commadString, sqlConnection);

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
