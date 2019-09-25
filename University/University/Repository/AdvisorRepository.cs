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
    class AdvisorRepository
    {
        string connectionString;
        string commadString;
        SqlCommand sqlCommand;
        SqlConnection sqlConnection;
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;
        public AdvisorRepository()
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
  
        public string IsExistOrInsert(Advisor advisor)
        {
            string exist = "";

            try
            {
                sqlConnection.Open();
                commadString = "SELECT * FROM Advisors WHERE s_ID = '"+advisor.S_id+"'";
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
                    commadString = "INSERT INTO Advisors VALUES('"+advisor.S_id+"','"+advisor.I_id+"')";
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
