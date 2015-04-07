namespace Planner
{
    partial class AssignmentPlanner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Calendar.DrawTool drawTool1 = new Calendar.DrawTool();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssignmentPlanner));
            this.calendarView = new Calendar.DayView();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cleanUpDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFinishedEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFinishedGeneralEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseEncryptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSemesterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProfessorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSemesterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProfessorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactProfessorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syncSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableDisableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authenticateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleCalendarSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeExternalChangesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.container = new System.Windows.Forms.Panel();
            this.gradeInformationPanel = new System.Windows.Forms.Panel();
            this.lblOverallGpa = new System.Windows.Forms.Label();
            this.lblSemesterGpa = new System.Windows.Forms.Label();
            this.lblOverallGpaValue = new System.Windows.Forms.Label();
            this.lblSemesterGpaValue = new System.Windows.Forms.Label();
            this.currentGradesPanel = new System.Windows.Forms.Panel();
            this.rtxtCurrentGrades = new System.Windows.Forms.RichTextBox();
            this.lblCurrentGrades = new System.Windows.Forms.Label();
            this.upcomingAssignmentsPanel = new System.Windows.Forms.Panel();
            this.rtxtUpcomingAssignments = new System.Windows.Forms.RichTextBox();
            this.lblUpcomingAssignments = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsTaskManagement = new System.Windows.Forms.ToolStripLabel();
            this.tsAddTaskBtn = new System.Windows.Forms.ToolStripButton();
            this.tsComboBoxDays = new System.Windows.Forms.ToolStripComboBox();
            this.tslCalendarView = new System.Windows.Forms.ToolStripLabel();
            this.tsDeleteTaskBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tslZoom = new System.Windows.Forms.ToolStripLabel();
            this.tsZoomInBtn = new System.Windows.Forms.ToolStripButton();
            this.tsZoomOutBtn = new System.Windows.Forms.ToolStripButton();
            this.tsResetZoomBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsViewOfficeHoursBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsViewScheduleBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsFinalsCalcBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.formPanel = new System.Windows.Forms.Panel();
            this.linksPanel = new System.Windows.Forms.Panel();
            this.btnEditGrades = new System.Windows.Forms.Button();
            this.btnGenerateAssignmentReport = new System.Windows.Forms.Button();
            this.btnGenerateGradeReport = new System.Windows.Forms.Button();
            this.btnViewCalendar = new System.Windows.Forms.Button();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabViewCalendar = new System.Windows.Forms.TabPage();
            this.calendarPanel = new System.Windows.Forms.Panel();
            this.tabGenerateAssignmentReport = new System.Windows.Forms.TabPage();
            this.lnkClearAssignmentType = new System.Windows.Forms.LinkLabel();
            this.lnkClearProfessorFilter = new System.Windows.Forms.LinkLabel();
            this.lnkClearClassFilter = new System.Windows.Forms.LinkLabel();
            this.chkUseDateAsFilter = new System.Windows.Forms.CheckBox();
            this.dtAssignmentDate = new System.Windows.Forms.DateTimePicker();
            this.lblAssignmentDate = new System.Windows.Forms.Label();
            this.lblKeywords = new System.Windows.Forms.Label();
            this.txtKeywords = new System.Windows.Forms.TextBox();
            this.cbAssignmentType = new System.Windows.Forms.ComboBox();
            this.lblAssignmentType = new System.Windows.Forms.Label();
            this.btnAssignmentReport = new System.Windows.Forms.Button();
            this.cbAssignmentClass = new System.Windows.Forms.ComboBox();
            this.lblAssignmentClass = new System.Windows.Forms.Label();
            this.cbAssignmentProfessor = new System.Windows.Forms.ComboBox();
            this.lblAssignmentProfessor = new System.Windows.Forms.Label();
            this.lblSelectOptions = new System.Windows.Forms.Label();
            this.assignmentReportPanel = new System.Windows.Forms.Panel();
            this.lblAssignmentReport = new System.Windows.Forms.Label();
            this.tvAssignmentReport = new System.Windows.Forms.TreeView();
            this.tabGenerateGradeReport = new System.Windows.Forms.TabPage();
            this.chkIncludePastClasses = new System.Windows.Forms.CheckBox();
            this.cbGradeUpperBound = new System.Windows.Forms.ComboBox();
            this.cbGradeLowerBound = new System.Windows.Forms.ComboBox();
            this.txtGradeCredits = new System.Windows.Forms.TextBox();
            this.lblCustomGradeReport = new System.Windows.Forms.Label();
            this.lblGradeCredits = new System.Windows.Forms.Label();
            this.lblGpaAbove = new System.Windows.Forms.Label();
            this.lblGpaBelow = new System.Windows.Forms.Label();
            this.btnGradeReport = new System.Windows.Forms.Button();
            this.cbGradeClass = new System.Windows.Forms.ComboBox();
            this.lblGradeClass = new System.Windows.Forms.Label();
            this.cbGradeProfessor = new System.Windows.Forms.ComboBox();
            this.lblGradeProfessor = new System.Windows.Forms.Label();
            this.gradeReportPanel = new System.Windows.Forms.Panel();
            this.lblGradeReport = new System.Windows.Forms.Label();
            this.tvGradeReport = new System.Windows.Forms.TreeView();
            this.tabEditGrades = new System.Windows.Forms.TabPage();
            this.editClassGradesPanel = new System.Windows.Forms.Panel();
            this.tvEditGrades = new System.Windows.Forms.TreeView();
            this.lblEditClassGrades = new System.Windows.Forms.Label();
            this.lblSaveStatus = new System.Windows.Forms.Label();
            this.lblEditGrades = new System.Windows.Forms.Label();
            this.btnResetGrades = new System.Windows.Forms.Button();
            this.btnSaveGrades = new System.Windows.Forms.Button();
            this.btnViewGrades = new System.Windows.Forms.Button();
            this.cbEditGradesClass = new System.Windows.Forms.ComboBox();
            this.lblEditClass = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.editGradesTimer = new System.Windows.Forms.Timer(this.components);
            this.upcomingAssignmentsTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.container.SuspendLayout();
            this.gradeInformationPanel.SuspendLayout();
            this.currentGradesPanel.SuspendLayout();
            this.upcomingAssignmentsPanel.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.formPanel.SuspendLayout();
            this.linksPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabViewCalendar.SuspendLayout();
            this.calendarPanel.SuspendLayout();
            this.tabGenerateAssignmentReport.SuspendLayout();
            this.assignmentReportPanel.SuspendLayout();
            this.tabGenerateGradeReport.SuspendLayout();
            this.gradeReportPanel.SuspendLayout();
            this.tabEditGrades.SuspendLayout();
            this.editClassGradesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendarView
            // 
            drawTool1.DayView = this.calendarView;
            this.calendarView.ActiveTool = drawTool1;
            this.calendarView.AllowInplaceEditing = false;
            this.calendarView.AmPmDisplay = true;
            this.calendarView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.calendarView.AppointmentHeightMode = Calendar.AppHeightDrawMode.TrueHeightAll;
            this.calendarView.DrawAllAppBorder = true;
            this.calendarView.EnableDurationDisplay = false;
            this.calendarView.EnableRoundedCorners = false;
            this.calendarView.EnableShadows = true;
            this.calendarView.EnableTimeIndicator = true;
            this.calendarView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.calendarView.Location = new System.Drawing.Point(8, 8);
            this.calendarView.MinHalfHourApp = false;
            this.calendarView.Name = "calendarView";
            this.calendarView.SelectionEnd = new System.DateTime(((long)(0)));
            this.calendarView.SelectionStart = new System.DateTime(((long)(0)));
            this.calendarView.Size = new System.Drawing.Size(592, 434);
            this.calendarView.StartDate = new System.DateTime(((long)(0)));
            this.calendarView.TabIndex = 32;
            this.calendarView.Text = "dayView1";
            this.calendarView.WorkingHourEnd = 17;
            this.calendarView.WorkingMinuteEnd = 0;
            this.calendarView.WorkingMinuteStart = 0;
            this.calendarView.OnAppointmentMove += new System.EventHandler<Calendar.AppointmentEventArgs>(this.calendarView_OnAppointmentMove);
            this.calendarView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.calendarView_MouseDoubleClick);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(9, 9);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 19;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStatus,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel2});
            this.statusStrip.Location = new System.Drawing.Point(0, 563);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(879, 22);
            this.statusStrip.TabIndex = 25;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tslStatus
            // 
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(42, 17);
            this.tslStatus.Text = "Status:";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(736, 17);
            this.toolStripStatusLabel3.Spring = true;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(86, 17);
            this.toolStripStatusLabel2.Text = "[Selected Date]";
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.contactToolStripMenuItem,
            this.syncSettingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(879, 24);
            this.mainMenuStrip.TabIndex = 26;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cleanUpDatabaseToolStripMenuItem,
            this.clearDatabaseToolStripMenuItem,
            this.databaseEncryptionToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // cleanUpDatabaseToolStripMenuItem
            // 
            this.cleanUpDatabaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteFinishedEventsToolStripMenuItem,
            this.deleteFinishedGeneralEventsToolStripMenuItem});
            this.cleanUpDatabaseToolStripMenuItem.Name = "cleanUpDatabaseToolStripMenuItem";
            this.cleanUpDatabaseToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cleanUpDatabaseToolStripMenuItem.Text = "Clean Up Database";
            // 
            // deleteFinishedEventsToolStripMenuItem
            // 
            this.deleteFinishedEventsToolStripMenuItem.Name = "deleteFinishedEventsToolStripMenuItem";
            this.deleteFinishedEventsToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.deleteFinishedEventsToolStripMenuItem.Text = "Delete Events for Finished Classes";
            this.deleteFinishedEventsToolStripMenuItem.Click += new System.EventHandler(this.deleteFinishedEventsToolStripMenuItem_Click);
            // 
            // deleteFinishedGeneralEventsToolStripMenuItem
            // 
            this.deleteFinishedGeneralEventsToolStripMenuItem.Name = "deleteFinishedGeneralEventsToolStripMenuItem";
            this.deleteFinishedGeneralEventsToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.deleteFinishedGeneralEventsToolStripMenuItem.Text = "Delete Finished General Events";
            this.deleteFinishedGeneralEventsToolStripMenuItem.Click += new System.EventHandler(this.deleteFinishedGeneralEventsToolStripMenuItem_Click);
            // 
            // clearDatabaseToolStripMenuItem
            // 
            this.clearDatabaseToolStripMenuItem.Name = "clearDatabaseToolStripMenuItem";
            this.clearDatabaseToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.clearDatabaseToolStripMenuItem.Text = "Reset Database";
            this.clearDatabaseToolStripMenuItem.Click += new System.EventHandler(this.clearDatabaseToolStripMenuItem_Click);
            // 
            // databaseEncryptionToolStripMenuItem
            // 
            this.databaseEncryptionToolStripMenuItem.Name = "databaseEncryptionToolStripMenuItem";
            this.databaseEncryptionToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.databaseEncryptionToolStripMenuItem.Text = "Database Encryption";
            this.databaseEncryptionToolStripMenuItem.Click += new System.EventHandler(this.databaseEncryptionToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSemesterToolStripMenuItem,
            this.addProfessorToolStripMenuItem,
            this.addClassToolStripMenuItem,
            this.addEventToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // addSemesterToolStripMenuItem
            // 
            this.addSemesterToolStripMenuItem.Name = "addSemesterToolStripMenuItem";
            this.addSemesterToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addSemesterToolStripMenuItem.Text = "Add Semester";
            this.addSemesterToolStripMenuItem.Click += new System.EventHandler(this.addSemesterToolStripMenuItem_Click);
            // 
            // addProfessorToolStripMenuItem
            // 
            this.addProfessorToolStripMenuItem.Name = "addProfessorToolStripMenuItem";
            this.addProfessorToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addProfessorToolStripMenuItem.Text = "Add Professor";
            this.addProfessorToolStripMenuItem.Click += new System.EventHandler(this.addProfessorToolStripMenuItem_Click);
            // 
            // addClassToolStripMenuItem
            // 
            this.addClassToolStripMenuItem.Name = "addClassToolStripMenuItem";
            this.addClassToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addClassToolStripMenuItem.Text = "Add Class";
            this.addClassToolStripMenuItem.Click += new System.EventHandler(this.addClassToolStripMenuItem_Click);
            // 
            // addEventToolStripMenuItem
            // 
            this.addEventToolStripMenuItem.Name = "addEventToolStripMenuItem";
            this.addEventToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.addEventToolStripMenuItem.Text = "Add Event";
            this.addEventToolStripMenuItem.Click += new System.EventHandler(this.addEventToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSemesterToolStripMenuItem,
            this.editProfessorToolStripMenuItem,
            this.editClassToolStripMenuItem,
            this.editEventToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // editSemesterToolStripMenuItem
            // 
            this.editSemesterToolStripMenuItem.Name = "editSemesterToolStripMenuItem";
            this.editSemesterToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.editSemesterToolStripMenuItem.Text = "Edit Semester";
            this.editSemesterToolStripMenuItem.Click += new System.EventHandler(this.editSemesterToolStripMenuItem_Click);
            // 
            // editProfessorToolStripMenuItem
            // 
            this.editProfessorToolStripMenuItem.Name = "editProfessorToolStripMenuItem";
            this.editProfessorToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.editProfessorToolStripMenuItem.Text = "Edit Professor";
            this.editProfessorToolStripMenuItem.Click += new System.EventHandler(this.editProfessorToolStripMenuItem_Click);
            // 
            // editClassToolStripMenuItem
            // 
            this.editClassToolStripMenuItem.Name = "editClassToolStripMenuItem";
            this.editClassToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.editClassToolStripMenuItem.Text = "Edit Class";
            this.editClassToolStripMenuItem.Click += new System.EventHandler(this.editClassToolStripMenuItem_Click);
            // 
            // editEventToolStripMenuItem
            // 
            this.editEventToolStripMenuItem.Name = "editEventToolStripMenuItem";
            this.editEventToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.editEventToolStripMenuItem.Text = "Edit Event";
            this.editEventToolStripMenuItem.Click += new System.EventHandler(this.editEventToolStripMenuItem_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactProfessorToolStripMenuItem,
            this.mailSettingsToolStripMenuItem});
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.contactToolStripMenuItem.Text = "Contact";
            // 
            // contactProfessorToolStripMenuItem
            // 
            this.contactProfessorToolStripMenuItem.Name = "contactProfessorToolStripMenuItem";
            this.contactProfessorToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.contactProfessorToolStripMenuItem.Text = "Contact Professor";
            this.contactProfessorToolStripMenuItem.Click += new System.EventHandler(this.contactProfessorToolStripMenuItem_Click);
            // 
            // mailSettingsToolStripMenuItem
            // 
            this.mailSettingsToolStripMenuItem.Name = "mailSettingsToolStripMenuItem";
            this.mailSettingsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.mailSettingsToolStripMenuItem.Text = "Mail Settings";
            this.mailSettingsToolStripMenuItem.Click += new System.EventHandler(this.mailSettingsToolStripMenuItem_Click);
            // 
            // syncSettingsToolStripMenuItem
            // 
            this.syncSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableDisableToolStripMenuItem,
            this.authenticateToolStripMenuItem,
            this.googleCalendarSettingsToolStripMenuItem,
            this.mergeExternalChangesToolStripMenuItem});
            this.syncSettingsToolStripMenuItem.Name = "syncSettingsToolStripMenuItem";
            this.syncSettingsToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.syncSettingsToolStripMenuItem.Text = "Sync Settings";
            // 
            // enableDisableToolStripMenuItem
            // 
            this.enableDisableToolStripMenuItem.Name = "enableDisableToolStripMenuItem";
            this.enableDisableToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.enableDisableToolStripMenuItem.Text = "Enable Calendar Sync";
            this.enableDisableToolStripMenuItem.Click += new System.EventHandler(this.enableCalendarSyncToolStripMenuItem_Click);
            // 
            // authenticateToolStripMenuItem
            // 
            this.authenticateToolStripMenuItem.Name = "authenticateToolStripMenuItem";
            this.authenticateToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.authenticateToolStripMenuItem.Text = "Authenticate";
            this.authenticateToolStripMenuItem.Click += new System.EventHandler(this.reauthenticateToolStripMenuItem_Click);
            // 
            // googleCalendarSettingsToolStripMenuItem
            // 
            this.googleCalendarSettingsToolStripMenuItem.Name = "googleCalendarSettingsToolStripMenuItem";
            this.googleCalendarSettingsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.googleCalendarSettingsToolStripMenuItem.Text = "Google Calendar Settings";
            this.googleCalendarSettingsToolStripMenuItem.Click += new System.EventHandler(this.googleCalendarSettingsToolStripMenuItem_Click);
            // 
            // mergeExternalChangesToolStripMenuItem
            // 
            this.mergeExternalChangesToolStripMenuItem.Name = "mergeExternalChangesToolStripMenuItem";
            this.mergeExternalChangesToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.mergeExternalChangesToolStripMenuItem.Text = "Merge External Changes";
            this.mergeExternalChangesToolStripMenuItem.Click += new System.EventHandler(this.mergeExternalChangesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.container);
            this.leftPanel.Controls.Add(this.monthCalendar);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Padding = new System.Windows.Forms.Padding(10);
            this.leftPanel.Size = new System.Drawing.Size(242, 514);
            this.leftPanel.TabIndex = 28;
            // 
            // container
            // 
            this.container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.container.BackColor = System.Drawing.Color.Transparent;
            this.container.Controls.Add(this.gradeInformationPanel);
            this.container.Controls.Add(this.currentGradesPanel);
            this.container.Controls.Add(this.upcomingAssignmentsPanel);
            this.container.Location = new System.Drawing.Point(9, 173);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(227, 334);
            this.container.TabIndex = 27;
            this.container.Resize += new System.EventHandler(this.container_Resize);
            // 
            // gradeInformationPanel
            // 
            this.gradeInformationPanel.Controls.Add(this.lblOverallGpa);
            this.gradeInformationPanel.Controls.Add(this.lblSemesterGpa);
            this.gradeInformationPanel.Controls.Add(this.lblOverallGpaValue);
            this.gradeInformationPanel.Controls.Add(this.lblSemesterGpaValue);
            this.gradeInformationPanel.Location = new System.Drawing.Point(3, 291);
            this.gradeInformationPanel.Name = "gradeInformationPanel";
            this.gradeInformationPanel.Size = new System.Drawing.Size(214, 40);
            this.gradeInformationPanel.TabIndex = 27;
            // 
            // lblOverallGpa
            // 
            this.lblOverallGpa.AutoSize = true;
            this.lblOverallGpa.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverallGpa.Location = new System.Drawing.Point(17, 19);
            this.lblOverallGpa.Name = "lblOverallGpa";
            this.lblOverallGpa.Size = new System.Drawing.Size(98, 18);
            this.lblOverallGpa.TabIndex = 28;
            this.lblOverallGpa.Text = "Overall GPA:";
            // 
            // lblSemesterGpa
            // 
            this.lblSemesterGpa.AutoSize = true;
            this.lblSemesterGpa.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemesterGpa.Location = new System.Drawing.Point(1, 1);
            this.lblSemesterGpa.Name = "lblSemesterGpa";
            this.lblSemesterGpa.Size = new System.Drawing.Size(114, 18);
            this.lblSemesterGpa.TabIndex = 23;
            this.lblSemesterGpa.Text = "Semester GPA:";
            // 
            // lblOverallGpaValue
            // 
            this.lblOverallGpaValue.AutoSize = true;
            this.lblOverallGpaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverallGpaValue.Location = new System.Drawing.Point(121, 19);
            this.lblOverallGpaValue.Name = "lblOverallGpaValue";
            this.lblOverallGpaValue.Size = new System.Drawing.Size(39, 18);
            this.lblOverallGpaValue.TabIndex = 29;
            this.lblOverallGpaValue.Text = "GPA";
            // 
            // lblSemesterGpaValue
            // 
            this.lblSemesterGpaValue.AutoSize = true;
            this.lblSemesterGpaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemesterGpaValue.Location = new System.Drawing.Point(121, 1);
            this.lblSemesterGpaValue.Name = "lblSemesterGpaValue";
            this.lblSemesterGpaValue.Size = new System.Drawing.Size(39, 18);
            this.lblSemesterGpaValue.TabIndex = 27;
            this.lblSemesterGpaValue.Text = "GPA";
            // 
            // currentGradesPanel
            // 
            this.currentGradesPanel.BackColor = System.Drawing.SystemColors.Control;
            this.currentGradesPanel.Controls.Add(this.rtxtCurrentGrades);
            this.currentGradesPanel.Controls.Add(this.lblCurrentGrades);
            this.currentGradesPanel.Location = new System.Drawing.Point(4, 151);
            this.currentGradesPanel.Name = "currentGradesPanel";
            this.currentGradesPanel.Size = new System.Drawing.Size(217, 134);
            this.currentGradesPanel.TabIndex = 26;
            // 
            // rtxtCurrentGrades
            // 
            this.rtxtCurrentGrades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtCurrentGrades.BackColor = System.Drawing.SystemColors.Control;
            this.rtxtCurrentGrades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtCurrentGrades.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtxtCurrentGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtCurrentGrades.Location = new System.Drawing.Point(5, 21);
            this.rtxtCurrentGrades.Name = "rtxtCurrentGrades";
            this.rtxtCurrentGrades.ReadOnly = true;
            this.rtxtCurrentGrades.Size = new System.Drawing.Size(208, 110);
            this.rtxtCurrentGrades.TabIndex = 0;
            this.rtxtCurrentGrades.TabStop = false;
            this.rtxtCurrentGrades.Text = "Grades";
            // 
            // lblCurrentGrades
            // 
            this.lblCurrentGrades.AutoSize = true;
            this.lblCurrentGrades.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentGrades.Location = new System.Drawing.Point(3, 0);
            this.lblCurrentGrades.Name = "lblCurrentGrades";
            this.lblCurrentGrades.Size = new System.Drawing.Size(119, 18);
            this.lblCurrentGrades.TabIndex = 22;
            this.lblCurrentGrades.Text = "Current Grades";
            // 
            // upcomingAssignmentsPanel
            // 
            this.upcomingAssignmentsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.upcomingAssignmentsPanel.Controls.Add(this.rtxtUpcomingAssignments);
            this.upcomingAssignmentsPanel.Controls.Add(this.lblUpcomingAssignments);
            this.upcomingAssignmentsPanel.Location = new System.Drawing.Point(3, 3);
            this.upcomingAssignmentsPanel.Name = "upcomingAssignmentsPanel";
            this.upcomingAssignmentsPanel.Size = new System.Drawing.Size(217, 142);
            this.upcomingAssignmentsPanel.TabIndex = 25;
            // 
            // rtxtUpcomingAssignments
            // 
            this.rtxtUpcomingAssignments.BackColor = System.Drawing.SystemColors.Control;
            this.rtxtUpcomingAssignments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtUpcomingAssignments.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtxtUpcomingAssignments.Location = new System.Drawing.Point(6, 21);
            this.rtxtUpcomingAssignments.Name = "rtxtUpcomingAssignments";
            this.rtxtUpcomingAssignments.ReadOnly = true;
            this.rtxtUpcomingAssignments.Size = new System.Drawing.Size(211, 118);
            this.rtxtUpcomingAssignments.TabIndex = 0;
            this.rtxtUpcomingAssignments.TabStop = false;
            this.rtxtUpcomingAssignments.Text = "Events";
            // 
            // lblUpcomingAssignments
            // 
            this.lblUpcomingAssignments.AutoSize = true;
            this.lblUpcomingAssignments.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpcomingAssignments.Location = new System.Drawing.Point(4, 0);
            this.lblUpcomingAssignments.Name = "lblUpcomingAssignments";
            this.lblUpcomingAssignments.Size = new System.Drawing.Size(133, 18);
            this.lblUpcomingAssignments.TabIndex = 22;
            this.lblUpcomingAssignments.Text = "Upcoming Events";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.tsTaskManagement,
            this.tsAddTaskBtn,
            this.tsComboBoxDays,
            this.tslCalendarView,
            this.tsDeleteTaskBtn,
            this.toolStripSeparator3,
            this.tslZoom,
            this.tsZoomInBtn,
            this.tsZoomOutBtn,
            this.tsResetZoomBtn,
            this.toolStripSeparator1,
            this.tsViewOfficeHoursBtn,
            this.toolStripSeparator4,
            this.tsViewScheduleBtn,
            this.toolStripSeparator5,
            this.tsFinalsCalcBtn,
            this.toolStripSeparator6});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(879, 25);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 30;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsTaskManagement
            // 
            this.tsTaskManagement.Name = "tsTaskManagement";
            this.tsTaskManagement.Size = new System.Drawing.Size(108, 22);
            this.tsTaskManagement.Text = "Task Management:";
            // 
            // tsAddTaskBtn
            // 
            this.tsAddTaskBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAddTaskBtn.Image = global::Planner.Properties.Resources.add_icon;
            this.tsAddTaskBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAddTaskBtn.Name = "tsAddTaskBtn";
            this.tsAddTaskBtn.Size = new System.Drawing.Size(23, 22);
            this.tsAddTaskBtn.Text = "Create New Task";
            this.tsAddTaskBtn.Click += new System.EventHandler(this.tsAddTaskBtn_Click);
            // 
            // tsComboBoxDays
            // 
            this.tsComboBoxDays.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsComboBoxDays.AutoSize = false;
            this.tsComboBoxDays.BackColor = System.Drawing.SystemColors.Window;
            this.tsComboBoxDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tsComboBoxDays.DropDownWidth = 60;
            this.tsComboBoxDays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tsComboBoxDays.Items.AddRange(new object[] {
            "1 Day  ",
            "3 Days",
            "5 Days",
            "7 Days"});
            this.tsComboBoxDays.MaxDropDownItems = 4;
            this.tsComboBoxDays.Name = "tsComboBoxDays";
            this.tsComboBoxDays.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tsComboBoxDays.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.tsComboBoxDays.Size = new System.Drawing.Size(0, 24);
            this.tsComboBoxDays.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // tslCalendarView
            // 
            this.tslCalendarView.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslCalendarView.Name = "tslCalendarView";
            this.tslCalendarView.Size = new System.Drawing.Size(85, 22);
            this.tslCalendarView.Text = "Calendar View:";
            // 
            // tsDeleteTaskBtn
            // 
            this.tsDeleteTaskBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDeleteTaskBtn.Image = global::Planner.Properties.Resources.delete_icon;
            this.tsDeleteTaskBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDeleteTaskBtn.Name = "tsDeleteTaskBtn";
            this.tsDeleteTaskBtn.Size = new System.Drawing.Size(23, 22);
            this.tsDeleteTaskBtn.Text = "Delete Task";
            this.tsDeleteTaskBtn.Click += new System.EventHandler(this.tsDeleteTaskBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tslZoom
            // 
            this.tslZoom.Name = "tslZoom";
            this.tslZoom.Size = new System.Drawing.Size(42, 22);
            this.tslZoom.Text = "Zoom:";
            // 
            // tsZoomInBtn
            // 
            this.tsZoomInBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsZoomInBtn.Image = ((System.Drawing.Image)(resources.GetObject("tsZoomInBtn.Image")));
            this.tsZoomInBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsZoomInBtn.Name = "tsZoomInBtn";
            this.tsZoomInBtn.Size = new System.Drawing.Size(23, 22);
            this.tsZoomInBtn.Text = "Zoom In";
            this.tsZoomInBtn.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // tsZoomOutBtn
            // 
            this.tsZoomOutBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsZoomOutBtn.Image = global::Planner.Properties.Resources.zoom_out_icon;
            this.tsZoomOutBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsZoomOutBtn.Name = "tsZoomOutBtn";
            this.tsZoomOutBtn.Size = new System.Drawing.Size(23, 22);
            this.tsZoomOutBtn.Text = "Zoom Out";
            this.tsZoomOutBtn.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // tsResetZoomBtn
            // 
            this.tsResetZoomBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsResetZoomBtn.Image = global::Planner.Properties.Resources.refresh_icon;
            this.tsResetZoomBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsResetZoomBtn.Name = "tsResetZoomBtn";
            this.tsResetZoomBtn.Size = new System.Drawing.Size(23, 22);
            this.tsResetZoomBtn.Text = "Reset Zoom";
            this.tsResetZoomBtn.Click += new System.EventHandler(this.tsResetZoomBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsViewOfficeHoursBtn
            // 
            this.tsViewOfficeHoursBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsViewOfficeHoursBtn.Image = ((System.Drawing.Image)(resources.GetObject("tsViewOfficeHoursBtn.Image")));
            this.tsViewOfficeHoursBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsViewOfficeHoursBtn.Name = "tsViewOfficeHoursBtn";
            this.tsViewOfficeHoursBtn.Size = new System.Drawing.Size(106, 22);
            this.tsViewOfficeHoursBtn.Text = "View Office Hours";
            this.tsViewOfficeHoursBtn.Click += new System.EventHandler(this.tsViewOfficeHoursBtn_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsViewScheduleBtn
            // 
            this.tsViewScheduleBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsViewScheduleBtn.Image = ((System.Drawing.Image)(resources.GetObject("tsViewScheduleBtn.Image")));
            this.tsViewScheduleBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsViewScheduleBtn.Name = "tsViewScheduleBtn";
            this.tsViewScheduleBtn.Size = new System.Drawing.Size(87, 22);
            this.tsViewScheduleBtn.Text = "View Schedule";
            this.tsViewScheduleBtn.Click += new System.EventHandler(this.tsViewScheduleBtn_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsFinalsCalcBtn
            // 
            this.tsFinalsCalcBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsFinalsCalcBtn.Image = ((System.Drawing.Image)(resources.GetObject("tsFinalsCalcBtn.Image")));
            this.tsFinalsCalcBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFinalsCalcBtn.Name = "tsFinalsCalcBtn";
            this.tsFinalsCalcBtn.Size = new System.Drawing.Size(98, 22);
            this.tsFinalsCalcBtn.Text = "Finals Calculator";
            this.tsFinalsCalcBtn.Click += new System.EventHandler(this.tsFinalsCalcBtn_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // formPanel
            // 
            this.formPanel.BackColor = System.Drawing.SystemColors.Control;
            this.formPanel.Controls.Add(this.linksPanel);
            this.formPanel.Controls.Add(this.leftPanel);
            this.formPanel.Controls.Add(this.rightPanel);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPanel.Location = new System.Drawing.Point(0, 49);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(879, 514);
            this.formPanel.TabIndex = 32;
            // 
            // linksPanel
            // 
            this.linksPanel.Controls.Add(this.btnEditGrades);
            this.linksPanel.Controls.Add(this.btnGenerateAssignmentReport);
            this.linksPanel.Controls.Add(this.btnGenerateGradeReport);
            this.linksPanel.Controls.Add(this.btnViewCalendar);
            this.linksPanel.Location = new System.Drawing.Point(248, 9);
            this.linksPanel.Name = "linksPanel";
            this.linksPanel.Size = new System.Drawing.Size(620, 37);
            this.linksPanel.TabIndex = 33;
            // 
            // btnEditGrades
            // 
            this.btnEditGrades.AutoSize = true;
            this.btnEditGrades.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditGrades.Image = global::Planner.Properties.Resources.edit_icon;
            this.btnEditGrades.Location = new System.Drawing.Point(498, 3);
            this.btnEditGrades.Name = "btnEditGrades";
            this.btnEditGrades.Size = new System.Drawing.Size(99, 32);
            this.btnEditGrades.TabIndex = 3;
            this.btnEditGrades.Text = "Edit Grades";
            this.btnEditGrades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditGrades.UseVisualStyleBackColor = false;
            this.btnEditGrades.Click += new System.EventHandler(this.btnEditGrades_Click);
            // 
            // btnGenerateAssignmentReport
            // 
            this.btnGenerateAssignmentReport.AutoSize = true;
            this.btnGenerateAssignmentReport.BackColor = System.Drawing.SystemColors.Control;
            this.btnGenerateAssignmentReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateAssignmentReport.Image = global::Planner.Properties.Resources.text_document_icon;
            this.btnGenerateAssignmentReport.Location = new System.Drawing.Point(128, 3);
            this.btnGenerateAssignmentReport.Name = "btnGenerateAssignmentReport";
            this.btnGenerateAssignmentReport.Size = new System.Drawing.Size(197, 32);
            this.btnGenerateAssignmentReport.TabIndex = 2;
            this.btnGenerateAssignmentReport.Text = "Generate Assignment Report";
            this.btnGenerateAssignmentReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerateAssignmentReport.UseVisualStyleBackColor = false;
            this.btnGenerateAssignmentReport.Click += new System.EventHandler(this.btnGenerateAssignmentReport_Click);
            // 
            // btnGenerateGradeReport
            // 
            this.btnGenerateGradeReport.AutoSize = true;
            this.btnGenerateGradeReport.BackColor = System.Drawing.SystemColors.Control;
            this.btnGenerateGradeReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateGradeReport.Image = global::Planner.Properties.Resources.text_document_icon;
            this.btnGenerateGradeReport.Location = new System.Drawing.Point(331, 3);
            this.btnGenerateGradeReport.Name = "btnGenerateGradeReport";
            this.btnGenerateGradeReport.Size = new System.Drawing.Size(161, 32);
            this.btnGenerateGradeReport.TabIndex = 1;
            this.btnGenerateGradeReport.Text = "Generate Grade Report";
            this.btnGenerateGradeReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGenerateGradeReport.UseVisualStyleBackColor = false;
            this.btnGenerateGradeReport.Click += new System.EventHandler(this.btnGenerateGradeReport_Click);
            // 
            // btnViewCalendar
            // 
            this.btnViewCalendar.AutoSize = true;
            this.btnViewCalendar.BackColor = System.Drawing.SystemColors.Control;
            this.btnViewCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCalendar.Image = global::Planner.Properties.Resources.calendar_icon;
            this.btnViewCalendar.Location = new System.Drawing.Point(10, 3);
            this.btnViewCalendar.Name = "btnViewCalendar";
            this.btnViewCalendar.Size = new System.Drawing.Size(112, 32);
            this.btnViewCalendar.TabIndex = 0;
            this.btnViewCalendar.Text = "View Calendar";
            this.btnViewCalendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewCalendar.UseVisualStyleBackColor = false;
            this.btnViewCalendar.Click += new System.EventHandler(this.btnViewCalendar_Click);
            // 
            // rightPanel
            // 
            this.rightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rightPanel.BackColor = System.Drawing.SystemColors.Control;
            this.rightPanel.Controls.Add(this.tabControl1);
            this.rightPanel.Location = new System.Drawing.Point(248, 34);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(619, 477);
            this.rightPanel.TabIndex = 35;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabViewCalendar);
            this.tabControl1.Controls.Add(this.tabGenerateAssignmentReport);
            this.tabControl1.Controls.Add(this.tabGenerateGradeReport);
            this.tabControl1.Controls.Add(this.tabEditGrades);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(622, 477);
            this.tabControl1.TabIndex = 34;
            this.tabControl1.Resize += new System.EventHandler(this.tabControl1_Resize);
            // 
            // tabViewCalendar
            // 
            this.tabViewCalendar.BackColor = System.Drawing.SystemColors.Control;
            this.tabViewCalendar.Controls.Add(this.calendarPanel);
            this.tabViewCalendar.Location = new System.Drawing.Point(4, 22);
            this.tabViewCalendar.Name = "tabViewCalendar";
            this.tabViewCalendar.Size = new System.Drawing.Size(614, 451);
            this.tabViewCalendar.TabIndex = 0;
            this.tabViewCalendar.Text = "View Calendar";
            this.tabViewCalendar.Enter += new System.EventHandler(this.tabViewCalendar_Enter);
            this.tabViewCalendar.Resize += new System.EventHandler(this.tabPage1_Resize);
            // 
            // calendarPanel
            // 
            this.calendarPanel.AutoSize = true;
            this.calendarPanel.BackColor = System.Drawing.SystemColors.Control;
            this.calendarPanel.Controls.Add(this.calendarView);
            this.calendarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendarPanel.Location = new System.Drawing.Point(0, 0);
            this.calendarPanel.Name = "calendarPanel";
            this.calendarPanel.Size = new System.Drawing.Size(614, 451);
            this.calendarPanel.TabIndex = 33;
            // 
            // tabGenerateAssignmentReport
            // 
            this.tabGenerateAssignmentReport.BackColor = System.Drawing.SystemColors.Control;
            this.tabGenerateAssignmentReport.Controls.Add(this.lnkClearAssignmentType);
            this.tabGenerateAssignmentReport.Controls.Add(this.lnkClearProfessorFilter);
            this.tabGenerateAssignmentReport.Controls.Add(this.lnkClearClassFilter);
            this.tabGenerateAssignmentReport.Controls.Add(this.chkUseDateAsFilter);
            this.tabGenerateAssignmentReport.Controls.Add(this.dtAssignmentDate);
            this.tabGenerateAssignmentReport.Controls.Add(this.lblAssignmentDate);
            this.tabGenerateAssignmentReport.Controls.Add(this.lblKeywords);
            this.tabGenerateAssignmentReport.Controls.Add(this.txtKeywords);
            this.tabGenerateAssignmentReport.Controls.Add(this.cbAssignmentType);
            this.tabGenerateAssignmentReport.Controls.Add(this.lblAssignmentType);
            this.tabGenerateAssignmentReport.Controls.Add(this.btnAssignmentReport);
            this.tabGenerateAssignmentReport.Controls.Add(this.cbAssignmentClass);
            this.tabGenerateAssignmentReport.Controls.Add(this.lblAssignmentClass);
            this.tabGenerateAssignmentReport.Controls.Add(this.cbAssignmentProfessor);
            this.tabGenerateAssignmentReport.Controls.Add(this.lblAssignmentProfessor);
            this.tabGenerateAssignmentReport.Controls.Add(this.lblSelectOptions);
            this.tabGenerateAssignmentReport.Controls.Add(this.assignmentReportPanel);
            this.tabGenerateAssignmentReport.Location = new System.Drawing.Point(4, 22);
            this.tabGenerateAssignmentReport.Name = "tabGenerateAssignmentReport";
            this.tabGenerateAssignmentReport.Size = new System.Drawing.Size(614, 451);
            this.tabGenerateAssignmentReport.TabIndex = 2;
            this.tabGenerateAssignmentReport.Text = "Generate Assignment Report";
            this.tabGenerateAssignmentReport.Enter += new System.EventHandler(this.tabGenerateAssignmentReport_Enter);
            // 
            // lnkClearAssignmentType
            // 
            this.lnkClearAssignmentType.AutoSize = true;
            this.lnkClearAssignmentType.Location = new System.Drawing.Point(193, 185);
            this.lnkClearAssignmentType.Name = "lnkClearAssignmentType";
            this.lnkClearAssignmentType.Size = new System.Drawing.Size(31, 13);
            this.lnkClearAssignmentType.TabIndex = 64;
            this.lnkClearAssignmentType.TabStop = true;
            this.lnkClearAssignmentType.Text = "Clear";
            this.lnkClearAssignmentType.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClearAssignmentType_LinkClicked);
            // 
            // lnkClearProfessorFilter
            // 
            this.lnkClearProfessorFilter.AutoSize = true;
            this.lnkClearProfessorFilter.Location = new System.Drawing.Point(193, 72);
            this.lnkClearProfessorFilter.Name = "lnkClearProfessorFilter";
            this.lnkClearProfessorFilter.Size = new System.Drawing.Size(31, 13);
            this.lnkClearProfessorFilter.TabIndex = 63;
            this.lnkClearProfessorFilter.TabStop = true;
            this.lnkClearProfessorFilter.Text = "Clear";
            this.lnkClearProfessorFilter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClearProfessorFilter_LinkClicked);
            // 
            // lnkClearClassFilter
            // 
            this.lnkClearClassFilter.AutoSize = true;
            this.lnkClearClassFilter.Location = new System.Drawing.Point(193, 125);
            this.lnkClearClassFilter.Name = "lnkClearClassFilter";
            this.lnkClearClassFilter.Size = new System.Drawing.Size(31, 13);
            this.lnkClearClassFilter.TabIndex = 62;
            this.lnkClearClassFilter.TabStop = true;
            this.lnkClearClassFilter.Text = "Clear";
            this.lnkClearClassFilter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClearClassFilter_LinkClicked);
            // 
            // chkUseDateAsFilter
            // 
            this.chkUseDateAsFilter.AutoSize = true;
            this.chkUseDateAsFilter.Location = new System.Drawing.Point(140, 293);
            this.chkUseDateAsFilter.Name = "chkUseDateAsFilter";
            this.chkUseDateAsFilter.Size = new System.Drawing.Size(84, 17);
            this.chkUseDateAsFilter.TabIndex = 61;
            this.chkUseDateAsFilter.Text = "Use as Filter";
            this.chkUseDateAsFilter.UseVisualStyleBackColor = true;
            this.chkUseDateAsFilter.CheckedChanged += new System.EventHandler(this.chkUseDateAsFilter_CheckedChanged);
            // 
            // dtAssignmentDate
            // 
            this.dtAssignmentDate.CustomFormat = "MM/dd/yyyy";
            this.dtAssignmentDate.Enabled = false;
            this.dtAssignmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtAssignmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtAssignmentDate.Location = new System.Drawing.Point(20, 289);
            this.dtAssignmentDate.Name = "dtAssignmentDate";
            this.dtAssignmentDate.Size = new System.Drawing.Size(108, 23);
            this.dtAssignmentDate.TabIndex = 60;
            this.dtAssignmentDate.Value = new System.DateTime(2011, 4, 17, 0, 0, 0, 0);
            // 
            // lblAssignmentDate
            // 
            this.lblAssignmentDate.AutoSize = true;
            this.lblAssignmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignmentDate.Location = new System.Drawing.Point(17, 269);
            this.lblAssignmentDate.Name = "lblAssignmentDate";
            this.lblAssignmentDate.Size = new System.Drawing.Size(95, 17);
            this.lblAssignmentDate.TabIndex = 59;
            this.lblAssignmentDate.Text = "Date Before";
            // 
            // lblKeywords
            // 
            this.lblKeywords.AutoSize = true;
            this.lblKeywords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeywords.Location = new System.Drawing.Point(17, 213);
            this.lblKeywords.Name = "lblKeywords";
            this.lblKeywords.Size = new System.Drawing.Size(77, 17);
            this.lblKeywords.TabIndex = 58;
            this.lblKeywords.Text = "Keywords";
            // 
            // txtKeywords
            // 
            this.txtKeywords.Location = new System.Drawing.Point(18, 239);
            this.txtKeywords.Name = "txtKeywords";
            this.txtKeywords.Size = new System.Drawing.Size(181, 20);
            this.txtKeywords.TabIndex = 57;
            // 
            // cbAssignmentType
            // 
            this.cbAssignmentType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAssignmentType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAssignmentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAssignmentType.FormattingEnabled = true;
            this.cbAssignmentType.Location = new System.Drawing.Point(20, 182);
            this.cbAssignmentType.Name = "cbAssignmentType";
            this.cbAssignmentType.Size = new System.Drawing.Size(167, 21);
            this.cbAssignmentType.TabIndex = 55;
            // 
            // lblAssignmentType
            // 
            this.lblAssignmentType.AutoSize = true;
            this.lblAssignmentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignmentType.Location = new System.Drawing.Point(17, 156);
            this.lblAssignmentType.Name = "lblAssignmentType";
            this.lblAssignmentType.Size = new System.Drawing.Size(197, 17);
            this.lblAssignmentType.TabIndex = 56;
            this.lblAssignmentType.Text = "Filter By Assignment Type";
            // 
            // btnAssignmentReport
            // 
            this.btnAssignmentReport.Location = new System.Drawing.Point(34, 328);
            this.btnAssignmentReport.Name = "btnAssignmentReport";
            this.btnAssignmentReport.Size = new System.Drawing.Size(180, 23);
            this.btnAssignmentReport.TabIndex = 54;
            this.btnAssignmentReport.Text = "Generate Assignment Report";
            this.btnAssignmentReport.UseVisualStyleBackColor = true;
            this.btnAssignmentReport.Click += new System.EventHandler(this.btnAssignmentReport_Click);
            // 
            // cbAssignmentClass
            // 
            this.cbAssignmentClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAssignmentClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAssignmentClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAssignmentClass.FormattingEnabled = true;
            this.cbAssignmentClass.Location = new System.Drawing.Point(19, 121);
            this.cbAssignmentClass.Name = "cbAssignmentClass";
            this.cbAssignmentClass.Size = new System.Drawing.Size(168, 21);
            this.cbAssignmentClass.TabIndex = 51;
            this.cbAssignmentClass.SelectedIndexChanged += new System.EventHandler(this.cbAssignmentClass_SelectedIndexChanged);
            // 
            // lblAssignmentClass
            // 
            this.lblAssignmentClass.AutoSize = true;
            this.lblAssignmentClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignmentClass.Location = new System.Drawing.Point(16, 99);
            this.lblAssignmentClass.Name = "lblAssignmentClass";
            this.lblAssignmentClass.Size = new System.Drawing.Size(112, 17);
            this.lblAssignmentClass.TabIndex = 53;
            this.lblAssignmentClass.Text = "Filter By Class";
            // 
            // cbAssignmentProfessor
            // 
            this.cbAssignmentProfessor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAssignmentProfessor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAssignmentProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAssignmentProfessor.FormattingEnabled = true;
            this.cbAssignmentProfessor.Location = new System.Drawing.Point(19, 69);
            this.cbAssignmentProfessor.Name = "cbAssignmentProfessor";
            this.cbAssignmentProfessor.Size = new System.Drawing.Size(168, 21);
            this.cbAssignmentProfessor.TabIndex = 50;
            this.cbAssignmentProfessor.SelectedIndexChanged += new System.EventHandler(this.cbAssignmentProfessor_SelectedIndexChanged);
            // 
            // lblAssignmentProfessor
            // 
            this.lblAssignmentProfessor.AutoSize = true;
            this.lblAssignmentProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignmentProfessor.Location = new System.Drawing.Point(16, 49);
            this.lblAssignmentProfessor.Margin = new System.Windows.Forms.Padding(0);
            this.lblAssignmentProfessor.Name = "lblAssignmentProfessor";
            this.lblAssignmentProfessor.Size = new System.Drawing.Size(143, 17);
            this.lblAssignmentProfessor.TabIndex = 52;
            this.lblAssignmentProfessor.Text = "Filter By Professor\r\n";
            // 
            // lblSelectOptions
            // 
            this.lblSelectOptions.AutoSize = true;
            this.lblSelectOptions.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectOptions.Location = new System.Drawing.Point(16, 17);
            this.lblSelectOptions.Name = "lblSelectOptions";
            this.lblSelectOptions.Size = new System.Drawing.Size(113, 18);
            this.lblSelectOptions.TabIndex = 25;
            this.lblSelectOptions.Text = "Select Options";
            // 
            // assignmentReportPanel
            // 
            this.assignmentReportPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.assignmentReportPanel.BackColor = System.Drawing.Color.White;
            this.assignmentReportPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.assignmentReportPanel.Controls.Add(this.lblAssignmentReport);
            this.assignmentReportPanel.Controls.Add(this.tvAssignmentReport);
            this.assignmentReportPanel.Location = new System.Drawing.Point(237, 7);
            this.assignmentReportPanel.Name = "assignmentReportPanel";
            this.assignmentReportPanel.Size = new System.Drawing.Size(374, 439);
            this.assignmentReportPanel.TabIndex = 2;
            // 
            // lblAssignmentReport
            // 
            this.lblAssignmentReport.AutoSize = true;
            this.lblAssignmentReport.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignmentReport.Location = new System.Drawing.Point(13, 9);
            this.lblAssignmentReport.Name = "lblAssignmentReport";
            this.lblAssignmentReport.Size = new System.Drawing.Size(143, 18);
            this.lblAssignmentReport.TabIndex = 23;
            this.lblAssignmentReport.Text = "Assignment Report";
            // 
            // tvAssignmentReport
            // 
            this.tvAssignmentReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tvAssignmentReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvAssignmentReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvAssignmentReport.Location = new System.Drawing.Point(3, 41);
            this.tvAssignmentReport.Name = "tvAssignmentReport";
            this.tvAssignmentReport.Size = new System.Drawing.Size(366, 393);
            this.tvAssignmentReport.TabIndex = 0;
            // 
            // tabGenerateGradeReport
            // 
            this.tabGenerateGradeReport.BackColor = System.Drawing.SystemColors.Control;
            this.tabGenerateGradeReport.Controls.Add(this.chkIncludePastClasses);
            this.tabGenerateGradeReport.Controls.Add(this.cbGradeUpperBound);
            this.tabGenerateGradeReport.Controls.Add(this.cbGradeLowerBound);
            this.tabGenerateGradeReport.Controls.Add(this.txtGradeCredits);
            this.tabGenerateGradeReport.Controls.Add(this.lblCustomGradeReport);
            this.tabGenerateGradeReport.Controls.Add(this.lblGradeCredits);
            this.tabGenerateGradeReport.Controls.Add(this.lblGpaAbove);
            this.tabGenerateGradeReport.Controls.Add(this.lblGpaBelow);
            this.tabGenerateGradeReport.Controls.Add(this.btnGradeReport);
            this.tabGenerateGradeReport.Controls.Add(this.cbGradeClass);
            this.tabGenerateGradeReport.Controls.Add(this.lblGradeClass);
            this.tabGenerateGradeReport.Controls.Add(this.cbGradeProfessor);
            this.tabGenerateGradeReport.Controls.Add(this.lblGradeProfessor);
            this.tabGenerateGradeReport.Controls.Add(this.gradeReportPanel);
            this.tabGenerateGradeReport.Location = new System.Drawing.Point(4, 22);
            this.tabGenerateGradeReport.Name = "tabGenerateGradeReport";
            this.tabGenerateGradeReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabGenerateGradeReport.Size = new System.Drawing.Size(614, 451);
            this.tabGenerateGradeReport.TabIndex = 1;
            this.tabGenerateGradeReport.Text = "Generate Grade Report";
            this.tabGenerateGradeReport.Enter += new System.EventHandler(this.tabGenerateGradeReport_Enter);
            // 
            // chkIncludePastClasses
            // 
            this.chkIncludePastClasses.AutoSize = true;
            this.chkIncludePastClasses.Location = new System.Drawing.Point(29, 48);
            this.chkIncludePastClasses.Name = "chkIncludePastClasses";
            this.chkIncludePastClasses.Size = new System.Drawing.Size(124, 17);
            this.chkIncludePastClasses.TabIndex = 62;
            this.chkIncludePastClasses.Text = "Include Past Classes";
            this.chkIncludePastClasses.UseVisualStyleBackColor = true;
            this.chkIncludePastClasses.CheckedChanged += new System.EventHandler(this.chkIncludePastClasses_CheckedChanged);
            // 
            // cbGradeUpperBound
            // 
            this.cbGradeUpperBound.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbGradeUpperBound.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbGradeUpperBound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGradeUpperBound.FormattingEnabled = true;
            this.cbGradeUpperBound.Location = new System.Drawing.Point(127, 221);
            this.cbGradeUpperBound.Name = "cbGradeUpperBound";
            this.cbGradeUpperBound.Size = new System.Drawing.Size(75, 21);
            this.cbGradeUpperBound.TabIndex = 61;
            // 
            // cbGradeLowerBound
            // 
            this.cbGradeLowerBound.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbGradeLowerBound.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbGradeLowerBound.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGradeLowerBound.FormattingEnabled = true;
            this.cbGradeLowerBound.Location = new System.Drawing.Point(127, 267);
            this.cbGradeLowerBound.Name = "cbGradeLowerBound";
            this.cbGradeLowerBound.Size = new System.Drawing.Size(75, 21);
            this.cbGradeLowerBound.TabIndex = 60;
            // 
            // txtGradeCredits
            // 
            this.txtGradeCredits.Location = new System.Drawing.Point(124, 185);
            this.txtGradeCredits.Name = "txtGradeCredits";
            this.txtGradeCredits.Size = new System.Drawing.Size(79, 20);
            this.txtGradeCredits.TabIndex = 59;
            // 
            // lblCustomGradeReport
            // 
            this.lblCustomGradeReport.AutoSize = true;
            this.lblCustomGradeReport.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomGradeReport.Location = new System.Drawing.Point(10, 16);
            this.lblCustomGradeReport.Name = "lblCustomGradeReport";
            this.lblCustomGradeReport.Size = new System.Drawing.Size(215, 18);
            this.lblCustomGradeReport.TabIndex = 24;
            this.lblCustomGradeReport.Text = "Create Custom Grade Report";
            // 
            // lblGradeCredits
            // 
            this.lblGradeCredits.AutoSize = true;
            this.lblGradeCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradeCredits.Location = new System.Drawing.Point(10, 185);
            this.lblGradeCredits.Name = "lblGradeCredits";
            this.lblGradeCredits.Size = new System.Drawing.Size(108, 17);
            this.lblGradeCredits.TabIndex = 58;
            this.lblGradeCredits.Text = "Class Credits:";
            // 
            // lblGpaAbove
            // 
            this.lblGpaAbove.AutoSize = true;
            this.lblGpaAbove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGpaAbove.Location = new System.Drawing.Point(13, 255);
            this.lblGpaAbove.Name = "lblGpaAbove";
            this.lblGpaAbove.Size = new System.Drawing.Size(101, 34);
            this.lblGpaAbove.TabIndex = 55;
            this.lblGpaAbove.Text = "Grade Equal\r\n    Or Above:";
            // 
            // lblGpaBelow
            // 
            this.lblGpaBelow.AutoSize = true;
            this.lblGpaBelow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGpaBelow.Location = new System.Drawing.Point(13, 222);
            this.lblGpaBelow.Name = "lblGpaBelow";
            this.lblGpaBelow.Size = new System.Drawing.Size(105, 17);
            this.lblGpaBelow.TabIndex = 53;
            this.lblGpaBelow.Text = "Grade Below:";
            // 
            // btnGradeReport
            // 
            this.btnGradeReport.Location = new System.Drawing.Point(40, 310);
            this.btnGradeReport.Name = "btnGradeReport";
            this.btnGradeReport.Size = new System.Drawing.Size(150, 23);
            this.btnGradeReport.TabIndex = 50;
            this.btnGradeReport.Text = "Generate Grade Report";
            this.btnGradeReport.UseVisualStyleBackColor = true;
            this.btnGradeReport.Click += new System.EventHandler(this.btnGradeReport_Click);
            // 
            // cbGradeClass
            // 
            this.cbGradeClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbGradeClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbGradeClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGradeClass.FormattingEnabled = true;
            this.cbGradeClass.Location = new System.Drawing.Point(13, 145);
            this.cbGradeClass.Name = "cbGradeClass";
            this.cbGradeClass.Size = new System.Drawing.Size(189, 21);
            this.cbGradeClass.TabIndex = 47;
            // 
            // lblGradeClass
            // 
            this.lblGradeClass.AutoSize = true;
            this.lblGradeClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradeClass.Location = new System.Drawing.Point(10, 123);
            this.lblGradeClass.Name = "lblGradeClass";
            this.lblGradeClass.Size = new System.Drawing.Size(112, 17);
            this.lblGradeClass.TabIndex = 49;
            this.lblGradeClass.Text = "Filter By Class";
            // 
            // cbGradeProfessor
            // 
            this.cbGradeProfessor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbGradeProfessor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbGradeProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGradeProfessor.FormattingEnabled = true;
            this.cbGradeProfessor.Items.AddRange(new object[] {
            ""});
            this.cbGradeProfessor.Location = new System.Drawing.Point(13, 93);
            this.cbGradeProfessor.Name = "cbGradeProfessor";
            this.cbGradeProfessor.Size = new System.Drawing.Size(189, 21);
            this.cbGradeProfessor.TabIndex = 46;
            this.cbGradeProfessor.SelectedIndexChanged += new System.EventHandler(this.cbGradeProfessor_SelectedIndexChanged);
            // 
            // lblGradeProfessor
            // 
            this.lblGradeProfessor.AutoSize = true;
            this.lblGradeProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradeProfessor.Location = new System.Drawing.Point(10, 73);
            this.lblGradeProfessor.Margin = new System.Windows.Forms.Padding(0);
            this.lblGradeProfessor.Name = "lblGradeProfessor";
            this.lblGradeProfessor.Size = new System.Drawing.Size(143, 17);
            this.lblGradeProfessor.TabIndex = 48;
            this.lblGradeProfessor.Text = "Filter By Professor\r\n";
            // 
            // gradeReportPanel
            // 
            this.gradeReportPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gradeReportPanel.BackColor = System.Drawing.Color.White;
            this.gradeReportPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradeReportPanel.Controls.Add(this.lblGradeReport);
            this.gradeReportPanel.Controls.Add(this.tvGradeReport);
            this.gradeReportPanel.Location = new System.Drawing.Point(237, 6);
            this.gradeReportPanel.Name = "gradeReportPanel";
            this.gradeReportPanel.Size = new System.Drawing.Size(377, 439);
            this.gradeReportPanel.TabIndex = 1;
            // 
            // lblGradeReport
            // 
            this.lblGradeReport.AutoSize = true;
            this.lblGradeReport.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradeReport.Location = new System.Drawing.Point(13, 9);
            this.lblGradeReport.Name = "lblGradeReport";
            this.lblGradeReport.Size = new System.Drawing.Size(105, 18);
            this.lblGradeReport.TabIndex = 23;
            this.lblGradeReport.Text = "Grade Report";
            // 
            // tvGradeReport
            // 
            this.tvGradeReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tvGradeReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvGradeReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvGradeReport.Location = new System.Drawing.Point(3, 41);
            this.tvGradeReport.Name = "tvGradeReport";
            this.tvGradeReport.Size = new System.Drawing.Size(369, 393);
            this.tvGradeReport.TabIndex = 0;
            // 
            // tabEditGrades
            // 
            this.tabEditGrades.BackColor = System.Drawing.SystemColors.Control;
            this.tabEditGrades.Controls.Add(this.editClassGradesPanel);
            this.tabEditGrades.Controls.Add(this.lblSaveStatus);
            this.tabEditGrades.Controls.Add(this.lblEditGrades);
            this.tabEditGrades.Controls.Add(this.btnResetGrades);
            this.tabEditGrades.Controls.Add(this.btnSaveGrades);
            this.tabEditGrades.Controls.Add(this.btnViewGrades);
            this.tabEditGrades.Controls.Add(this.cbEditGradesClass);
            this.tabEditGrades.Controls.Add(this.lblEditClass);
            this.tabEditGrades.Location = new System.Drawing.Point(4, 22);
            this.tabEditGrades.Name = "tabEditGrades";
            this.tabEditGrades.Size = new System.Drawing.Size(614, 451);
            this.tabEditGrades.TabIndex = 3;
            this.tabEditGrades.Text = "Edit Grades";
            this.tabEditGrades.Enter += new System.EventHandler(this.tabEditGrades_Enter);
            // 
            // editClassGradesPanel
            // 
            this.editClassGradesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.editClassGradesPanel.BackColor = System.Drawing.Color.White;
            this.editClassGradesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editClassGradesPanel.Controls.Add(this.tvEditGrades);
            this.editClassGradesPanel.Controls.Add(this.lblEditClassGrades);
            this.editClassGradesPanel.Location = new System.Drawing.Point(187, 35);
            this.editClassGradesPanel.Name = "editClassGradesPanel";
            this.editClassGradesPanel.Size = new System.Drawing.Size(424, 412);
            this.editClassGradesPanel.TabIndex = 58;
            // 
            // tvEditGrades
            // 
            this.tvEditGrades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tvEditGrades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvEditGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvEditGrades.LabelEdit = true;
            this.tvEditGrades.Location = new System.Drawing.Point(3, 39);
            this.tvEditGrades.Name = "tvEditGrades";
            this.tvEditGrades.Size = new System.Drawing.Size(416, 368);
            this.tvEditGrades.TabIndex = 0;
            this.tvEditGrades.BeforeLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.tvEditGrades_BeforeLabelEdit);
            this.tvEditGrades.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.tvEditGrades_AfterLabelEdit);
            // 
            // lblEditClassGrades
            // 
            this.lblEditClassGrades.AutoSize = true;
            this.lblEditClassGrades.Font = new System.Drawing.Font("Arial", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditClassGrades.Location = new System.Drawing.Point(11, 9);
            this.lblEditClassGrades.Name = "lblEditClassGrades";
            this.lblEditClassGrades.Size = new System.Drawing.Size(135, 18);
            this.lblEditClassGrades.TabIndex = 57;
            this.lblEditClassGrades.Text = "Edit Class Grades";
            // 
            // lblSaveStatus
            // 
            this.lblSaveStatus.AutoSize = true;
            this.lblSaveStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveStatus.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSaveStatus.Location = new System.Drawing.Point(22, 194);
            this.lblSaveStatus.Name = "lblSaveStatus";
            this.lblSaveStatus.Size = new System.Drawing.Size(8, 17);
            this.lblSaveStatus.TabIndex = 56;
            this.lblSaveStatus.Text = "\r\n";
            this.lblSaveStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEditGrades
            // 
            this.lblEditGrades.AutoSize = true;
            this.lblEditGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditGrades.Location = new System.Drawing.Point(198, 10);
            this.lblEditGrades.Name = "lblEditGrades";
            this.lblEditGrades.Size = new System.Drawing.Size(362, 17);
            this.lblEditGrades.TabIndex = 55;
            this.lblEditGrades.Text = "Highlight any grade and then single click to edit its value";
            // 
            // btnResetGrades
            // 
            this.btnResetGrades.Enabled = false;
            this.btnResetGrades.Location = new System.Drawing.Point(38, 154);
            this.btnResetGrades.Name = "btnResetGrades";
            this.btnResetGrades.Size = new System.Drawing.Size(91, 23);
            this.btnResetGrades.TabIndex = 54;
            this.btnResetGrades.Text = "Reset";
            this.btnResetGrades.UseVisualStyleBackColor = true;
            this.btnResetGrades.Click += new System.EventHandler(this.btnResetGrades_Click);
            // 
            // btnSaveGrades
            // 
            this.btnSaveGrades.Enabled = false;
            this.btnSaveGrades.Location = new System.Drawing.Point(38, 115);
            this.btnSaveGrades.Name = "btnSaveGrades";
            this.btnSaveGrades.Size = new System.Drawing.Size(91, 23);
            this.btnSaveGrades.TabIndex = 53;
            this.btnSaveGrades.Text = "Save";
            this.btnSaveGrades.UseVisualStyleBackColor = true;
            this.btnSaveGrades.Click += new System.EventHandler(this.btnSaveGrades_Click);
            // 
            // btnViewGrades
            // 
            this.btnViewGrades.Location = new System.Drawing.Point(38, 75);
            this.btnViewGrades.Name = "btnViewGrades";
            this.btnViewGrades.Size = new System.Drawing.Size(91, 23);
            this.btnViewGrades.TabIndex = 52;
            this.btnViewGrades.Text = "View Grades";
            this.btnViewGrades.UseVisualStyleBackColor = true;
            this.btnViewGrades.Click += new System.EventHandler(this.btnViewGrades_Click);
            // 
            // cbEditGradesClass
            // 
            this.cbEditGradesClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEditGradesClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEditGradesClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditGradesClass.FormattingEnabled = true;
            this.cbEditGradesClass.Location = new System.Drawing.Point(16, 35);
            this.cbEditGradesClass.Name = "cbEditGradesClass";
            this.cbEditGradesClass.Size = new System.Drawing.Size(161, 21);
            this.cbEditGradesClass.TabIndex = 50;
            // 
            // lblEditClass
            // 
            this.lblEditClass.AutoSize = true;
            this.lblEditClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditClass.Location = new System.Drawing.Point(13, 10);
            this.lblEditClass.Name = "lblEditClass";
            this.lblEditClass.Size = new System.Drawing.Size(97, 17);
            this.lblEditClass.TabIndex = 51;
            this.lblEditClass.Text = "Select Class";
            // 
            // editGradesTimer
            // 
            this.editGradesTimer.Enabled = true;
            this.editGradesTimer.Interval = 3000;
            this.editGradesTimer.Tick += new System.EventHandler(this.editGradesTimer_Tick);
            // 
            // upcomingAssignmentsTimer
            // 
            this.upcomingAssignmentsTimer.Enabled = true;
            this.upcomingAssignmentsTimer.Interval = 60000;
            this.upcomingAssignmentsTimer.Tick += new System.EventHandler(this.upcomingAssignmentsTimer_Tick);
            // 
            // AssignmentPlanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 585);
            this.Controls.Add(this.formPanel);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(875, 600);
            this.Name = "AssignmentPlanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A+ Student Planner";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AssignmentPlanner_FormClosing);
            this.Load += new System.EventHandler(this.AssignmentPlanner_Load);
            this.SizeChanged += new System.EventHandler(this.AssignmentPlanner_SizeChanged);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.container.ResumeLayout(false);
            this.gradeInformationPanel.ResumeLayout(false);
            this.gradeInformationPanel.PerformLayout();
            this.currentGradesPanel.ResumeLayout(false);
            this.currentGradesPanel.PerformLayout();
            this.upcomingAssignmentsPanel.ResumeLayout(false);
            this.upcomingAssignmentsPanel.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.formPanel.ResumeLayout(false);
            this.linksPanel.ResumeLayout(false);
            this.linksPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabViewCalendar.ResumeLayout(false);
            this.tabViewCalendar.PerformLayout();
            this.calendarPanel.ResumeLayout(false);
            this.tabGenerateAssignmentReport.ResumeLayout(false);
            this.tabGenerateAssignmentReport.PerformLayout();
            this.assignmentReportPanel.ResumeLayout(false);
            this.assignmentReportPanel.PerformLayout();
            this.tabGenerateGradeReport.ResumeLayout(false);
            this.tabGenerateGradeReport.PerformLayout();
            this.gradeReportPanel.ResumeLayout(false);
            this.gradeReportPanel.PerformLayout();
            this.tabEditGrades.ResumeLayout(false);
            this.tabEditGrades.PerformLayout();
            this.editClassGradesPanel.ResumeLayout(false);
            this.editClassGradesPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Panel linksPanel;
        private System.Windows.Forms.Button btnEditGrades;
        private System.Windows.Forms.Button btnGenerateAssignmentReport;
        private System.Windows.Forms.Button btnGenerateGradeReport;
        private System.Windows.Forms.Button btnViewCalendar;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripComboBox tsComboBoxDays;
        private System.Windows.Forms.ToolStripLabel tslCalendarView;
        private System.Windows.Forms.ToolStripButton tsZoomInBtn;
        private System.Windows.Forms.ToolStripButton tsZoomOutBtn;
        private System.Windows.Forms.ToolStripButton tsResetZoomBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslZoom;
        private System.Windows.Forms.ToolStripButton tsAddTaskBtn;
        private System.Windows.Forms.ToolStripLabel tsTaskManagement;
        private System.Windows.Forms.ToolStripButton tsDeleteTaskBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabViewCalendar;
        private System.Windows.Forms.Panel calendarPanel;
        private System.Windows.Forms.TabPage tabGenerateGradeReport;
        private System.Windows.Forms.Panel rightPanel;
        private Calendar.DayView calendarView;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Panel gradeInformationPanel;
        private System.Windows.Forms.Label lblOverallGpa;
        private System.Windows.Forms.Label lblSemesterGpa;
        private System.Windows.Forms.Label lblOverallGpaValue;
        private System.Windows.Forms.Label lblSemesterGpaValue;
        private System.Windows.Forms.Panel currentGradesPanel;
        private System.Windows.Forms.RichTextBox rtxtCurrentGrades;
        private System.Windows.Forms.Label lblCurrentGrades;
        private System.Windows.Forms.Panel upcomingAssignmentsPanel;
        private System.Windows.Forms.RichTextBox rtxtUpcomingAssignments;
        private System.Windows.Forms.Label lblUpcomingAssignments;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProfessorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProfessorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactProfessorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mailSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsViewOfficeHoursBtn;
        private System.Windows.Forms.ToolStripButton tsViewScheduleBtn;
        private System.Windows.Forms.ToolStripButton tsFinalsCalcBtn;
        private System.Windows.Forms.ToolStripMenuItem clearDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TreeView tvGradeReport;
        private System.Windows.Forms.Panel gradeReportPanel;
        private System.Windows.Forms.Label lblGradeReport;
        private System.Windows.Forms.TabPage tabGenerateAssignmentReport;
        private System.Windows.Forms.TabPage tabEditGrades;
        private System.Windows.Forms.TextBox txtGradeCredits;
        private System.Windows.Forms.Label lblCustomGradeReport;
        private System.Windows.Forms.Label lblGradeCredits;
        private System.Windows.Forms.Label lblGpaAbove;
        private System.Windows.Forms.Label lblGpaBelow;
        private System.Windows.Forms.Button btnGradeReport;
        private System.Windows.Forms.ComboBox cbGradeClass;
        private System.Windows.Forms.Label lblGradeClass;
        private System.Windows.Forms.ComboBox cbGradeProfessor;
        private System.Windows.Forms.Label lblGradeProfessor;
        private System.Windows.Forms.Button btnResetGrades;
        private System.Windows.Forms.Button btnSaveGrades;
        private System.Windows.Forms.Button btnViewGrades;
        private System.Windows.Forms.ComboBox cbEditGradesClass;
        private System.Windows.Forms.Label lblEditClass;
        private System.Windows.Forms.TreeView tvEditGrades;
        private System.Windows.Forms.Label lblEditGrades;
        private System.Windows.Forms.Label lblSelectOptions;
        private System.Windows.Forms.Panel assignmentReportPanel;
        private System.Windows.Forms.Label lblAssignmentReport;
        private System.Windows.Forms.TreeView tvAssignmentReport;
        private System.Windows.Forms.Label lblAssignmentDate;
        private System.Windows.Forms.Label lblKeywords;
        private System.Windows.Forms.TextBox txtKeywords;
        private System.Windows.Forms.ComboBox cbAssignmentType;
        private System.Windows.Forms.Label lblAssignmentType;
        private System.Windows.Forms.Button btnAssignmentReport;
        private System.Windows.Forms.ComboBox cbAssignmentClass;
        private System.Windows.Forms.Label lblAssignmentClass;
        private System.Windows.Forms.ComboBox cbAssignmentProfessor;
        private System.Windows.Forms.Label lblAssignmentProfessor;
        private System.Windows.Forms.DateTimePicker dtAssignmentDate;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ToolStripMenuItem cleanUpDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteFinishedEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseEncryptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteFinishedGeneralEventsToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkUseDateAsFilter;
        private System.Windows.Forms.ComboBox cbGradeUpperBound;
        private System.Windows.Forms.ComboBox cbGradeLowerBound;
        private System.Windows.Forms.LinkLabel lnkClearAssignmentType;
        private System.Windows.Forms.LinkLabel lnkClearProfessorFilter;
        private System.Windows.Forms.LinkLabel lnkClearClassFilter;
        private System.Windows.Forms.Label lblSaveStatus;
        private System.Windows.Forms.Timer editGradesTimer;
        private System.Windows.Forms.Label lblEditClassGrades;
        private System.Windows.Forms.Panel editClassGradesPanel;
        private System.Windows.Forms.Timer upcomingAssignmentsTimer;
        private System.Windows.Forms.ToolStripMenuItem syncSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableDisableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googleCalendarSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authenticateToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkIncludePastClasses;
        private System.Windows.Forms.ToolStripMenuItem mergeExternalChangesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSemesterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSemesterToolStripMenuItem;
    }
}

