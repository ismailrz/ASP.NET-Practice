using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University.BLL;
using University.Models;

namespace University.Views
{
    public partial class AdvisorUi : Form
    {
        Advisor advisor;
        AdvisorManager advisorManager;
        public AdvisorUi()
        {
            InitializeComponent();
          advisor = new Advisor();
         advisorManager = new AdvisorManager();
        }

        private void AdvisorSaveButton_Click(object sender, EventArgs e)
        {
            

            if (String.IsNullOrEmpty(studentIdComboBox.Text))
            {
                MessageBox.Show("Select a student  ID");
                return;
            }

            if (String.IsNullOrEmpty(instructorIdComboBox.Text))
            {
                MessageBox.Show("Select a instructor ID");
                return;
            }

            
            advisor.S_id = studentIdComboBox.Text;
            advisor.I_id = instructorIdComboBox.Text;

            string exist = advisorManager.IsExistOrInsert(advisor);
            if (!String.IsNullOrEmpty(exist))
            {
                MessageBox.Show("Data is exist \n Please enter a new instructor ID");
            }
            else
            {
                MessageBox.Show("Data Inserted successfully.");
            }


        }

        private void AdvisorUi_Load(object sender, EventArgs e)
        {
            studentIdComboBox.DataSource = advisorManager.GetStudentIdTocomboBox();
            instructorIdComboBox.DataSource = advisorManager.GetInstructorIdTocomboBox();

        }
    }
}
