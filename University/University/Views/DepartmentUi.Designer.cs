namespace University.Views
{
    partial class DepartmentUi
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
            this.DepartmentGroup = new System.Windows.Forms.GroupBox();
            this.DepartmentSaveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.budgetTexBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buildingTexBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.departmentNameTextBox = new System.Windows.Forms.TextBox();
            this.DepartmentGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // DepartmentGroup
            // 
            this.DepartmentGroup.Controls.Add(this.DepartmentSaveButton);
            this.DepartmentGroup.Controls.Add(this.label5);
            this.DepartmentGroup.Controls.Add(this.budgetTexBox);
            this.DepartmentGroup.Controls.Add(this.label4);
            this.DepartmentGroup.Controls.Add(this.buildingTexBox);
            this.DepartmentGroup.Controls.Add(this.label1);
            this.DepartmentGroup.Controls.Add(this.departmentNameTextBox);
            this.DepartmentGroup.Location = new System.Drawing.Point(46, 54);
            this.DepartmentGroup.Name = "DepartmentGroup";
            this.DepartmentGroup.Size = new System.Drawing.Size(366, 211);
            this.DepartmentGroup.TabIndex = 1;
            this.DepartmentGroup.TabStop = false;
            this.DepartmentGroup.Text = "Department";
            // 
            // DepartmentSaveButton
            // 
            this.DepartmentSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentSaveButton.Location = new System.Drawing.Point(227, 160);
            this.DepartmentSaveButton.Name = "DepartmentSaveButton";
            this.DepartmentSaveButton.Size = new System.Drawing.Size(105, 23);
            this.DepartmentSaveButton.TabIndex = 7;
            this.DepartmentSaveButton.Text = "Save";
            this.DepartmentSaveButton.UseVisualStyleBackColor = true;
            this.DepartmentSaveButton.Click += new System.EventHandler(this.DepartmentSaveButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Budget";
            // 
            // budgetTexBox
            // 
            this.budgetTexBox.Location = new System.Drawing.Point(129, 119);
            this.budgetTexBox.Name = "budgetTexBox";
            this.budgetTexBox.Size = new System.Drawing.Size(203, 20);
            this.budgetTexBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Building";
            // 
            // buildingTexBox
            // 
            this.buildingTexBox.Location = new System.Drawing.Point(129, 74);
            this.buildingTexBox.Name = "buildingTexBox";
            this.buildingTexBox.Size = new System.Drawing.Size(203, 20);
            this.buildingTexBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Department Name";
            // 
            // departmentNameTextBox
            // 
            this.departmentNameTextBox.Location = new System.Drawing.Point(129, 36);
            this.departmentNameTextBox.Name = "departmentNameTextBox";
            this.departmentNameTextBox.Size = new System.Drawing.Size(203, 20);
            this.departmentNameTextBox.TabIndex = 2;
            // 
            // DepartmentUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DepartmentGroup);
            this.Name = "DepartmentUi";
            this.Text = "Department";
            this.Load += new System.EventHandler(this.DepartmentForm_Load);
            this.DepartmentGroup.ResumeLayout(false);
            this.DepartmentGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox DepartmentGroup;
        private System.Windows.Forms.Button DepartmentSaveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox budgetTexBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox buildingTexBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox departmentNameTextBox;
    }
}