namespace Planner
{
    partial class EditSemesterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditSemesterForm));
            this.btnSaveSemester = new System.Windows.Forms.Button();
            this.btnCloseSemester = new System.Windows.Forms.Button();
            this.lblSemesterText = new System.Windows.Forms.Label();
            this.lblRequiredSemester2 = new System.Windows.Forms.Label();
            this.dtSemesterEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblSemesterEndDate = new System.Windows.Forms.Label();
            this.dtSemesterStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblSemesterStartDate = new System.Windows.Forms.Label();
            this.lblRequiredSemester1 = new System.Windows.Forms.Label();
            this.lblSemesterNum = new System.Windows.Forms.Label();
            this.lblSemesterName = new System.Windows.Forms.Label();
            this.txtSemesterName = new System.Windows.Forms.TextBox();
            this.ctrSemesterNum = new System.Windows.Forms.NumericUpDown();
            this.btnDeleteSemester = new System.Windows.Forms.Button();
            this.lblSaveStatus = new System.Windows.Forms.Label();
            this.lblSelectSemester = new System.Windows.Forms.Label();
            this.cbEditSemester = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblRequiredSemester3 = new System.Windows.Forms.Label();
            this.lblRequiredSemester4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ctrSemesterNum)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveSemester
            // 
            this.btnSaveSemester.AutoSize = true;
            this.btnSaveSemester.Location = new System.Drawing.Point(35, 238);
            this.btnSaveSemester.Name = "btnSaveSemester";
            this.btnSaveSemester.Size = new System.Drawing.Size(85, 23);
            this.btnSaveSemester.TabIndex = 51;
            this.btnSaveSemester.Text = "Save";
            this.btnSaveSemester.UseVisualStyleBackColor = true;
            this.btnSaveSemester.Click += new System.EventHandler(this.btnSaveSemester_Click);
            // 
            // btnCloseSemester
            // 
            this.btnCloseSemester.AutoSize = true;
            this.btnCloseSemester.Location = new System.Drawing.Point(280, 238);
            this.btnCloseSemester.Name = "btnCloseSemester";
            this.btnCloseSemester.Size = new System.Drawing.Size(93, 23);
            this.btnCloseSemester.TabIndex = 52;
            this.btnCloseSemester.Text = "Close";
            this.btnCloseSemester.UseVisualStyleBackColor = true;
            this.btnCloseSemester.Click += new System.EventHandler(this.btnCloseSemester_Click);
            // 
            // lblSemesterText
            // 
            this.lblSemesterText.AutoSize = true;
            this.lblSemesterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemesterText.Location = new System.Drawing.Point(12, 9);
            this.lblSemesterText.Name = "lblSemesterText";
            this.lblSemesterText.Size = new System.Drawing.Size(332, 17);
            this.lblSemesterText.TabIndex = 9;
            this.lblSemesterText.Text = "Select a semester and edit the following information";
            this.lblSemesterText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRequiredSemester2
            // 
            this.lblRequiredSemester2.AutoSize = true;
            this.lblRequiredSemester2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredSemester2.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredSemester2.Location = new System.Drawing.Point(319, 112);
            this.lblRequiredSemester2.Name = "lblRequiredSemester2";
            this.lblRequiredSemester2.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredSemester2.TabIndex = 65;
            this.lblRequiredSemester2.Text = "*";
            // 
            // dtSemesterEndDate
            // 
            this.dtSemesterEndDate.CustomFormat = "MM/dd/yy";
            this.dtSemesterEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSemesterEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSemesterEndDate.Location = new System.Drawing.Point(158, 172);
            this.dtSemesterEndDate.Name = "dtSemesterEndDate";
            this.dtSemesterEndDate.Size = new System.Drawing.Size(83, 23);
            this.dtSemesterEndDate.TabIndex = 61;
            this.dtSemesterEndDate.Value = new System.DateTime(2011, 4, 3, 12, 0, 0, 0);
            // 
            // lblSemesterEndDate
            // 
            this.lblSemesterEndDate.AutoSize = true;
            this.lblSemesterEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemesterEndDate.Location = new System.Drawing.Point(71, 172);
            this.lblSemesterEndDate.Name = "lblSemesterEndDate";
            this.lblSemesterEndDate.Size = new System.Drawing.Size(80, 17);
            this.lblSemesterEndDate.TabIndex = 64;
            this.lblSemesterEndDate.Text = "End Date:";
            // 
            // dtSemesterStartDate
            // 
            this.dtSemesterStartDate.CustomFormat = "MM/dd/yy";
            this.dtSemesterStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSemesterStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSemesterStartDate.Location = new System.Drawing.Point(157, 140);
            this.dtSemesterStartDate.Name = "dtSemesterStartDate";
            this.dtSemesterStartDate.Size = new System.Drawing.Size(83, 23);
            this.dtSemesterStartDate.TabIndex = 60;
            this.dtSemesterStartDate.Value = new System.DateTime(2011, 4, 3, 11, 0, 0, 0);
            // 
            // lblSemesterStartDate
            // 
            this.lblSemesterStartDate.AutoSize = true;
            this.lblSemesterStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemesterStartDate.Location = new System.Drawing.Point(64, 140);
            this.lblSemesterStartDate.Name = "lblSemesterStartDate";
            this.lblSemesterStartDate.Size = new System.Drawing.Size(87, 17);
            this.lblSemesterStartDate.TabIndex = 63;
            this.lblSemesterStartDate.Text = "Start Date:";
            // 
            // lblRequiredSemester1
            // 
            this.lblRequiredSemester1.AutoSize = true;
            this.lblRequiredSemester1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredSemester1.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredSemester1.Location = new System.Drawing.Point(211, 82);
            this.lblRequiredSemester1.Name = "lblRequiredSemester1";
            this.lblRequiredSemester1.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredSemester1.TabIndex = 62;
            this.lblRequiredSemester1.Text = "*";
            // 
            // lblSemesterNum
            // 
            this.lblSemesterNum.AutoSize = true;
            this.lblSemesterNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemesterNum.Location = new System.Drawing.Point(56, 82);
            this.lblSemesterNum.Name = "lblSemesterNum";
            this.lblSemesterNum.Size = new System.Drawing.Size(95, 17);
            this.lblSemesterNum.TabIndex = 66;
            this.lblSemesterNum.Text = "Semester #:";
            // 
            // lblSemesterName
            // 
            this.lblSemesterName.AutoSize = true;
            this.lblSemesterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemesterName.Location = new System.Drawing.Point(24, 112);
            this.lblSemesterName.Name = "lblSemesterName";
            this.lblSemesterName.Size = new System.Drawing.Size(127, 17);
            this.lblSemesterName.TabIndex = 67;
            this.lblSemesterName.Text = "Semester Name:";
            // 
            // txtSemesterName
            // 
            this.txtSemesterName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSemesterName.Location = new System.Drawing.Point(156, 112);
            this.txtSemesterName.Name = "txtSemesterName";
            this.txtSemesterName.Size = new System.Drawing.Size(157, 20);
            this.txtSemesterName.TabIndex = 68;
            // 
            // ctrSemesterNum
            // 
            this.ctrSemesterNum.Location = new System.Drawing.Point(156, 82);
            this.ctrSemesterNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ctrSemesterNum.Name = "ctrSemesterNum";
            this.ctrSemesterNum.Size = new System.Drawing.Size(49, 20);
            this.ctrSemesterNum.TabIndex = 69;
            this.ctrSemesterNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ctrSemesterNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnDeleteSemester
            // 
            this.btnDeleteSemester.AutoSize = true;
            this.btnDeleteSemester.Location = new System.Drawing.Point(152, 238);
            this.btnDeleteSemester.Name = "btnDeleteSemester";
            this.btnDeleteSemester.Size = new System.Drawing.Size(93, 23);
            this.btnDeleteSemester.TabIndex = 70;
            this.btnDeleteSemester.Text = "Delete";
            this.btnDeleteSemester.UseVisualStyleBackColor = true;
            this.btnDeleteSemester.Click += new System.EventHandler(this.btnDeleteSemester_Click);
            // 
            // lblSaveStatus
            // 
            this.lblSaveStatus.AutoSize = true;
            this.lblSaveStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveStatus.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblSaveStatus.Location = new System.Drawing.Point(89, 211);
            this.lblSaveStatus.Name = "lblSaveStatus";
            this.lblSaveStatus.Size = new System.Drawing.Size(7, 13);
            this.lblSaveStatus.TabIndex = 71;
            this.lblSaveStatus.Text = "\r\n";
            // 
            // lblSelectSemester
            // 
            this.lblSelectSemester.AutoSize = true;
            this.lblSelectSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectSemester.Location = new System.Drawing.Point(20, 45);
            this.lblSelectSemester.Name = "lblSelectSemester";
            this.lblSelectSemester.Size = new System.Drawing.Size(131, 17);
            this.lblSelectSemester.TabIndex = 72;
            this.lblSelectSemester.Text = "Select Semester:";
            // 
            // cbEditSemester
            // 
            this.cbEditSemester.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEditSemester.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEditSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEditSemester.FormattingEnabled = true;
            this.cbEditSemester.Location = new System.Drawing.Point(158, 44);
            this.cbEditSemester.Name = "cbEditSemester";
            this.cbEditSemester.Size = new System.Drawing.Size(215, 21);
            this.cbEditSemester.TabIndex = 73;
            this.cbEditSemester.SelectedIndexChanged += new System.EventHandler(this.cbEditSemester_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblRequiredSemester3
            // 
            this.lblRequiredSemester3.AutoSize = true;
            this.lblRequiredSemester3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredSemester3.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredSemester3.Location = new System.Drawing.Point(245, 143);
            this.lblRequiredSemester3.Name = "lblRequiredSemester3";
            this.lblRequiredSemester3.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredSemester3.TabIndex = 74;
            this.lblRequiredSemester3.Text = "*";
            // 
            // lblRequiredSemester4
            // 
            this.lblRequiredSemester4.AutoSize = true;
            this.lblRequiredSemester4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredSemester4.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredSemester4.Location = new System.Drawing.Point(245, 175);
            this.lblRequiredSemester4.Name = "lblRequiredSemester4";
            this.lblRequiredSemester4.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredSemester4.TabIndex = 75;
            this.lblRequiredSemester4.Text = "*";
            // 
            // EditSemesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 283);
            this.Controls.Add(this.lblRequiredSemester4);
            this.Controls.Add(this.lblRequiredSemester3);
            this.Controls.Add(this.cbEditSemester);
            this.Controls.Add(this.lblSelectSemester);
            this.Controls.Add(this.lblSaveStatus);
            this.Controls.Add(this.btnDeleteSemester);
            this.Controls.Add(this.ctrSemesterNum);
            this.Controls.Add(this.txtSemesterName);
            this.Controls.Add(this.lblSemesterName);
            this.Controls.Add(this.lblSemesterNum);
            this.Controls.Add(this.lblRequiredSemester2);
            this.Controls.Add(this.dtSemesterEndDate);
            this.Controls.Add(this.lblSemesterEndDate);
            this.Controls.Add(this.dtSemesterStartDate);
            this.Controls.Add(this.lblSemesterStartDate);
            this.Controls.Add(this.lblRequiredSemester1);
            this.Controls.Add(this.lblSemesterText);
            this.Controls.Add(this.btnCloseSemester);
            this.Controls.Add(this.btnSaveSemester);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditSemesterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Semester";
            ((System.ComponentModel.ISupportInitialize)(this.ctrSemesterNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveSemester;
        private System.Windows.Forms.Button btnCloseSemester;
        private System.Windows.Forms.Label lblSemesterText;
        private System.Windows.Forms.Label lblRequiredSemester2;
        private System.Windows.Forms.DateTimePicker dtSemesterEndDate;
        private System.Windows.Forms.Label lblSemesterEndDate;
        private System.Windows.Forms.DateTimePicker dtSemesterStartDate;
        private System.Windows.Forms.Label lblSemesterStartDate;
        private System.Windows.Forms.Label lblRequiredSemester1;
        private System.Windows.Forms.Label lblSemesterNum;
        private System.Windows.Forms.Label lblSemesterName;
        private System.Windows.Forms.TextBox txtSemesterName;
        private System.Windows.Forms.NumericUpDown ctrSemesterNum;
        private System.Windows.Forms.Button btnDeleteSemester;
        private System.Windows.Forms.Label lblSaveStatus;
        private System.Windows.Forms.Label lblSelectSemester;
        private System.Windows.Forms.ComboBox cbEditSemester;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblRequiredSemester3;
        private System.Windows.Forms.Label lblRequiredSemester4;




    }
}