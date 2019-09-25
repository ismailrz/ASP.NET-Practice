using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University.Models;

namespace University.Views
{
    public partial class TimeSlotUi : Form
    {
        public TimeSlotUi()
        {
            InitializeComponent();
        }

        private void TimeSlotSaveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(timeSlotIdTexbox.Text))
            {
                MessageBox.Show("Select a time slot ID");
                return;
            }

            if (String.IsNullOrEmpty(dayComboBox.Text))
            {
                MessageBox.Show("Select a Day");
                return;
            }
      

            TimeSlot timeSlot = new TimeSlot();
            timeSlot.Time_slot_id = timeSlotIdTexbox.Text;
            timeSlot.Day = dayComboBox.Text;
            timeSlot.Start_time = startDateTimePicker.CustomFormat;
            timeSlot.End_time = endDateTimePicker.CustomFormat;

          

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
