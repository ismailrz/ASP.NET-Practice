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

namespace Student_Record
{
    public partial class StudentRecord : Form
    {
        public StudentRecord()
        {
            InitializeComponent();
        }

        private void StudentRecord_Load(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Id cannot empty!");
                return;
            }
            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Name cannot empty!");
                return;
            }
            if (String.IsNullOrEmpty(departmentTextBox.Text))
            {
                MessageBox.Show("Department cannot  empty!");
                return;
            }
            try
            {
                int count = 0;
                //1. connentionString
                string connentionString = @"Server = DESKTOP-3K97P4H\SQLEXPRESS; Database =StudentDataBase; Integrated security = true";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connentionString;

                //2 connection open
                sqlConnection.Open();

                //3. command string
                string commandString = "Insert into Students Values(" + idTextBox.Text + ",'" + nameTextBox.Text + "','" + departmentTextBox.Text + "')";
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = commandString;
                sqlCommand.Connection = sqlConnection;

                //4. Execute
                count = sqlCommand.ExecuteNonQuery();

                if (count > 0)
                {
                    MessageBox.Show("Data insert successful");
                }
                else
                {
                    MessageBox.Show("Data insert Failed");
                }
                //5. connection close
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(updateIdTextbox.Text))
            {
                MessageBox.Show("Id cannot empty!");
                return;
            }
            
            try
            {
                string connectionstring = @"Server =DESKTOP-3K97P4H\SQLEXPRESS ; Database =StudentDataBase ; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionstring;

                sqlConnection.Open();

                string commandString = "Delete from Students where id = " + updateIdTextbox.Text + "";
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = commandString;
                sqlCommand.Connection = sqlConnection;
                int count = 0;
               count = sqlCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    MessageBox.Show("Delete successful");
                }
                else
                {
                    MessageBox.Show("Delete Failed");
                }


                sqlConnection.Close();
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(updateIdTextbox.Text))
            {
                MessageBox.Show("Id cannot empty!");
                return;
            }
            if (String.IsNullOrEmpty(updateNameTextBox.Text))
            {
                MessageBox.Show("Name cannot empty!");
                return;
            }
            if (String.IsNullOrEmpty(updateDepartmentTextBox.Text))
            {
                MessageBox.Show("Department cannot  empty!");
                return;
            }

            try
            {
                //connetion string
                string connectionString = @"Server = DESKTOP-3K97P4H\SQLEXPRESS; Database = StudentDataBase; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;

                //connection open
                sqlConnection.Open();

                //command string

                string commandString = "Update Students set id =" + updateIdTextbox.Text + ", Name ='" + updateNameTextBox.Text + "', Department = '" + updateDepartmentTextBox.Text + "' where id = "+ updateIdTextbox.Text+ "";

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = commandString;
                sqlCommand.Connection = sqlConnection;

                // execute

                int count = 0;
                count = sqlCommand.ExecuteNonQuery();

                if (count > 0)
                {
                    MessageBox.Show("Data updated successful");
                }
                else
                {
                    MessageBox.Show("Data updated Failed");
                }


                // connection close

                sqlConnection.Close();
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(updateIdTextbox.Text))
            {
                MessageBox.Show("Id cannot empty!");
                return;
            }

            try
            {
                //connetion string
                string connectionString = @"Server = DESKTOP-3K97P4H\SQLEXPRESS; Database = StudentDataBase; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;

                //connection open
                sqlConnection.Open();

                //command string

                string commandString = "Select * from Students where id = "+ updateIdTextbox.Text+"";

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = commandString;
                sqlCommand.Connection = sqlConnection;

                // execute

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);


                if (dataTable.Rows.Count>0)
                {
                    updateNameTextBox.Text = dataTable.Rows[0]["Name"].ToString();
                    updateDepartmentTextBox.Text = dataTable.Rows[0]["Department"].ToString();
                }
                else
                {
                    MessageBox.Show("Data show Failed");
                }


                // connection close

                sqlConnection.Close();
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }
        }

        private void ViewTableButton_Click(object sender, EventArgs e)
        {


            try
            {
                //connetion string
                string connectionString = @"Server = DESKTOP-3K97P4H\SQLEXPRESS; Database = StudentDataBase; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;

                //connection open
                sqlConnection.Open();

                //command string

                string commandString = "Select * from Students";

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = commandString;
                sqlCommand.Connection = sqlConnection;

                // execute

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                int i = dataTable.Rows.Count;
                string allInfor = "Name\t\tDepartment\n";
                if (dataTable.Rows.Count > 0)
                {
                    while (i>0)
                    {
                        allInfor += dataTable.Rows[i-1]["Name"].ToString()+"\t\t" + dataTable.Rows[i-1]["Department"].ToString()+" \n";
                        i--;
                    }

                    MessageBox.Show(allInfor);
                }
                else
                {
                    MessageBox.Show("Data show Failed");
                }


                // connection close

                sqlConnection.Close();
            }
            catch (Exception exeption)
            {
                MessageBox.Show(exeption.Message);
            }

        }
    }
}
