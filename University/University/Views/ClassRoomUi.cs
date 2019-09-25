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
    public partial class ClassRoomUi : Form
    {
        ClassRoomManager classRoomManager;
        public ClassRoomUi()
        {
            InitializeComponent();
            classRoomManager = new ClassRoomManager();

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

                if (System.Text.RegularExpressions.Regex.IsMatch(capacityTexBox.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter a numeric capacity");
                    capacityTexBox.Text = capacityTexBox.Text.Remove(capacityTexBox.Text.Length - 1);
                    return;
                }
          

                Classroom classroom = new Classroom();

                classroom.Building = buildingTextBox.Text;
                classroom.Room_Number = roomNumberTexBox.Text;
                classroom.Capacity = Convert.ToDouble( capacityTexBox.Text);

               

              string existOrInsert =  classRoomManager.IsExistOrInsert(classroom);
                if (!String.IsNullOrEmpty(existOrInsert))
                {
                    MessageBox.Show(existOrInsert);
                }
                else
                {
                    MessageBox.Show("Data Insert successfull !");
                }


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
