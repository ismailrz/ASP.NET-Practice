﻿using System;
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
    public partial class ClassRoomUi : Form
    {
        public ClassRoomUi()
        {
            InitializeComponent();
        }

        private void ClassroomSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(buildingTextBox.Text))
                {
                    MessageBox.Show("please enter builing name");
                    return;
                }
                if (String.IsNullOrEmpty(roomNumberTexBox.Text))
                {
                    MessageBox.Show("Please enter room number");
                    return;
                }
                if (String.IsNullOrEmpty(capacityTexBox.Text))
                {
                    MessageBox.Show("Please enter only numeric value");
                    return;
                }

                Classroom classroom = new Classroom();

                classroom.Building = buildingTextBox.Text;
                classroom.RoomNumber = roomNumberTexBox.Text;
                classroom.Capacity = Convert.ToDouble( capacityTexBox.Text);
            }
            catch (Exception ex)
            {
              
            }
        }

        private void ClassRoomForm_Load(object sender, EventArgs e)
        {

        }
    }
}