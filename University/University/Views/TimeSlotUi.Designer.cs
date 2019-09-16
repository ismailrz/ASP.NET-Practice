namespace University.Views
{
    partial class TimeSlotUi
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
            this.TimeSlotGroup = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.endTimeTexbox = new System.Windows.Forms.TextBox();
            this.TimeSlotSaveButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dayTexbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timeSlotIdTexbox = new System.Windows.Forms.TextBox();
            this.startTimeTexBox = new System.Windows.Forms.TextBox();
            this.TimeSlotGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimeSlotGroup
            // 
            this.TimeSlotGroup.Controls.Add(this.startTimeTexBox);
            this.TimeSlotGroup.Controls.Add(this.label2);
            this.TimeSlotGroup.Controls.Add(this.endTimeTexbox);
            this.TimeSlotGroup.Controls.Add(this.TimeSlotSaveButton);
            this.TimeSlotGroup.Controls.Add(this.label5);
            this.TimeSlotGroup.Controls.Add(this.label4);
            this.TimeSlotGroup.Controls.Add(this.dayTexbox);
            this.TimeSlotGroup.Controls.Add(this.label1);
            this.TimeSlotGroup.Controls.Add(this.timeSlotIdTexbox);
            this.TimeSlotGroup.Location = new System.Drawing.Point(33, 46);
            this.TimeSlotGroup.Name = "TimeSlotGroup";
            this.TimeSlotGroup.Size = new System.Drawing.Size(361, 271);
            this.TimeSlotGroup.TabIndex = 3;
            this.TimeSlotGroup.TabStop = false;
            this.TimeSlotGroup.Text = "Time Slot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "End Time";
            // 
            // endTimeTexbox
            // 
            this.endTimeTexbox.Location = new System.Drawing.Point(129, 162);
            this.endTimeTexbox.Name = "endTimeTexbox";
            this.endTimeTexbox.Size = new System.Drawing.Size(203, 20);
            this.endTimeTexbox.TabIndex = 9;
            // 
            // TimeSlotSaveButton
            // 
            this.TimeSlotSaveButton.Location = new System.Drawing.Point(192, 202);
            this.TimeSlotSaveButton.Name = "TimeSlotSaveButton";
            this.TimeSlotSaveButton.Size = new System.Drawing.Size(140, 23);
            this.TimeSlotSaveButton.TabIndex = 7;
            this.TimeSlotSaveButton.Text = "Save";
            this.TimeSlotSaveButton.UseVisualStyleBackColor = true;
            this.TimeSlotSaveButton.Click += new System.EventHandler(this.TimeSlotSaveButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Start Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Day";
            // 
            // dayTexbox
            // 
            this.dayTexbox.Location = new System.Drawing.Point(129, 74);
            this.dayTexbox.Name = "dayTexbox";
            this.dayTexbox.Size = new System.Drawing.Size(203, 20);
            this.dayTexbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Slot ID";
            // 
            // timeSlotIdTexbox
            // 
            this.timeSlotIdTexbox.Location = new System.Drawing.Point(129, 36);
            this.timeSlotIdTexbox.Name = "timeSlotIdTexbox";
            this.timeSlotIdTexbox.Size = new System.Drawing.Size(203, 20);
            this.timeSlotIdTexbox.TabIndex = 2;
            // 
            // startTimeTexBox
            // 
            this.startTimeTexBox.Location = new System.Drawing.Point(129, 119);
            this.startTimeTexBox.Name = "startTimeTexBox";
            this.startTimeTexBox.Size = new System.Drawing.Size(203, 20);
            this.startTimeTexBox.TabIndex = 10;
            // 
            // TimeSlotUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TimeSlotGroup);
            this.Name = "TimeSlotUi";
            this.Text = "TimeSlotUi";
            this.TimeSlotGroup.ResumeLayout(false);
            this.TimeSlotGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TimeSlotGroup;
        private System.Windows.Forms.TextBox startTimeTexBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox endTimeTexbox;
        private System.Windows.Forms.Button TimeSlotSaveButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dayTexbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox timeSlotIdTexbox;
    }
}