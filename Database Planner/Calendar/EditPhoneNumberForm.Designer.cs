namespace Planner
{
    partial class EditPhoneNumberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPhoneNumberForm));
            this.lnkAddAnotherPhoneNumber = new System.Windows.Forms.LinkLabel();
            this.btnDeletePhoneNum = new System.Windows.Forms.Button();
            this.lnkPreviousPhone = new System.Windows.Forms.LinkLabel();
            this.lnkNextPhone = new System.Windows.Forms.LinkLabel();
            this.lblPhoneNumText = new System.Windows.Forms.Label();
            this.btnClosePhoneNum = new System.Windows.Forms.Button();
            this.btnSavePhoneNum = new System.Windows.Forms.Button();
            this.lblRequiredPhone = new System.Windows.Forms.Label();
            this.cbPhoneType = new System.Windows.Forms.ComboBox();
            this.lblPhoneType = new System.Windows.Forms.Label();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.lblSaveStatus = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lnkAddAnotherPhoneNumber
            // 
            this.lnkAddAnotherPhoneNumber.AutoSize = true;
            this.lnkAddAnotherPhoneNumber.Location = new System.Drawing.Point(149, 110);
            this.lnkAddAnotherPhoneNumber.Name = "lnkAddAnotherPhoneNumber";
            this.lnkAddAnotherPhoneNumber.Size = new System.Drawing.Size(140, 13);
            this.lnkAddAnotherPhoneNumber.TabIndex = 4;
            this.lnkAddAnotherPhoneNumber.TabStop = true;
            this.lnkAddAnotherPhoneNumber.Text = "Add Another Phone Number";
            this.lnkAddAnotherPhoneNumber.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddAnotherPhoneNumber_LinkClicked);
            // 
            // btnDeletePhoneNum
            // 
            this.btnDeletePhoneNum.AutoSize = true;
            this.btnDeletePhoneNum.Location = new System.Drawing.Point(168, 173);
            this.btnDeletePhoneNum.Name = "btnDeletePhoneNum";
            this.btnDeletePhoneNum.Size = new System.Drawing.Size(86, 23);
            this.btnDeletePhoneNum.TabIndex = 7;
            this.btnDeletePhoneNum.Text = "Delete";
            this.btnDeletePhoneNum.UseVisualStyleBackColor = true;
            this.btnDeletePhoneNum.Click += new System.EventHandler(this.btnDeletePhoneNum_Click);
            // 
            // lnkPreviousPhone
            // 
            this.lnkPreviousPhone.AutoSize = true;
            this.lnkPreviousPhone.Enabled = false;
            this.lnkPreviousPhone.Location = new System.Drawing.Point(73, 110);
            this.lnkPreviousPhone.Name = "lnkPreviousPhone";
            this.lnkPreviousPhone.Size = new System.Drawing.Size(48, 13);
            this.lnkPreviousPhone.TabIndex = 3;
            this.lnkPreviousPhone.TabStop = true;
            this.lnkPreviousPhone.Text = "Previous";
            this.lnkPreviousPhone.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPreviousPhone_LinkClicked);
            // 
            // lnkNextPhone
            // 
            this.lnkNextPhone.AutoSize = true;
            this.lnkNextPhone.Enabled = false;
            this.lnkNextPhone.Location = new System.Drawing.Point(320, 110);
            this.lnkNextPhone.Name = "lnkNextPhone";
            this.lnkNextPhone.Size = new System.Drawing.Size(29, 13);
            this.lnkNextPhone.TabIndex = 5;
            this.lnkNextPhone.TabStop = true;
            this.lnkNextPhone.Text = "Next";
            this.lnkNextPhone.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNextPhone_LinkClicked);
            // 
            // lblPhoneNumText
            // 
            this.lblPhoneNumText.AutoSize = true;
            this.lblPhoneNumText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumText.Location = new System.Drawing.Point(12, 9);
            this.lblPhoneNumText.Name = "lblPhoneNumText";
            this.lblPhoneNumText.Size = new System.Drawing.Size(226, 17);
            this.lblPhoneNumText.TabIndex = 21;
            this.lblPhoneNumText.Text = "Edit the professor\'s phone number";
            this.lblPhoneNumText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnClosePhoneNum
            // 
            this.btnClosePhoneNum.AutoSize = true;
            this.btnClosePhoneNum.Location = new System.Drawing.Point(276, 173);
            this.btnClosePhoneNum.Name = "btnClosePhoneNum";
            this.btnClosePhoneNum.Size = new System.Drawing.Size(139, 23);
            this.btnClosePhoneNum.TabIndex = 8;
            this.btnClosePhoneNum.Text = "Close Without Saving";
            this.btnClosePhoneNum.UseVisualStyleBackColor = true;
            this.btnClosePhoneNum.Click += new System.EventHandler(this.btnClosePhoneNum_Click);
            // 
            // btnSavePhoneNum
            // 
            this.btnSavePhoneNum.AutoSize = true;
            this.btnSavePhoneNum.Location = new System.Drawing.Point(32, 173);
            this.btnSavePhoneNum.Name = "btnSavePhoneNum";
            this.btnSavePhoneNum.Size = new System.Drawing.Size(117, 23);
            this.btnSavePhoneNum.TabIndex = 6;
            this.btnSavePhoneNum.Text = "Save And Close";
            this.btnSavePhoneNum.UseVisualStyleBackColor = true;
            this.btnSavePhoneNum.Click += new System.EventHandler(this.btnSavePhoneNum_Click);
            // 
            // lblRequiredPhone
            // 
            this.lblRequiredPhone.AutoSize = true;
            this.lblRequiredPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredPhone.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredPhone.Location = new System.Drawing.Point(280, 40);
            this.lblRequiredPhone.Name = "lblRequiredPhone";
            this.lblRequiredPhone.Size = new System.Drawing.Size(15, 20);
            this.lblRequiredPhone.TabIndex = 17;
            this.lblRequiredPhone.Text = "*";
            // 
            // cbPhoneType
            // 
            this.cbPhoneType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPhoneType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPhoneType.FormattingEnabled = true;
            this.cbPhoneType.Items.AddRange(new object[] {
            "School",
            "Office",
            "Cell",
            "Home"});
            this.cbPhoneType.Location = new System.Drawing.Point(155, 71);
            this.cbPhoneType.Name = "cbPhoneType";
            this.cbPhoneType.Size = new System.Drawing.Size(121, 21);
            this.cbPhoneType.TabIndex = 2;
            // 
            // lblPhoneType
            // 
            this.lblPhoneType.AutoSize = true;
            this.lblPhoneType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneType.Location = new System.Drawing.Point(49, 72);
            this.lblPhoneType.Name = "lblPhoneType";
            this.lblPhoneType.Size = new System.Drawing.Size(100, 17);
            this.lblPhoneType.TabIndex = 6;
            this.lblPhoneType.Text = "Phone Type:";
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNum.Location = new System.Drawing.Point(155, 37);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.Size = new System.Drawing.Size(121, 20);
            this.txtPhoneNum.TabIndex = 1;
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNum.Location = new System.Drawing.Point(29, 37);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(120, 17);
            this.lblPhoneNum.TabIndex = 3;
            this.lblPhoneNum.Text = "Phone Number:";
            // 
            // lblSaveStatus
            // 
            this.lblSaveStatus.AutoSize = true;
            this.lblSaveStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveStatus.Location = new System.Drawing.Point(135, 144);
            this.lblSaveStatus.Name = "lblSaveStatus";
            this.lblSaveStatus.Size = new System.Drawing.Size(0, 13);
            this.lblSaveStatus.TabIndex = 22;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EditPhoneNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 213);
            this.Controls.Add(this.lblSaveStatus);
            this.Controls.Add(this.lnkAddAnotherPhoneNumber);
            this.Controls.Add(this.btnDeletePhoneNum);
            this.Controls.Add(this.lblPhoneNumText);
            this.Controls.Add(this.lnkPreviousPhone);
            this.Controls.Add(this.lblPhoneNum);
            this.Controls.Add(this.lnkNextPhone);
            this.Controls.Add(this.txtPhoneNum);
            this.Controls.Add(this.lblPhoneType);
            this.Controls.Add(this.btnClosePhoneNum);
            this.Controls.Add(this.cbPhoneType);
            this.Controls.Add(this.btnSavePhoneNum);
            this.Controls.Add(this.lblRequiredPhone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditPhoneNumberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Phone Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPhoneType;
        private System.Windows.Forms.Label lblPhoneType;
        private System.Windows.Forms.TextBox txtPhoneNum;
        private System.Windows.Forms.Label lblPhoneNum;
        private System.Windows.Forms.Label lblRequiredPhone;
        private System.Windows.Forms.Button btnClosePhoneNum;
        private System.Windows.Forms.Button btnSavePhoneNum;
        private System.Windows.Forms.Label lblPhoneNumText;
        private System.Windows.Forms.LinkLabel lnkPreviousPhone;
        private System.Windows.Forms.LinkLabel lnkNextPhone;
        private System.Windows.Forms.LinkLabel lnkAddAnotherPhoneNumber;
        private System.Windows.Forms.Button btnDeletePhoneNum;
        private System.Windows.Forms.Label lblSaveStatus;
        private System.Windows.Forms.Timer timer1;




    }
}