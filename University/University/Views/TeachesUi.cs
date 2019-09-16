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
    public partial class TeachesUi : Form
    {
        public TeachesUi()
        {
            InitializeComponent();
        }

        private void TeachesSaveButton_Click(object sender, EventArgs e)
        {
            Teaches teaches = new Teaches();
            teaches.ID = idComboBox.Text;
            teaches.Course_id = courseIdComboBox.Text;
            teaches.Section_id = sectionIdComboBox.Text;
            teaches.Semester = semesterComboBox.Text;
            teaches.Year=Convert.ToDouble(yearComboBox.Text);
        }
    }
}
