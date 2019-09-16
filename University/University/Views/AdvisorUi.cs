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
    public partial class AdvisorUi : Form
    {
        public AdvisorUi()
        {
            InitializeComponent();
        }

        private void AdvisorSaveButton_Click(object sender, EventArgs e)
        {
            Advisor advisor = new Advisor();
            advisor.S_id = studentIdComboBox.Text;
            advisor.I_id = instructorIdComboBox.Text;
        }
    }
}
