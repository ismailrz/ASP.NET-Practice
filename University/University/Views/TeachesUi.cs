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
    public partial class TeachesUi : Form
    {
        TeachesManager teachesManager;
        Teaches teaches;
        public TeachesUi()
        {
            InitializeComponent();
            teachesManager = new TeachesManager();
            teaches = new Teaches();
        }

        private void TeachesSaveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(idComboBox.Text))
            {
                MessageBox.Show("Enter a Instuctor ID");
                return;
            }

            if (String.IsNullOrEmpty(courseIdComboBox.Text))
            {
                MessageBox.Show("Select a Course ID");
                return;
            }

            if (String.IsNullOrEmpty(sectionIdComboBox.Text))
            {
                MessageBox.Show("Select a section ID");
                return;
            }

            if (String.IsNullOrEmpty(semesterComboBox.Text))
            {
                MessageBox.Show("Select a Semester");
                return;
            }

            if (String.IsNullOrEmpty(yearComboBox.Text))
            {
                MessageBox.Show("Select a year ");
                return;
            }

            Teaches teaches = new Teaches();
            teaches.ID = idComboBox.Text;
            teaches.Course_id = courseIdComboBox.Text;
            teaches.sec_id = sectionIdComboBox.Text;
            teaches.Semester = semesterComboBox.Text;
            teaches.Year = Convert.ToDouble(yearComboBox.Text);

            string exist = teachesManager.IsExistOrInsert(teaches);
            if (!String.IsNullOrEmpty(exist))
            {
                MessageBox.Show("Data is exist \n Please Check ID, course id, section id, year and semester are primary key");
            }
            else
            {
                MessageBox.Show("Data Inserted successfully.");
            }
            
        }

        private void TeachesUi_Load(object sender, EventArgs e)
        {
           
            idComboBox.DataSource = teachesManager.GetInstructorIdTocomboBox();
            courseIdComboBox.DataSource = teachesManager.GetSectionsTableTocomboBox();
            sectionIdComboBox.DataSource = teachesManager.GetSectionsTableTocomboBox();
            semesterComboBox.DataSource = teachesManager.GetSectionsTableTocomboBox();
            yearComboBox.DataSource = teachesManager.GetSectionsTableTocomboBox();
        }
    }
}
