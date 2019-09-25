namespace Stock_Management_System
{
    partial class Item_Setup
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReorderLevelTextBox = new System.Windows.Forms.TextBox();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.companyComboBox = new System.Windows.Forms.ComboBox();
            this.companyModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ReorderLevelTextBox);
            this.groupBox1.Controls.Add(this.itemTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Controls.Add(this.companyComboBox);
            this.groupBox1.Controls.Add(this.categoryComboBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(79, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Setup";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Reorder Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Item Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Company Name";
            // 
            // ReorderLevelTextBox
            // 
            this.ReorderLevelTextBox.Location = new System.Drawing.Point(246, 177);
            this.ReorderLevelTextBox.Name = "ReorderLevelTextBox";
            this.ReorderLevelTextBox.Size = new System.Drawing.Size(216, 29);
            this.ReorderLevelTextBox.TabIndex = 14;
            // 
            // itemTextBox
            // 
            this.itemTextBox.Location = new System.Drawing.Point(246, 142);
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.Size = new System.Drawing.Size(216, 29);
            this.itemTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Category Name";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(322, 214);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(140, 39);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // companyComboBox
            // 
            this.companyComboBox.DataSource = this.companyModelBindingSource;
            this.companyComboBox.DisplayMember = "CompanyName";
            this.companyComboBox.FormattingEnabled = true;
            this.companyComboBox.Location = new System.Drawing.Point(246, 100);
            this.companyComboBox.Name = "companyComboBox";
            this.companyComboBox.Size = new System.Drawing.Size(216, 32);
            this.companyComboBox.TabIndex = 10;
            this.companyComboBox.ValueMember = "Serial";
            // 
            // companyModelBindingSource
            // 
            this.companyModelBindingSource.DataSource = typeof(Stock_Management_System.Models.CompanyModel);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.categoryModelBindingSource;
            this.categoryComboBox.DisplayMember = "CategoryName";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(246, 59);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(216, 32);
            this.categoryComboBox.TabIndex = 9;
            this.categoryComboBox.ValueMember = "Serial";
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // categoryModelBindingSource
            // 
            this.categoryModelBindingSource.DataSource = typeof(Stock_Management_System.Models.CategoryModel);
            // 
            // Item_Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Item_Setup";
            this.Text = "Item Setup";
            this.Load += new System.EventHandler(this.Item_Setup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ReorderLevelTextBox;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox companyComboBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.BindingSource categoryModelBindingSource;
        private System.Windows.Forms.BindingSource companyModelBindingSource;
    }
}