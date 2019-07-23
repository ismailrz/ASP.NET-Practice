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

namespace MyWinApp
{
    public partial class Student : Form
    {
        private SqlCommand sqlCommand;
        private SqlDataReader dr;

        public Student()
        {
            InitializeComponent();
          
        }

        private void Student_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = "Enter your Name";
            departmentTextBox.Text = "Enter department";
        }

        private void NameTextBox_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
        }

        private void DepartmentTextBox_Click(object sender, EventArgs e)
        {
            departmentTextBox.Text = "";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Name field is empty");
                return;
            }
            if (String.IsNullOrEmpty(departmentTextBox.Text))
            {
                MessageBox.Show("Department" +
                    " field is empty");

                return;
            }
            try
            {
                int isExecuted = 0;
                //1.connectionString
                string connectionString = @"Server=DESKTOP-3K97P4H\SQLEXPRESS ;Database=StudentDB ;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;
                //2.connection open
                sqlConnection.Open();

                //4.commandString
                string commandString = "INSERT INTO Students VALUES('" + nameTextBox.Text + "','"+departmentTextBox.Text+"')";
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = commandString;
                sqlCommand.Connection = sqlConnection;

                //5.Execute
                isExecuted=sqlCommand.ExecuteNonQuery();
                if(isExecuted>0)
                {
                    MessageBox.Show("Save Successful");
                }
                else
                {
                    MessageBox.Show("Save Failed");
                }
                
                //3.connection close
                sqlConnection.Close();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    int isExecuted = 0;
            //    //1.connectionString
            //    string connectionString = @"Server=DESKTOP-3K97P4H\SQLEXPRESS ;Database=StudentDB ;Integrated Security=True";
            //    SqlConnection sqlConnection = new SqlConnection();
            //    sqlConnection.ConnectionString = connectionString;
            //    //2.connection open
            //    sqlConnection.Open();

            //    //4.commandString
         
            //    string query = "select * from Students";
            //    sqlCommand = new SqlCommand(query, sqlConnection);
            //    sqlCommand.CommandType = CommandType.Text;

            //    dr = sqlCommand.ExecuteReader();

            //    RichTextBox.Text = "Name" + "   " + "Department\n";

            //    while (dr.Read())
            //    {

            //        // Label3.Text += dr["name"].ToString();
            //        // Label4.Text += dr["department"].ToString();
            //        RichTextBox.Text += dr["name"].ToString()+" "+dr["department"].ToString()+"\n";

            //        //MessageBox.Show(dr["name"].ToString() ,dr["department"].ToString());
            //    }



            //    //3.connection close
            //    sqlConnection.Close();
            //}
            //catch (Exception exception)
            //{
            //    MessageBox.Show(exception.Message);
            //}
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Id field is empty");
                return;
            }
            try
            {
                int isExecuted = 0;
                //1.connectionString
                string connectionString = @"Server=DESKTOP-3K97P4H\SQLEXPRESS ;Database=StudentDB ;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;
                //2.connection open
                sqlConnection.Open();

                //4.commandString
                string commandString = "DELETE Students WHERE Id="+idTextBox.Text+"";
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = commandString;
                sqlCommand.Connection = sqlConnection;

                //5.Execute
                isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    MessageBox.Show("Deleted Successful");
                }
                else
                {
                    MessageBox.Show("Delete Failed");
                }

                //3.connection close
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Id field is empty");
                return;
            }
            if (String.IsNullOrEmpty(nameModificationTextBox.Text))
            {
                MessageBox.Show("Name field is empty");
                return;
            }
            if (String.IsNullOrEmpty(departmentModificationTextBox.Text))
            {
                MessageBox.Show("Department" +
                    " field is empty");

                return;
            }            
            try
            {
                int isExecuted = 0;
                //1.connectionString
                string connectionString = @"Server=DESKTOP-3K97P4H\SQLEXPRESS ;Database=StudentDB ;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;
                //2.connection open
                sqlConnection.Open();

                //4.commandString
                string commandString = "UPDATE Students SET Name='"+nameModificationTextBox.Text+"', Department='"+departmentModificationTextBox.Text+"' WHERE Id="+idTextBox.Text+"";
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = commandString;
                sqlCommand.Connection = sqlConnection;

                //5.Execute
                isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    MessageBox.Show("Update Successful");
                }
                else
                {
                    MessageBox.Show("Update Failed");
                }

                //3.connection close
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ShowButton_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(idTextBox.Text))
            {
                MessageBox.Show("Id field is empty");
                return;
            }
            try
            {
                //1.connectionString
                string connectionString = @"Server=DESKTOP-3K97P4H\SQLEXPRESS ;Database=StudentDB ;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;
                //2.connection open
                sqlConnection.Open();

                //4.commandString
                string commandString = "SELECT * FROM Students WHERE Id="+idTextBox.Text+"";
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = commandString;
                sqlCommand.Connection = sqlConnection;

                //5.Execute
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                if(dataTable.Rows.Count>0)
                {
                    nameModificationTextBox.Text = dataTable.Rows[0]["Name"].ToString();
                    departmentModificationTextBox.Text = dataTable.Rows[0]["Department"].ToString();
                } 
                else
                {
                    MessageBox.Show("No Data with this id");
                }
              

                //3.connection close
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
