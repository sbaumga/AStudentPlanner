namespace Planner
{
    partial class AddClassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddClassForm));
            this.lblRequiredClass7 = new System.Windows.Forms.Label();
            this.lblRequiredClass6 = new System.Windows.Forms.Label();
            this.lblClassText = new System.Windows.Forms.Label();
            this.btnSaveClass = new System.Windows.Forms.Button();
            this.btnCloseClass = new System.Windows.Forms.Button();
            this.btnAddAnotherClass = new System.Windows.Forms.Button();
            this.cbFinalLetterGrade = new System.Windows.Forms.ComboBox();
            this.chkClassFinished = new System.Windows.Forms.CheckBox();
            this.lblFinalGrade = new System.Windows.Forms.Label();
            this.lnkAddGradingCategories = new System.Windows.Forms.LinkLabel();
            this.lnkAddGradingScale = new System.Windows.Forms.LinkLabel();
            this.lblClassLocation = new System.Windows.Forms.Label();
            this.txtClassLocation = new System.Windows.Forms.TextBox();
            this.lblRequiredClass5 = new System.Windows.Forms.Label();
            this.lblRequiredClass4 = new System.Windows.Forms.Label();
            this.dtClassEndTime = new System.Windows.Forms.DateTimePicker();
            this.lblClassEndTime = new System.Windows.Forms.Label();
            this.cbClassProfessor = new System.Windows.Forms.ComboBox();
            this.dtClassStartTime = new System.Windows.Forms.DateTimePicker();
            this.lblClassProfessor = new System.Windows.Forms.Label();
            this.lblClassStartTime = new System.Windows.Forms.Label();
            this.lblRequiredClass2 = new System.Windows.Forms.Label();
            this.lblRequiredClass1 = new System.Windows.Forms.Label();
            this.chkClassFriday = new System.Windows.Forms.CheckBox();
            this.chkClassThursday = new System.Windows.Forms.CheckBox();
            this.chkClassWednesday = new System.Windows.Forms.CheckBox();
            this.chkClassTuesday = new System.Windows.Forms.CheckBox();
            this.chkClassMonday = new System.Windows.Forms.CheckBox();
            this.lblRequiredClass3 = new System.Windows.Forms.Label();
            this.lblClassDays = new System.Windows.Forms.Label();
            this.ctrCredits = new System.Windows.Forms.NumericUpDown();
            this.lblClassName = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.lblClassCredits = new System.Windows.Forms.Label();
            this.lblSemester = new System.Windows.Forms.Label();
            this.cbSemester = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ctrCredits)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRequiredClass7
            // 
            this.lblRequiredClass7.AutoSize = true;
            this.lblRequiredClass7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredClass7.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredClass7.Location = new System.Drawing.Point(397, 384);
            this.lblRequiredClass7.Name = "lblRequiredClass7";
            this.lblRequiredClass7.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredClass7.TabIndex = 60;
            this.lblRequiredClass7.Text = "*";
            // 
            // lblRequiredClass6
            // 
            this.lblRequiredClass6.AutoSize = true;
            this.lblRequiredClass6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredClass6.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredClass6.Location = new System.Drawing.Point(170, 384);
            this.lblRequiredClass6.Name = "lblRequiredClass6";
            this.lblRequiredClass6.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredClass6.TabIndex = 59;
            this.lblRequiredClass6.Text = "*";
            // 
            // lblClassText
            // 
            this.lblClassText.AutoSize = true;
            this.lblClassText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassText.Location = new System.Drawing.Point(25, 12);
            this.lblClassText.Name = "lblClassText";
            this.lblClassText.Size = new System.Drawing.Size(306, 17);
            this.lblClassText.TabIndex = 58;
            this.lblClassText.Text = "Enter the following information about your class";
            this.lblClassText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSaveClass
            // 
            this.btnSaveClass.AutoSize = true;
            this.btnSaveClass.Location = new System.Drawing.Point(192, 449);
            this.btnSaveClass.Name = "btnSaveClass";
            this.btnSaveClass.Size = new System.Drawing.Size(126, 23);
            this.btnSaveClass.TabIndex = 19;
            this.btnSaveClass.Text = "Save and Close";
            this.btnSaveClass.UseVisualStyleBackColor = true;
            this.btnSaveClass.Click += new System.EventHandler(this.btnSaveClass_Click);
            // 
            // btnCloseClass
            // 
            this.btnCloseClass.AutoSize = true;
            this.btnCloseClass.Location = new System.Drawing.Point(334, 449);
            this.btnCloseClass.Name = "btnCloseClass";
            this.btnCloseClass.Size = new System.Drawing.Size(148, 23);
            this.btnCloseClass.TabIndex = 20;
            this.btnCloseClass.Text = "Close Without Saving";
            this.btnCloseClass.UseVisualStyleBackColor = true;
            this.btnCloseClass.Click += new System.EventHandler(this.btnCloseClass_Click);
            // 
            // btnAddAnotherClass
            // 
            this.btnAddAnotherClass.AutoSize = true;
            this.btnAddAnotherClass.Location = new System.Drawing.Point(20, 449);
            this.btnAddAnotherClass.Name = "btnAddAnotherClass";
            this.btnAddAnotherClass.Size = new System.Drawing.Size(152, 23);
            this.btnAddAnotherClass.TabIndex = 18;
            this.btnAddAnotherClass.Text = "Add Another Class";
            this.btnAddAnotherClass.UseVisualStyleBackColor = true;
            this.btnAddAnotherClass.Click += new System.EventHandler(this.btnAddAnotherClass_Click);
            // 
            // cbFinalLetterGrade
            // 
            this.cbFinalLetterGrade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbFinalLetterGrade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbFinalLetterGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFinalLetterGrade.Enabled = false;
            this.cbFinalLetterGrade.FormattingEnabled = true;
            this.cbFinalLetterGrade.Location = new System.Drawing.Point(118, 413);
            this.cbFinalLetterGrade.Name = "cbFinalLetterGrade";
            this.cbFinalLetterGrade.Size = new System.Drawing.Size(84, 21);
            this.cbFinalLetterGrade.TabIndex = 16;
            // 
            // chkClassFinished
            // 
            this.chkClassFinished.AutoSize = true;
            this.chkClassFinished.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClassFinished.Location = new System.Drawing.Point(219, 413);
            this.chkClassFinished.Name = "chkClassFinished";
            this.chkClassFinished.Size = new System.Drawing.Size(80, 21);
            this.chkClassFinished.TabIndex = 17;
            this.chkClassFinished.Text = "Finished";
            this.chkClassFinished.UseVisualStyleBackColor = true;
            this.chkClassFinished.CheckedChanged += new System.EventHandler(this.chkClassFinished_CheckedChanged);
            // 
            // lblFinalGrade
            // 
            this.lblFinalGrade.AutoSize = true;
            this.lblFinalGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalGrade.Location = new System.Drawing.Point(14, 413);
            this.lblFinalGrade.Name = "lblFinalGrade";
            this.lblFinalGrade.Size = new System.Drawing.Size(98, 17);
            this.lblFinalGrade.TabIndex = 52;
            this.lblFinalGrade.Text = "Final Grade:";
            // 
            // lnkAddGradingCategories
            // 
            this.lnkAddGradingCategories.AutoSize = true;
            this.lnkAddGradingCategories.Location = new System.Drawing.Point(272, 384);
            this.lnkAddGradingCategories.Name = "lnkAddGradingCategories";
            this.lnkAddGradingCategories.Size = new System.Drawing.Size(119, 13);
            this.lnkAddGradingCategories.TabIndex = 15;
            this.lnkAddGradingCategories.TabStop = true;
            this.lnkAddGradingCategories.Text = "Add Grading Categories";
            this.lnkAddGradingCategories.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddGradingCategories_LinkClicked);
            // 
            // lnkAddGradingScale
            // 
            this.lnkAddGradingScale.AutoSize = true;
            this.lnkAddGradingScale.Location = new System.Drawing.Point(63, 384);
            this.lnkAddGradingScale.Name = "lnkAddGradingScale";
            this.lnkAddGradingScale.Size = new System.Drawing.Size(96, 13);
            this.lnkAddGradingScale.TabIndex = 14;
            this.lnkAddGradingScale.TabStop = true;
            this.lnkAddGradingScale.Text = "Add Grading Scale";
            this.lnkAddGradingScale.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddGradingScale_LinkClicked);
            // 
            // lblClassLocation
            // 
            this.lblClassLocation.AutoSize = true;
            this.lblClassLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassLocation.Location = new System.Drawing.Point(37, 348);
            this.lblClassLocation.Name = "lblClassLocation";
            this.lblClassLocation.Size = new System.Drawing.Size(75, 17);
            this.lblClassLocation.TabIndex = 46;
            this.lblClassLocation.Text = "Location:";
            // 
            // txtClassLocation
            // 
            this.txtClassLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClassLocation.Location = new System.Drawing.Point(118, 346);
            this.txtClassLocation.Name = "txtClassLocation";
            this.txtClassLocation.Size = new System.Drawing.Size(171, 20);
            this.txtClassLocation.TabIndex = 13;
            // 
            // lblRequiredClass5
            // 
            this.lblRequiredClass5.AutoSize = true;
            this.lblRequiredClass5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredClass5.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredClass5.Location = new System.Drawing.Point(426, 278);
            this.lblRequiredClass5.Name = "lblRequiredClass5";
            this.lblRequiredClass5.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredClass5.TabIndex = 44;
            this.lblRequiredClass5.Text = "*";
            // 
            // lblRequiredClass4
            // 
            this.lblRequiredClass4.AutoSize = true;
            this.lblRequiredClass4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredClass4.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredClass4.Location = new System.Drawing.Point(207, 277);
            this.lblRequiredClass4.Name = "lblRequiredClass4";
            this.lblRequiredClass4.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredClass4.TabIndex = 39;
            this.lblRequiredClass4.Text = "*";
            // 
            // dtClassEndTime
            // 
            this.dtClassEndTime.CustomFormat = "hh:mm tt";
            this.dtClassEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtClassEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtClassEndTime.Location = new System.Drawing.Point(337, 275);
            this.dtClassEndTime.Name = "dtClassEndTime";
            this.dtClassEndTime.ShowUpDown = true;
            this.dtClassEndTime.Size = new System.Drawing.Size(83, 23);
            this.dtClassEndTime.TabIndex = 10;
            this.dtClassEndTime.Value = new System.DateTime(2011, 4, 3, 12, 0, 0, 0);
            // 
            // lblClassEndTime
            // 
            this.lblClassEndTime.AutoSize = true;
            this.lblClassEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassEndTime.Location = new System.Drawing.Point(250, 278);
            this.lblClassEndTime.Name = "lblClassEndTime";
            this.lblClassEndTime.Size = new System.Drawing.Size(81, 17);
            this.lblClassEndTime.TabIndex = 29;
            this.lblClassEndTime.Text = "End Time:";
            // 
            // cbClassProfessor
            // 
            this.cbClassProfessor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbClassProfessor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbClassProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClassProfessor.FormattingEnabled = true;
            this.cbClassProfessor.Location = new System.Drawing.Point(118, 76);
            this.cbClassProfessor.Name = "cbClassProfessor";
            this.cbClassProfessor.Size = new System.Drawing.Size(227, 21);
            this.cbClassProfessor.TabIndex = 2;
            // 
            // dtClassStartTime
            // 
            this.dtClassStartTime.CustomFormat = "hh:mm tt";
            this.dtClassStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtClassStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtClassStartTime.Location = new System.Drawing.Point(118, 275);
            this.dtClassStartTime.Name = "dtClassStartTime";
            this.dtClassStartTime.ShowUpDown = true;
            this.dtClassStartTime.Size = new System.Drawing.Size(83, 23);
            this.dtClassStartTime.TabIndex = 9;
            this.dtClassStartTime.Value = new System.DateTime(2011, 4, 3, 11, 0, 0, 0);
            this.dtClassStartTime.ValueChanged += new System.EventHandler(this.dtClassStartTime_ValueChanged);
            // 
            // lblClassProfessor
            // 
            this.lblClassProfessor.AutoSize = true;
            this.lblClassProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassProfessor.Location = new System.Drawing.Point(29, 76);
            this.lblClassProfessor.Name = "lblClassProfessor";
            this.lblClassProfessor.Size = new System.Drawing.Size(83, 17);
            this.lblClassProfessor.TabIndex = 37;
            this.lblClassProfessor.Text = "Professor:";
            // 
            // lblClassStartTime
            // 
            this.lblClassStartTime.AutoSize = true;
            this.lblClassStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassStartTime.Location = new System.Drawing.Point(24, 275);
            this.lblClassStartTime.Name = "lblClassStartTime";
            this.lblClassStartTime.Size = new System.Drawing.Size(88, 17);
            this.lblClassStartTime.TabIndex = 27;
            this.lblClassStartTime.Text = "Start Time:";
            // 
            // lblRequiredClass2
            // 
            this.lblRequiredClass2.AutoSize = true;
            this.lblRequiredClass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredClass2.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredClass2.Location = new System.Drawing.Point(215, 120);
            this.lblRequiredClass2.Name = "lblRequiredClass2";
            this.lblRequiredClass2.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredClass2.TabIndex = 35;
            this.lblRequiredClass2.Text = "*";
            // 
            // lblRequiredClass1
            // 
            this.lblRequiredClass1.AutoSize = true;
            this.lblRequiredClass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredClass1.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredClass1.Location = new System.Drawing.Point(354, 46);
            this.lblRequiredClass1.Name = "lblRequiredClass1";
            this.lblRequiredClass1.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredClass1.TabIndex = 34;
            this.lblRequiredClass1.Text = "*";
            // 
            // chkClassFriday
            // 
            this.chkClassFriday.AutoSize = true;
            this.chkClassFriday.Location = new System.Drawing.Point(118, 244);
            this.chkClassFriday.Name = "chkClassFriday";
            this.chkClassFriday.Size = new System.Drawing.Size(54, 17);
            this.chkClassFriday.TabIndex = 8;
            this.chkClassFriday.Text = "Friday";
            this.chkClassFriday.UseVisualStyleBackColor = true;
            // 
            // chkClassThursday
            // 
            this.chkClassThursday.AutoSize = true;
            this.chkClassThursday.Location = new System.Drawing.Point(118, 221);
            this.chkClassThursday.Name = "chkClassThursday";
            this.chkClassThursday.Size = new System.Drawing.Size(70, 17);
            this.chkClassThursday.TabIndex = 7;
            this.chkClassThursday.Text = "Thursday";
            this.chkClassThursday.UseVisualStyleBackColor = true;
            // 
            // chkClassWednesday
            // 
            this.chkClassWednesday.AutoSize = true;
            this.chkClassWednesday.Location = new System.Drawing.Point(118, 198);
            this.chkClassWednesday.Name = "chkClassWednesday";
            this.chkClassWednesday.Size = new System.Drawing.Size(83, 17);
            this.chkClassWednesday.TabIndex = 6;
            this.chkClassWednesday.Text = "Wednesday";
            this.chkClassWednesday.UseVisualStyleBackColor = true;
            // 
            // chkClassTuesday
            // 
            this.chkClassTuesday.AutoSize = true;
            this.chkClassTuesday.Location = new System.Drawing.Point(118, 175);
            this.chkClassTuesday.Name = "chkClassTuesday";
            this.chkClassTuesday.Size = new System.Drawing.Size(67, 17);
            this.chkClassTuesday.TabIndex = 5;
            this.chkClassTuesday.Text = "Tuesday";
            this.chkClassTuesday.UseVisualStyleBackColor = true;
            // 
            // chkClassMonday
            // 
            this.chkClassMonday.AutoSize = true;
            this.chkClassMonday.Location = new System.Drawing.Point(118, 152);
            this.chkClassMonday.Name = "chkClassMonday";
            this.chkClassMonday.Size = new System.Drawing.Size(64, 17);
            this.chkClassMonday.TabIndex = 4;
            this.chkClassMonday.Text = "Monday";
            this.chkClassMonday.UseVisualStyleBackColor = true;
            // 
            // lblRequiredClass3
            // 
            this.lblRequiredClass3.AutoSize = true;
            this.lblRequiredClass3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredClass3.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredClass3.Location = new System.Drawing.Point(188, 152);
            this.lblRequiredClass3.Name = "lblRequiredClass3";
            this.lblRequiredClass3.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredClass3.TabIndex = 28;
            this.lblRequiredClass3.Text = "*";
            // 
            // lblClassDays
            // 
            this.lblClassDays.AutoSize = true;
            this.lblClassDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassDays.Location = new System.Drawing.Point(51, 149);
            this.lblClassDays.Name = "lblClassDays";
            this.lblClassDays.Size = new System.Drawing.Size(61, 17);
            this.lblClassDays.TabIndex = 27;
            this.lblClassDays.Text = "Day(s):";
            // 
            // ctrCredits
            // 
            this.ctrCredits.DecimalPlaces = 1;
            this.ctrCredits.Location = new System.Drawing.Point(118, 117);
            this.ctrCredits.Name = "ctrCredits";
            this.ctrCredits.Size = new System.Drawing.Size(84, 20);
            this.ctrCredits.TabIndex = 3;
            this.ctrCredits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.Location = new System.Drawing.Point(14, 46);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(98, 17);
            this.lblClassName.TabIndex = 10;
            this.lblClassName.Text = "Class Name:";
            // 
            // txtClassName
            // 
            this.txtClassName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClassName.Location = new System.Drawing.Point(118, 46);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(227, 20);
            this.txtClassName.TabIndex = 1;
            // 
            // lblClassCredits
            // 
            this.lblClassCredits.AutoSize = true;
            this.lblClassCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassCredits.Location = new System.Drawing.Point(48, 120);
            this.lblClassCredits.Name = "lblClassCredits";
            this.lblClassCredits.Size = new System.Drawing.Size(64, 17);
            this.lblClassCredits.TabIndex = 11;
            this.lblClassCredits.Text = "Credits:";
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.Location = new System.Drawing.Point(31, 312);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(81, 17);
            this.lblSemester.TabIndex = 61;
            this.lblSemester.Text = "Semester:";
            // 
            // cbSemester
            // 
            this.cbSemester.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSemester.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSemester.FormattingEnabled = true;
            this.cbSemester.Location = new System.Drawing.Point(118, 312);
            this.cbSemester.Name = "cbSemester";
            this.cbSemester.Size = new System.Drawing.Size(227, 21);
            this.cbSemester.TabIndex = 62;
            // 
            // AddClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 491);
            this.Controls.Add(this.cbSemester);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.lblRequiredClass7);
            this.Controls.Add(this.lblRequiredClass6);
            this.Controls.Add(this.lblClassText);
            this.Controls.Add(this.lblClassCredits);
            this.Controls.Add(this.btnSaveClass);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.btnCloseClass);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.btnAddAnotherClass);
            this.Controls.Add(this.ctrCredits);
            this.Controls.Add(this.cbFinalLetterGrade);
            this.Controls.Add(this.lblClassDays);
            this.Controls.Add(this.chkClassFinished);
            this.Controls.Add(this.lblRequiredClass3);
            this.Controls.Add(this.lblFinalGrade);
            this.Controls.Add(this.chkClassMonday);
            this.Controls.Add(this.chkClassTuesday);
            this.Controls.Add(this.chkClassWednesday);
            this.Controls.Add(this.lnkAddGradingCategories);
            this.Controls.Add(this.chkClassThursday);
            this.Controls.Add(this.lnkAddGradingScale);
            this.Controls.Add(this.chkClassFriday);
            this.Controls.Add(this.lblClassLocation);
            this.Controls.Add(this.lblRequiredClass1);
            this.Controls.Add(this.txtClassLocation);
            this.Controls.Add(this.lblRequiredClass2);
            this.Controls.Add(this.lblRequiredClass5);
            this.Controls.Add(this.lblClassStartTime);
            this.Controls.Add(this.lblClassProfessor);
            this.Controls.Add(this.dtClassStartTime);
            this.Controls.Add(this.cbClassProfessor);
            this.Controls.Add(this.lblClassEndTime);
            this.Controls.Add(this.lblRequiredClass4);
            this.Controls.Add(this.dtClassEndTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddClassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Class";
            ((System.ComponentModel.ISupportInitialize)(this.ctrCredits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkClassFinished;
        private System.Windows.Forms.Label lblFinalGrade;
        private System.Windows.Forms.LinkLabel lnkAddGradingCategories;
        private System.Windows.Forms.LinkLabel lnkAddGradingScale;
        private System.Windows.Forms.Label lblClassLocation;
        private System.Windows.Forms.TextBox txtClassLocation;
        private System.Windows.Forms.Label lblRequiredClass5;
        private System.Windows.Forms.Label lblRequiredClass4;
        private System.Windows.Forms.DateTimePicker dtClassEndTime;
        private System.Windows.Forms.Label lblClassEndTime;
        private System.Windows.Forms.ComboBox cbClassProfessor;
        private System.Windows.Forms.DateTimePicker dtClassStartTime;
        private System.Windows.Forms.Label lblClassProfessor;
        private System.Windows.Forms.Label lblClassStartTime;
        private System.Windows.Forms.Label lblRequiredClass2;
        private System.Windows.Forms.Label lblRequiredClass1;
        private System.Windows.Forms.CheckBox chkClassFriday;
        private System.Windows.Forms.CheckBox chkClassThursday;
        private System.Windows.Forms.CheckBox chkClassWednesday;
        private System.Windows.Forms.CheckBox chkClassTuesday;
        private System.Windows.Forms.CheckBox chkClassMonday;
        private System.Windows.Forms.Label lblRequiredClass3;
        private System.Windows.Forms.Label lblClassDays;
        private System.Windows.Forms.NumericUpDown ctrCredits;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label lblClassCredits;
        private System.Windows.Forms.ComboBox cbFinalLetterGrade;
        private System.Windows.Forms.Button btnSaveClass;
        private System.Windows.Forms.Button btnCloseClass;
        private System.Windows.Forms.Button btnAddAnotherClass;
        private System.Windows.Forms.Label lblClassText;
        private System.Windows.Forms.Label lblRequiredClass7;
        private System.Windows.Forms.Label lblRequiredClass6;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.ComboBox cbSemester;




    }
}