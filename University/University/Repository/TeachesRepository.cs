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
    class TeachesRepository
    {
        string connectionString;
        string commadString;
        SqlCommand sqlCommand;
        SqlConnection sqlConnection;
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;
        public TeachesRepository()
        {
            connectionString = @"Server=DESKTOP-3K97P4H\SQLEXPRESS ;Database=University ; Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
        }
        public DataTable GetInstructorIdTocomboBox()
        {
            commadString = "SELECT * FROM Instructors";
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

        public string IsExistOrInsert(Teaches teaches)
        {
            string exist = "";

            try
            {
                sqlConnection.Open();
                commadString = "SELECT * FROM Teaches WHERE ID ='"+teaches.ID+"' AND course_id ='"+teaches.Course_id+"' AND sec_id ='"+teaches.sec_id+"' AND semester = '"+teaches.Semester+"' AND year ="+teaches.Year+"";
               // commadString = "SELECT * FROM Teaches WHERE ID ='" + teaches.ID + "' AND course_id ='" + teaches.Course_id + "' AND sec_id ='" + teaches.sec_id + "' AND semester = '" + teaches.Semester + "' AND year =" + teaches.Year + "";
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
                    commadString = "INSERT INTO Teaches VALUES('"+teaches.ID+"','"+teaches.Course_id+"','"+teaches.sec_id+"','"+teaches.Semester+"',"+teaches.Year+")";
                   // commadString = "INSERT INTO Teaches VALUES('" + teaches.ID + "','" + teaches.Course_id + "','" + teaches.sec_id + "','" + teaches.Semester + "'," + teaches.Year + ")";
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
