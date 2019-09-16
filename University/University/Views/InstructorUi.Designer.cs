﻿namespace University.Views
{
    partial class InstructorUi
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
            this.InstructorGroup = new System.Windows.Forms.GroupBox();
            this.departmentNameCombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.salaryTexbox = new System.Windows.Forms.TextBox();
            this.InstructorSaveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTexbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idTexbox = new System.Windows.Forms.TextBox();
            this.InstructorGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // InstructorGroup
            // 
            this.InstructorGroup.Controls.Add(this.departmentNameCombobox);
            this.InstructorGroup.Controls.Add(this.label2);
            this.InstructorGroup.Controls.Add(this.salaryTexbox);
            this.InstructorGroup.Controls.Add(this.InstructorSaveButton);
            this.InstructorGroup.Controls.Add(this.label5);
            this.InstructorGroup.Controls.Add(this.label4);
            this.InstructorGroup.Controls.Add(this.nameTexbox);
            this.InstructorGroup.Controls.Add(this.label1);
            this.InstructorGroup.Controls.Add(this.idTexbox);
            this.InstructorGroup.Location = new System.Drawing.Point(33, 44);
            this.InstructorGroup.Name = "InstructorGroup";
            this.InstructorGroup.Size = new System.Drawing.Size(361, 271);
            this.InstructorGroup.TabIndex = 4;
            this.InstructorGroup.TabStop = false;
            this.InstructorGroup.Text = "Instructor";
            // 
            // departmentNameCombobox
            // 
            this.departmentNameCombobox.FormattingEnabled = true;
            this.departmentNameCombobox.Location = new System.Drawing.Point(129, 119);
            this.departmentNameCombobox.Name = "departmentNameCombobox";
            this.departmentNameCombobox.Size = new System.Drawing.Size(203, 21);
            this.departmentNameCombobox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Salary";
            // 
            // salaryTexbox
            // 
            this.salaryTexbox.Location = new System.Drawing.Point(129, 162);
            this.salaryTexbox.Name = "salaryTexbox";
            this.salaryTexbox.Size = new System.Drawing.Size(203, 20);
            this.salaryTexbox.TabIndex = 9;
            // 
            // InstructorSaveButton
            // 
            this.InstructorSaveButton.Location = new System.Drawing.Point(192, 202);
            this.InstructorSaveButton.Name = "InstructorSaveButton";
            this.InstructorSaveButton.Size = new System.Drawing.Size(140, 23);
            this.InstructorSaveButton.TabIndex = 7;
            this.InstructorSaveButton.Text = "Save";
            this.InstructorSaveButton.UseVisualStyleBackColor = true;
            this.InstructorSaveButton.Click += new System.EventHandler(this.InstructorSaveButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Department Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            // 
            // nameTexbox
            // 
            this.nameTexbox.Location = new System.Drawing.Point(129, 74);
            this.nameTexbox.Name = "nameTexbox";
            this.nameTexbox.Size = new System.Drawing.Size(203, 20);
            this.nameTexbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // idTexbox
            // 
            this.idTexbox.Location = new System.Drawing.Point(129, 36);
            this.idTexbox.Name = "idTexbox";
            this.idTexbox.Size = new System.Drawing.Size(203, 20);
            this.idTexbox.TabIndex = 2;
            // 
            // InstructorUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InstructorGroup);
            this.Name = "InstructorUi";
            this.Text = "Instructor";
            this.InstructorGroup.ResumeLayout(false);
            this.InstructorGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox InstructorGroup;
        private System.Windows.Forms.ComboBox departmentNameCombobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox salaryTexbox;
        private System.Windows.Forms.Button InstructorSaveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTexbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTexbox;
    }
}