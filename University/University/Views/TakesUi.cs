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
    public partial class TakesUi : Form
    {
        public TakesUi()
        {
            InitializeComponent();
        }

        private void TakesSaveButton_Click(object sender, EventArgs e)
        {
            Takes takes = new Takes();
            takes.ID = idComboBox.Text;
            takes.Course_id = courseIdComboBox.Text;
            takes.Section_id = sectionIdComboBox.Text;
            takes.Semester = semesterComboBox.Text;
            takes.Year =Convert.ToDouble(yearComboBox.Text);
            takes.Grade = gradeTexBox.Text;
        }
    }
}
