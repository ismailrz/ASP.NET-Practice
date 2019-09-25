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
    class StudentRepository
    {
        string connectionString;
        string commadString;
        SqlCommand sqlCommand;
        SqlConnection sqlConnection;
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;

        public StudentRepository()
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
        public string IsExistOrInsert(Student student)
        {
            string exist = "";

            try
            {
                commadString = "SELECT * FROM Students WHERE ID = '" + student.ID + "'";
                sqlCommand = new SqlCommand(commadString, sqlConnection);

                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    exist = student.ID + " is exist \n Please insert a new ID ";
                }
                sqlConnection.Close();

                if (String.IsNullOrEmpty(exist))
                {
                    commadString = "INSERT INTO Students VALUES('" + student.ID + "','" + student.Name + "','" + student.Dept_name + "'," + student.Total_credit+ ")";
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
