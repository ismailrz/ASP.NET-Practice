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
    public partial class PrereqUi : Form
    {
        public PrereqUi()
        {
            InitializeComponent();
        }

        private void PrereqSaveButton_Click(object sender, EventArgs e)
        {
            Prereq prereq = new Prereq();
            prereq.Course_id = courseIdComboBox.Text;
            prereq.Prereq_id = prereqIdComboBox.Text;
        }
    }
}
