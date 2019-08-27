using Stock_Management_System.BLL;
using Stock_Management_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management_System
{
    public partial class Item_Setup : Form
    {
        
        ItemSetupManager _itemSetupManager, _itemSetupManager2;
        ItemModel Item;
        public Item_Setup()
        {
            InitializeComponent();
            _itemSetupManager = new ItemSetupManager();
            _itemSetupManager2 = new ItemSetupManager();
            Item = new ItemModel();
        }
        private void Item_Setup_Load(object sender, EventArgs e)
        {
            // category load function call
          categoryComboBox.DataSource = _itemSetupManager.LoadToCategoryComboBox();

        companyComboBox.DataSource = _itemSetupManager2.LoadToCompanyComboBox();

           
        }
        
   

     

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(categoryComboBox.Text))
            {
                MessageBox.Show("Select a Category Name !!");
                return;
            }
            if (String.IsNullOrEmpty(companyComboBox.Text))
            {
                MessageBox.Show("Select a Company Name !!");
                return;
            }

            if (String.IsNullOrEmpty(itemTextBox.Text))
            {
                MessageBox.Show("Enter an Item Name !!");
                return;
            }
            if (String.IsNullOrEmpty(ReorderLevelTextBox.Text))
            {
                MessageBox.Show(" Reorder cannot empty !!");
                return;
            }

            Item.CategoryName = categoryComboBox.Text;
            Item.CompanyName = companyComboBox.Text;
            Item.ItemName = itemTextBox.Text;
            Item.ReorderLevel =Convert.ToInt32(ReorderLevelTextBox.Text);
            // function call 
            MessageBox.Show(_itemSetupManager.IsExistOrInsert(Item));
        }

       
    }
}
