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
    public partial class PrereqUi : Form
    {
        Prereq prereq;
        PreReqManager preReqManager;
        public PrereqUi()
        {
            InitializeComponent();
             prereq = new Prereq();
            preReqManager = new PreReqManager();
        }

        private void PrereqSaveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(courseIdComboBox.Text))
            {
                MessageBox.Show("Select a course ID");
                return;
            }

            if (String.IsNullOrEmpty(prereqIdComboBox.Text))
            {
                MessageBox.Show("Select a instructor ID");
                return;
            }


            prereq.Course_id = courseIdComboBox.Text;
            prereq.Prereq_id = prereqIdComboBox.Text;

            string exist = preReqManager.IsExistOrInsert(prereq);
            if (!String.IsNullOrEmpty(exist))
            {
                MessageBox.Show("Data is exist \n Please enter a new instructor ID");
            }
            else
            {
                MessageBox.Show("Data Inserted successfully.");
            }


        }

        private void PrereqUi_Load(object sender, EventArgs e)
        {
            courseIdComboBox.DataSource = preReqManager.GetCourseIdTocomboBox();
            prereqIdComboBox.DataSource = preReqManager.GetCourseIdTocomboBox();
        }
    }
}
