using Stock_Management_System.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System.Repository
{
    class CompanyRepository
    {
        string connectionString;
        SqlConnection sqlConnection;
        string commandString;
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;
        DataTable datatable;
        
        public CompanyRepository()
        {
            //connectionString
            connectionString = @"Server =DESKTOP-3K97P4H; Database =StockManagementSystem; Integrated Security = true";
            sqlConnection = new SqlConnection(connectionString);
        }
        public string IsExistOrInsert(CompanyModel company)
        {
            string check;
            try
            {
               
                //commandSting for Existing Company Checked
                 commandString = "Select * from  Company where CompanyName = ('" + company.CompanyName + "')";
                 sqlCommand = new SqlCommand(commandString, sqlConnection);

                // connection open
                sqlConnection.Open();

                //Execute
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                datatable = new DataTable();
                sqlDataAdapter.Fill(datatable);


                if (datatable.Rows.Count > 0)
                {
                    // if company exists
                    check = company.CompanyName+" Company already Exists!! \n Please insert new company";
                }
                else
                {
                    // commandString for insert Category in Database
                    commandString = "insert into Company Values('" + company.CompanyName + "')";
                    sqlCommand = new SqlCommand(commandString,sqlConnection);
                    int count = 0;
                   count = sqlCommand.ExecuteNonQuery();
                    if (count > 0)
                    {
                        check = company.CompanyName +" Company Insert Successfull !!";
                    }
                    else
                    {
                        check = "Data Insert Failed \n try Again !!";
                    }
                }

                //connection close
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                check = exception.ToString();
            }
            return check;
        }

        public DataTable LoadToCompanyFunction()
        {
  
            try
            {
     
                //commandSting for Existing Company Checked
                commandString = "Select * from  Company";
                sqlCommand = new SqlCommand(commandString, sqlConnection);
               
                //connection open
                sqlConnection.Open();
                // Execute
                 sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                 datatable = new DataTable();
                sqlDataAdapter.Fill(datatable);

                //connection close
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                datatable.Rows[0][0] = exception +" or Company is not available  \n Please Insert Company Name !!";
            }

            return datatable;
        }
    }
}
