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
   

    public class ClassRoomRepository
    {
        string connectionString;
        string commandString;
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;
        public ClassRoomRepository()
        {
            connectionString = @"Server=DESKTOP-3K97P4H\SQLEXPRESS ;Database=University ; Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
        }

        public string IsExistOrInsert(Classroom classroom)
        {
            string exist="";
            try {
               
                commandString = "SELECT * FROM ClassRooms WHERE building='"+classroom.Building+"' AND room_number ='"+classroom.RoomNumber+"'";
                sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();

                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    exist = classroom.Building+ " and "+ classroom.RoomNumber +" are exist \n\t Please enter a new building and room number!!!";
                   
                }
                sqlConnection.Close();

                if (String.IsNullOrEmpty(exist))
                {
                    commandString = "Insert INTO ClassRooms VALUES('"+classroom.Building+"','"+classroom.RoomNumber+"',"+classroom.Capacity+")";
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
