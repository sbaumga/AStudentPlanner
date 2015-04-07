namespace Planner
{
    partial class AddSemesterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSemesterForm));
            this.btnSaveSemester = new System.Windows.Forms.Button();
            this.btnCloseSemester = new System.Windows.Forms.Button();
            this.lblSemesterText = new System.Windows.Forms.Label();
            this.lnkAddSemester = new System.Windows.Forms.LinkLabel();
            this.lblRequiredSemester4 = new System.Windows.Forms.Label();
            this.dtSemesterEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblSemesterEndDate = new System.Windows.Forms.Label();
            this.dtSemesterStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblSemesterStartDate = new System.Windows.Forms.Label();
            this.lblRequiredSemester3 = new System.Windows.Forms.Label();
            this.lblSemesterNum = new System.Windows.Forms.Label();
            this.lblSemesterName = new System.Windows.Forms.Label();
            this.txtSemesterName = new System.Windows.Forms.TextBox();
            this.ctrSemester = new System.Windows.Forms.NumericUpDown();
            this.lblRequiredSemester2 = new System.Windows.Forms.Label();
            this.lblRequiredSemester1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ctrSemester)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveSemester
            // 
            this.btnSaveSemester.AutoSize = true;
            this.btnSaveSemester.Location = new System.Drawing.Point(15, 204);
            this.btnSaveSemester.Name = "btnSaveSemester";
            this.btnSaveSemester.Size = new System.Drawing.Size(138, 23);
            this.btnSaveSemester.TabIndex = 51;
            this.btnSaveSemester.Text = "Save And Close";
            this.btnSaveSemester.UseVisualStyleBackColor = true;
            this.btnSaveSemester.Click += new System.EventHandler(this.btnSaveSemester_Click);
            // 
            // btnCloseSemester
            // 
            this.btnCloseSemester.AutoSize = true;
            this.btnCloseSemester.Location = new System.Drawing.Point(176, 204);
            this.btnCloseSemester.Name = "btnCloseSemester";
            this.btnCloseSemester.Size = new System.Drawing.Size(149, 23);
            this.btnCloseSemester.TabIndex = 52;
            this.btnCloseSemester.Text = "Close Without Saving";
            this.btnCloseSemester.UseVisualStyleBackColor = true;
            this.btnCloseSemester.Click += new System.EventHandler(this.btnCloseSemester_Click);
            // 
            // lblSemesterText
            // 
            this.lblSemesterText.AutoSize = true;
            this.lblSemesterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemesterText.Location = new System.Drawing.Point(12, 9);
            this.lblSemesterText.Name = "lblSemesterText";
            this.lblSemesterText.Size = new System.Drawing.Size(202, 17);
            this.lblSemesterText.TabIndex = 9;
            this.lblSemesterText.Text = "Enter the semester information";
            this.lblSemesterText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lnkAddSemester
            // 
            this.lnkAddSemester.AutoSize = true;
            this.lnkAddSemester.Location = new System.Drawing.Point(104, 173);
            this.lnkAddSemester.Name = "lnkAddSemester";
            this.lnkAddSemester.Size = new System.Drawing.Size(113, 13);
            this.lnkAddSemester.TabIndex = 59;
            this.lnkAddSemester.TabStop = true;
            this.lnkAddSemester.Text = "Add Another Semester";
            this.lnkAddSemester.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddSemester_LinkClicked);
            // 
            // lblRequiredSemester4
            // 
            this.lblRequiredSemester4.AutoSize = true;
            this.lblRequiredSemester4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredSemester4.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredSemester4.Location = new System.Drawing.Point(241, 136);
            this.lblRequiredSemester4.Name = "lblRequiredSemester4";
            this.lblRequiredSemester4.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredSemester4.TabIndex = 65;
            this.lblRequiredSemester4.Text = "*";
            // 
            // dtSemesterEndDate
            // 
            this.dtSemesterEndDate.CustomFormat = "MM/dd/yy";
            this.dtSemesterEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSemesterEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSemesterEndDate.Location = new System.Drawing.Point(154, 132);
            this.dtSemesterEndDate.Name = "dtSemesterEndDate";
            this.dtSemesterEndDate.Size = new System.Drawing.Size(83, 23);
            this.dtSemesterEndDate.TabIndex = 61;
            this.dtSemesterEndDate.Value = new System.DateTime(2011, 4, 3, 12, 0, 0, 0);
            // 
            // lblSemesterEndDate
            // 
            this.lblSemesterEndDate.AutoSize = true;
            this.lblSemesterEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemesterEndDate.Location = new System.Drawing.Point(67, 132);
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
            this.dtSemesterStartDate.Location = new System.Drawing.Point(153, 100);
            this.dtSemesterStartDate.Name = "dtSemesterStartDate";
            this.dtSemesterStartDate.Size = new System.Drawing.Size(83, 23);
            this.dtSemesterStartDate.TabIndex = 60;
            this.dtSemesterStartDate.Value = new System.DateTime(2011, 4, 3, 11, 0, 0, 0);
            // 
            // lblSemesterStartDate
            // 
            this.lblSemesterStartDate.AutoSize = true;
            this.lblSemesterStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemesterStartDate.Location = new System.Drawing.Point(60, 100);
            this.lblSemesterStartDate.Name = "lblSemesterStartDate";
            this.lblSemesterStartDate.Size = new System.Drawing.Size(87, 17);
            this.lblSemesterStartDate.TabIndex = 63;
            this.lblSemesterStartDate.Text = "Start Date:";
            // 
            // lblRequiredSemester3
            // 
            this.lblRequiredSemester3.AutoSize = true;
            this.lblRequiredSemester3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredSemester3.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredSemester3.Location = new System.Drawing.Point(241, 104);
            this.lblRequiredSemester3.Name = "lblRequiredSemester3";
            this.lblRequiredSemester3.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredSemester3.TabIndex = 62;
            this.lblRequiredSemester3.Text = "*";
            // 
            // lblSemesterNum
            // 
            this.lblSemesterNum.AutoSize = true;
            this.lblSemesterNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemesterNum.Location = new System.Drawing.Point(52, 42);
            this.lblSemesterNum.Name = "lblSemesterNum";
            this.lblSemesterNum.Size = new System.Drawing.Size(95, 17);
            this.lblSemesterNum.TabIndex = 66;
            this.lblSemesterNum.Text = "Semester #:";
            // 
            // lblSemesterName
            // 
            this.lblSemesterName.AutoSize = true;
            this.lblSemesterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemesterName.Location = new System.Drawing.Point(20, 72);
            this.lblSemesterName.Name = "lblSemesterName";
            this.lblSemesterName.Size = new System.Drawing.Size(127, 17);
            this.lblSemesterName.TabIndex = 67;
            this.lblSemesterName.Text = "Semester Name:";
            // 
            // txtSemesterName
            // 
            this.txtSemesterName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSemesterName.Location = new System.Drawing.Point(152, 72);
            this.txtSemesterName.Name = "txtSemesterName";
            this.txtSemesterName.Size = new System.Drawing.Size(157, 20);
            this.txtSemesterName.TabIndex = 68;
            // 
            // ctrSemester
            // 
            this.ctrSemester.Location = new System.Drawing.Point(152, 42);
            this.ctrSemester.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ctrSemester.Name = "ctrSemester";
            this.ctrSemester.Size = new System.Drawing.Size(49, 20);
            this.ctrSemester.TabIndex = 69;
            this.ctrSemester.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ctrSemester.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblRequiredSemester2
            // 
            this.lblRequiredSemester2.AutoSize = true;
            this.lblRequiredSemester2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredSemester2.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredSemester2.Location = new System.Drawing.Point(315, 72);
            this.lblRequiredSemester2.Name = "lblRequiredSemester2";
            this.lblRequiredSemester2.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredSemester2.TabIndex = 70;
            this.lblRequiredSemester2.Text = "*";
            // 
            // lblRequiredSemester1
            // 
            this.lblRequiredSemester1.AutoSize = true;
            this.lblRequiredSemester1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredSemester1.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredSemester1.Location = new System.Drawing.Point(207, 42);
            this.lblRequiredSemester1.Name = "lblRequiredSemester1";
            this.lblRequiredSemester1.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredSemester1.TabIndex = 71;
            this.lblRequiredSemester1.Text = "*";
            // 
            // AddSemesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 247);
            this.Controls.Add(this.lblRequiredSemester1);
            this.Controls.Add(this.lblRequiredSemester2);
            this.Controls.Add(this.ctrSemester);
            this.Controls.Add(this.txtSemesterName);
            this.Controls.Add(this.lblSemesterName);
            this.Controls.Add(this.lblSemesterNum);
            this.Controls.Add(this.lblRequiredSemester4);
            this.Controls.Add(this.dtSemesterEndDate);
            this.Controls.Add(this.lblSemesterEndDate);
            this.Controls.Add(this.dtSemesterStartDate);
            this.Controls.Add(this.lblSemesterStartDate);
            this.Controls.Add(this.lblRequiredSemester3);
            this.Controls.Add(this.lnkAddSemester);
            this.Controls.Add(this.lblSemesterText);
            this.Controls.Add(this.btnCloseSemester);
            this.Controls.Add(this.btnSaveSemester);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSemesterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Semester";
            ((System.ComponentModel.ISupportInitialize)(this.ctrSemester)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveSemester;
        private System.Windows.Forms.Button btnCloseSemester;
        private System.Windows.Forms.Label lblSemesterText;
        private System.Windows.Forms.LinkLabel lnkAddSemester;
        private System.Windows.Forms.Label lblRequiredSemester4;
        private System.Windows.Forms.DateTimePicker dtSemesterEndDate;
        private System.Windows.Forms.Label lblSemesterEndDate;
        private System.Windows.Forms.DateTimePicker dtSemesterStartDate;
        private System.Windows.Forms.Label lblSemesterStartDate;
        private System.Windows.Forms.Label lblRequiredSemester3;
        private System.Windows.Forms.Label lblSemesterNum;
        private System.Windows.Forms.Label lblSemesterName;
        private System.Windows.Forms.TextBox txtSemesterName;
        private System.Windows.Forms.NumericUpDown ctrSemester;
        private System.Windows.Forms.Label lblRequiredSemester2;
        private System.Windows.Forms.Label lblRequiredSemester1;




    }
}