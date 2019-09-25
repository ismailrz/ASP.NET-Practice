namespace University.Views
{
    partial class SectionUi
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
            this.SectionGroup = new System.Windows.Forms.GroupBox();
            this.semesterComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.yearTexbox = new System.Windows.Forms.TextBox();
            this.buildingComboBox = new System.Windows.Forms.ComboBox();
            this.classroomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.courseIdComboBox = new System.Windows.Forms.ComboBox();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.roomNumberComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timeSlotIdTexbox = new System.Windows.Forms.TextBox();
            this.SectionSaveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sectionIdTexbox = new System.Windows.Forms.TextBox();
            this.SectionGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classroomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SectionGroup
            // 
            this.SectionGroup.Controls.Add(this.semesterComboBox);
            this.SectionGroup.Controls.Add(this.label7);
            this.SectionGroup.Controls.Add(this.yearTexbox);
            this.SectionGroup.Controls.Add(this.buildingComboBox);
            this.SectionGroup.Controls.Add(this.label6);
            this.SectionGroup.Controls.Add(this.courseIdComboBox);
            this.SectionGroup.Controls.Add(this.label3);
            this.SectionGroup.Controls.Add(this.roomNumberComboBox);
            this.SectionGroup.Controls.Add(this.label2);
            this.SectionGroup.Controls.Add(this.timeSlotIdTexbox);
            this.SectionGroup.Controls.Add(this.SectionSaveButton);
            this.SectionGroup.Controls.Add(this.label5);
            this.SectionGroup.Controls.Add(this.label4);
            this.SectionGroup.Controls.Add(this.label1);
            this.SectionGroup.Controls.Add(this.sectionIdTexbox);
            this.SectionGroup.Location = new System.Drawing.Point(40, 12);
            this.SectionGroup.Name = "SectionGroup";
            this.SectionGroup.Size = new System.Drawing.Size(460, 399);
            this.SectionGroup.TabIndex = 5;
            this.SectionGroup.TabStop = false;
            this.SectionGroup.Text = "Section";
            // 
            // semesterComboBox
            // 
            this.semesterComboBox.FormattingEnabled = true;
            this.semesterComboBox.Items.AddRange(new object[] {
            "Fall",
            "Winter",
            "Spring",
            "summer"});
            this.semesterComboBox.Location = new System.Drawing.Point(135, 119);
            this.semesterComboBox.Name = "semesterComboBox";
            this.semesterComboBox.Size = new System.Drawing.Size(203, 21);
            this.semesterComboBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Year";
            // 
            // yearTexbox
            // 
            this.yearTexbox.Location = new System.Drawing.Point(135, 158);
            this.yearTexbox.Name = "yearTexbox";
            this.yearTexbox.Size = new System.Drawing.Size(203, 20);
            this.yearTexbox.TabIndex = 15;
            // 
            // buildingComboBox
            // 
            this.buildingComboBox.DataSource = this.classroomBindingSource;
            this.buildingComboBox.DisplayMember = "Building";
            this.buildingComboBox.FormattingEnabled = true;
            this.buildingComboBox.Location = new System.Drawing.Point(135, 193);
            this.buildingComboBox.Name = "buildingComboBox";
            this.buildingComboBox.Size = new System.Drawing.Size(203, 21);
            this.buildingComboBox.TabIndex = 12;
            this.buildingComboBox.ValueMember = "Building";
            // 
            // classroomBindingSource
            // 
            this.classroomBindingSource.DataSource = typeof(University.Models.Classroom);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Building";
            // 
            // courseIdComboBox
            // 
            this.courseIdComboBox.DataSource = this.courseBindingSource;
            this.courseIdComboBox.DisplayMember = "Course_id";
            this.courseIdComboBox.FormattingEnabled = true;
            this.courseIdComboBox.Location = new System.Drawing.Point(135, 36);
            this.courseIdComboBox.Name = "courseIdComboBox";
            this.courseIdComboBox.Size = new System.Drawing.Size(203, 21);
            this.courseIdComboBox.TabIndex = 10;
            this.courseIdComboBox.ValueMember = "Course_id";
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(University.Models.Course);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Course ID";
            // 
            // roomNumberComboBox
            // 
            this.roomNumberComboBox.DataSource = this.classroomBindingSource;
            this.roomNumberComboBox.DisplayMember = "Room_Number";
            this.roomNumberComboBox.FormattingEnabled = true;
            this.roomNumberComboBox.Location = new System.Drawing.Point(135, 237);
            this.roomNumberComboBox.Name = "roomNumberComboBox";
            this.roomNumberComboBox.Size = new System.Drawing.Size(203, 21);
            this.roomNumberComboBox.TabIndex = 3;
            this.roomNumberComboBox.ValueMember = "Room_Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Time slot Id";
            // 
            // timeSlotIdTexbox
            // 
            this.timeSlotIdTexbox.Location = new System.Drawing.Point(135, 280);
            this.timeSlotIdTexbox.Name = "timeSlotIdTexbox";
            this.timeSlotIdTexbox.Size = new System.Drawing.Size(203, 20);
            this.timeSlotIdTexbox.TabIndex = 9;
            // 
            // SectionSaveButton
            // 
            this.SectionSaveButton.Location = new System.Drawing.Point(198, 322);
            this.SectionSaveButton.Name = "SectionSaveButton";
            this.SectionSaveButton.Size = new System.Drawing.Size(140, 23);
            this.SectionSaveButton.TabIndex = 7;
            this.SectionSaveButton.Text = "Save";
            this.SectionSaveButton.UseVisualStyleBackColor = true;
            this.SectionSaveButton.Click += new System.EventHandler(this.SectionSaveButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Room Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Semester";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Section ID";
            // 
            // sectionIdTexbox
            // 
            this.sectionIdTexbox.Location = new System.Drawing.Point(135, 77);
            this.sectionIdTexbox.Name = "sectionIdTexbox";
            this.sectionIdTexbox.Size = new System.Drawing.Size(203, 20);
            this.sectionIdTexbox.TabIndex = 2;
            // 
            // SectionUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SectionGroup);
            this.Name = "SectionUi";
            this.Text = "SectionUi";
            this.Load += new System.EventHandler(this.SectionUi_Load);
            this.SectionGroup.ResumeLayout(false);
            this.SectionGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classroomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SectionGroup;
        private System.Windows.Forms.ComboBox roomNumberComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox timeSlotIdTexbox;
        private System.Windows.Forms.Button SectionSaveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sectionIdTexbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox yearTexbox;
        private System.Windows.Forms.ComboBox buildingComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox courseIdComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox semesterComboBox;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.BindingSource classroomBindingSource;
    }
}