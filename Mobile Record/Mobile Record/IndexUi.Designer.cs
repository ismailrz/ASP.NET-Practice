namespace Mobile_Record
{
    partial class IndexUi
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
            this.InformationLabel = new System.Windows.Forms.Label();
            this.SearchPriceabel = new System.Windows.Forms.Label();
            this.SearchIMEILabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InformationLabel
            // 
            this.InformationLabel.AutoSize = true;
            this.InformationLabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.InformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformationLabel.Location = new System.Drawing.Point(90, 67);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(317, 24);
            this.InformationLabel.TabIndex = 0;
            this.InformationLabel.Text = "Save Mobile Handset Information";
            this.InformationLabel.Click += new System.EventHandler(this.InformationLabel_Click);
            // 
            // SearchPriceabel
            // 
            this.SearchPriceabel.AutoSize = true;
            this.SearchPriceabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SearchPriceabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchPriceabel.Location = new System.Drawing.Point(90, 109);
            this.SearchPriceabel.Name = "SearchPriceabel";
            this.SearchPriceabel.Size = new System.Drawing.Size(377, 24);
            this.SearchPriceabel.TabIndex = 1;
            this.SearchPriceabel.Text = "Search Mobile Handset by Price Range";
            this.SearchPriceabel.Click += new System.EventHandler(this.SearchPriceabel_Click);
            // 
            // SearchIMEILabel
            // 
            this.SearchIMEILabel.AutoSize = true;
            this.SearchIMEILabel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SearchIMEILabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchIMEILabel.Location = new System.Drawing.Point(90, 153);
            this.SearchIMEILabel.Name = "SearchIMEILabel";
            this.SearchIMEILabel.Size = new System.Drawing.Size(303, 24);
            this.SearchIMEILabel.TabIndex = 2;
            this.SearchIMEILabel.Text = "Search Mobile Handset ny IMEI";
            this.SearchIMEILabel.Click += new System.EventHandler(this.SearchIMEILabel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.InformationLabel);
            this.groupBox1.Controls.Add(this.SearchIMEILabel);
            this.groupBox1.Controls.Add(this.SearchPriceabel);
            this.groupBox1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(74, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 275);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Welcome to Mobile Handset Index";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Show All Mobile";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // IndexUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "IndexUi";
            this.Text = "Index";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label InformationLabel;
        private System.Windows.Forms.Label SearchPriceabel;
        private System.Windows.Forms.Label SearchIMEILabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}