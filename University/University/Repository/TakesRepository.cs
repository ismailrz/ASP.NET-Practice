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
    class TakesRepository
    {
        string connectionString;
        string commadString;
        SqlCommand sqlCommand;
        SqlConnection sqlConnection;
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;
        public TakesRepository()
        {
            connectionString = @"Server=DESKTOP-3K97P4H\SQLEXPRESS ;Database=University ; Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
        }
        public DataTable GetStudentIdTocomboBox()
        {
            commadString = "SELECT * FROM Students";
            sqlCommand = new SqlCommand(commadString, sqlConnection);

            sqlConnection.Open();

            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);


            sqlConnection.Close();

            return dataTable;
        }
        public DataTable GetSectionsTableTocomboBox()
        {
            commadString = "SELECT * FROM Sections";
            sqlCommand = new SqlCommand(commadString, sqlConnection);

            sqlConnection.Open();

            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);


            sqlConnection.Close();

            return dataTable;
        }

        public string IsExistOrInsert(Takes takes)
        {
            string exist = "";

            try
            {
                commadString = "SELECT * FROM Takes WHERE ID ='"+takes.ID+"' AND course_id ='"+takes.Course_id+"' AND sec_id ='"+takes.sec_id + "' AND semester = '"+takes.Semester+"' AND year ="+takes.Year+"";
                sqlCommand = new SqlCommand(commadString, sqlConnection);

                sqlConnection.Open();
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
                    commadString = "INSERT INTO Takes VALUES('"+takes.ID+"','"+takes.Course_id+"','"+takes.sec_id+"','"+takes.Semester+"',"+takes.Year+",'"+takes.Grade+"')";
                   // commadString = "INSERT INTO Takes VALUES('"+takes.ID+"','"+takes.Course_id+"','"+takes.sec_id + "','"+takes.Semester+"',"+takes.Year+",'"+takes.Grade+"')";
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
