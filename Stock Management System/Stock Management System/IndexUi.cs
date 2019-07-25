using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management_System
{
    public partial class IndexUi : Form
    {
        public IndexUi()
        {
            InitializeComponent();
        }

        private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Category_Setup category_Setup = new Category_Setup();
            category_Setup.Show();
            this.Hide();
        }

        private void LinkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Company_Setup company_Setup = new Company_Setup();
            company_Setup.Show();
            this.Hide();
        }

        private void LinkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Item_Setup item_Setup = new Item_Setup();
            item_Setup.Show();
            this.Hide();
        }

        private void LinkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StockIn stockIn = new StockIn();
            stockIn.Show();
            this.Hide();
        }

        private void LinkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StockOut stockOut = new StockOut();
            stockOut.Show();
            this.Hide();
        }
    }
}
