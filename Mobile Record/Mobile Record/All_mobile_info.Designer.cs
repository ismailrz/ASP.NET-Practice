namespace Mobile_Record
{
    partial class All_mobile_info
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
            this.allDataGridView = new System.Windows.Forms.DataGridView();
            this.showButton = new System.Windows.Forms.Button();
            this.SearchIMEILabel = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMEIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.allDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // allDataGridView
            // 
            this.allDataGridView.AutoGenerateColumns = false;
            this.allDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.allDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.modelNameDataGridViewTextBoxColumn,
            this.iMEIDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.allDataGridView.DataSource = this.mobileBindingSource;
            this.allDataGridView.Location = new System.Drawing.Point(47, 110);
            this.allDataGridView.Name = "allDataGridView";
            this.allDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.allDataGridView.Size = new System.Drawing.Size(741, 150);
            this.allDataGridView.TabIndex = 0;
            this.allDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllDataGridView_CellContentClick);
            // 
            // showButton
            // 
            this.showButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showButton.Location = new System.Drawing.Point(158, 45);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(473, 36);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show all information";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // SearchIMEILabel
            // 
            this.SearchIMEILabel.AutoSize = true;
            this.SearchIMEILabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SearchIMEILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchIMEILabel.Location = new System.Drawing.Point(624, 335);
            this.SearchIMEILabel.Name = "SearchIMEILabel";
            this.SearchIMEILabel.Size = new System.Drawing.Size(140, 24);
            this.SearchIMEILabel.TabIndex = 3;
            this.SearchIMEILabel.Text = "Back to Home";
            this.SearchIMEILabel.Click += new System.EventHandler(this.SearchIMEILabel_Click);
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
            // All_mobile_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchIMEILabel);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.allDataGridView);
            this.Name = "All_mobile_info";
            this.Text = "All_mobile_info";
            ((System.ComponentModel.ISupportInitialize)(this.allDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView allDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMEIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mobileBindingSource;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label SearchIMEILabel;
    }
}