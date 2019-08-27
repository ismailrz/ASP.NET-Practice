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
    class ItemSetupRepository
    {

        string connectionString;
        SqlConnection sqlConnection;
        string commandString;
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;
        DataTable datatable;

     

        public ItemSetupRepository()
        {
            //connectionString
            connectionString = @"Server =DESKTOP-3K97P4H\SQLEXPRESS; Database =StockManagementSystem; Integrated Security = true";
            sqlConnection = new SqlConnection(connectionString);
        }

        public string IsExistOrInsert(ItemModel Item)
        {
            string check = "";
            try
            {

                //commandSting for Existing Company Checked
                commandString = "Select * from  Items where CategoryName = ('" + Item.CompanyName + "') and CompanyName = ('" + Item.CompanyName + "') and ItemName = ('" + Item.ItemName + "')";
                sqlCommand = new SqlCommand(commandString, sqlConnection);

                // connection open
                sqlConnection.Open();

                //Execute
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                datatable = new DataTable();
                sqlDataAdapter.Fill(datatable);

                //connection close
                sqlConnection.Close();

                if (datatable.Rows.Count > 0)
                {
                    // if company exists
                    check = Item.ItemName + " Item already Exists!! \n Please insert new Item !!";
                  
                }
                //else
                //{
                //    // connection open
                //    sqlConnection.Open();

                //    // commandString for insert Category in Database
                //    commandString = "insert into Items Values('"+Item.CategoryName+",'"+Item.CompanyName+"','"+Item.ItemName+"',"+Item.ReorderLevel+")";
                //    sqlCommand = new SqlCommand(commandString, sqlConnection);
                //    int count = 0;
                //    count = sqlCommand.ExecuteNonQuery();
                //    if (count > 0)
                //    {
                //        check = Item.ItemName + " Item Insert Successfull !!";
                //    }
                //    else
                //    {
                //        check = "Data Insert Failed \n try Again !!";
                //    }
                //}

                //connection close
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                check = exception.ToString();
            }
            return check;
        }
      
        public DataTable LoadToCategoryComboBox()
        {


            try
            {
                // commandString 
                string commandString = "Select * from  Category";
                sqlCommand = new SqlCommand(commandString, sqlConnection);

                // connection open
                sqlConnection.Open();


                //Execute
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);

                if (datatable.Rows.Count > 0)
                {
                    return datatable;
                }
                else

                    // connection close
                    sqlConnection.Close();
            }
            catch (Exception exception)
            {
              //  datatable.Rows[0]["CategoryName"] = exception + " or Category is not available  \n Please Insert Category Name !!";
            }

            return datatable;
        }
        public DataTable LoadToCompanyComboBox()
        {

            try
            {
                // commandString 
                string commandString = "Select * from  Company";
                sqlCommand = new SqlCommand(commandString, sqlConnection);

                // connection open
                sqlConnection.Open();


                //Execute
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);

                if (datatable.Rows.Count > 0)
                {
                    return datatable;
                }

                // connection close
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
              //  datatable.Rows[0]["CompanyName"] = exception + " or Company is not available  \n Please Insert Company Name !!";
            }
            return datatable;
        }
      
    }
}
