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
            TimeSlot timeSlot = new TimeSlot();
            timeSlot.Time_slot_id = timeSlotIdTexbox.Text;
            timeSlot.Day = dayTexbox.Text;
            timeSlot.Start_time = startTimeTexBox.Text;
            timeSlot.End_time = endTimeTexbox.Text;
        }
    }
}
