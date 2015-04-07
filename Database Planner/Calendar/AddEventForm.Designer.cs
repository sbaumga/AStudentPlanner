namespace Planner {
    partial class AddEventForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEventForm));
            this.lblEventTitle = new System.Windows.Forms.Label();
            this.lblEventText = new System.Windows.Forms.Label();
            this.txtEventTitle = new System.Windows.Forms.TextBox();
            this.lblEventDescription = new System.Windows.Forms.Label();
            this.txtEventDescription = new System.Windows.Forms.TextBox();
            this.lblRequiredEvent1 = new System.Windows.Forms.Label();
            this.dtEventEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEventEndDate = new System.Windows.Forms.Label();
            this.dtEventStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEventStartDate = new System.Windows.Forms.Label();
            this.lblRequiredEvent3 = new System.Windows.Forms.Label();
            this.dtEventEndTime = new System.Windows.Forms.DateTimePicker();
            this.lblEventEndTime = new System.Windows.Forms.Label();
            this.dtEventStartTime = new System.Windows.Forms.DateTimePicker();
            this.lblEventStartTime = new System.Windows.Forms.Label();
            this.chkAllDayEvent = new System.Windows.Forms.CheckBox();
            this.lblRequiredEvent5 = new System.Windows.Forms.Label();
            this.cbEventClass = new System.Windows.Forms.ComboBox();
            this.lblEventClass = new System.Windows.Forms.Label();
            this.chkGradedAssignment = new System.Windows.Forms.CheckBox();
            this.lblEventType = new System.Windows.Forms.Label();
            this.cbEventType = new System.Windows.Forms.ComboBox();
            this.lblEventGrade = new System.Windows.Forms.Label();
            this.txtEventGrade = new System.Windows.Forms.TextBox();
            this.lblTotalPoints = new System.Windows.Forms.Label();
            this.txtEventGradeTotalPoints = new System.Windows.Forms.TextBox();
            this.btnSaveCloseEvent = new System.Windows.Forms.Button();
            this.btnCloseEvent = new System.Windows.Forms.Button();
            this.lblAssignmentName = new System.Windows.Forms.Label();
            this.txtAssignmentName = new System.Windows.Forms.TextBox();
            this.eventInfoPanel = new System.Windows.Forms.Panel();
            this.lblRequiredEvent4 = new System.Windows.Forms.Label();
            this.lblRequiredEvent2 = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.eventInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEventTitle
            // 
            this.lblEventTitle.AutoSize = true;
            this.lblEventTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventTitle.Location = new System.Drawing.Point(63, 38);
            this.lblEventTitle.Name = "lblEventTitle";
            this.lblEventTitle.Size = new System.Drawing.Size(45, 17);
            this.lblEventTitle.TabIndex = 11;
            this.lblEventTitle.Text = "Title:";
            // 
            // lblEventText
            // 
            this.lblEventText.AutoSize = true;
            this.lblEventText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventText.Location = new System.Drawing.Point(12, 9);
            this.lblEventText.Name = "lblEventText";
            this.lblEventText.Size = new System.Drawing.Size(301, 17);
            this.lblEventText.TabIndex = 12;
            this.lblEventText.Text = "Enter the following information about the event";
            this.lblEventText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEventTitle
            // 
            this.txtEventTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEventTitle.Location = new System.Drawing.Point(124, 38);
            this.txtEventTitle.Name = "txtEventTitle";
            this.txtEventTitle.Size = new System.Drawing.Size(189, 20);
            this.txtEventTitle.TabIndex = 0;
            // 
            // lblEventDescription
            // 
            this.lblEventDescription.AutoSize = true;
            this.lblEventDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDescription.Location = new System.Drawing.Point(13, 68);
            this.lblEventDescription.Name = "lblEventDescription";
            this.lblEventDescription.Size = new System.Drawing.Size(95, 17);
            this.lblEventDescription.TabIndex = 14;
            this.lblEventDescription.Text = "Description:";
            // 
            // txtEventDescription
            // 
            this.txtEventDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEventDescription.Location = new System.Drawing.Point(124, 68);
            this.txtEventDescription.Multiline = true;
            this.txtEventDescription.Name = "txtEventDescription";
            this.txtEventDescription.Size = new System.Drawing.Size(189, 64);
            this.txtEventDescription.TabIndex = 1;
            // 
            // lblRequiredEvent1
            // 
            this.lblRequiredEvent1.AutoSize = true;
            this.lblRequiredEvent1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredEvent1.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredEvent1.Location = new System.Drawing.Point(321, 41);
            this.lblRequiredEvent1.Name = "lblRequiredEvent1";
            this.lblRequiredEvent1.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredEvent1.TabIndex = 34;
            this.lblRequiredEvent1.Text = "*";
            // 
            // dtEventEndDate
            // 
            this.dtEventEndDate.CustomFormat = "MM/dd/yy";
            this.dtEventEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEventEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEventEndDate.Location = new System.Drawing.Point(124, 214);
            this.dtEventEndDate.Name = "dtEventEndDate";
            this.dtEventEndDate.Size = new System.Drawing.Size(83, 23);
            this.dtEventEndDate.TabIndex = 5;
            this.dtEventEndDate.Value = new System.DateTime(2011, 4, 3, 12, 0, 0, 0);
            this.dtEventEndDate.ValueChanged += new System.EventHandler(this.dtEventEndDate_ValueChanged);
            // 
            // lblEventEndDate
            // 
            this.lblEventEndDate.AutoSize = true;
            this.lblEventEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventEndDate.Location = new System.Drawing.Point(28, 220);
            this.lblEventEndDate.Name = "lblEventEndDate";
            this.lblEventEndDate.Size = new System.Drawing.Size(80, 17);
            this.lblEventEndDate.TabIndex = 53;
            this.lblEventEndDate.Text = "End Date:";
            // 
            // dtEventStartDate
            // 
            this.dtEventStartDate.CustomFormat = "MM/dd/yy";
            this.dtEventStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEventStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEventStartDate.Location = new System.Drawing.Point(124, 185);
            this.dtEventStartDate.Name = "dtEventStartDate";
            this.dtEventStartDate.Size = new System.Drawing.Size(83, 23);
            this.dtEventStartDate.TabIndex = 3;
            this.dtEventStartDate.Value = new System.DateTime(2011, 4, 3, 11, 0, 0, 0);
            this.dtEventStartDate.ValueChanged += new System.EventHandler(this.dtEventStartDate_ValueChanged);
            // 
            // lblEventStartDate
            // 
            this.lblEventStartDate.AutoSize = true;
            this.lblEventStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventStartDate.Location = new System.Drawing.Point(21, 185);
            this.lblEventStartDate.Name = "lblEventStartDate";
            this.lblEventStartDate.Size = new System.Drawing.Size(87, 17);
            this.lblEventStartDate.TabIndex = 52;
            this.lblEventStartDate.Text = "Start Date:";
            // 
            // lblRequiredEvent3
            // 
            this.lblRequiredEvent3.AutoSize = true;
            this.lblRequiredEvent3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredEvent3.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredEvent3.Location = new System.Drawing.Point(435, 188);
            this.lblRequiredEvent3.Name = "lblRequiredEvent3";
            this.lblRequiredEvent3.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredEvent3.TabIndex = 51;
            this.lblRequiredEvent3.Text = "*";
            // 
            // dtEventEndTime
            // 
            this.dtEventEndTime.CustomFormat = "hh:mm tt";
            this.dtEventEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEventEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEventEndTime.Location = new System.Drawing.Point(349, 215);
            this.dtEventEndTime.Name = "dtEventEndTime";
            this.dtEventEndTime.ShowUpDown = true;
            this.dtEventEndTime.Size = new System.Drawing.Size(83, 23);
            this.dtEventEndTime.TabIndex = 6;
            this.dtEventEndTime.Value = new System.DateTime(2000, 1, 1, 12, 0, 0, 0);
            // 
            // lblEventEndTime
            // 
            this.lblEventEndTime.AutoSize = true;
            this.lblEventEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventEndTime.Location = new System.Drawing.Point(255, 219);
            this.lblEventEndTime.Name = "lblEventEndTime";
            this.lblEventEndTime.Size = new System.Drawing.Size(81, 17);
            this.lblEventEndTime.TabIndex = 50;
            this.lblEventEndTime.Text = "End Time:";
            // 
            // dtEventStartTime
            // 
            this.dtEventStartTime.CustomFormat = "hh:mm tt";
            this.dtEventStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEventStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEventStartTime.Location = new System.Drawing.Point(349, 185);
            this.dtEventStartTime.Name = "dtEventStartTime";
            this.dtEventStartTime.ShowUpDown = true;
            this.dtEventStartTime.Size = new System.Drawing.Size(83, 23);
            this.dtEventStartTime.TabIndex = 4;
            this.dtEventStartTime.Value = new System.DateTime(2000, 1, 1, 11, 0, 0, 0);
            this.dtEventStartTime.ValueChanged += new System.EventHandler(this.dtEventStartTime_ValueChanged);
            // 
            // lblEventStartTime
            // 
            this.lblEventStartTime.AutoSize = true;
            this.lblEventStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventStartTime.Location = new System.Drawing.Point(255, 185);
            this.lblEventStartTime.Name = "lblEventStartTime";
            this.lblEventStartTime.Size = new System.Drawing.Size(88, 17);
            this.lblEventStartTime.TabIndex = 49;
            this.lblEventStartTime.Text = "Start Time:";
            // 
            // chkAllDayEvent
            // 
            this.chkAllDayEvent.AutoSize = true;
            this.chkAllDayEvent.Location = new System.Drawing.Point(66, 253);
            this.chkAllDayEvent.Name = "chkAllDayEvent";
            this.chkAllDayEvent.Size = new System.Drawing.Size(90, 17);
            this.chkAllDayEvent.TabIndex = 7;
            this.chkAllDayEvent.Text = "All Day Event";
            this.chkAllDayEvent.UseVisualStyleBackColor = true;
            this.chkAllDayEvent.CheckedChanged += new System.EventHandler(this.chkAllDayEvent_CheckedChanged);
            // 
            // lblRequiredEvent5
            // 
            this.lblRequiredEvent5.AutoSize = true;
            this.lblRequiredEvent5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredEvent5.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredEvent5.Location = new System.Drawing.Point(435, 221);
            this.lblRequiredEvent5.Name = "lblRequiredEvent5";
            this.lblRequiredEvent5.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredEvent5.TabIndex = 56;
            this.lblRequiredEvent5.Text = "*";
            // 
            // cbEventClass
            // 
            this.cbEventClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEventClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEventClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEventClass.FormattingEnabled = true;
            this.cbEventClass.Location = new System.Drawing.Point(12, 37);
            this.cbEventClass.Name = "cbEventClass";
            this.cbEventClass.Size = new System.Drawing.Size(222, 21);
            this.cbEventClass.TabIndex = 9;
            this.cbEventClass.SelectedIndexChanged += new System.EventHandler(this.cbEventClass_SelectedIndexChanged);
            // 
            // lblEventClass
            // 
            this.lblEventClass.AutoSize = true;
            this.lblEventClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventClass.Location = new System.Drawing.Point(102, 317);
            this.lblEventClass.Name = "lblEventClass";
            this.lblEventClass.Size = new System.Drawing.Size(52, 17);
            this.lblEventClass.TabIndex = 58;
            this.lblEventClass.Text = "Class:";
            // 
            // chkGradedAssignment
            // 
            this.chkGradedAssignment.AutoSize = true;
            this.chkGradedAssignment.Location = new System.Drawing.Point(213, 253);
            this.chkGradedAssignment.Name = "chkGradedAssignment";
            this.chkGradedAssignment.Size = new System.Drawing.Size(118, 17);
            this.chkGradedAssignment.TabIndex = 8;
            this.chkGradedAssignment.Text = "Graded Assignment";
            this.chkGradedAssignment.UseVisualStyleBackColor = true;
            this.chkGradedAssignment.CheckedChanged += new System.EventHandler(this.chkGradedAssignment_CheckedChanged);
            // 
            // lblEventType
            // 
            this.lblEventType.AutoSize = true;
            this.lblEventType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventType.Location = new System.Drawing.Point(105, 352);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(49, 17);
            this.lblEventType.TabIndex = 60;
            this.lblEventType.Text = "Type:";
            // 
            // cbEventType
            // 
            this.cbEventType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEventType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEventType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEventType.FormattingEnabled = true;
            this.cbEventType.Location = new System.Drawing.Point(12, 72);
            this.cbEventType.Name = "cbEventType";
            this.cbEventType.Size = new System.Drawing.Size(222, 21);
            this.cbEventType.TabIndex = 10;
            this.cbEventType.SelectedIndexChanged += new System.EventHandler(this.cbEventType_SelectedIndexChanged);
            // 
            // lblEventGrade
            // 
            this.lblEventGrade.AutoSize = true;
            this.lblEventGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventGrade.Location = new System.Drawing.Point(96, 387);
            this.lblEventGrade.Name = "lblEventGrade";
            this.lblEventGrade.Size = new System.Drawing.Size(58, 17);
            this.lblEventGrade.TabIndex = 62;
            this.lblEventGrade.Text = "Grade:";
            // 
            // txtEventGrade
            // 
            this.txtEventGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEventGrade.Location = new System.Drawing.Point(12, 111);
            this.txtEventGrade.Name = "txtEventGrade";
            this.txtEventGrade.Size = new System.Drawing.Size(103, 20);
            this.txtEventGrade.TabIndex = 11;
            // 
            // lblTotalPoints
            // 
            this.lblTotalPoints.AutoSize = true;
            this.lblTotalPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPoints.Location = new System.Drawing.Point(54, 422);
            this.lblTotalPoints.Name = "lblTotalPoints";
            this.lblTotalPoints.Size = new System.Drawing.Size(100, 17);
            this.lblTotalPoints.TabIndex = 64;
            this.lblTotalPoints.Text = "Total Points:";
            // 
            // txtEventGradeTotalPoints
            // 
            this.txtEventGradeTotalPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEventGradeTotalPoints.Location = new System.Drawing.Point(12, 143);
            this.txtEventGradeTotalPoints.Name = "txtEventGradeTotalPoints";
            this.txtEventGradeTotalPoints.Size = new System.Drawing.Size(103, 20);
            this.txtEventGradeTotalPoints.TabIndex = 12;
            // 
            // btnSaveCloseEvent
            // 
            this.btnSaveCloseEvent.AutoSize = true;
            this.btnSaveCloseEvent.Location = new System.Drawing.Point(84, 469);
            this.btnSaveCloseEvent.Name = "btnSaveCloseEvent";
            this.btnSaveCloseEvent.Size = new System.Drawing.Size(123, 23);
            this.btnSaveCloseEvent.TabIndex = 65;
            this.btnSaveCloseEvent.Text = "Save and Close";
            this.btnSaveCloseEvent.UseVisualStyleBackColor = true;
            this.btnSaveCloseEvent.Click += new System.EventHandler(this.btnSaveCloseEvent_Click);
            // 
            // btnCloseEvent
            // 
            this.btnCloseEvent.AutoSize = true;
            this.btnCloseEvent.Location = new System.Drawing.Point(244, 469);
            this.btnCloseEvent.Name = "btnCloseEvent";
            this.btnCloseEvent.Size = new System.Drawing.Size(174, 23);
            this.btnCloseEvent.TabIndex = 66;
            this.btnCloseEvent.Text = "Close Without Saving";
            this.btnCloseEvent.UseVisualStyleBackColor = true;
            this.btnCloseEvent.Click += new System.EventHandler(this.btnCloseEvent_Click);
            // 
            // lblAssignmentName
            // 
            this.lblAssignmentName.AutoSize = true;
            this.lblAssignmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignmentName.Location = new System.Drawing.Point(12, 285);
            this.lblAssignmentName.Name = "lblAssignmentName";
            this.lblAssignmentName.Size = new System.Drawing.Size(142, 17);
            this.lblAssignmentName.TabIndex = 67;
            this.lblAssignmentName.Text = "Assignment Name:";
            // 
            // txtAssignmentName
            // 
            this.txtAssignmentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAssignmentName.Location = new System.Drawing.Point(12, 9);
            this.txtAssignmentName.Name = "txtAssignmentName";
            this.txtAssignmentName.Size = new System.Drawing.Size(222, 20);
            this.txtAssignmentName.TabIndex = 68;
            // 
            // eventInfoPanel
            // 
            this.eventInfoPanel.Controls.Add(this.txtAssignmentName);
            this.eventInfoPanel.Controls.Add(this.cbEventClass);
            this.eventInfoPanel.Controls.Add(this.txtEventGradeTotalPoints);
            this.eventInfoPanel.Controls.Add(this.cbEventType);
            this.eventInfoPanel.Controls.Add(this.txtEventGrade);
            this.eventInfoPanel.Enabled = false;
            this.eventInfoPanel.Location = new System.Drawing.Point(160, 276);
            this.eventInfoPanel.Name = "eventInfoPanel";
            this.eventInfoPanel.Size = new System.Drawing.Size(258, 174);
            this.eventInfoPanel.TabIndex = 69;
            // 
            // lblRequiredEvent4
            // 
            this.lblRequiredEvent4.AutoSize = true;
            this.lblRequiredEvent4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredEvent4.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredEvent4.Location = new System.Drawing.Point(213, 220);
            this.lblRequiredEvent4.Name = "lblRequiredEvent4";
            this.lblRequiredEvent4.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredEvent4.TabIndex = 71;
            this.lblRequiredEvent4.Text = "*";
            // 
            // lblRequiredEvent2
            // 
            this.lblRequiredEvent2.AutoSize = true;
            this.lblRequiredEvent2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredEvent2.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredEvent2.Location = new System.Drawing.Point(213, 187);
            this.lblRequiredEvent2.Name = "lblRequiredEvent2";
            this.lblRequiredEvent2.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredEvent2.TabIndex = 70;
            this.lblRequiredEvent2.Text = "*";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(33, 146);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(75, 17);
            this.lblLocation.TabIndex = 72;
            this.lblLocation.Text = "Location:";
            // 
            // txtLocation
            // 
            this.txtLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocation.Location = new System.Drawing.Point(124, 146);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(189, 20);
            this.txtLocation.TabIndex = 2;
            // 
            // AddEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 522);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblRequiredEvent4);
            this.Controls.Add(this.lblRequiredEvent2);
            this.Controls.Add(this.btnCloseEvent);
            this.Controls.Add(this.lblAssignmentName);
            this.Controls.Add(this.lblEventClass);
            this.Controls.Add(this.btnSaveCloseEvent);
            this.Controls.Add(this.chkGradedAssignment);
            this.Controls.Add(this.lblEventType);
            this.Controls.Add(this.lblRequiredEvent5);
            this.Controls.Add(this.chkAllDayEvent);
            this.Controls.Add(this.dtEventEndDate);
            this.Controls.Add(this.lblTotalPoints);
            this.Controls.Add(this.lblEventEndDate);
            this.Controls.Add(this.lblEventGrade);
            this.Controls.Add(this.dtEventStartDate);
            this.Controls.Add(this.lblEventStartDate);
            this.Controls.Add(this.lblRequiredEvent3);
            this.Controls.Add(this.dtEventEndTime);
            this.Controls.Add(this.lblEventEndTime);
            this.Controls.Add(this.dtEventStartTime);
            this.Controls.Add(this.lblEventStartTime);
            this.Controls.Add(this.lblRequiredEvent1);
            this.Controls.Add(this.lblEventDescription);
            this.Controls.Add(this.txtEventDescription);
            this.Controls.Add(this.lblEventTitle);
            this.Controls.Add(this.lblEventText);
            this.Controls.Add(this.txtEventTitle);
            this.Controls.Add(this.eventInfoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Event";
            this.eventInfoPanel.ResumeLayout(false);
            this.eventInfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEventTitle;
        private System.Windows.Forms.Label lblEventText;
        private System.Windows.Forms.TextBox txtEventTitle;
        private System.Windows.Forms.Label lblEventDescription;
        private System.Windows.Forms.TextBox txtEventDescription;
        private System.Windows.Forms.Label lblRequiredEvent1;
        private System.Windows.Forms.DateTimePicker dtEventEndDate;
        private System.Windows.Forms.Label lblEventEndDate;
        private System.Windows.Forms.DateTimePicker dtEventStartDate;
        private System.Windows.Forms.Label lblEventStartDate;
        private System.Windows.Forms.Label lblRequiredEvent3;
        private System.Windows.Forms.DateTimePicker dtEventEndTime;
        private System.Windows.Forms.Label lblEventEndTime;
        private System.Windows.Forms.DateTimePicker dtEventStartTime;
        private System.Windows.Forms.Label lblEventStartTime;
        private System.Windows.Forms.CheckBox chkAllDayEvent;
        private System.Windows.Forms.Label lblRequiredEvent5;
        private System.Windows.Forms.ComboBox cbEventClass;
        private System.Windows.Forms.Label lblEventClass;
        private System.Windows.Forms.CheckBox chkGradedAssignment;
        private System.Windows.Forms.Label lblEventType;
        private System.Windows.Forms.ComboBox cbEventType;
        private System.Windows.Forms.Label lblEventGrade;
        private System.Windows.Forms.TextBox txtEventGrade;
        private System.Windows.Forms.Label lblTotalPoints;
        private System.Windows.Forms.TextBox txtEventGradeTotalPoints;
        private System.Windows.Forms.Button btnSaveCloseEvent;
        private System.Windows.Forms.Button btnCloseEvent;
        private System.Windows.Forms.Label lblAssignmentName;
        private System.Windows.Forms.TextBox txtAssignmentName;
        private System.Windows.Forms.Panel eventInfoPanel;
        private System.Windows.Forms.Label lblRequiredEvent4;
        private System.Windows.Forms.Label lblRequiredEvent2;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
    }
}