namespace University.Views
{
    partial class ClassRoomUi
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
            this.ClassRoomGroup = new System.Windows.Forms.GroupBox();
            this.ClassroomSaveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.capacityTexBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.roomNumberTexBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buildingTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ClassRoomGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClassRoomGroup
            // 
            this.ClassRoomGroup.Controls.Add(this.ClassroomSaveButton);
            this.ClassRoomGroup.Controls.Add(this.label5);
            this.ClassRoomGroup.Controls.Add(this.capacityTexBox);
            this.ClassRoomGroup.Controls.Add(this.label4);
            this.ClassRoomGroup.Controls.Add(this.roomNumberTexBox);
            this.ClassRoomGroup.Controls.Add(this.label1);
            this.ClassRoomGroup.Controls.Add(this.buildingTextBox);
            this.ClassRoomGroup.Location = new System.Drawing.Point(55, 67);
            this.ClassRoomGroup.Name = "ClassRoomGroup";
            this.ClassRoomGroup.Size = new System.Drawing.Size(297, 219);
            this.ClassRoomGroup.TabIndex = 0;
            this.ClassRoomGroup.TabStop = false;
            this.ClassRoomGroup.Text = "Class Room";
            // 
            // ClassroomSaveButton
            // 
            this.ClassroomSaveButton.Location = new System.Drawing.Point(192, 160);
            this.ClassroomSaveButton.Name = "ClassroomSaveButton";
            this.ClassroomSaveButton.Size = new System.Drawing.Size(75, 23);
            this.ClassroomSaveButton.TabIndex = 7;
            this.ClassroomSaveButton.Text = "Save";
            this.ClassroomSaveButton.UseVisualStyleBackColor = true;
            this.ClassroomSaveButton.Click += new System.EventHandler(this.ClassroomSaveButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Capacity";
            // 
            // capacityTexBox
            // 
            this.capacityTexBox.Location = new System.Drawing.Point(102, 119);
            this.capacityTexBox.Name = "capacityTexBox";
            this.capacityTexBox.Size = new System.Drawing.Size(165, 20);
            this.capacityTexBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Room Number";
            // 
            // roomNumberTexBox
            // 
            this.roomNumberTexBox.Location = new System.Drawing.Point(102, 74);
            this.roomNumberTexBox.Name = "roomNumberTexBox";
            this.roomNumberTexBox.Size = new System.Drawing.Size(165, 20);
            this.roomNumberTexBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Building";
            // 
            // buildingTextBox
            // 
            this.buildingTextBox.Location = new System.Drawing.Point(102, 36);
            this.buildingTextBox.Name = "buildingTextBox";
            this.buildingTextBox.Size = new System.Drawing.Size(165, 20);
            this.buildingTextBox.TabIndex = 2;
            // 
            // ClassRoomUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClassRoomGroup);
            this.Name = "ClassRoomUi";
            this.Text = "Class Room ";
            this.Load += new System.EventHandler(this.ClassRoomForm_Load);
            this.ClassRoomGroup.ResumeLayout(false);
            this.ClassRoomGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ClassRoomGroup;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button ClassroomSaveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox capacityTexBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox roomNumberTexBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox buildingTextBox;
    }
}

