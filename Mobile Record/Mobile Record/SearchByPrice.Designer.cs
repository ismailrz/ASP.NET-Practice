namespace Mobile_Record
{
    partial class SearchByPrice
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maxPriveTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.minPriceTextBox1 = new System.Windows.Forms.TextBox();
            this.displayDataGridView = new System.Windows.Forms.DataGridView();
            this.SearchIMEILabel = new System.Windows.Forms.Label();
            this.InformationLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMEIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price between ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maxPriveTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SearchButton);
            this.groupBox1.Controls.Add(this.minPriceTextBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(43, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By Price Range";
            // 
            // maxPriveTextBox
            // 
            this.maxPriveTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxPriveTextBox.Location = new System.Drawing.Point(374, 46);
            this.maxPriveTextBox.Name = "maxPriveTextBox";
            this.maxPriveTextBox.Size = new System.Drawing.Size(145, 26);
            this.maxPriveTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "and";
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(563, 46);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(107, 29);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // minPriceTextBox1
            // 
            this.minPriceTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minPriceTextBox1.Location = new System.Drawing.Point(154, 46);
            this.minPriceTextBox1.Name = "minPriceTextBox1";
            this.minPriceTextBox1.Size = new System.Drawing.Size(133, 26);
            this.minPriceTextBox1.TabIndex = 1;
            // 
            // displayDataGridView
            // 
            this.displayDataGridView.AutoGenerateColumns = false;
            this.displayDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.displayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.modelNameDataGridViewTextBoxColumn,
            this.iMEIDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.displayDataGridView.DataSource = this.mobileBindingSource;
            this.displayDataGridView.Location = new System.Drawing.Point(30, 133);
            this.displayDataGridView.Name = "displayDataGridView";
            this.displayDataGridView.Size = new System.Drawing.Size(720, 140);
            this.displayDataGridView.TabIndex = 2;
            // 
            // SearchIMEILabel
            // 
            this.SearchIMEILabel.AutoSize = true;
            this.SearchIMEILabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SearchIMEILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchIMEILabel.Location = new System.Drawing.Point(118, 362);
            this.SearchIMEILabel.Name = "SearchIMEILabel";
            this.SearchIMEILabel.Size = new System.Drawing.Size(224, 16);
            this.SearchIMEILabel.TabIndex = 7;
            this.SearchIMEILabel.Text = "Search Mobile Handset ny IMEI";
            this.SearchIMEILabel.Click += new System.EventHandler(this.SearchIMEILabel_Click);
            // 
            // InformationLabel
            // 
            this.InformationLabel.AutoSize = true;
            this.InformationLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.InformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformationLabel.Location = new System.Drawing.Point(118, 324);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(226, 18);
            this.InformationLabel.TabIndex = 8;
            this.InformationLabel.Text = "Save Mobile Handset Information";
            this.InformationLabel.Click += new System.EventHandler(this.InformationLabel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(659, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Back to Home";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // modelNameDataGridViewTextBoxColumn
            // 
            this.modelNameDataGridViewTextBoxColumn.DataPropertyName = "ModelName";
            this.modelNameDataGridViewTextBoxColumn.HeaderText = "ModelName";
            this.modelNameDataGridViewTextBoxColumn.Name = "modelNameDataGridViewTextBoxColumn";
            // 
            // iMEIDataGridViewTextBoxColumn
            // 
            this.iMEIDataGridViewTextBoxColumn.DataPropertyName = "IMEI";
            this.iMEIDataGridViewTextBoxColumn.HeaderText = "IMEI";
            this.iMEIDataGridViewTextBoxColumn.Name = "iMEIDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // mobileBindingSource
            // 
            this.mobileBindingSource.DataSource = typeof(Mobile_Record.Models.Mobile);
            // 
            // SearchByPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.InformationLabel);
            this.Controls.Add(this.SearchIMEILabel);
            this.Controls.Add(this.displayDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchByPrice";
            this.Text = "SearchByPrice";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox maxPriveTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox minPriceTextBox1;
        private System.Windows.Forms.DataGridView displayDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMEIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mobileBindingSource;
        private System.Windows.Forms.Label SearchIMEILabel;
        private System.Windows.Forms.Label InformationLabel;
        private System.Windows.Forms.Label label6;
    }
}