using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management_System
{
    public partial class StockOut : Form
    {
        public StockOut()
        {
            InitializeComponent();
        }

        private void StockOut_Load(object sender, EventArgs e)
        {
            LoadToDisplayDataGridViewFunction();
            LoadToCategoryComboBox();
            LoadToCompanyComboBox();
            LoadToItemComboBox();
            ReorderLevelTextBoxFunction();
            AvailableQuantityFunction();
        }
        private void LoadToDisplayDataGridViewFunction()
        {
            try
            {
                //connectionString
                string connectionString = @"Server =DESKTOP-3K97P4H\SQLEXPRESS; Database =StockManagementSystem; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;

                string commandString = "Select * from  StockOut";
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = commandString;
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();


                //commandSting for Existing Category Checked


                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                //
                DisplayDataGridView.DataSource = datatable;

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void LoadToCategoryComboBox()
        {
            try
            {
                //connectionString
                string connectionString = @"Server =DESKTOP-3K97P4H\SQLEXPRESS; Database =StockManagementSystem; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;

                string commandString = "Select * from  Category";
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = commandString;
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();


                //commandSting for Existing Category Checked


                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                //
                CategoryComboBox.DataSource = datatable;

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void LoadToCompanyComboBox()
        {
            try
            {
                //connectionString
                string connectionString = @"Server =DESKTOP-3K97P4H\SQLEXPRESS; Database =StockManagementSystem; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;

                string commandStringFind = "Select * from  Company";
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = commandStringFind;
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();


                //commandSting for Existing Category Checked

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                //
                CompanyComboBox.DataSource = datatable;

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void LoadToItemComboBox()
        {
            try
            {
                //connectionString
                string connectionString = @"Server =DESKTOP-3K97P4H\SQLEXPRESS; Database =StockManagementSystem; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;

                string commandStringFind = "Select * from  Items";
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = commandStringFind;
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();


                //commandSting for Existing Category Checked

                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                //
                ItemComboBox.DataSource = datatable;

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

       

        private void ReorderLevelTextBoxFunction()
        {
            try
            {
                //connectionString
                string connectionString = @"Server =DESKTOP-3K97P4H\SQLEXPRESS; Database =StockManagementSystem; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;

                string commandStringFind = "Select * from  Items Where CategoryName = '" + CategoryComboBox.Text + "' and CompanyName = '" + CompanyComboBox.Text + "' and ItemName = '" + ItemComboBox.Text + "'";
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
                    ReorderLevelTextBox.Text = datatable.Rows[0]["ReorderLevel"].ToString();

                }
                else
                {
                    ReorderLevelTextBox.Text = "0";

                }


                // ReorderLevelTextBox.Text = "2109";
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void AvailableQuantityFunction()
        {
            try
            {
                //connectionString
                string connectionString = @"Server =DESKTOP-3K97P4H\SQLEXPRESS; Database =StockManagementSystem; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;

                string commandStringFind = "Select * from StockIn Where CategoryName = '" + CategoryComboBox.Text + "' and CompanyName = '" + CompanyComboBox.Text + "' and ItemName = '" + ItemComboBox.Text + "'";
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
                    int quantity = (Convert.ToInt32(datatable.Rows[0]["Quantity"].ToString()) - Convert.ToInt32(ReorderLevelTextBox.Text.ToString()));
                    if (quantity > -1)
                    {
                        AvailableQuantityTextBox.Text = quantity.ToString();
                    }
                    else
                    {
                        AvailableQuantityTextBox.Text = "Unavailable";
                    }

                }
                else
                {
                    AvailableQuantityTextBox.Text = "0";

                }


                // ReorderLevelTextBox.Text = "2109";
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
       


        private void ADDButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(CategoryComboBox.Text))
            {
                MessageBox.Show("Select a Category Name");
                return;
            }
            if (String.IsNullOrEmpty(CompanyComboBox.Text))
            {
                MessageBox.Show("Select a Company Name");
                return;
            }
            if (String.IsNullOrEmpty(ItemComboBox.Text))
            {
                MessageBox.Show("Select a Item Name");
                return;
            }

            if (String.IsNullOrEmpty(StockOutQuantityTextBox.Text))
            {
                MessageBox.Show("Enter Stock Out Quantity !!");
                return;
            }
            int check = 0;
             check = Convert.ToInt32(AvailableQuantityTextBox.Text) - Convert.ToInt32(StockOutQuantityTextBox.Text);
            if (check < 1)
            {
                MessageBox.Show(StockOutQuantityTextBox.Text +" Quantity not avalible \n Please Restock Quantity !!");
                return;
            }
            try
            {
                //connectionString
                string connectionString = @"Server =DESKTOP-3K97P4H\SQLEXPRESS; Database =StockManagementSystem; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;
                sqlConnection.Open();

                //commandSting for Existing StockOut Checked
                string commandStringFind = "Select * from  StockOut Where CategoryName = '" + CategoryComboBox.Text + "' and CompanyName = '" + CompanyComboBox.Text + "' and ItemName = '" + ItemComboBox.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(commandStringFind, sqlConnection);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                //commandSting for Existing StockIn Checked
                string commandStringFind2 = "Select * from  StockIn Where CategoryName = '" + CategoryComboBox.Text + "' and CompanyName = '" + CompanyComboBox.Text + "' and ItemName = '" + ItemComboBox.Text + "'";
                SqlDataAdapter adapter2 = new SqlDataAdapter(commandStringFind2, sqlConnection);
                DataTable datatable2 = new DataTable();
                adapter2.Fill(datatable2);


                if (datatable.Rows.Count > 0)
                {

                    int quantityOut = Convert.ToInt32(datatable.Rows[0]["QuantityOut"].ToString()) + Convert.ToInt32(StockOutQuantityTextBox.Text);
                    int quantityIn = Convert.ToInt32(datatable2.Rows[0]["Quantity"].ToString()) - Convert.ToInt32(StockOutQuantityTextBox.Text);

                    // commandString for StockOut
                    string commandString = "Update StockOut Set QuantityOut = " + quantityOut + " Where CategoryName = '" + CategoryComboBox.Text + "' and CompanyName = '" + CompanyComboBox.Text + "' and ItemName = '" + ItemComboBox.Text + "'";
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = commandString;
                    sqlCommand.Connection = sqlConnection;

                    int count = 0;
                    count = sqlCommand.ExecuteNonQuery();

                    // stock In table update
                    string commandString2 = "Update StockIn Set Quantity = " + quantityIn + " Where CategoryName = '" + CategoryComboBox.Text + "' and CompanyName = '" + CompanyComboBox.Text + "' and ItemName = '" + ItemComboBox.Text + "'";
                    SqlCommand sqlCommand2 = new SqlCommand();
                    sqlCommand2.CommandText = commandString2;
                    sqlCommand2.Connection = sqlConnection;
                   sqlCommand2.ExecuteNonQuery();
                    if (count > 0)
                    {

                        MessageBox.Show(" Data Update Successful !!");
                    }
                    else
                    {
                        MessageBox.Show(" Update Failed \n Try Again");
                    }
                }
                else
                {
                    int quantityIn = Convert.ToInt32(datatable2.Rows[0]["Quantity"].ToString()) - Convert.ToInt32(StockOutQuantityTextBox.Text);

                    // commandString for insert Category in Database
                    string commandString = "insert into StockOut Values('" + CategoryComboBox.Text + "','" + CompanyComboBox.Text + "','" + ItemComboBox.Text + "'," + StockOutQuantityTextBox.Text + ",GETDATE())";
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = commandString;
                    sqlCommand.Connection = sqlConnection;

                    int count = 0;
                    count = sqlCommand.ExecuteNonQuery();
                    // stock In table update
                    string commandString2 = "Update StockIn Set Quantity = " + quantityIn + " Where CategoryName = '" + CategoryComboBox.Text + "' and CompanyName = '" + CompanyComboBox.Text + "' and ItemName = '" + ItemComboBox.Text + "'";
                    SqlCommand sqlCommand2 = new SqlCommand();
                    sqlCommand2.CommandText = commandString2;
                    sqlCommand2.Connection = sqlConnection;
                     sqlCommand2.ExecuteNonQuery();

                    if (count > 0)
                    {
                        MessageBox.Show(" Data Save Successful !!");
                    }
                    else
                    {
                        MessageBox.Show(" Save Failed \n Try Again");
                    }


                }

                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            /// function call
            LoadToDisplayDataGridViewFunction();
            ReorderLevelTextBoxFunction();
            AvailableQuantityFunction();

        }

        private void CategoryComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ReorderLevelTextBoxFunction();
            AvailableQuantityFunction();
        }

        private void CompanyComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ReorderLevelTextBoxFunction();
            AvailableQuantityFunction();
        }

        private void ItemComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ReorderLevelTextBoxFunction();
            AvailableQuantityFunction();
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            sell_lost_damage("sell");
        }

        private void LostButton_Click(object sender, EventArgs e)
        {
            sell_lost_damage("lost");
        }

        private void DamageButton_Click(object sender, EventArgs e)
        {
            sell_lost_damage("Damage");
        }

        public void sell_lost_damage(string variableString)
        {


            try
            {
                //connectionString
                string connectionString = @"Server =DESKTOP-3K97P4H\SQLEXPRESS; Database =StockManagementSystem; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;
                sqlConnection.Open();


                //commandSting for Existing Category Checked
                string commandStringFind = "Select * from StockOut";
                SqlDataAdapter adapter = new SqlDataAdapter(commandStringFind, sqlConnection);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);

                if (datatable.Rows.Count > 0)
                {
                    int count = 0;
                        for(int i =0; i<datatable.Rows.Count; i++)
                        {
                            // commandString 
                            string commandString = "Insert into Sell_Lost_Damage Values ('"+datatable.Rows[i]["CategoryName"]+ "','" + datatable.Rows[i]["CompanyName"] + "','" + datatable.Rows[i]["ItemName"] + "'," + datatable.Rows[i]["QuantityOut"] + ",'"+variableString+"',GETDATE())";
                            SqlCommand sqlCommand = new SqlCommand();
                            sqlCommand.CommandText = commandString;
                            sqlCommand.Connection = sqlConnection;

                          
                            count = sqlCommand.ExecuteNonQuery();

                          
                        }
                        if (count > 0)
                        {
                            MessageBox.Show(variableString+" added Successfully !!");
                        }
                        else
                        {
                            MessageBox.Show(variableString +" added Failed \n Try Again");
                        }

                    // commandString  for delete form STockOut
                    string commandStringDelete = "Delete  from StockOut";
                    SqlCommand sqlCommandDelete = new SqlCommand();
                    sqlCommandDelete.CommandText = commandStringDelete;
                    sqlCommandDelete.Connection = sqlConnection;
                    count = sqlCommandDelete.ExecuteNonQuery();

                }


                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            /// Display DataDridview FUnction call
            LoadToDisplayDataGridViewFunction();

        }
    }


}
