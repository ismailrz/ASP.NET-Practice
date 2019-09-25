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
    class PreReqRepository
    {
        string connectionString;
        string commadString;
        SqlCommand sqlCommand;
        SqlConnection sqlConnection;
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;
        public PreReqRepository()
        {
            connectionString = @"Server=DESKTOP-3K97P4H\SQLEXPRESS ;Database=University ; Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
        }
       
        public DataTable GetCourseIdTocomboBox()
        {
            commadString = "SELECT * FROM Courses";
            sqlCommand = new SqlCommand(commadString, sqlConnection);

            sqlConnection.Open();

            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);


            sqlConnection.Close();

            return dataTable;

        }

        public string IsExistOrInsert(Prereq prereq)
        {
            string exist = "";

            try
            {
                sqlConnection.Open();
                commadString = "SELECT * FROM prereqs WHERE course_id = '"+prereq.Course_id+"' AND prereq_id = '"+prereq.Prereq_id+"'";
                sqlCommand = new SqlCommand(commadString, sqlConnection);


                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    exist = "Data  is exist \n Please check duplicated data";
                }
                sqlConnection.Close();

                if (String.IsNullOrEmpty(exist))
                {
                    sqlConnection.Open();
                    commadString = "INSERT INTO prereqs VALUES('"+prereq.Course_id+"','"+prereq.Prereq_id+"')";
                    sqlCommand = new SqlCommand(commadString, sqlConnection);

                    sqlCommand.ExecuteNonQuery();

                    sqlConnection.Close();
                }

            }
            catch (Exception exception)
            {
                sqlConnection.Close();
            }

            return exist;
        }
    }
}
