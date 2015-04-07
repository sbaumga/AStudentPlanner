namespace Planner
{
    partial class EditClassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditClassForm));
            this.lblRequiredClass7 = new System.Windows.Forms.Label();
            this.lblRequiredClass6 = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblClassCredits = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.ctrCredits = new System.Windows.Forms.NumericUpDown();
            this.lblClassDays = new System.Windows.Forms.Label();
            this.lblRequiredClass3 = new System.Windows.Forms.Label();
            this.chkClassMonday = new System.Windows.Forms.CheckBox();
            this.cbFinalLetterGrade = new System.Windows.Forms.ComboBox();
            this.chkClassTuesday = new System.Windows.Forms.CheckBox();
            this.chkClassFinished = new System.Windows.Forms.CheckBox();
            this.chkClassWednesday = new System.Windows.Forms.CheckBox();
            this.lblFinalGrade = new System.Windows.Forms.Label();
            this.chkClassThursday = new System.Windows.Forms.CheckBox();
            this.chkClassFriday = new System.Windows.Forms.CheckBox();
            this.lblRequiredClass1 = new System.Windows.Forms.Label();
            this.lnkEditGradingCategories = new System.Windows.Forms.LinkLabel();
            this.lblRequiredClass2 = new System.Windows.Forms.Label();
            this.lnkEditGradingScale = new System.Windows.Forms.LinkLabel();
            this.lblClassLocation = new System.Windows.Forms.Label();
            this.lblClassProfessor = new System.Windows.Forms.Label();
            this.txtClassLocation = new System.Windows.Forms.TextBox();
            this.cbClassProfessor = new System.Windows.Forms.ComboBox();
            this.btnDeleteClass = new System.Windows.Forms.Button();
            this.btnCloseClose = new System.Windows.Forms.Button();
            this.btnSaveClass = new System.Windows.Forms.Button();
            this.cbEditClass = new System.Windows.Forms.ComboBox();
            this.lblClassText = new System.Windows.Forms.Label();
            this.lblEditClass = new System.Windows.Forms.Label();
            this.cbEditClassProfessorFilter = new System.Windows.Forms.ComboBox();
            this.lblEditClassProfessorFilter = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSaveStatus = new System.Windows.Forms.Label();
            this.cbSemester = new System.Windows.Forms.ComboBox();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblRequiredClass5 = new System.Windows.Forms.Label();
            this.lblClassStartTime = new System.Windows.Forms.Label();
            this.dtClassStartTime = new System.Windows.Forms.DateTimePicker();
            this.lblClassEndTime = new System.Windows.Forms.Label();
            this.lblRequiredClass4 = new System.Windows.Forms.Label();
            this.dtClassEndTime = new System.Windows.Forms.DateTimePicker();
            this.lblEditClassSemesterFilter = new System.Windows.Forms.Label();
            this.cbEditClassSemesterFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ctrCredits)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRequiredClass7
            // 
            this.lblRequiredClass7.AutoSize = true;
            this.lblRequiredClass7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredClass7.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredClass7.Location = new System.Drawing.Point(395, 390);
            this.lblRequiredClass7.Name = "lblRequiredClass7";
            this.lblRequiredClass7.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredClass7.TabIndex = 95;
            this.lblRequiredClass7.Text = "*";
            // 
            // lblRequiredClass6
            // 
            this.lblRequiredClass6.AutoSize = true;
            this.lblRequiredClass6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredClass6.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredClass6.Location = new System.Drawing.Point(211, 390);
            this.lblRequiredClass6.Name = "lblRequiredClass6";
            this.lblRequiredClass6.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredClass6.TabIndex = 94;
            this.lblRequiredClass6.Text = "*";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.Location = new System.Drawing.Point(57, 114);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(98, 17);
            this.lblClassName.TabIndex = 70;
            this.lblClassName.Text = "Class Name:";
            // 
            // lblClassCredits
            // 
            this.lblClassCredits.AutoSize = true;
            this.lblClassCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassCredits.Location = new System.Drawing.Point(92, 188);
            this.lblClassCredits.Name = "lblClassCredits";
            this.lblClassCredits.Size = new System.Drawing.Size(64, 17);
            this.lblClassCredits.TabIndex = 72;
            this.lblClassCredits.Text = "Credits:";
            // 
            // txtClassName
            // 
            this.txtClassName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClassName.Location = new System.Drawing.Point(162, 114);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(199, 20);
            this.txtClassName.TabIndex = 60;
            // 
            // ctrCredits
            // 
            this.ctrCredits.DecimalPlaces = 1;
            this.ctrCredits.Location = new System.Drawing.Point(162, 185);
            this.ctrCredits.Name = "ctrCredits";
            this.ctrCredits.Size = new System.Drawing.Size(84, 20);
            this.ctrCredits.TabIndex = 62;
            this.ctrCredits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblClassDays
            // 
            this.lblClassDays.AutoSize = true;
            this.lblClassDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassDays.Location = new System.Drawing.Point(95, 217);
            this.lblClassDays.Name = "lblClassDays";
            this.lblClassDays.Size = new System.Drawing.Size(61, 17);
            this.lblClassDays.TabIndex = 79;
            this.lblClassDays.Text = "Day(s):";
            // 
            // lblRequiredClass3
            // 
            this.lblRequiredClass3.AutoSize = true;
            this.lblRequiredClass3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredClass3.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredClass3.Location = new System.Drawing.Point(441, 217);
            this.lblRequiredClass3.Name = "lblRequiredClass3";
            this.lblRequiredClass3.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredClass3.TabIndex = 81;
            this.lblRequiredClass3.Text = "*";
            // 
            // chkClassMonday
            // 
            this.chkClassMonday.AutoSize = true;
            this.chkClassMonday.Location = new System.Drawing.Point(162, 220);
            this.chkClassMonday.Name = "chkClassMonday";
            this.chkClassMonday.Size = new System.Drawing.Size(64, 17);
            this.chkClassMonday.TabIndex = 63;
            this.chkClassMonday.Text = "Monday";
            this.chkClassMonday.UseVisualStyleBackColor = true;
            // 
            // cbFinalLetterGrade
            // 
            this.cbFinalLetterGrade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFinalLetterGrade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFinalLetterGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFinalLetterGrade.Enabled = false;
            this.cbFinalLetterGrade.FormattingEnabled = true;
            this.cbFinalLetterGrade.Location = new System.Drawing.Point(151, 419);
            this.cbFinalLetterGrade.Name = "cbFinalLetterGrade";
            this.cbFinalLetterGrade.Size = new System.Drawing.Size(84, 21);
            this.cbFinalLetterGrade.TabIndex = 77;
            // 
            // chkClassTuesday
            // 
            this.chkClassTuesday.AutoSize = true;
            this.chkClassTuesday.Location = new System.Drawing.Point(252, 218);
            this.chkClassTuesday.Name = "chkClassTuesday";
            this.chkClassTuesday.Size = new System.Drawing.Size(67, 17);
            this.chkClassTuesday.TabIndex = 64;
            this.chkClassTuesday.Text = "Tuesday";
            this.chkClassTuesday.UseVisualStyleBackColor = true;
            // 
            // chkClassFinished
            // 
            this.chkClassFinished.AutoSize = true;
            this.chkClassFinished.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClassFinished.Location = new System.Drawing.Point(252, 419);
            this.chkClassFinished.Name = "chkClassFinished";
            this.chkClassFinished.Size = new System.Drawing.Size(80, 21);
            this.chkClassFinished.TabIndex = 78;
            this.chkClassFinished.Text = "Finished";
            this.chkClassFinished.UseVisualStyleBackColor = true;
            this.chkClassFinished.CheckedChanged += new System.EventHandler(this.chkClassFinished_CheckedChanged_1);
            // 
            // chkClassWednesday
            // 
            this.chkClassWednesday.AutoSize = true;
            this.chkClassWednesday.Location = new System.Drawing.Point(352, 217);
            this.chkClassWednesday.Name = "chkClassWednesday";
            this.chkClassWednesday.Size = new System.Drawing.Size(83, 17);
            this.chkClassWednesday.TabIndex = 65;
            this.chkClassWednesday.Text = "Wednesday";
            this.chkClassWednesday.UseVisualStyleBackColor = true;
            // 
            // lblFinalGrade
            // 
            this.lblFinalGrade.AutoSize = true;
            this.lblFinalGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalGrade.Location = new System.Drawing.Point(47, 419);
            this.lblFinalGrade.Name = "lblFinalGrade";
            this.lblFinalGrade.Size = new System.Drawing.Size(98, 17);
            this.lblFinalGrade.TabIndex = 93;
            this.lblFinalGrade.Text = "Final Grade:";
            // 
            // chkClassThursday
            // 
            this.chkClassThursday.AutoSize = true;
            this.chkClassThursday.Location = new System.Drawing.Point(252, 250);
            this.chkClassThursday.Name = "chkClassThursday";
            this.chkClassThursday.Size = new System.Drawing.Size(70, 17);
            this.chkClassThursday.TabIndex = 66;
            this.chkClassThursday.Text = "Thursday";
            this.chkClassThursday.UseVisualStyleBackColor = true;
            // 
            // chkClassFriday
            // 
            this.chkClassFriday.AutoSize = true;
            this.chkClassFriday.Location = new System.Drawing.Point(352, 250);
            this.chkClassFriday.Name = "chkClassFriday";
            this.chkClassFriday.Size = new System.Drawing.Size(54, 17);
            this.chkClassFriday.TabIndex = 67;
            this.chkClassFriday.Text = "Friday";
            this.chkClassFriday.UseVisualStyleBackColor = true;
            // 
            // lblRequiredClass1
            // 
            this.lblRequiredClass1.AutoSize = true;
            this.lblRequiredClass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredClass1.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredClass1.Location = new System.Drawing.Point(367, 114);
            this.lblRequiredClass1.Name = "lblRequiredClass1";
            this.lblRequiredClass1.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredClass1.TabIndex = 83;
            this.lblRequiredClass1.Text = "*";
            // 
            // lnkEditGradingCategories
            // 
            this.lnkEditGradingCategories.AutoSize = true;
            this.lnkEditGradingCategories.Enabled = false;
            this.lnkEditGradingCategories.Location = new System.Drawing.Point(271, 390);
            this.lnkEditGradingCategories.Name = "lnkEditGradingCategories";
            this.lnkEditGradingCategories.Size = new System.Drawing.Size(118, 13);
            this.lnkEditGradingCategories.TabIndex = 76;
            this.lnkEditGradingCategories.TabStop = true;
            this.lnkEditGradingCategories.Text = "Edit Grading Categories";
            this.lnkEditGradingCategories.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditGradingCategories_LinkClicked);
            // 
            // lblRequiredClass2
            // 
            this.lblRequiredClass2.AutoSize = true;
            this.lblRequiredClass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredClass2.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredClass2.Location = new System.Drawing.Point(252, 188);
            this.lblRequiredClass2.Name = "lblRequiredClass2";
            this.lblRequiredClass2.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredClass2.TabIndex = 84;
            this.lblRequiredClass2.Text = "*";
            // 
            // lnkEditGradingScale
            // 
            this.lnkEditGradingScale.AutoSize = true;
            this.lnkEditGradingScale.Enabled = false;
            this.lnkEditGradingScale.Location = new System.Drawing.Point(110, 390);
            this.lnkEditGradingScale.Name = "lnkEditGradingScale";
            this.lnkEditGradingScale.Size = new System.Drawing.Size(95, 13);
            this.lnkEditGradingScale.TabIndex = 75;
            this.lnkEditGradingScale.TabStop = true;
            this.lnkEditGradingScale.Text = "Edit Grading Scale";
            this.lnkEditGradingScale.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditGradingScale_LinkClicked);
            // 
            // lblClassLocation
            // 
            this.lblClassLocation.AutoSize = true;
            this.lblClassLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassLocation.Location = new System.Drawing.Point(59, 355);
            this.lblClassLocation.Name = "lblClassLocation";
            this.lblClassLocation.Size = new System.Drawing.Size(75, 17);
            this.lblClassLocation.TabIndex = 90;
            this.lblClassLocation.Text = "Location:";
            // 
            // lblClassProfessor
            // 
            this.lblClassProfessor.AutoSize = true;
            this.lblClassProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassProfessor.Location = new System.Drawing.Point(73, 144);
            this.lblClassProfessor.Name = "lblClassProfessor";
            this.lblClassProfessor.Size = new System.Drawing.Size(83, 17);
            this.lblClassProfessor.TabIndex = 85;
            this.lblClassProfessor.Text = "Professor:";
            // 
            // txtClassLocation
            // 
            this.txtClassLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClassLocation.Location = new System.Drawing.Point(141, 352);
            this.txtClassLocation.Name = "txtClassLocation";
            this.txtClassLocation.Size = new System.Drawing.Size(171, 20);
            this.txtClassLocation.TabIndex = 74;
            // 
            // cbClassProfessor
            // 
            this.cbClassProfessor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbClassProfessor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbClassProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClassProfessor.FormattingEnabled = true;
            this.cbClassProfessor.Location = new System.Drawing.Point(162, 144);
            this.cbClassProfessor.Name = "cbClassProfessor";
            this.cbClassProfessor.Size = new System.Drawing.Size(199, 21);
            this.cbClassProfessor.TabIndex = 61;
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.AutoSize = true;
            this.btnDeleteClass.Enabled = false;
            this.btnDeleteClass.Location = new System.Drawing.Point(224, 493);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(86, 23);
            this.btnDeleteClass.TabIndex = 19;
            this.btnDeleteClass.Text = "Delete";
            this.btnDeleteClass.UseVisualStyleBackColor = true;
            this.btnDeleteClass.Click += new System.EventHandler(this.btnDeleteClass_Click);
            // 
            // btnCloseClose
            // 
            this.btnCloseClose.AutoSize = true;
            this.btnCloseClose.Location = new System.Drawing.Point(330, 493);
            this.btnCloseClose.Name = "btnCloseClose";
            this.btnCloseClose.Size = new System.Drawing.Size(80, 23);
            this.btnCloseClose.TabIndex = 20;
            this.btnCloseClose.Text = "Close";
            this.btnCloseClose.UseVisualStyleBackColor = true;
            this.btnCloseClose.Click += new System.EventHandler(this.btnCloseClose_Click);
            // 
            // btnSaveClass
            // 
            this.btnSaveClass.AutoSize = true;
            this.btnSaveClass.Enabled = false;
            this.btnSaveClass.Location = new System.Drawing.Point(113, 493);
            this.btnSaveClass.Name = "btnSaveClass";
            this.btnSaveClass.Size = new System.Drawing.Size(92, 23);
            this.btnSaveClass.TabIndex = 18;
            this.btnSaveClass.Text = "Save";
            this.btnSaveClass.UseVisualStyleBackColor = true;
            this.btnSaveClass.Click += new System.EventHandler(this.btnSaveClass_Click);
            // 
            // cbEditClass
            // 
            this.cbEditClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEditClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEditClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditClass.FormattingEnabled = true;
            this.cbEditClass.Location = new System.Drawing.Point(162, 86);
            this.cbEditClass.Name = "cbEditClass";
            this.cbEditClass.Size = new System.Drawing.Size(199, 21);
            this.cbEditClass.TabIndex = 0;
            this.cbEditClass.SelectedIndexChanged += new System.EventHandler(this.cbEditClass_SelectedIndexChanged);
            // 
            // lblClassText
            // 
            this.lblClassText.AutoSize = true;
            this.lblClassText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassText.Location = new System.Drawing.Point(22, 4);
            this.lblClassText.Name = "lblClassText";
            this.lblClassText.Size = new System.Drawing.Size(306, 17);
            this.lblClassText.TabIndex = 58;
            this.lblClassText.Text = "Select a class and edit the following information";
            this.lblClassText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEditClass
            // 
            this.lblEditClass.AutoSize = true;
            this.lblEditClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditClass.Location = new System.Drawing.Point(53, 86);
            this.lblEditClass.Name = "lblEditClass";
            this.lblEditClass.Size = new System.Drawing.Size(102, 17);
            this.lblEditClass.TabIndex = 45;
            this.lblEditClass.Text = "Select Class:";
            // 
            // cbEditClassProfessorFilter
            // 
            this.cbEditClassProfessorFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEditClassProfessorFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEditClassProfessorFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditClassProfessorFilter.FormattingEnabled = true;
            this.cbEditClassProfessorFilter.Location = new System.Drawing.Point(162, 58);
            this.cbEditClassProfessorFilter.Name = "cbEditClassProfessorFilter";
            this.cbEditClassProfessorFilter.Size = new System.Drawing.Size(199, 21);
            this.cbEditClassProfessorFilter.TabIndex = 0;
            this.cbEditClassProfessorFilter.SelectedIndexChanged += new System.EventHandler(this.cbEditClassFilter_SelectedIndexChanged);
            // 
            // lblEditClassProfessorFilter
            // 
            this.lblEditClassProfessorFilter.AutoSize = true;
            this.lblEditClassProfessorFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditClassProfessorFilter.Location = new System.Drawing.Point(11, 59);
            this.lblEditClassProfessorFilter.Margin = new System.Windows.Forms.Padding(0);
            this.lblEditClassProfessorFilter.Name = "lblEditClassProfessorFilter";
            this.lblEditClassProfessorFilter.Size = new System.Drawing.Size(148, 17);
            this.lblEditClassProfessorFilter.TabIndex = 43;
            this.lblEditClassProfessorFilter.Text = "Filter By Professor:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSaveStatus
            // 
            this.lblSaveStatus.AutoSize = true;
            this.lblSaveStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveStatus.Location = new System.Drawing.Point(159, 459);
            this.lblSaveStatus.Name = "lblSaveStatus";
            this.lblSaveStatus.Size = new System.Drawing.Size(0, 13);
            this.lblSaveStatus.TabIndex = 96;
            // 
            // cbSemester
            // 
            this.cbSemester.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSemester.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSemester.FormattingEnabled = true;
            this.cbSemester.Location = new System.Drawing.Point(140, 317);
            this.cbSemester.Name = "cbSemester";
            this.cbSemester.Size = new System.Drawing.Size(227, 21);
            this.cbSemester.TabIndex = 104;
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.Location = new System.Drawing.Point(53, 317);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(81, 17);
            this.lblSemester.TabIndex = 103;
            this.lblSemester.Text = "Semester:";
            // 
            // lblRequiredClass5
            // 
            this.lblRequiredClass5.AutoSize = true;
            this.lblRequiredClass5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredClass5.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredClass5.Location = new System.Drawing.Point(448, 283);
            this.lblRequiredClass5.Name = "lblRequiredClass5";
            this.lblRequiredClass5.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredClass5.TabIndex = 102;
            this.lblRequiredClass5.Text = "*";
            // 
            // lblClassStartTime
            // 
            this.lblClassStartTime.AutoSize = true;
            this.lblClassStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassStartTime.Location = new System.Drawing.Point(46, 280);
            this.lblClassStartTime.Name = "lblClassStartTime";
            this.lblClassStartTime.Size = new System.Drawing.Size(88, 17);
            this.lblClassStartTime.TabIndex = 99;
            this.lblClassStartTime.Text = "Start Time:";
            // 
            // dtClassStartTime
            // 
            this.dtClassStartTime.CustomFormat = "hh:mm tt";
            this.dtClassStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtClassStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtClassStartTime.Location = new System.Drawing.Point(140, 280);
            this.dtClassStartTime.Name = "dtClassStartTime";
            this.dtClassStartTime.ShowUpDown = true;
            this.dtClassStartTime.Size = new System.Drawing.Size(83, 23);
            this.dtClassStartTime.TabIndex = 97;
            this.dtClassStartTime.Value = new System.DateTime(2011, 4, 3, 11, 0, 0, 0);
            // 
            // lblClassEndTime
            // 
            this.lblClassEndTime.AutoSize = true;
            this.lblClassEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassEndTime.Location = new System.Drawing.Point(272, 283);
            this.lblClassEndTime.Name = "lblClassEndTime";
            this.lblClassEndTime.Size = new System.Drawing.Size(81, 17);
            this.lblClassEndTime.TabIndex = 100;
            this.lblClassEndTime.Text = "End Time:";
            // 
            // lblRequiredClass4
            // 
            this.lblRequiredClass4.AutoSize = true;
            this.lblRequiredClass4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredClass4.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredClass4.Location = new System.Drawing.Point(229, 282);
            this.lblRequiredClass4.Name = "lblRequiredClass4";
            this.lblRequiredClass4.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredClass4.TabIndex = 101;
            this.lblRequiredClass4.Text = "*";
            // 
            // dtClassEndTime
            // 
            this.dtClassEndTime.CustomFormat = "hh:mm tt";
            this.dtClassEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtClassEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtClassEndTime.Location = new System.Drawing.Point(359, 280);
            this.dtClassEndTime.Name = "dtClassEndTime";
            this.dtClassEndTime.ShowUpDown = true;
            this.dtClassEndTime.Size = new System.Drawing.Size(83, 23);
            this.dtClassEndTime.TabIndex = 98;
            this.dtClassEndTime.Value = new System.DateTime(2011, 4, 3, 12, 0, 0, 0);
            // 
            // lblEditClassSemesterFilter
            // 
            this.lblEditClassSemesterFilter.AutoSize = true;
            this.lblEditClassSemesterFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditClassSemesterFilter.Location = new System.Drawing.Point(12, 31);
            this.lblEditClassSemesterFilter.Margin = new System.Windows.Forms.Padding(0);
            this.lblEditClassSemesterFilter.Name = "lblEditClassSemesterFilter";
            this.lblEditClassSemesterFilter.Size = new System.Drawing.Size(146, 17);
            this.lblEditClassSemesterFilter.TabIndex = 106;
            this.lblEditClassSemesterFilter.Text = "Filter By Semester:";
            // 
            // cbEditClassSemesterFilter
            // 
            this.cbEditClassSemesterFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEditClassSemesterFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEditClassSemesterFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditClassSemesterFilter.FormattingEnabled = true;
            this.cbEditClassSemesterFilter.Location = new System.Drawing.Point(162, 30);
            this.cbEditClassSemesterFilter.Name = "cbEditClassSemesterFilter";
            this.cbEditClassSemesterFilter.Size = new System.Drawing.Size(199, 21);
            this.cbEditClassSemesterFilter.TabIndex = 105;
            this.cbEditClassSemesterFilter.SelectedIndexChanged += new System.EventHandler(this.cbEditClassSemesterFilter_SelectedIndexChanged);
            // 
            // EditClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 538);
            this.Controls.Add(this.lblEditClassSemesterFilter);
            this.Controls.Add(this.cbEditClassSemesterFilter);
            this.Controls.Add(this.cbSemester);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.lblRequiredClass5);
            this.Controls.Add(this.lblClassStartTime);
            this.Controls.Add(this.dtClassStartTime);
            this.Controls.Add(this.lblClassEndTime);
            this.Controls.Add(this.lblRequiredClass4);
            this.Controls.Add(this.dtClassEndTime);
            this.Controls.Add(this.lblSaveStatus);
            this.Controls.Add(this.lblRequiredClass7);
            this.Controls.Add(this.lblRequiredClass6);
            this.Controls.Add(this.lblClassText);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.lblEditClassProfessorFilter);
            this.Controls.Add(this.lblClassCredits);
            this.Controls.Add(this.cbEditClassProfessorFilter);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.lblEditClass);
            this.Controls.Add(this.ctrCredits);
            this.Controls.Add(this.cbEditClass);
            this.Controls.Add(this.lblClassDays);
            this.Controls.Add(this.btnSaveClass);
            this.Controls.Add(this.lblRequiredClass3);
            this.Controls.Add(this.btnCloseClose);
            this.Controls.Add(this.chkClassMonday);
            this.Controls.Add(this.btnDeleteClass);
            this.Controls.Add(this.cbFinalLetterGrade);
            this.Controls.Add(this.chkClassTuesday);
            this.Controls.Add(this.chkClassFinished);
            this.Controls.Add(this.chkClassWednesday);
            this.Controls.Add(this.lblFinalGrade);
            this.Controls.Add(this.chkClassThursday);
            this.Controls.Add(this.chkClassFriday);
            this.Controls.Add(this.cbClassProfessor);
            this.Controls.Add(this.lblRequiredClass1);
            this.Controls.Add(this.lnkEditGradingCategories);
            this.Controls.Add(this.txtClassLocation);
            this.Controls.Add(this.lblRequiredClass2);
            this.Controls.Add(this.lblClassProfessor);
            this.Controls.Add(this.lnkEditGradingScale);
            this.Controls.Add(this.lblClassLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditClassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Class";
            ((System.ComponentModel.ISupportInitialize)(this.ctrCredits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClassText;
        private System.Windows.Forms.ComboBox cbEditClass;
        private System.Windows.Forms.Label lblEditClass;
        private System.Windows.Forms.ComboBox cbEditClassProfessorFilter;
        private System.Windows.Forms.Label lblEditClassProfessorFilter;
        private System.Windows.Forms.Button btnDeleteClass;
        private System.Windows.Forms.Button btnCloseClose;
        private System.Windows.Forms.Button btnSaveClass;
        private System.Windows.Forms.Label lblRequiredClass7;
        private System.Windows.Forms.Label lblRequiredClass6;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblClassCredits;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.NumericUpDown ctrCredits;
        private System.Windows.Forms.Label lblClassDays;
        private System.Windows.Forms.Label lblRequiredClass3;
        private System.Windows.Forms.CheckBox chkClassMonday;
        private System.Windows.Forms.ComboBox cbFinalLetterGrade;
        private System.Windows.Forms.CheckBox chkClassTuesday;
        private System.Windows.Forms.CheckBox chkClassFinished;
        private System.Windows.Forms.CheckBox chkClassWednesday;
        private System.Windows.Forms.Label lblFinalGrade;
        private System.Windows.Forms.CheckBox chkClassThursday;
        private System.Windows.Forms.CheckBox chkClassFriday;
        private System.Windows.Forms.Label lblRequiredClass1;
        private System.Windows.Forms.LinkLabel lnkEditGradingCategories;
        private System.Windows.Forms.Label lblRequiredClass2;
        private System.Windows.Forms.LinkLabel lnkEditGradingScale;
        private System.Windows.Forms.Label lblClassLocation;
        private System.Windows.Forms.Label lblClassProfessor;
        private System.Windows.Forms.TextBox txtClassLocation;
        private System.Windows.Forms.ComboBox cbClassProfessor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSaveStatus;
        private System.Windows.Forms.ComboBox cbSemester;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label lblRequiredClass5;
        private System.Windows.Forms.Label lblClassStartTime;
        private System.Windows.Forms.DateTimePicker dtClassStartTime;
        private System.Windows.Forms.Label lblClassEndTime;
        private System.Windows.Forms.Label lblRequiredClass4;
        private System.Windows.Forms.DateTimePicker dtClassEndTime;
        private System.Windows.Forms.Label lblEditClassSemesterFilter;
        private System.Windows.Forms.ComboBox cbEditClassSemesterFilter;




    }
}