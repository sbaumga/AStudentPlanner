namespace Planner {
    partial class EditEventForm {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEventForm));
            this.btnCloseEvent = new System.Windows.Forms.Button();
            this.btnSaveCloseEvent = new System.Windows.Forms.Button();
            this.chkGradedAssignment = new System.Windows.Forms.CheckBox();
            this.lblRequiredEvent4 = new System.Windows.Forms.Label();
            this.chkAllDayEvent = new System.Windows.Forms.CheckBox();
            this.dtEventEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEventEndDate = new System.Windows.Forms.Label();
            this.dtEventStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblEventStartDate = new System.Windows.Forms.Label();
            this.lblRequiredEvent3 = new System.Windows.Forms.Label();
            this.dtEventEndTime = new System.Windows.Forms.DateTimePicker();
            this.lblEventEndTime = new System.Windows.Forms.Label();
            this.dtEventStartTime = new System.Windows.Forms.DateTimePicker();
            this.lblEventStartTime = new System.Windows.Forms.Label();
            this.lblRequiredEvent1 = new System.Windows.Forms.Label();
            this.lblEventDescription = new System.Windows.Forms.Label();
            this.txtEventDescription = new System.Windows.Forms.TextBox();
            this.lblEventTitle = new System.Windows.Forms.Label();
            this.txtEventTitle = new System.Windows.Forms.TextBox();
            this.lblAssignmentName = new System.Windows.Forms.Label();
            this.lblEventClass = new System.Windows.Forms.Label();
            this.lblEventType = new System.Windows.Forms.Label();
            this.lblTotalPoints = new System.Windows.Forms.Label();
            this.lblEventGrade = new System.Windows.Forms.Label();
            this.eventInfoPanel = new System.Windows.Forms.Panel();
            this.txtAssignmentName = new System.Windows.Forms.TextBox();
            this.cbEventClass = new System.Windows.Forms.ComboBox();
            this.txtEventGradeTotalPoints = new System.Windows.Forms.TextBox();
            this.cbEventType = new System.Windows.Forms.ComboBox();
            this.txtEventGrade = new System.Windows.Forms.TextBox();
            this.cbEvent = new System.Windows.Forms.ComboBox();
            this.lblEditProfessor = new System.Windows.Forms.Label();
            this.cbClassFilter = new System.Windows.Forms.ComboBox();
            this.lblEditProfessorFilter = new System.Windows.Forms.Label();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFilterDate = new System.Windows.Forms.DateTimePicker();
            this.lblRequiredEvent2 = new System.Windows.Forms.Label();
            this.lblRequiredEvent5 = new System.Windows.Forms.Label();
            this.chkDateFilter = new System.Windows.Forms.CheckBox();
            this.lblSaveStatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lnkClearClassFilter = new System.Windows.Forms.LinkLabel();
            this.eventInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCloseEvent
            // 
            this.btnCloseEvent.AutoSize = true;
            this.btnCloseEvent.Location = new System.Drawing.Point(324, 535);
            this.btnCloseEvent.Name = "btnCloseEvent";
            this.btnCloseEvent.Size = new System.Drawing.Size(90, 23);
            this.btnCloseEvent.TabIndex = 97;
            this.btnCloseEvent.Text = "Close";
            this.btnCloseEvent.UseVisualStyleBackColor = true;
            this.btnCloseEvent.Click += new System.EventHandler(this.btnCloseEvent_Click);
            // 
            // btnSaveCloseEvent
            // 
            this.btnSaveCloseEvent.AutoSize = true;
            this.btnSaveCloseEvent.Enabled = false;
            this.btnSaveCloseEvent.Location = new System.Drawing.Point(58, 533);
            this.btnSaveCloseEvent.Name = "btnSaveCloseEvent";
            this.btnSaveCloseEvent.Size = new System.Drawing.Size(96, 23);
            this.btnSaveCloseEvent.TabIndex = 95;
            this.btnSaveCloseEvent.Text = "Save";
            this.btnSaveCloseEvent.UseVisualStyleBackColor = true;
            this.btnSaveCloseEvent.Click += new System.EventHandler(this.btnSaveCloseEvent_Click);
            // 
            // chkGradedAssignment
            // 
            this.chkGradedAssignment.AutoSize = true;
            this.chkGradedAssignment.Location = new System.Drawing.Point(214, 301);
            this.chkGradedAssignment.Name = "chkGradedAssignment";
            this.chkGradedAssignment.Size = new System.Drawing.Size(118, 17);
            this.chkGradedAssignment.TabIndex = 76;
            this.chkGradedAssignment.Text = "Graded Assignment";
            this.chkGradedAssignment.UseVisualStyleBackColor = true;
            this.chkGradedAssignment.CheckedChanged += new System.EventHandler(this.chkGradedAssignment_CheckedChanged);
            // 
            // lblRequiredEvent4
            // 
            this.lblRequiredEvent4.AutoSize = true;
            this.lblRequiredEvent4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredEvent4.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredEvent4.Location = new System.Drawing.Point(214, 267);
            this.lblRequiredEvent4.Name = "lblRequiredEvent4";
            this.lblRequiredEvent4.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredEvent4.TabIndex = 90;
            this.lblRequiredEvent4.Text = "*";
            // 
            // chkAllDayEvent
            // 
            this.chkAllDayEvent.AutoSize = true;
            this.chkAllDayEvent.Location = new System.Drawing.Point(67, 301);
            this.chkAllDayEvent.Name = "chkAllDayEvent";
            this.chkAllDayEvent.Size = new System.Drawing.Size(90, 17);
            this.chkAllDayEvent.TabIndex = 75;
            this.chkAllDayEvent.Text = "All Day Event";
            this.chkAllDayEvent.UseVisualStyleBackColor = true;
            this.chkAllDayEvent.CheckedChanged += new System.EventHandler(this.chkAllDayEvent_CheckedChanged);
            // 
            // dtEventEndDate
            // 
            this.dtEventEndDate.CustomFormat = "MM/dd/yy";
            this.dtEventEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEventEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEventEndDate.Location = new System.Drawing.Point(125, 262);
            this.dtEventEndDate.Name = "dtEventEndDate";
            this.dtEventEndDate.Size = new System.Drawing.Size(83, 23);
            this.dtEventEndDate.TabIndex = 73;
            this.dtEventEndDate.Value = new System.DateTime(2011, 4, 3, 12, 0, 0, 0);
            this.dtEventEndDate.ValueChanged += new System.EventHandler(this.dtEventEndDate_ValueChanged);
            // 
            // lblEventEndDate
            // 
            this.lblEventEndDate.AutoSize = true;
            this.lblEventEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventEndDate.Location = new System.Drawing.Point(29, 268);
            this.lblEventEndDate.Name = "lblEventEndDate";
            this.lblEventEndDate.Size = new System.Drawing.Size(80, 17);
            this.lblEventEndDate.TabIndex = 89;
            this.lblEventEndDate.Text = "End Date:";
            // 
            // dtEventStartDate
            // 
            this.dtEventStartDate.CustomFormat = "MM/dd/yy";
            this.dtEventStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEventStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEventStartDate.Location = new System.Drawing.Point(125, 233);
            this.dtEventStartDate.Name = "dtEventStartDate";
            this.dtEventStartDate.Size = new System.Drawing.Size(83, 23);
            this.dtEventStartDate.TabIndex = 71;
            this.dtEventStartDate.Value = new System.DateTime(2011, 4, 3, 11, 0, 0, 0);
            this.dtEventStartDate.ValueChanged += new System.EventHandler(this.dtEventStartDate_ValueChanged);
            // 
            // lblEventStartDate
            // 
            this.lblEventStartDate.AutoSize = true;
            this.lblEventStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventStartDate.Location = new System.Drawing.Point(22, 233);
            this.lblEventStartDate.Name = "lblEventStartDate";
            this.lblEventStartDate.Size = new System.Drawing.Size(87, 17);
            this.lblEventStartDate.TabIndex = 88;
            this.lblEventStartDate.Text = "Start Date:";
            // 
            // lblRequiredEvent3
            // 
            this.lblRequiredEvent3.AutoSize = true;
            this.lblRequiredEvent3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredEvent3.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredEvent3.Location = new System.Drawing.Point(427, 236);
            this.lblRequiredEvent3.Name = "lblRequiredEvent3";
            this.lblRequiredEvent3.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredEvent3.TabIndex = 87;
            this.lblRequiredEvent3.Text = "*";
            // 
            // dtEventEndTime
            // 
            this.dtEventEndTime.CustomFormat = "hh:mm tt";
            this.dtEventEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEventEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEventEndTime.Location = new System.Drawing.Point(338, 263);
            this.dtEventEndTime.Name = "dtEventEndTime";
            this.dtEventEndTime.ShowUpDown = true;
            this.dtEventEndTime.Size = new System.Drawing.Size(83, 23);
            this.dtEventEndTime.TabIndex = 74;
            this.dtEventEndTime.Value = new System.DateTime(2011, 4, 3, 12, 0, 0, 0);
            // 
            // lblEventEndTime
            // 
            this.lblEventEndTime.AutoSize = true;
            this.lblEventEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventEndTime.Location = new System.Drawing.Point(244, 267);
            this.lblEventEndTime.Name = "lblEventEndTime";
            this.lblEventEndTime.Size = new System.Drawing.Size(81, 17);
            this.lblEventEndTime.TabIndex = 86;
            this.lblEventEndTime.Text = "End Time:";
            // 
            // dtEventStartTime
            // 
            this.dtEventStartTime.CustomFormat = "hh:mm tt";
            this.dtEventStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEventStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEventStartTime.Location = new System.Drawing.Point(338, 233);
            this.dtEventStartTime.Name = "dtEventStartTime";
            this.dtEventStartTime.ShowUpDown = true;
            this.dtEventStartTime.Size = new System.Drawing.Size(83, 23);
            this.dtEventStartTime.TabIndex = 72;
            this.dtEventStartTime.Value = new System.DateTime(2011, 4, 3, 11, 0, 0, 0);
            this.dtEventStartTime.ValueChanged += new System.EventHandler(this.dtEventStartTime_ValueChanged);
            // 
            // lblEventStartTime
            // 
            this.lblEventStartTime.AutoSize = true;
            this.lblEventStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventStartTime.Location = new System.Drawing.Point(244, 233);
            this.lblEventStartTime.Name = "lblEventStartTime";
            this.lblEventStartTime.Size = new System.Drawing.Size(88, 17);
            this.lblEventStartTime.TabIndex = 85;
            this.lblEventStartTime.Text = "Start Time:";
            // 
            // lblRequiredEvent1
            // 
            this.lblRequiredEvent1.AutoSize = true;
            this.lblRequiredEvent1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredEvent1.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredEvent1.Location = new System.Drawing.Point(320, 109);
            this.lblRequiredEvent1.Name = "lblRequiredEvent1";
            this.lblRequiredEvent1.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredEvent1.TabIndex = 84;
            this.lblRequiredEvent1.Text = "*";
            // 
            // lblEventDescription
            // 
            this.lblEventDescription.AutoSize = true;
            this.lblEventDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDescription.Location = new System.Drawing.Point(14, 139);
            this.lblEventDescription.Name = "lblEventDescription";
            this.lblEventDescription.Size = new System.Drawing.Size(95, 17);
            this.lblEventDescription.TabIndex = 83;
            this.lblEventDescription.Text = "Description:";
            // 
            // txtEventDescription
            // 
            this.txtEventDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEventDescription.Location = new System.Drawing.Point(125, 139);
            this.txtEventDescription.Multiline = true;
            this.txtEventDescription.Name = "txtEventDescription";
            this.txtEventDescription.Size = new System.Drawing.Size(242, 50);
            this.txtEventDescription.TabIndex = 6;
            // 
            // lblEventTitle
            // 
            this.lblEventTitle.AutoSize = true;
            this.lblEventTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventTitle.Location = new System.Drawing.Point(64, 109);
            this.lblEventTitle.Name = "lblEventTitle";
            this.lblEventTitle.Size = new System.Drawing.Size(45, 17);
            this.lblEventTitle.TabIndex = 80;
            this.lblEventTitle.Text = "Title:";
            // 
            // txtEventTitle
            // 
            this.txtEventTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEventTitle.Location = new System.Drawing.Point(125, 109);
            this.txtEventTitle.Name = "txtEventTitle";
            this.txtEventTitle.Size = new System.Drawing.Size(189, 20);
            this.txtEventTitle.TabIndex = 5;
            // 
            // lblAssignmentName
            // 
            this.lblAssignmentName.AutoSize = true;
            this.lblAssignmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignmentName.Location = new System.Drawing.Point(13, 333);
            this.lblAssignmentName.Name = "lblAssignmentName";
            this.lblAssignmentName.Size = new System.Drawing.Size(142, 17);
            this.lblAssignmentName.TabIndex = 101;
            this.lblAssignmentName.Text = "Assignment Name:";
            // 
            // lblEventClass
            // 
            this.lblEventClass.AutoSize = true;
            this.lblEventClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventClass.Location = new System.Drawing.Point(103, 365);
            this.lblEventClass.Name = "lblEventClass";
            this.lblEventClass.Size = new System.Drawing.Size(52, 17);
            this.lblEventClass.TabIndex = 97;
            this.lblEventClass.Text = "Class:";
            // 
            // lblEventType
            // 
            this.lblEventType.AutoSize = true;
            this.lblEventType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventType.Location = new System.Drawing.Point(106, 400);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(49, 17);
            this.lblEventType.TabIndex = 98;
            this.lblEventType.Text = "Type:";
            // 
            // lblTotalPoints
            // 
            this.lblTotalPoints.AutoSize = true;
            this.lblTotalPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPoints.Location = new System.Drawing.Point(55, 470);
            this.lblTotalPoints.Name = "lblTotalPoints";
            this.lblTotalPoints.Size = new System.Drawing.Size(100, 17);
            this.lblTotalPoints.TabIndex = 100;
            this.lblTotalPoints.Text = "Total Points:";
            // 
            // lblEventGrade
            // 
            this.lblEventGrade.AutoSize = true;
            this.lblEventGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventGrade.Location = new System.Drawing.Point(97, 435);
            this.lblEventGrade.Name = "lblEventGrade";
            this.lblEventGrade.Size = new System.Drawing.Size(58, 17);
            this.lblEventGrade.TabIndex = 99;
            this.lblEventGrade.Text = "Grade:";
            // 
            // eventInfoPanel
            // 
            this.eventInfoPanel.Controls.Add(this.txtAssignmentName);
            this.eventInfoPanel.Controls.Add(this.cbEventClass);
            this.eventInfoPanel.Controls.Add(this.txtEventGradeTotalPoints);
            this.eventInfoPanel.Controls.Add(this.cbEventType);
            this.eventInfoPanel.Controls.Add(this.txtEventGrade);
            this.eventInfoPanel.Enabled = false;
            this.eventInfoPanel.Location = new System.Drawing.Point(161, 324);
            this.eventInfoPanel.Name = "eventInfoPanel";
            this.eventInfoPanel.Size = new System.Drawing.Size(265, 174);
            this.eventInfoPanel.TabIndex = 102;
            // 
            // txtAssignmentName
            // 
            this.txtAssignmentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAssignmentName.Location = new System.Drawing.Point(12, 9);
            this.txtAssignmentName.Name = "txtAssignmentName";
            this.txtAssignmentName.Size = new System.Drawing.Size(225, 20);
            this.txtAssignmentName.TabIndex = 77;
            // 
            // cbEventClass
            // 
            this.cbEventClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEventClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEventClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEventClass.FormattingEnabled = true;
            this.cbEventClass.Location = new System.Drawing.Point(12, 37);
            this.cbEventClass.Name = "cbEventClass";
            this.cbEventClass.Size = new System.Drawing.Size(225, 21);
            this.cbEventClass.TabIndex = 78;
            this.cbEventClass.SelectedIndexChanged += new System.EventHandler(this.cbEventClass_SelectedIndexChanged);
            // 
            // txtEventGradeTotalPoints
            // 
            this.txtEventGradeTotalPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEventGradeTotalPoints.Location = new System.Drawing.Point(12, 143);
            this.txtEventGradeTotalPoints.Name = "txtEventGradeTotalPoints";
            this.txtEventGradeTotalPoints.Size = new System.Drawing.Size(103, 20);
            this.txtEventGradeTotalPoints.TabIndex = 81;
            // 
            // cbEventType
            // 
            this.cbEventType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEventType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEventType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEventType.FormattingEnabled = true;
            this.cbEventType.Location = new System.Drawing.Point(12, 72);
            this.cbEventType.Name = "cbEventType";
            this.cbEventType.Size = new System.Drawing.Size(225, 21);
            this.cbEventType.TabIndex = 79;
            this.cbEventType.SelectedIndexChanged += new System.EventHandler(this.cbEventType_SelectedIndexChanged);
            // 
            // txtEventGrade
            // 
            this.txtEventGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEventGrade.Location = new System.Drawing.Point(12, 111);
            this.txtEventGrade.Name = "txtEventGrade";
            this.txtEventGrade.Size = new System.Drawing.Size(103, 20);
            this.txtEventGrade.TabIndex = 80;
            // 
            // cbEvent
            // 
            this.cbEvent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEvent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEvent.FormattingEnabled = true;
            this.cbEvent.Location = new System.Drawing.Point(136, 75);
            this.cbEvent.Name = "cbEvent";
            this.cbEvent.Size = new System.Drawing.Size(253, 21);
            this.cbEvent.TabIndex = 4;
            this.cbEvent.SelectedIndexChanged += new System.EventHandler(this.cbEvent_SelectedIndexChanged);
            // 
            // lblEditProfessor
            // 
            this.lblEditProfessor.AutoSize = true;
            this.lblEditProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditProfessor.Location = new System.Drawing.Point(26, 79);
            this.lblEditProfessor.Name = "lblEditProfessor";
            this.lblEditProfessor.Size = new System.Drawing.Size(104, 17);
            this.lblEditProfessor.TabIndex = 106;
            this.lblEditProfessor.Text = "Select Event:";
            // 
            // cbClassFilter
            // 
            this.cbClassFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbClassFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbClassFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClassFilter.FormattingEnabled = true;
            this.cbClassFilter.Location = new System.Drawing.Point(136, 42);
            this.cbClassFilter.Name = "cbClassFilter";
            this.cbClassFilter.Size = new System.Drawing.Size(253, 21);
            this.cbClassFilter.TabIndex = 3;
            this.cbClassFilter.SelectedIndexChanged += new System.EventHandler(this.cbClassFilter_SelectedIndexChanged);
            // 
            // lblEditProfessorFilter
            // 
            this.lblEditProfessorFilter.AutoSize = true;
            this.lblEditProfessorFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditProfessorFilter.Location = new System.Drawing.Point(13, 43);
            this.lblEditProfessorFilter.Name = "lblEditProfessorFilter";
            this.lblEditProfessorFilter.Size = new System.Drawing.Size(117, 17);
            this.lblEditProfessorFilter.TabIndex = 104;
            this.lblEditProfessorFilter.Text = "Filter By Class:";
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.AutoSize = true;
            this.btnDeleteEvent.Enabled = false;
            this.btnDeleteEvent.Location = new System.Drawing.Point(190, 533);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(108, 23);
            this.btnDeleteEvent.TabIndex = 96;
            this.btnDeleteEvent.Text = "Delete Event";
            this.btnDeleteEvent.UseVisualStyleBackColor = true;
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 108;
            this.label1.Text = "Filter By Date:";
            // 
            // dtFilterDate
            // 
            this.dtFilterDate.CustomFormat = "MM/dd/yy";
            this.dtFilterDate.Enabled = false;
            this.dtFilterDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFilterDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFilterDate.Location = new System.Drawing.Point(136, 9);
            this.dtFilterDate.Name = "dtFilterDate";
            this.dtFilterDate.Size = new System.Drawing.Size(103, 23);
            this.dtFilterDate.TabIndex = 1;
            this.dtFilterDate.Value = new System.DateTime(2011, 4, 3, 11, 0, 0, 0);
            this.dtFilterDate.ValueChanged += new System.EventHandler(this.dtFilterDate_ValueChanged);
            // 
            // lblRequiredEvent2
            // 
            this.lblRequiredEvent2.AutoSize = true;
            this.lblRequiredEvent2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredEvent2.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredEvent2.Location = new System.Drawing.Point(214, 236);
            this.lblRequiredEvent2.Name = "lblRequiredEvent2";
            this.lblRequiredEvent2.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredEvent2.TabIndex = 110;
            this.lblRequiredEvent2.Text = "*";
            // 
            // lblRequiredEvent5
            // 
            this.lblRequiredEvent5.AutoSize = true;
            this.lblRequiredEvent5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredEvent5.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredEvent5.Location = new System.Drawing.Point(427, 268);
            this.lblRequiredEvent5.Name = "lblRequiredEvent5";
            this.lblRequiredEvent5.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredEvent5.TabIndex = 111;
            this.lblRequiredEvent5.Text = "*";
            // 
            // chkDateFilter
            // 
            this.chkDateFilter.AutoSize = true;
            this.chkDateFilter.Location = new System.Drawing.Point(247, 14);
            this.chkDateFilter.Name = "chkDateFilter";
            this.chkDateFilter.Size = new System.Drawing.Size(85, 17);
            this.chkDateFilter.TabIndex = 2;
            this.chkDateFilter.Text = "Use As Filter";
            this.chkDateFilter.UseVisualStyleBackColor = true;
            this.chkDateFilter.CheckedChanged += new System.EventHandler(this.chkDateFilter_CheckedChanged);
            // 
            // lblSaveStatus
            // 
            this.lblSaveStatus.AutoSize = true;
            this.lblSaveStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveStatus.Location = new System.Drawing.Point(145, 507);
            this.lblSaveStatus.Name = "lblSaveStatus";
            this.lblSaveStatus.Size = new System.Drawing.Size(0, 13);
            this.lblSaveStatus.TabIndex = 113;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(34, 199);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(75, 17);
            this.lblLocation.TabIndex = 114;
            this.lblLocation.Text = "Location:";
            // 
            // txtLocation
            // 
            this.txtLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLocation.Location = new System.Drawing.Point(125, 199);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(189, 20);
            this.txtLocation.TabIndex = 7;
            // 
            // lnkClearClassFilter
            // 
            this.lnkClearClassFilter.AutoSize = true;
            this.lnkClearClassFilter.Location = new System.Drawing.Point(395, 45);
            this.lnkClearClassFilter.Name = "lnkClearClassFilter";
            this.lnkClearClassFilter.Size = new System.Drawing.Size(31, 13);
            this.lnkClearClassFilter.TabIndex = 115;
            this.lnkClearClassFilter.TabStop = true;
            this.lnkClearClassFilter.Text = "Clear";
            this.lnkClearClassFilter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClearClassFilter_LinkClicked);
            // 
            // EditEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 572);
            this.Controls.Add(this.lnkClearClassFilter);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblSaveStatus);
            this.Controls.Add(this.chkDateFilter);
            this.Controls.Add(this.lblRequiredEvent5);
            this.Controls.Add(this.lblRequiredEvent2);
            this.Controls.Add(this.dtFilterDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteEvent);
            this.Controls.Add(this.cbEvent);
            this.Controls.Add(this.lblEditProfessor);
            this.Controls.Add(this.cbClassFilter);
            this.Controls.Add(this.lblEditProfessorFilter);
            this.Controls.Add(this.lblAssignmentName);
            this.Controls.Add(this.lblEventClass);
            this.Controls.Add(this.lblEventType);
            this.Controls.Add(this.lblTotalPoints);
            this.Controls.Add(this.lblEventGrade);
            this.Controls.Add(this.eventInfoPanel);
            this.Controls.Add(this.btnCloseEvent);
            this.Controls.Add(this.btnSaveCloseEvent);
            this.Controls.Add(this.chkGradedAssignment);
            this.Controls.Add(this.lblRequiredEvent4);
            this.Controls.Add(this.chkAllDayEvent);
            this.Controls.Add(this.dtEventEndDate);
            this.Controls.Add(this.lblEventEndDate);
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
            this.Controls.Add(this.txtEventTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Event";
            this.eventInfoPanel.ResumeLayout(false);
            this.eventInfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCloseEvent;
        private System.Windows.Forms.Button btnSaveCloseEvent;
        private System.Windows.Forms.CheckBox chkGradedAssignment;
        private System.Windows.Forms.Label lblRequiredEvent4;
        private System.Windows.Forms.CheckBox chkAllDayEvent;
        private System.Windows.Forms.DateTimePicker dtEventEndDate;
        private System.Windows.Forms.Label lblEventEndDate;
        private System.Windows.Forms.DateTimePicker dtEventStartDate;
        private System.Windows.Forms.Label lblEventStartDate;
        private System.Windows.Forms.Label lblRequiredEvent3;
        private System.Windows.Forms.DateTimePicker dtEventEndTime;
        private System.Windows.Forms.Label lblEventEndTime;
        private System.Windows.Forms.DateTimePicker dtEventStartTime;
        private System.Windows.Forms.Label lblEventStartTime;
        private System.Windows.Forms.Label lblRequiredEvent1;
        private System.Windows.Forms.Label lblEventDescription;
        private System.Windows.Forms.TextBox txtEventDescription;
        private System.Windows.Forms.Label lblEventTitle;
        private System.Windows.Forms.TextBox txtEventTitle;
        private System.Windows.Forms.Label lblAssignmentName;
        private System.Windows.Forms.Label lblEventClass;
        private System.Windows.Forms.Label lblEventType;
        private System.Windows.Forms.Label lblTotalPoints;
        private System.Windows.Forms.Label lblEventGrade;
        private System.Windows.Forms.Panel eventInfoPanel;
        private System.Windows.Forms.TextBox txtAssignmentName;
        private System.Windows.Forms.ComboBox cbEventClass;
        private System.Windows.Forms.TextBox txtEventGradeTotalPoints;
        private System.Windows.Forms.ComboBox cbEventType;
        private System.Windows.Forms.TextBox txtEventGrade;
        private System.Windows.Forms.ComboBox cbEvent;
        private System.Windows.Forms.Label lblEditProfessor;
        private System.Windows.Forms.ComboBox cbClassFilter;
        private System.Windows.Forms.Label lblEditProfessorFilter;
        private System.Windows.Forms.Button btnDeleteEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFilterDate;
        private System.Windows.Forms.Label lblRequiredEvent2;
        private System.Windows.Forms.Label lblRequiredEvent5;
        private System.Windows.Forms.CheckBox chkDateFilter;
        private System.Windows.Forms.Label lblSaveStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.LinkLabel lnkClearClassFilter;
    }
}