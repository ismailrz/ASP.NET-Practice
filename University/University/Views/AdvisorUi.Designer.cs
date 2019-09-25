namespace University.Views
{
    partial class AdvisorUi
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
            this.AdvisorGroup = new System.Windows.Forms.GroupBox();
            this.instructorIdComboBox = new System.Windows.Forms.ComboBox();
            this.studentIdComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AdvisorSaveButton = new System.Windows.Forms.Button();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instructorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AdvisorGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AdvisorGroup
            // 
            this.AdvisorGroup.Controls.Add(this.instructorIdComboBox);
            this.AdvisorGroup.Controls.Add(this.studentIdComboBox);
            this.AdvisorGroup.Controls.Add(this.label2);
            this.AdvisorGroup.Controls.Add(this.label3);
            this.AdvisorGroup.Controls.Add(this.AdvisorSaveButton);
            this.AdvisorGroup.Location = new System.Drawing.Point(35, 39);
            this.AdvisorGroup.Name = "AdvisorGroup";
            this.AdvisorGroup.Size = new System.Drawing.Size(383, 188);
            this.AdvisorGroup.TabIndex = 8;
            this.AdvisorGroup.TabStop = false;
            this.AdvisorGroup.Text = "Advisor";
            // 
            // instructorIdComboBox
            // 
            this.instructorIdComboBox.DataSource = this.instructorBindingSource;
            this.instructorIdComboBox.DisplayMember = "ID";
            this.instructorIdComboBox.FormattingEnabled = true;
            this.instructorIdComboBox.Location = new System.Drawing.Point(135, 99);
            this.instructorIdComboBox.Name = "instructorIdComboBox";
            this.instructorIdComboBox.Size = new System.Drawing.Size(203, 21);
            this.instructorIdComboBox.TabIndex = 19;
            this.instructorIdComboBox.ValueMember = "ID";
            // 
            // studentIdComboBox
            // 
            this.studentIdComboBox.DataSource = this.studentBindingSource;
            this.studentIdComboBox.DisplayMember = "ID";
            this.studentIdComboBox.FormattingEnabled = true;
            this.studentIdComboBox.Location = new System.Drawing.Point(135, 54);
            this.studentIdComboBox.Name = "studentIdComboBox";
            this.studentIdComboBox.Size = new System.Drawing.Size(203, 21);
            this.studentIdComboBox.TabIndex = 16;
            this.studentIdComboBox.ValueMember = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Student ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Instructor ID";
            // 
            // AdvisorSaveButton
            // 
            this.AdvisorSaveButton.Location = new System.Drawing.Point(198, 142);
            this.AdvisorSaveButton.Name = "AdvisorSaveButton";
            this.AdvisorSaveButton.Size = new System.Drawing.Size(140, 23);
            this.AdvisorSaveButton.TabIndex = 7;
            this.AdvisorSaveButton.Text = "Save";
            this.AdvisorSaveButton.UseVisualStyleBackColor = true;
            this.AdvisorSaveButton.Click += new System.EventHandler(this.AdvisorSaveButton_Click);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(University.Models.Student);
            // 
            // instructorBindingSource
            // 
            this.instructorBindingSource.DataSource = typeof(University.Models.Instructor);
            // 
            // AdvisorUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AdvisorGroup);
            this.Name = "AdvisorUi";
            this.Text = "AdvisorUi";
            this.Load += new System.EventHandler(this.AdvisorUi_Load);
            this.AdvisorGroup.ResumeLayout(false);
            this.AdvisorGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instructorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AdvisorGroup;
        private System.Windows.Forms.ComboBox instructorIdComboBox;
        private System.Windows.Forms.ComboBox studentIdComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AdvisorSaveButton;
        private System.Windows.Forms.BindingSource instructorBindingSource;
        private System.Windows.Forms.BindingSource studentBindingSource;
    }
}