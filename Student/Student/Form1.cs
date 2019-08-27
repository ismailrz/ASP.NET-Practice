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

namespace Student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> IDs = new List<int>();
        List<string> Names = new List<string>();
        List<string> Departments = new List<string>();
        List<string> Genders = new List<string>();
        List<int> Mobiles = new List<int>();

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

            try
            {
                //connectionString 
                string connectionString = @"Server =DESKTOP-3K97P4H\SQLEXPRESS; Database = MindforkDB ; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;

                //connection open
                sqlConnection.Open();
                // Insert into Students Values(1,'Ismail','CSE','Male','01743557172')
                // commandString
                //string commandString = "Insert into Students Values(" + IdTextbox.Text + ",'" + ModelNameTexbox.Text + "'," + IMEITextbox.Text + "," + PriceTextbox.Text + ")";

                for (int i = 0; i < Names.Count; i++)
                {
                    string commandString = "Insert into Students Values(" + IDs[i] + ",'" + Names[i] + "','" + Departments[i] + "','" + Genders[i] + "','" + Mobiles[i] + "')";

                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = commandString;
                    sqlCommand.Connection = sqlConnection;
                
                //execute
                    int count = 0;
                    count = sqlCommand.ExecuteNonQuery();
                    if (count > 0)
                    {
                        MessageBox.Show("Data Insert Successful !!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to Isert \n Try again");
                    }

                }
                //connection closed
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        int sl = 100;
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NameTextView.Text))
            {
                MessageBox.Show("Name cannot empty!!");
                return;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(MobileTextBox.Text, "[^0-9]"))
            {

                MessageBox.Show("Please enter only numbers.");

            }
            if (String.IsNullOrEmpty(MobileTextBox.Text))
            {
                MessageBox.Show("Mobile cannot empty!!");
                return;
            }
            if (String.IsNullOrEmpty(DepartmentComboBox.Text))
            {
                MessageBox.Show("Department cannot empty!!");
                return;
            }


            try
            {
                string Name, Department, Gender;
                int ID, Mobile;


                Name = NameTextView.Text;
                Department = DepartmentComboBox.Text;

                Gender = MaleRadioButton.Text;
                Mobile = Convert.ToInt32(MobileTextBox.Text);
                ID = sl++;

                IDs.Add(ID);
                Names.Add(Name);
                Departments.Add(Department);
                Genders.Add(Gender);
                Mobiles.Add(Mobile);



            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            RichTextBox.Text = Display();
        }
        private string Display()
        {
            string message = "";
            message += "SI\t Student ID\tStudent Name\tDepartment\tGender\tMobile\t\n";
            for (int i = 0; i < Names.Count; i++)
            {

                message += (i + 1) + "\t" + IDs[i] + "\t\t" + Names[i] + "\t\t" + Departments[i] + "\t\t" + Genders[i] + "\t\t" + Mobiles[i]  + "\n";
            }
            return message;
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
             try
            {
                //connectionString 
                string connectionString = @"Server =DESKTOP-3K97P4H\SQLEXPRESS; Database = MindforkDB  ; Integrated Security = true";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = connectionString;

                //connection open
                sqlConnection.Open();

                // commandString
                string commandString = "select * from Students";
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = commandString;
                sqlCommand.Connection = sqlConnection;

                //execute

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);


                //ddddd.DataSource = dataTable;



                //connection closed
                sqlConnection.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}