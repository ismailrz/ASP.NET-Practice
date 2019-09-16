namespace University.Views
{
    partial class TeachesUi
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
            this.TeachesGroup = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sectionIdComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TeachesSaveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.semesterComboBox = new System.Windows.Forms.ComboBox();
            this.courseIdComboBox = new System.Windows.Forms.ComboBox();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.TeachesGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeachesGroup
            // 
            this.TeachesGroup.Controls.Add(this.yearComboBox);
            this.TeachesGroup.Controls.Add(this.courseIdComboBox);
            this.TeachesGroup.Controls.Add(this.semesterComboBox);
            this.TeachesGroup.Controls.Add(this.idComboBox);
            this.TeachesGroup.Controls.Add(this.label2);
            this.TeachesGroup.Controls.Add(this.label7);
            this.TeachesGroup.Controls.Add(this.sectionIdComboBox);
            this.TeachesGroup.Controls.Add(this.label3);
            this.TeachesGroup.Controls.Add(this.TeachesSaveButton);
            this.TeachesGroup.Controls.Add(this.label4);
            this.TeachesGroup.Controls.Add(this.label1);
            this.TeachesGroup.Location = new System.Drawing.Point(29, 12);
            this.TeachesGroup.Name = "TeachesGroup";
            this.TeachesGroup.Size = new System.Drawing.Size(460, 399);
            this.TeachesGroup.TabIndex = 6;
            this.TeachesGroup.TabStop = false;
            this.TeachesGroup.Text = "Teaches";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Year";
            // 
            // sectionIdComboBox
            // 
            this.sectionIdComboBox.FormattingEnabled = true;
            this.sectionIdComboBox.Location = new System.Drawing.Point(135, 144);
            this.sectionIdComboBox.Name = "sectionIdComboBox";
            this.sectionIdComboBox.Size = new System.Drawing.Size(203, 21);
            this.sectionIdComboBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Course ID";
            // 
            // TeachesSaveButton
            // 
            this.TeachesSaveButton.Location = new System.Drawing.Point(198, 281);
            this.TeachesSaveButton.Name = "TeachesSaveButton";
            this.TeachesSaveButton.Size = new System.Drawing.Size(140, 23);
            this.TeachesSaveButton.TabIndex = 7;
            this.TeachesSaveButton.Text = "Save";
            this.TeachesSaveButton.UseVisualStyleBackColor = true;
            this.TeachesSaveButton.Click += new System.EventHandler(this.TeachesSaveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Semester";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Section ID";
            // 
            // idComboBox
            // 
            this.idComboBox.FormattingEnabled = true;
            this.idComboBox.Location = new System.Drawing.Point(135, 54);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(203, 21);
            this.idComboBox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "ID";
            // 
            // semesterComboBox
            // 
            this.semesterComboBox.FormattingEnabled = true;
            this.semesterComboBox.Location = new System.Drawing.Point(135, 189);
            this.semesterComboBox.Name = "semesterComboBox";
            this.semesterComboBox.Size = new System.Drawing.Size(203, 21);
            this.semesterComboBox.TabIndex = 18;
            // 
            // courseIdComboBox
            // 
            this.courseIdComboBox.FormattingEnabled = true;
            this.courseIdComboBox.Location = new System.Drawing.Point(135, 99);
            this.courseIdComboBox.Name = "courseIdComboBox";
            this.courseIdComboBox.Size = new System.Drawing.Size(203, 21);
            this.courseIdComboBox.TabIndex = 19;
            // 
            // yearComboBox
            // 
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(135, 238);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(203, 21);
            this.yearComboBox.TabIndex = 20;
            // 
            // TeachesUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TeachesGroup);
            this.Name = "TeachesUi";
            this.Text = "TeachesUi";
            this.TeachesGroup.ResumeLayout(false);
            this.TeachesGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TeachesGroup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox sectionIdComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button TeachesSaveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.ComboBox courseIdComboBox;
        private System.Windows.Forms.ComboBox semesterComboBox;
        private System.Windows.Forms.ComboBox idComboBox;
        private System.Windows.Forms.Label label2;
    }
}