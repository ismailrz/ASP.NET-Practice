namespace University.Views
{
    partial class PrereqUi
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
            this.PrereqGroup = new System.Windows.Forms.GroupBox();
            this.prereqIdComboBox = new System.Windows.Forms.ComboBox();
            this.courseIdComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PrereqSaveButton = new System.Windows.Forms.Button();
            this.PrereqGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrereqGroup
            // 
            this.PrereqGroup.Controls.Add(this.prereqIdComboBox);
            this.PrereqGroup.Controls.Add(this.courseIdComboBox);
            this.PrereqGroup.Controls.Add(this.label2);
            this.PrereqGroup.Controls.Add(this.label3);
            this.PrereqGroup.Controls.Add(this.PrereqSaveButton);
            this.PrereqGroup.Location = new System.Drawing.Point(26, 30);
            this.PrereqGroup.Name = "PrereqGroup";
            this.PrereqGroup.Size = new System.Drawing.Size(383, 188);
            this.PrereqGroup.TabIndex = 9;
            this.PrereqGroup.TabStop = false;
            this.PrereqGroup.Text = "Prereq";
            // 
            // prereqIdComboBox
            // 
            this.prereqIdComboBox.FormattingEnabled = true;
            this.prereqIdComboBox.Location = new System.Drawing.Point(135, 99);
            this.prereqIdComboBox.Name = "prereqIdComboBox";
            this.prereqIdComboBox.Size = new System.Drawing.Size(203, 21);
            this.prereqIdComboBox.TabIndex = 19;
            // 
            // courseIdComboBox
            // 
            this.courseIdComboBox.FormattingEnabled = true;
            this.courseIdComboBox.Location = new System.Drawing.Point(135, 54);
            this.courseIdComboBox.Name = "courseIdComboBox";
            this.courseIdComboBox.Size = new System.Drawing.Size(203, 21);
            this.courseIdComboBox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Course ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Prereq ID";
            // 
            // PrereqSaveButton
            // 
            this.PrereqSaveButton.Location = new System.Drawing.Point(198, 142);
            this.PrereqSaveButton.Name = "PrereqSaveButton";
            this.PrereqSaveButton.Size = new System.Drawing.Size(140, 23);
            this.PrereqSaveButton.TabIndex = 7;
            this.PrereqSaveButton.Text = "Save";
            this.PrereqSaveButton.UseVisualStyleBackColor = true;
            this.PrereqSaveButton.Click += new System.EventHandler(this.PrereqSaveButton_Click);
            // 
            // PrereqUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PrereqGroup);
            this.Name = "PrereqUi";
            this.Text = "PrereqUi";
            this.PrereqGroup.ResumeLayout(false);
            this.PrereqGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PrereqGroup;
        private System.Windows.Forms.ComboBox prereqIdComboBox;
        private System.Windows.Forms.ComboBox courseIdComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PrereqSaveButton;
    }
}