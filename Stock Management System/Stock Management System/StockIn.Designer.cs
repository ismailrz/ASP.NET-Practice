namespace Stock_Management_System
{
    partial class StockIn
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
            this.ReorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SaveButton = new System.Windows.Forms.Button();
            this.DisplayDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemComboBox = new System.Windows.Forms.ComboBox();
            this.itemModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CompanyComboBox = new System.Windows.Forms.ComboBox();
            this.companyModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StockInQuantityTextBox = new System.Windows.Forms.TextBox();
            this.AvailableQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.stockInModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.categoryModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockInModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Name";
            // 
            // ReorderLevelTextBox
            // 
            this.ReorderLevelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReorderLevelTextBox.Location = new System.Drawing.Point(318, 150);
            this.ReorderLevelTextBox.Name = "ReorderLevelTextBox";
            this.ReorderLevelTextBox.ReadOnly = true;
            this.ReorderLevelTextBox.Size = new System.Drawing.Size(260, 26);
            this.ReorderLevelTextBox.TabIndex = 1;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DataSource = this.categoryModelBindingSource;
            this.CategoryComboBox.DisplayMember = "CategoryName";
            this.CategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(318, 36);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(260, 28);
            this.CategoryComboBox.TabIndex = 2;
            this.CategoryComboBox.ValueMember = "Serial";
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(441, 275);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(137, 36);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
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
            this.dTDataGridViewTextBoxColumn});
            this.DisplayDataGridView.DataSource = this.stockInModelBindingSource;
            this.DisplayDataGridView.Location = new System.Drawing.Point(45, 317);
            this.DisplayDataGridView.Name = "DisplayDataGridView";
            this.DisplayDataGridView.Size = new System.Drawing.Size(704, 121);
            this.DisplayDataGridView.TabIndex = 4;
            // 
            // ItemComboBox
            // 
            this.ItemComboBox.DataSource = this.itemModelBindingSource;
            this.ItemComboBox.DisplayMember = "ItemName";
            this.ItemComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemComboBox.FormattingEnabled = true;
            this.ItemComboBox.Location = new System.Drawing.Point(318, 114);
            this.ItemComboBox.Name = "ItemComboBox";
            this.ItemComboBox.Size = new System.Drawing.Size(260, 28);
            this.ItemComboBox.TabIndex = 5;
            this.ItemComboBox.ValueMember = "Serial";
            this.ItemComboBox.SelectedIndexChanged += new System.EventHandler(this.ItemComboBox_SelectedIndexChanged);
            // 
            // CompanyComboBox
            // 
            this.CompanyComboBox.DataSource = this.companyModelBindingSource;
            this.CompanyComboBox.DisplayMember = "CompanyName";
            this.CompanyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyComboBox.FormattingEnabled = true;
            this.CompanyComboBox.Location = new System.Drawing.Point(318, 72);
            this.CompanyComboBox.Name = "CompanyComboBox";
            this.CompanyComboBox.Size = new System.Drawing.Size(260, 28);
            this.CompanyComboBox.TabIndex = 6;
            this.CompanyComboBox.ValueMember = "Serial";
            this.CompanyComboBox.SelectedIndexChanged += new System.EventHandler(this.CompanyComboBox_SelectedIndexChanged);
            // 
            // StockInQuantityTextBox
            // 
            this.StockInQuantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockInQuantityTextBox.Location = new System.Drawing.Point(318, 231);
            this.StockInQuantityTextBox.Name = "StockInQuantityTextBox";
            this.StockInQuantityTextBox.Size = new System.Drawing.Size(260, 26);
            this.StockInQuantityTextBox.TabIndex = 7;
            // 
            // AvailableQuantityTextBox
            // 
            this.AvailableQuantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableQuantityTextBox.Location = new System.Drawing.Point(318, 189);
            this.AvailableQuantityTextBox.Name = "AvailableQuantityTextBox";
            this.AvailableQuantityTextBox.ReadOnly = true;
            this.AvailableQuantityTextBox.Size = new System.Drawing.Size(260, 26);
            this.AvailableQuantityTextBox.TabIndex = 8;
            this.AvailableQuantityTextBox.TextChanged += new System.EventHandler(this.AvailableQuantityTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Company Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(158, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Reorder Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(158, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Available Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(158, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Stock in Quantity";
            // 
            // stockInModelBindingSource
            // 
            this.stockInModelBindingSource.DataSource = typeof(Stock_Management_System.Models.StockInModel);
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
            // dTDataGridViewTextBoxColumn
            // 
            this.dTDataGridViewTextBoxColumn.DataPropertyName = "DT";
            this.dTDataGridViewTextBoxColumn.HeaderText = "DT";
            this.dTDataGridViewTextBoxColumn.Name = "dTDataGridViewTextBoxColumn";
            // 
            // StockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AvailableQuantityTextBox);
            this.Controls.Add(this.StockInQuantityTextBox);
            this.Controls.Add(this.CompanyComboBox);
            this.Controls.Add(this.ItemComboBox);
            this.Controls.Add(this.DisplayDataGridView);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.ReorderLevelTextBox);
            this.Controls.Add(this.label1);
            this.Name = "StockIn";
            this.Text = "StockIn";
            this.Load += new System.EventHandler(this.StockIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockInModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ReorderLevelTextBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridView DisplayDataGridView;
        private System.Windows.Forms.BindingSource categoryModelBindingSource;
        private System.Windows.Forms.ComboBox ItemComboBox;
        private System.Windows.Forms.ComboBox CompanyComboBox;
        private System.Windows.Forms.BindingSource companyModelBindingSource;
        private System.Windows.Forms.TextBox StockInQuantityTextBox;
        private System.Windows.Forms.TextBox AvailableQuantityTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource itemModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dTDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stockInModelBindingSource;
    }
}