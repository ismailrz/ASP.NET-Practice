namespace Stock_Management_System
{
    partial class StockOut
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AvailableQuantityTextBox = new System.Windows.Forms.TextBox();
            this.StockOutQuantityTextBox = new System.Windows.Forms.TextBox();
            this.CompanyComboBox = new System.Windows.Forms.ComboBox();
            this.ItemComboBox = new System.Windows.Forms.ComboBox();
            this.DisplayDataGridView = new System.Windows.Forms.DataGridView();
            this.ADDButton = new System.Windows.Forms.Button();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.ReorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockOutModelBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.stockOutModelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.stockOutModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stockOutModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SellButton = new System.Windows.Forms.Button();
            this.DamageButton = new System.Windows.Forms.Button();
            this.LostButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutModelBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutModelBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(160, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Stock out Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Available Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(160, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Reorder Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(160, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Company Name";
            // 
            // AvailableQuantityTextBox
            // 
            this.AvailableQuantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailableQuantityTextBox.Location = new System.Drawing.Point(320, 129);
            this.AvailableQuantityTextBox.Name = "AvailableQuantityTextBox";
            this.AvailableQuantityTextBox.ReadOnly = true;
            this.AvailableQuantityTextBox.Size = new System.Drawing.Size(260, 22);
            this.AvailableQuantityTextBox.TabIndex = 22;
            // 
            // StockOutQuantityTextBox
            // 
            this.StockOutQuantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockOutQuantityTextBox.Location = new System.Drawing.Point(320, 164);
            this.StockOutQuantityTextBox.Name = "StockOutQuantityTextBox";
            this.StockOutQuantityTextBox.Size = new System.Drawing.Size(260, 22);
            this.StockOutQuantityTextBox.TabIndex = 21;
            // 
            // CompanyComboBox
            // 
            this.CompanyComboBox.DisplayMember = "CompanyName";
            this.CompanyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyComboBox.FormattingEnabled = true;
            this.CompanyComboBox.Location = new System.Drawing.Point(320, 41);
            this.CompanyComboBox.Name = "CompanyComboBox";
            this.CompanyComboBox.Size = new System.Drawing.Size(260, 24);
            this.CompanyComboBox.TabIndex = 20;
            this.CompanyComboBox.ValueMember = "Serial";
            this.CompanyComboBox.SelectedIndexChanged += new System.EventHandler(this.CompanyComboBox_SelectedIndexChanged_1);
            // 
            // ItemComboBox
            // 
            this.ItemComboBox.DisplayMember = "ItemName";
            this.ItemComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemComboBox.FormattingEnabled = true;
            this.ItemComboBox.Location = new System.Drawing.Point(320, 71);
            this.ItemComboBox.Name = "ItemComboBox";
            this.ItemComboBox.Size = new System.Drawing.Size(260, 24);
            this.ItemComboBox.TabIndex = 19;
            this.ItemComboBox.ValueMember = "Serial";
            this.ItemComboBox.SelectedIndexChanged += new System.EventHandler(this.ItemComboBox_SelectedIndexChanged_1);
            // 
            // DisplayDataGridView
            // 
            this.DisplayDataGridView.AutoGenerateColumns = false;
            this.DisplayDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DisplayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.quantityOutDataGridViewTextBoxColumn});
            this.DisplayDataGridView.DataSource = this.stockOutModelBindingSource3;
            this.DisplayDataGridView.Location = new System.Drawing.Point(46, 248);
            this.DisplayDataGridView.Name = "DisplayDataGridView";
            this.DisplayDataGridView.Size = new System.Drawing.Size(704, 121);
            this.DisplayDataGridView.TabIndex = 18;
            // 
            // ADDButton
            // 
            this.ADDButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ADDButton.Location = new System.Drawing.Point(443, 196);
            this.ADDButton.Name = "ADDButton";
            this.ADDButton.Size = new System.Drawing.Size(137, 36);
            this.ADDButton.TabIndex = 17;
            this.ADDButton.Text = "ADD";
            this.ADDButton.UseVisualStyleBackColor = true;
            this.ADDButton.Click += new System.EventHandler(this.ADDButton_Click);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DisplayMember = "CategoryName";
            this.CategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(320, 11);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(260, 24);
            this.CategoryComboBox.TabIndex = 16;
            this.CategoryComboBox.ValueMember = "Serial";
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged_1);
            // 
            // ReorderLevelTextBox
            // 
            this.ReorderLevelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReorderLevelTextBox.Location = new System.Drawing.Point(320, 101);
            this.ReorderLevelTextBox.Name = "ReorderLevelTextBox";
            this.ReorderLevelTextBox.ReadOnly = true;
            this.ReorderLevelTextBox.Size = new System.Drawing.Size(260, 22);
            this.ReorderLevelTextBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Category Name";
            // 
            // serialDataGridViewTextBoxColumn
            // 
            this.serialDataGridViewTextBoxColumn.DataPropertyName = "Serial";
            this.serialDataGridViewTextBoxColumn.HeaderText = "Serial";
            this.serialDataGridViewTextBoxColumn.Name = "serialDataGridViewTextBoxColumn";
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            // 
            // quantityOutDataGridViewTextBoxColumn
            // 
            this.quantityOutDataGridViewTextBoxColumn.DataPropertyName = "QuantityOut";
            this.quantityOutDataGridViewTextBoxColumn.HeaderText = "QuantityOut";
            this.quantityOutDataGridViewTextBoxColumn.Name = "quantityOutDataGridViewTextBoxColumn";
            // 
            // stockOutModelBindingSource3
            // 
            this.stockOutModelBindingSource3.DataSource = typeof(Stock_Management_System.Models.StockOutModel);
            // 
            // stockOutModelBindingSource2
            // 
            this.stockOutModelBindingSource2.DataSource = typeof(Stock_Management_System.Models.StockOutModel);
            // 
            // stockOutModelBindingSource1
            // 
            this.stockOutModelBindingSource1.DataSource = typeof(Stock_Management_System.Models.StockOutModel);
            // 
            // stockOutModelBindingSource
            // 
            this.stockOutModelBindingSource.DataSource = typeof(Stock_Management_System.Models.StockOutModel);
            // 
            // SellButton
            // 
            this.SellButton.Location = new System.Drawing.Point(291, 397);
            this.SellButton.Name = "SellButton";
            this.SellButton.Size = new System.Drawing.Size(75, 23);
            this.SellButton.TabIndex = 28;
            this.SellButton.Text = "Sell";
            this.SellButton.UseVisualStyleBackColor = true;
            this.SellButton.Click += new System.EventHandler(this.SellButton_Click);
            // 
            // DamageButton
            // 
            this.DamageButton.Location = new System.Drawing.Point(530, 397);
            this.DamageButton.Name = "DamageButton";
            this.DamageButton.Size = new System.Drawing.Size(75, 23);
            this.DamageButton.TabIndex = 29;
            this.DamageButton.Text = "Damage";
            this.DamageButton.UseVisualStyleBackColor = true;
            this.DamageButton.Click += new System.EventHandler(this.DamageButton_Click);
            // 
            // LostButton
            // 
            this.LostButton.Location = new System.Drawing.Point(412, 397);
            this.LostButton.Name = "LostButton";
            this.LostButton.Size = new System.Drawing.Size(75, 23);
            this.LostButton.TabIndex = 30;
            this.LostButton.Text = "Lost";
            this.LostButton.UseVisualStyleBackColor = true;
            this.LostButton.Click += new System.EventHandler(this.LostButton_Click);
            // 
            // StockOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LostButton);
            this.Controls.Add(this.DamageButton);
            this.Controls.Add(this.SellButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AvailableQuantityTextBox);
            this.Controls.Add(this.StockOutQuantityTextBox);
            this.Controls.Add(this.CompanyComboBox);
            this.Controls.Add(this.ItemComboBox);
            this.Controls.Add(this.DisplayDataGridView);
            this.Controls.Add(this.ADDButton);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.ReorderLevelTextBox);
            this.Controls.Add(this.label1);
            this.Name = "StockOut";
            this.Text = "StockOut";
            this.Load += new System.EventHandler(this.StockOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutModelBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutModelBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AvailableQuantityTextBox;
        private System.Windows.Forms.TextBox StockOutQuantityTextBox;
        private System.Windows.Forms.ComboBox CompanyComboBox;
        private System.Windows.Forms.ComboBox ItemComboBox;
        private System.Windows.Forms.DataGridView DisplayDataGridView;
        private System.Windows.Forms.Button ADDButton;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.TextBox ReorderLevelTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stockOutModelBindingSource;
        private System.Windows.Forms.BindingSource stockOutModelBindingSource1;
        private System.Windows.Forms.BindingSource stockOutModelBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stockOutModelBindingSource3;
        private System.Windows.Forms.Button SellButton;
        private System.Windows.Forms.Button DamageButton;
        private System.Windows.Forms.Button LostButton;
    }
}