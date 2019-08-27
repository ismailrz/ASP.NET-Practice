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
    class StockInRepository
    {
        string connectionString;
        SqlConnection sqlConnection;
        string commandString;
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;
        DataTable datatable;

        public StockInRepository()
        {
            //connectionString
            connectionString = @"Server =DESKTOP-3K97P4H\SQLEXPRESS; Database =StockManagementSystem; Integrated Security = true";
            sqlConnection = new SqlConnection(connectionString);
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
        public DataTable LoadToItemSetupComboBox()
        {

            try
            {
                // commandString 
                string commandString = "Select * from  Items";
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
        public string ReorderLevelTextBoxFunction(ItemModel itemModel)
        {
            string value = "";
            try
            {
                //connectionString
                string connectionString = @"Server =DESKTOP-3K97P4H\SQLEXPRESS; Database =StockManagementSystem; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;

                string commandStringFind = "Select * from  Items Where CategoryName = '" + itemModel.CategoryName + "' and CompanyName = '" +itemModel.CompanyName + "' and ItemName = '" + itemModel.ItemName + "'";
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = commandStringFind;
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();


                //commandSting for Existing Category Checked

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable datatable = new DataTable();
                int count = 0;
                count = adapter.Fill(datatable);
                //
                if (count > 0)
                {
                   value = datatable.Rows[0]["ReorderLevel"].ToString();

                }
                else
                {
                    value = "0";

                }


                // ReorderLevelTextBox.Text = "2109";
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                value = exception.ToString();
            }

            return value;
        }
    }
}
