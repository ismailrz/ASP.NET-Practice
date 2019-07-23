using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Record
{
    public partial class IndexUi : Form
    {
        public IndexUi()
        {
            InitializeComponent();
        }

        private void InformationLabel_Click(object sender, EventArgs e)
        {
            MobileUi mobileUi = new MobileUi();
            mobileUi.Show();
            this.Hide();
        }

        private void SearchPriceabel_Click(object sender, EventArgs e)
        {
            SearchByPrice searchByPrice = new SearchByPrice();
            searchByPrice.Show();
            this.Hide();
        }

        private void SearchIMEILabel_Click(object sender, EventArgs e)
        {
            SearchByIMEI searchByIMEI = new SearchByIMEI();
            searchByIMEI.Show();
            this.Hide();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            All_mobile_info all_Mobile_Info = new All_mobile_info();
            all_Mobile_Info.Show();
            this.Hide();
        }
    }
}
