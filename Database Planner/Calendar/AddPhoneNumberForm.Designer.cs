namespace Planner
{
    partial class AddPhoneNumberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPhoneNumberForm));
            this.lnkAddPhoneNumber = new System.Windows.Forms.LinkLabel();
            this.lblPhoneNumText = new System.Windows.Forms.Label();
            this.btnClosePhoneNum = new System.Windows.Forms.Button();
            this.btnSavePhoneNum = new System.Windows.Forms.Button();
            this.lblRequiredPhone = new System.Windows.Forms.Label();
            this.cbPhoneType = new System.Windows.Forms.ComboBox();
            this.lblPhoneType = new System.Windows.Forms.Label();
            this.txtPhoneNum = new System.Windows.Forms.TextBox();
            this.lblPhoneNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lnkAddPhoneNumber
            // 
            this.lnkAddPhoneNumber.AutoSize = true;
            this.lnkAddPhoneNumber.Location = new System.Drawing.Point(144, 117);
            this.lnkAddPhoneNumber.Name = "lnkAddPhoneNumber";
            this.lnkAddPhoneNumber.Size = new System.Drawing.Size(140, 13);
            this.lnkAddPhoneNumber.TabIndex = 22;
            this.lnkAddPhoneNumber.TabStop = true;
            this.lnkAddPhoneNumber.Text = "Add Another Phone Number";
            this.lnkAddPhoneNumber.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddPhoneNumber_LinkClicked);
            // 
            // lblPhoneNumText
            // 
            this.lblPhoneNumText.AutoSize = true;
            this.lblPhoneNumText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumText.Location = new System.Drawing.Point(12, 9);
            this.lblPhoneNumText.Name = "lblPhoneNumText";
            this.lblPhoneNumText.Size = new System.Drawing.Size(236, 17);
            this.lblPhoneNumText.TabIndex = 21;
            this.lblPhoneNumText.Text = "Enter the professor\'s phone number";
            this.lblPhoneNumText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnClosePhoneNum
            // 
            this.btnClosePhoneNum.AutoSize = true;
            this.btnClosePhoneNum.Location = new System.Drawing.Point(222, 148);
            this.btnClosePhoneNum.Name = "btnClosePhoneNum";
            this.btnClosePhoneNum.Size = new System.Drawing.Size(155, 23);
            this.btnClosePhoneNum.TabIndex = 5;
            this.btnClosePhoneNum.Text = "Close Without Saving";
            this.btnClosePhoneNum.UseVisualStyleBackColor = true;
            this.btnClosePhoneNum.Click += new System.EventHandler(this.btnClosePhoneNum_Click);
            // 
            // btnSavePhoneNum
            // 
            this.btnSavePhoneNum.AutoSize = true;
            this.btnSavePhoneNum.Location = new System.Drawing.Point(52, 148);
            this.btnSavePhoneNum.Name = "btnSavePhoneNum";
            this.btnSavePhoneNum.Size = new System.Drawing.Size(133, 23);
            this.btnSavePhoneNum.TabIndex = 4;
            this.btnSavePhoneNum.Text = "Save And Close";
            this.btnSavePhoneNum.UseVisualStyleBackColor = true;
            this.btnSavePhoneNum.Click += new System.EventHandler(this.btnSavePhoneNum_Click);
            // 
            // lblRequiredPhone
            // 
            this.lblRequiredPhone.AutoSize = true;
            this.lblRequiredPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredPhone.ForeColor = System.Drawing.Color.Maroon;
            this.lblRequiredPhone.Location = new System.Drawing.Point(284, 40);
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
            // AddPhoneNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(420, 201);
            this.Controls.Add(this.lnkAddPhoneNumber);
            this.Controls.Add(this.lblPhoneNumText);
            this.Controls.Add(this.btnClosePhoneNum);
            this.Controls.Add(this.lblPhoneNum);
            this.Controls.Add(this.btnSavePhoneNum);
            this.Controls.Add(this.txtPhoneNum);
            this.Controls.Add(this.lblRequiredPhone);
            this.Controls.Add(this.lblPhoneType);
            this.Controls.Add(this.cbPhoneType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPhoneNumberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Phone Number";
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
        private System.Windows.Forms.LinkLabel lnkAddPhoneNumber;




    }
}