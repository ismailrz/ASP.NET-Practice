namespace University.Views
{
    partial class TakesUi
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
            this.TakesGroup = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gradeTexBox = new System.Windows.Forms.TextBox();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.sectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseIdComboBox = new System.Windows.Forms.ComboBox();
            this.semesterComboBox = new System.Windows.Forms.ComboBox();
            this.idComboBox = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sectionIdComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TakesSaveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TakesGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TakesGroup
            // 
            this.TakesGroup.Controls.Add(this.label5);
            this.TakesGroup.Controls.Add(this.gradeTexBox);
            this.TakesGroup.Controls.Add(this.yearComboBox);
            this.TakesGroup.Controls.Add(this.courseIdComboBox);
            this.TakesGroup.Controls.Add(this.semesterComboBox);
            this.TakesGroup.Controls.Add(this.idComboBox);
            this.TakesGroup.Controls.Add(this.label2);
            this.TakesGroup.Controls.Add(this.label7);
            this.TakesGroup.Controls.Add(this.sectionIdComboBox);
            this.TakesGroup.Controls.Add(this.label3);
            this.TakesGroup.Controls.Add(this.TakesSaveButton);
            this.TakesGroup.Controls.Add(this.label4);
            this.TakesGroup.Controls.Add(this.label1);
            this.TakesGroup.Location = new System.Drawing.Point(12, 12);
            this.TakesGroup.Name = "TakesGroup";
            this.TakesGroup.Size = new System.Drawing.Size(460, 399);
            this.TakesGroup.TabIndex = 7;
            this.TakesGroup.TabStop = false;
            this.TakesGroup.Text = "Takes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Grade";
            // 
            // gradeTexBox
            // 
            this.gradeTexBox.Location = new System.Drawing.Point(135, 274);
            this.gradeTexBox.Name = "gradeTexBox";
            this.gradeTexBox.Size = new System.Drawing.Size(203, 20);
            this.gradeTexBox.TabIndex = 21;
            // 
            // yearComboBox
            // 
            this.yearComboBox.DataSource = this.sectionBindingSource;
            this.yearComboBox.DisplayMember = "Year";
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(135, 238);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(203, 21);
            this.yearComboBox.TabIndex = 20;
            this.yearComboBox.ValueMember = "Year";
            // 
            // sectionBindingSource
            // 
            this.sectionBindingSource.DataSource = typeof(University.Models.Section);
            // 
            // courseIdComboBox
            // 
            this.courseIdComboBox.DataSource = this.sectionBindingSource;
            this.courseIdComboBox.DisplayMember = "Course_id";
            this.courseIdComboBox.FormattingEnabled = true;
            this.courseIdComboBox.Location = new System.Drawing.Point(135, 99);
            this.courseIdComboBox.Name = "courseIdComboBox";
            this.courseIdComboBox.Size = new System.Drawing.Size(203, 21);
            this.courseIdComboBox.TabIndex = 19;
            this.courseIdComboBox.ValueMember = "Course_id";
            // 
            // semesterComboBox
            // 
            this.semesterComboBox.DataSource = this.sectionBindingSource;
            this.semesterComboBox.DisplayMember = "Semester";
            this.semesterComboBox.FormattingEnabled = true;
            this.semesterComboBox.Location = new System.Drawing.Point(135, 189);
            this.semesterComboBox.Name = "semesterComboBox";
            this.semesterComboBox.Size = new System.Drawing.Size(203, 21);
            this.semesterComboBox.TabIndex = 18;
            this.semesterComboBox.ValueMember = "Semester";
            // 
            // idComboBox
            // 
            this.idComboBox.DataSource = this.studentBindingSource;
            this.idComboBox.DisplayMember = "ID";
            this.idComboBox.FormattingEnabled = true;
            this.idComboBox.Location = new System.Drawing.Point(135, 54);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(203, 21);
            this.idComboBox.TabIndex = 16;
            this.idComboBox.ValueMember = "ID";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(University.Models.Student);
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
            this.sectionIdComboBox.DataSource = this.sectionBindingSource;
            this.sectionIdComboBox.DisplayMember = "sec_id";
            this.sectionIdComboBox.FormattingEnabled = true;
            this.sectionIdComboBox.Location = new System.Drawing.Point(135, 144);
            this.sectionIdComboBox.Name = "sectionIdComboBox";
            this.sectionIdComboBox.Size = new System.Drawing.Size(203, 21);
            this.sectionIdComboBox.TabIndex = 10;
            this.sectionIdComboBox.ValueMember = "sec_id";
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
            // TakesSaveButton
            // 
            this.TakesSaveButton.Location = new System.Drawing.Point(198, 309);
            this.TakesSaveButton.Name = "TakesSaveButton";
            this.TakesSaveButton.Size = new System.Drawing.Size(140, 23);
            this.TakesSaveButton.TabIndex = 7;
            this.TakesSaveButton.Text = "Save";
            this.TakesSaveButton.UseVisualStyleBackColor = true;
            this.TakesSaveButton.Click += new System.EventHandler(this.TakesSaveButton_Click);
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
            // TakesUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TakesGroup);
            this.Name = "TakesUi";
            this.Text = "TakesUi";
            this.Load += new System.EventHandler(this.TakesUi_Load);
            this.TakesGroup.ResumeLayout(false);
            this.TakesGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TakesGroup;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.ComboBox courseIdComboBox;
        private System.Windows.Forms.ComboBox semesterComboBox;
        private System.Windows.Forms.ComboBox idComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox sectionIdComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button TakesSaveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox gradeTexBox;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.BindingSource sectionBindingSource;
    }
}