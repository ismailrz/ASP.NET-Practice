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
    public partial class SectionUi : Form
    {
        Section section;
        SectionManager sectionManager;
        public SectionUi()
        {
            InitializeComponent();
            section = new Section();
            sectionManager = new SectionManager();
        }

        private void SectionSaveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(courseIdComboBox.Text))
            {
                MessageBox.Show("Enter a Course Id");
                return;
            }

            if (String.IsNullOrEmpty(sectionIdTexbox.Text))
            {
                MessageBox.Show("Enter a Section ID");
                return;
            }

            if (String.IsNullOrEmpty(semesterComboBox.Text))
            {
                MessageBox.Show("Select a Semester");
                return;
            }

            if (String.IsNullOrEmpty(yearTexbox.Text))
            {
                MessageBox.Show("Enter a year ");
                return;
            }
            if (String.IsNullOrEmpty(buildingComboBox.Text))
            {
                MessageBox.Show("Select a building name");
                return;
            }
             if (String.IsNullOrEmpty(roomNumberComboBox.Text))
            {
                MessageBox.Show("Select a room number ");
                return;
            }
              if (String.IsNullOrEmpty(timeSlotIdTexbox.Text))
            {
                MessageBox.Show("Enter a Time slot");
                return;
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(yearTexbox.Text, "[^0-9]"))
            {
                MessageBox.Show("Year is numeric");
                yearTexbox.Text = yearTexbox.Text.Remove(yearTexbox.Text.Length - 1);
                return;
            }

            section.Course_id = courseIdComboBox.Text;
            section.sec_id = sectionIdTexbox.Text;
            section.Semester = semesterComboBox.Text;
            section.Year = Convert.ToDouble(yearTexbox.Text);
            section.Building = buildingComboBox.Text;
            section.Room_number = roomNumberComboBox.Text;
            section.Time_slot_id = timeSlotIdTexbox.Text;

            string exist = sectionManager.IsExistOrInsert(section);
            if (!String.IsNullOrEmpty(exist))
            {
                MessageBox.Show("Data is exist \n Please Check course id, section id, year and semester are primary key");
            }
            else
            {
                MessageBox.Show("Section Inserted successfully.");
            }


        }

        private void SectionUi_Load(object sender, EventArgs e)
        {
          courseIdComboBox.DataSource = sectionManager.GetCourseTocomboBox();
          buildingComboBox.DataSource= sectionManager.GetBuildingAndRoomNumberTocomboBox();
          roomNumberComboBox.DataSource= sectionManager.GetBuildingAndRoomNumberTocomboBox();
        }
    }
}
