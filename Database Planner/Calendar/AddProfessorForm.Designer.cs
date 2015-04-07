namespace Planner
{
    partial class AddProfessorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProfessorForm));
            this.btnSaveProfessor = new System.Windows.Forms.Button();
            this.btnCloseProfessor = new System.Windows.Forms.Button();
            this.btnAddAnotherProfessor = new System.Windows.Forms.Button();
            this.lnkAddOfficeHours = new System.Windows.Forms.LinkLabel();
            this.lnkAddPhoneNum = new System.Windows.Forms.LinkLabel();
            this.lblProfessorTitle = new System.Windows.Forms.Label();
            this.lblProfessorText = new System.Windows.Forms.Label();
            this.lblRequiredProfessor = new System.Windows.Forms.Label();
            this.txtProfessorTitle = new System.Windows.Forms.TextBox();
            this.txtProfessorOfficeLoc = new System.Windows.Forms.TextBox();
            this.lblProfessorFName = new System.Windows.Forms.Label();
            this.lblProfessorOfficeLoc = new System.Windows.Forms.Label();
            this.txtProfessorFName = new System.Windows.Forms.TextBox();
            this.txtProfessorEmail = new System.Windows.Forms.TextBox();
            this.lblProfessorLName = new System.Windows.Forms.Label();
            this.lblProfessorEmail = new System.Windows.Forms.Label();
            this.txtProfessorLName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSaveProfessor
            // 
            this.btnSaveProfessor.AutoSize = true;
            this.btnSaveProfessor.Location = new System.Drawing.Point(199, 257);
            this.btnSaveProfessor.Name = "btnSaveProfessor";
            this.btnSaveProfessor.Size = new System.Drawing.Size(120, 23);
            this.btnSaveProfessor.TabIndex = 9;
            this.btnSaveProfessor.Text = "Save and Close";
            this.btnSaveProfessor.UseVisualStyleBackColor = true;
            this.btnSaveProfessor.Click += new System.EventHandler(this.btnSaveProfessor_Click);
            // 
            // btnCloseProfessor
            // 
            this.btnCloseProfessor.AutoSize = true;
            this.btnCloseProfessor.Location = new System.Drawing.Point(347, 257);
            this.btnCloseProfessor.Name = "btnCloseProfessor";
            this.btnCloseProfessor.Size = new System.Drawing.Size(90, 23);
            this.btnCloseProfessor.TabIndex = 10;
            this.btnCloseProfessor.Text = "Close";
            this.btnCloseProfessor.UseVisualStyleBackColor = true;
            this.btnCloseProfessor.Click += new System.EventHandler(this.btnCloseProfessor_Click);
            // 
            // btnAddAnotherProfessor
            // 
            this.btnAddAnotherProfessor.AutoSize = true;
            this.btnAddAnotherProfessor.Location = new System.Drawing.Point(15, 257);
            this.btnAddAnotherProfessor.Name = "btnAddAnotherProfessor";
            this.btnAddAnotherProfessor.Size = new System.Drawing.Size(155, 23);
            this.btnAddAnotherProfessor.TabIndex = 8;
            this.btnAddAnotherProfessor.Text = "Add Another Professor";
            this.btnAddAnotherProfessor.UseVisualStyleBackColor = true;
            this.btnAddAnotherProfessor.Click += new System.EventHandler(this.btnAddAnotherProfessor_Click);
            // 
            // lnkAddOfficeHours
            // 
            this.lnkAddOfficeHours.AutoSize = true;
            this.lnkAddOfficeHours.Location = new System.Drawing.Point(246, 212);
            this.lnkAddOfficeHours.Name = "lnkAddOfficeHours";
            this.lnkAddOfficeHours.Size = new System.Drawing.Size(88, 13);
            this.lnkAddOfficeHours.TabIndex = 7;
            this.lnkAddOfficeHours.TabStop = true;
            this.lnkAddOfficeHours.Text = "Add Office Hours";
            this.lnkAddOfficeHours.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddOfficeHours_LinkClicked);
            // 
            // lnkAddPhoneNum
            // 
            this.lnkAddPhoneNum.AutoSize = true;
            this.lnkAddPhoneNum.Location = new System.Drawing.Point(102, 212);
            this.lnkAddPhoneNum.Name = "lnkAddPhoneNum";
            this.lnkAddPhoneNum.Size = new System.Drawing.Size(109, 13);
            this.lnkAddPhoneNum.TabIndex = 6;
            this.lnkAddPhoneNum.TabStop = true;
            this.lnkAddPhoneNum.Text = "Add a Phone Number";
            this.lnkAddPhoneNum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddPhoneNum_LinkClicked);
            // 
            // lblProfessorTitle
            // 
            this.lblProfessorTitle.AutoSize = true;
            this.lblProfessorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessorTitle.Location = new System.Drawing.Point(102, 43);
            this.lblProfessorTitle.Name = "lblProfessorTitle";
            this.lblProfessorTitle.Size = new System.Drawing.Size(45, 17);
            this.lblProfessorTitle.TabIndex = 6;
            this.lblProfessorTitle.Text = "Title:";
            // 
            // lblProfessorText
            // 
            this.lblProfessorText.AutoSize = true;
            this.lblProfessorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessorText.Location = new System.Drawing.Point(12, 9);
            this.lblProfessorText.Name = "lblProfessorText";
            this.lblProfessorText.Size = new System.Drawing.Size(334, 17);
            this.lblProfessorText.TabIndex = 9;
            this.lblProfessorText.Text = "Enter the following information about your professor";
            this.lblProfessorText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRequiredProfessor
            // 
            this.lblRequiredProfessor.AutoSize = true;
            this.lblRequiredProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredProfessor.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredProfessor.Location = new System.Drawing.Point(319, 107);
            this.lblRequiredProfessor.Name = "lblRequiredProfessor";
            this.lblRequiredProfessor.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredProfessor.TabIndex = 16;
            this.lblRequiredProfessor.Text = "*";
            // 
            // txtProfessorTitle
            // 
            this.txtProfessorTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfessorTitle.Location = new System.Drawing.Point(153, 43);
            this.txtProfessorTitle.Name = "txtProfessorTitle";
            this.txtProfessorTitle.Size = new System.Drawing.Size(160, 20);
            this.txtProfessorTitle.TabIndex = 1;
            // 
            // txtProfessorOfficeLoc
            // 
            this.txtProfessorOfficeLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfessorOfficeLoc.Location = new System.Drawing.Point(153, 168);
            this.txtProfessorOfficeLoc.Name = "txtProfessorOfficeLoc";
            this.txtProfessorOfficeLoc.Size = new System.Drawing.Size(160, 20);
            this.txtProfessorOfficeLoc.TabIndex = 5;
            // 
            // lblProfessorFName
            // 
            this.lblProfessorFName.AutoSize = true;
            this.lblProfessorFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessorFName.Location = new System.Drawing.Point(57, 73);
            this.lblProfessorFName.Name = "lblProfessorFName";
            this.lblProfessorFName.Size = new System.Drawing.Size(91, 17);
            this.lblProfessorFName.TabIndex = 7;
            this.lblProfessorFName.Text = "First Name:";
            // 
            // lblProfessorOfficeLoc
            // 
            this.lblProfessorOfficeLoc.AutoSize = true;
            this.lblProfessorOfficeLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessorOfficeLoc.Location = new System.Drawing.Point(24, 168);
            this.lblProfessorOfficeLoc.Name = "lblProfessorOfficeLoc";
            this.lblProfessorOfficeLoc.Size = new System.Drawing.Size(123, 17);
            this.lblProfessorOfficeLoc.TabIndex = 14;
            this.lblProfessorOfficeLoc.Text = "Office Location:";
            // 
            // txtProfessorFName
            // 
            this.txtProfessorFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfessorFName.Location = new System.Drawing.Point(154, 73);
            this.txtProfessorFName.Name = "txtProfessorFName";
            this.txtProfessorFName.Size = new System.Drawing.Size(159, 20);
            this.txtProfessorFName.TabIndex = 2;
            // 
            // txtProfessorEmail
            // 
            this.txtProfessorEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfessorEmail.Location = new System.Drawing.Point(154, 136);
            this.txtProfessorEmail.Name = "txtProfessorEmail";
            this.txtProfessorEmail.Size = new System.Drawing.Size(159, 20);
            this.txtProfessorEmail.TabIndex = 4;
            // 
            // lblProfessorLName
            // 
            this.lblProfessorLName.AutoSize = true;
            this.lblProfessorLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessorLName.Location = new System.Drawing.Point(58, 107);
            this.lblProfessorLName.Name = "lblProfessorLName";
            this.lblProfessorLName.Size = new System.Drawing.Size(90, 17);
            this.lblProfessorLName.TabIndex = 10;
            this.lblProfessorLName.Text = "Last Name:";
            // 
            // lblProfessorEmail
            // 
            this.lblProfessorEmail.AutoSize = true;
            this.lblProfessorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessorEmail.Location = new System.Drawing.Point(95, 139);
            this.lblProfessorEmail.Name = "lblProfessorEmail";
            this.lblProfessorEmail.Size = new System.Drawing.Size(52, 17);
            this.lblProfessorEmail.TabIndex = 12;
            this.lblProfessorEmail.Text = "Email:";
            // 
            // txtProfessorLName
            // 
            this.txtProfessorLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProfessorLName.Location = new System.Drawing.Point(154, 104);
            this.txtProfessorLName.Name = "txtProfessorLName";
            this.txtProfessorLName.Size = new System.Drawing.Size(159, 20);
            this.txtProfessorLName.TabIndex = 3;
            // 
            // AddProfessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 294);
            this.Controls.Add(this.btnSaveProfessor);
            this.Controls.Add(this.btnCloseProfessor);
            this.Controls.Add(this.lblProfessorText);
            this.Controls.Add(this.btnAddAnotherProfessor);
            this.Controls.Add(this.txtProfessorLName);
            this.Controls.Add(this.lnkAddOfficeHours);
            this.Controls.Add(this.lblProfessorEmail);
            this.Controls.Add(this.lnkAddPhoneNum);
            this.Controls.Add(this.lblProfessorLName);
            this.Controls.Add(this.lblProfessorTitle);
            this.Controls.Add(this.txtProfessorEmail);
            this.Controls.Add(this.txtProfessorFName);
            this.Controls.Add(this.lblRequiredProfessor);
            this.Controls.Add(this.lblProfessorOfficeLoc);
            this.Controls.Add(this.txtProfessorTitle);
            this.Controls.Add(this.lblProfessorFName);
            this.Controls.Add(this.txtProfessorOfficeLoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProfessorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Professor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveProfessor;
        private System.Windows.Forms.Button btnCloseProfessor;
        private System.Windows.Forms.Button btnAddAnotherProfessor;
        private System.Windows.Forms.LinkLabel lnkAddOfficeHours;
        private System.Windows.Forms.LinkLabel lnkAddPhoneNum;
        private System.Windows.Forms.Label lblProfessorTitle;
        private System.Windows.Forms.Label lblProfessorText;
        private System.Windows.Forms.Label lblRequiredProfessor;
        private System.Windows.Forms.TextBox txtProfessorTitle;
        private System.Windows.Forms.TextBox txtProfessorOfficeLoc;
        private System.Windows.Forms.Label lblProfessorFName;
        private System.Windows.Forms.Label lblProfessorOfficeLoc;
        private System.Windows.Forms.TextBox txtProfessorFName;
        private System.Windows.Forms.TextBox txtProfessorEmail;
        private System.Windows.Forms.Label lblProfessorLName;
        private System.Windows.Forms.Label lblProfessorEmail;
        private System.Windows.Forms.TextBox txtProfessorLName;




    }
}