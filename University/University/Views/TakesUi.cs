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
    public partial class TakesUi : Form
    {
        Takes takes;
        TakesManager takesManager;
        public TakesUi()
        {
            InitializeComponent();
            takes = new Takes();
            takesManager = new TakesManager();
        }

        private void TakesSaveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(idComboBox.Text))
            {
                MessageBox.Show("Enter a Student ID");
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
            if (String.IsNullOrEmpty(gradeTexBox.Text))
            {
                MessageBox.Show("Enter a grad");
                return;
            }
           
            takes.ID = idComboBox.Text;
            takes.Course_id = courseIdComboBox.Text;
            takes.sec_id = sectionIdComboBox.Text;
            takes.Semester = semesterComboBox.Text;
            takes.Year = Convert.ToDouble(yearComboBox.Text);
            takes.Grade = gradeTexBox.Text;
            string exist = takesManager.IsExistOrInsert(takes);
            if (!String.IsNullOrEmpty(exist))
            {
                MessageBox.Show("Data is exist \n Please Check ID, course id, section id, year and semester are primary key");
            }
            else
            {
                MessageBox.Show("Data Inserted successfully.");
            }

        }

        private void TakesUi_Load(object sender, EventArgs e)
        {
           
            idComboBox.DataSource = takesManager.GetStudentIdTocomboBox();
           courseIdComboBox.DataSource =takesManager.GetSectionsTableTocomboBox();
           sectionIdComboBox.DataSource =takesManager.GetSectionsTableTocomboBox();
           semesterComboBox.DataSource =takesManager.GetSectionsTableTocomboBox();
           yearComboBox.DataSource =takesManager.GetSectionsTableTocomboBox();
        }
    }
}
