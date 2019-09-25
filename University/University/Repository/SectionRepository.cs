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
    class SectionRepository
    {
  
        string connectionString;
        string commadString;
        SqlCommand sqlCommand;
        SqlConnection sqlConnection;
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;
        public SectionRepository()
        {
            connectionString = @"Server=DESKTOP-3K97P4H\SQLEXPRESS ;Database=University ; Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
        }
        public DataTable GetCourseTocomboBox()
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
         public DataTable GetBuildingAndRoomNumberTocomboBox()
        {
            commadString = "SELECT * FROM ClassRooms";
            sqlCommand = new SqlCommand(commadString, sqlConnection);

            sqlConnection.Open();

            sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);


            sqlConnection.Close();

            return dataTable;
        }

        public string IsExistOrInsert(Section section)
        {
            string exist = "";

            try
            {
                commadString = "SELECT * FROM Sections WHERE course_id ='"+section.Course_id+"' AND sec_id ='"+section.sec_id+"' AND semester = '"+section.Semester+"' AND year ="+section.Year+"";
                //commadString = "SELECT * FROM Sections WHERE course_id ='"+section.Course_id+"' AND sec_id ='"+section.sec_id + "' AND semester = '"+section.Semester+"' AND year ="+section.Year+"";
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
                    commadString = "INSERT INTO Sections VALUES('"+section.Course_id+"','"+section.sec_id+"','"+section.Semester+"',"+section.Year+",'"+section.Building+"','"+section.Room_number+"','"+section.Time_slot_id+"')";
                   // commadString = "INSERT INTO Sections VALUES('"+section.Course_id+"','"+section.sec_id + "','"+section.Semester+"',"+section.Year+",'"+section.Building+"','"+section.Room_number+"','"+section.Time_slot_id+"')";
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
