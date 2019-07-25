namespace Stock_Management_System
{
    partial class Search_and_View_Items_Summary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.DisplayDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.CategoryNameComboBox = new System.Windows.Forms.ComboBox();
            this.CompanyNameComboBox = new System.Windows.Forms.ComboBox();
            this.categoryModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Name";
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(405, 123);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(104, 35);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // DisplayDataGridView
            // 
            this.DisplayDataGridView.AutoGenerateColumns = false;
            this.DisplayDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DisplayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.availableQuantityDataGridViewTextBoxColumn,
            this.reorderLevelDataGridViewTextBoxColumn});
            this.DisplayDataGridView.DataSource = this.itemModelBindingSource;
            this.DisplayDataGridView.Location = new System.Drawing.Point(22, 258);
            this.DisplayDataGridView.Name = "DisplayDataGridView";
            this.DisplayDataGridView.Size = new System.Drawing.Size(766, 180);
            this.DisplayDataGridView.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Company Name";
            // 
            // CategoryNameComboBox
            // 
            this.CategoryNameComboBox.DataSource = this.categoryModelBindingSource;
            this.CategoryNameComboBox.DisplayMember = "CategoryName";
            this.CategoryNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryNameComboBox.FormattingEnabled = true;
            this.CategoryNameComboBox.Location = new System.Drawing.Point(318, 34);
            this.CategoryNameComboBox.Name = "CategoryNameComboBox";
            this.CategoryNameComboBox.Size = new System.Drawing.Size(191, 28);
            this.CategoryNameComboBox.TabIndex = 5;
            this.CategoryNameComboBox.ValueMember = "Serial";
            // 
            // CompanyNameComboBox
            // 
            this.CompanyNameComboBox.DataSource = this.companyModelBindingSource;
            this.CompanyNameComboBox.DisplayMember = "CompanyName";
            this.CompanyNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyNameComboBox.FormattingEnabled = true;
            this.CompanyNameComboBox.Location = new System.Drawing.Point(318, 78);
            this.CompanyNameComboBox.Name = "CompanyNameComboBox";
            this.CompanyNameComboBox.Size = new System.Drawing.Size(191, 28);
            this.CompanyNameComboBox.TabIndex = 6;
            this.CompanyNameComboBox.ValueMember = "Serial";
            // 
            // categoryModelBindingSource
            // 
            this.categoryModelBindingSource.DataSource = typeof(Stock_Management_System.Models.CategoryModel);
            // 
            // companyModelBindingSource
            // 
            this.companyModelBindingSource.DataSource = typeof(Stock_Management_System.Models.CompanyModel);
            // 
            // itemModelBindingSource
            // 
            this.itemModelBindingSource.DataSource = typeof(Stock_Management_System.Models.itemModel);
            // 
            // serialDataGridViewTextBoxColumn
            // 
            this.serialDataGridViewTextBoxColumn.DataPropertyName = "Serial";
            this.serialDataGridViewTextBoxColumn.HeaderText = "Serial";
            this.serialDataGridViewTextBoxColumn.Name = "serialDataGridViewTextBoxColumn";
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            // 
            // availableQuantityDataGridViewTextBoxColumn
            // 
            this.availableQuantityDataGridViewTextBoxColumn.DataPropertyName = "AvailableQuantity";
            this.availableQuantityDataGridViewTextBoxColumn.HeaderText = "AvailableQuantity";
            this.availableQuantityDataGridViewTextBoxColumn.Name = "availableQuantityDataGridViewTextBoxColumn";
            // 
            // reorderLevelDataGridViewTextBoxColumn
            // 
            this.reorderLevelDataGridViewTextBoxColumn.DataPropertyName = "ReorderLevel";
            this.reorderLevelDataGridViewTextBoxColumn.HeaderText = "ReorderLevel";
            this.reorderLevelDataGridViewTextBoxColumn.Name = "reorderLevelDataGridViewTextBoxColumn";
            // 
            // Search_and_View_Items_Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CompanyNameComboBox);
            this.Controls.Add(this.CategoryNameComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DisplayDataGridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label1);
            this.Name = "Search_and_View_Items_Summary";
            this.Text = "Search and View Items Summary";
            this.Load += new System.EventHandler(this.Search_and_View_Items_Summary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView DisplayDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CategoryNameComboBox;
        private System.Windows.Forms.ComboBox CompanyNameComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource itemModelBindingSource;
        private System.Windows.Forms.BindingSource categoryModelBindingSource;
        private System.Windows.Forms.BindingSource companyModelBindingSource;
    }
}