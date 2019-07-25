using Stock_Management_System.BLL;
using Stock_Management_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management_System
{
    public partial class Category_Setup : Form
    {
        CategoryManager _categoryManager;
        CategoryModel category;
        public Category_Setup()
        {
            InitializeComponent();
            _categoryManager = new CategoryManager();
            category = new CategoryModel();
            
            // Category Functon Call
            LoadToCategoryFunction();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(categoryTextBox.Text))
            {
                MessageBox.Show("Enter a Category Name");
                return;
            }

            try
            {
                category.CategoryName = categoryTextBox.Text;

                if (!_categoryManager.IsCategoryUnique(category))
                {
                    MessageBox.Show("This category is Duplicated !!");
                    return;
                }
                else
                {
                    MessageBox.Show(_categoryManager.InsertCategory(category));
                }   
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            // Category Function call
            LoadToCategoryFunction();
        }

        private void LoadToCategoryFunction()
        {
            categoryDataGridView.DataSource= _categoryManager.LoadCategoryToComboBox();
        }

        private void CategoryDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)

            {

                //textBox1.Visible = textBox2.Visible = textBox3.Visible = true;

                //textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                //textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                categoryTextBox.Text = categoryDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                SaveButton.Text ="Update";

            }

        }
    }
}
