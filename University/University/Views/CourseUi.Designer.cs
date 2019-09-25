namespace University.Views
{
    partial class CourseUi
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
            this.CourseGroup = new System.Windows.Forms.GroupBox();
            this.departmentNameCombobox = new System.Windows.Forms.ComboBox();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.creditsTexbox = new System.Windows.Forms.TextBox();
            this.CourseSaveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.titleTexbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.courseIdTexbox = new System.Windows.Forms.TextBox();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.CourseGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // CourseGroup
            // 
            this.CourseGroup.Controls.Add(this.departmentNameCombobox);
            this.CourseGroup.Controls.Add(this.label2);
            this.CourseGroup.Controls.Add(this.creditsTexbox);
            this.CourseGroup.Controls.Add(this.CourseSaveButton);
            this.CourseGroup.Controls.Add(this.label5);
            this.CourseGroup.Controls.Add(this.label4);
            this.CourseGroup.Controls.Add(this.titleTexbox);
            this.CourseGroup.Controls.Add(this.label1);
            this.CourseGroup.Controls.Add(this.courseIdTexbox);
            this.CourseGroup.Location = new System.Drawing.Point(42, 37);
            this.CourseGroup.Name = "CourseGroup";
            this.CourseGroup.Size = new System.Drawing.Size(361, 271);
            this.CourseGroup.TabIndex = 2;
            this.CourseGroup.TabStop = false;
            this.CourseGroup.Text = "Course";
            // 
            // departmentNameCombobox
            // 
            this.departmentNameCombobox.DataSource = this.departmentBindingSource;
            this.departmentNameCombobox.DisplayMember = "Dept_name";
            this.departmentNameCombobox.FormattingEnabled = true;
            this.departmentNameCombobox.Location = new System.Drawing.Point(129, 119);
            this.departmentNameCombobox.Name = "departmentNameCombobox";
            this.departmentNameCombobox.Size = new System.Drawing.Size(203, 21);
            this.departmentNameCombobox.TabIndex = 3;
            this.departmentNameCombobox.ValueMember = "Dept_Name";
            this.departmentNameCombobox.SelectedIndexChanged += new System.EventHandler(this.DepartmentNameCombobox_SelectedIndexChanged);
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataSource = typeof(University.Models.Department);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Credits";
            // 
            // creditsTexbox
            // 
            this.creditsTexbox.Location = new System.Drawing.Point(129, 162);
            this.creditsTexbox.Name = "creditsTexbox";
            this.creditsTexbox.Size = new System.Drawing.Size(203, 20);
            this.creditsTexbox.TabIndex = 9;
            // 
            // CourseSaveButton
            // 
            this.CourseSaveButton.Location = new System.Drawing.Point(192, 202);
            this.CourseSaveButton.Name = "CourseSaveButton";
            this.CourseSaveButton.Size = new System.Drawing.Size(140, 23);
            this.CourseSaveButton.TabIndex = 7;
            this.CourseSaveButton.Text = "Save";
            this.CourseSaveButton.UseVisualStyleBackColor = true;
            this.CourseSaveButton.Click += new System.EventHandler(this.CourseSaveButton_Click);
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
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Title";
            // 
            // titleTexbox
            // 
            this.titleTexbox.Location = new System.Drawing.Point(129, 74);
            this.titleTexbox.Name = "titleTexbox";
            this.titleTexbox.Size = new System.Drawing.Size(203, 20);
            this.titleTexbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cousre ID";
            // 
            // courseIdTexbox
            // 
            this.courseIdTexbox.Location = new System.Drawing.Point(129, 36);
            this.courseIdTexbox.Name = "courseIdTexbox";
            this.courseIdTexbox.Size = new System.Drawing.Size(203, 20);
            this.courseIdTexbox.TabIndex = 2;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataSource = typeof(University.Models.Course);
            // 
            // courseBindingSource1
            // 
            this.courseBindingSource1.DataSource = typeof(University.Models.Course);
            // 
            // CourseUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CourseGroup);
            this.Name = "CourseUi";
            this.Text = "Course";
            this.Load += new System.EventHandler(this.CourseForm_Load);
            this.CourseGroup.ResumeLayout(false);
            this.CourseGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CourseGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox creditsTexbox;
        private System.Windows.Forms.Button CourseSaveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox titleTexbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox courseIdTexbox;
        private System.Windows.Forms.ComboBox departmentNameCombobox;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private System.Windows.Forms.BindingSource courseBindingSource1;
    }
}

