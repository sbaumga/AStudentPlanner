namespace Planner {
    partial class ContactForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactForm));
            this.cbSelectProfessor = new System.Windows.Forms.ComboBox();
            this.lblSelectProfessor = new System.Windows.Forms.Label();
            this.lblPhoneNumbersTitle = new System.Windows.Forms.Label();
            this.lblPhoneNumbers = new System.Windows.Forms.Label();
            this.lblEmailTitle = new System.Windows.Forms.Label();
            this.lblEmailTo = new System.Windows.Forms.Label();
            this.txtEmailTo = new System.Windows.Forms.TextBox();
            this.lblEmailFrom = new System.Windows.Forms.Label();
            this.txtEmailFrom = new System.Windows.Forms.TextBox();
            this.lblEmailSubject = new System.Windows.Forms.Label();
            this.txtEmailSubject = new System.Windows.Forms.TextBox();
            this.lblEmailMessage = new System.Windows.Forms.Label();
            this.txtEmailMessage = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.emailPanel = new System.Windows.Forms.Panel();
            this.emailPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSelectProfessor
            // 
            this.cbSelectProfessor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSelectProfessor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSelectProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectProfessor.FormattingEnabled = true;
            this.cbSelectProfessor.Location = new System.Drawing.Point(165, 20);
            this.cbSelectProfessor.Name = "cbSelectProfessor";
            this.cbSelectProfessor.Size = new System.Drawing.Size(192, 21);
            this.cbSelectProfessor.TabIndex = 0;
            this.cbSelectProfessor.SelectedIndexChanged += new System.EventHandler(this.cbSelectProfessor_SelectedIndexChanged);
            // 
            // lblSelectProfessor
            // 
            this.lblSelectProfessor.AutoSize = true;
            this.lblSelectProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectProfessor.Location = new System.Drawing.Point(25, 21);
            this.lblSelectProfessor.Margin = new System.Windows.Forms.Padding(0);
            this.lblSelectProfessor.Name = "lblSelectProfessor";
            this.lblSelectProfessor.Size = new System.Drawing.Size(133, 17);
            this.lblSelectProfessor.TabIndex = 45;
            this.lblSelectProfessor.Text = "Select Professor:";
            // 
            // lblPhoneNumbersTitle
            // 
            this.lblPhoneNumbersTitle.AutoSize = true;
            this.lblPhoneNumbersTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumbersTitle.Location = new System.Drawing.Point(25, 55);
            this.lblPhoneNumbersTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblPhoneNumbersTitle.Name = "lblPhoneNumbersTitle";
            this.lblPhoneNumbersTitle.Size = new System.Drawing.Size(123, 17);
            this.lblPhoneNumbersTitle.TabIndex = 46;
            this.lblPhoneNumbersTitle.Text = "Phone Numbers";
            // 
            // lblPhoneNumbers
            // 
            this.lblPhoneNumbers.AutoSize = true;
            this.lblPhoneNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumbers.Location = new System.Drawing.Point(26, 81);
            this.lblPhoneNumbers.Name = "lblPhoneNumbers";
            this.lblPhoneNumbers.Size = new System.Drawing.Size(231, 15);
            this.lblPhoneNumbers.TabIndex = 47;
            this.lblPhoneNumbers.Text = "Select Professor to View Phone Numbers";
            // 
            // lblEmailTitle
            // 
            this.lblEmailTitle.AutoSize = true;
            this.lblEmailTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailTitle.Location = new System.Drawing.Point(24, 9);
            this.lblEmailTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblEmailTitle.Name = "lblEmailTitle";
            this.lblEmailTitle.Size = new System.Drawing.Size(47, 17);
            this.lblEmailTitle.TabIndex = 48;
            this.lblEmailTitle.Text = "Email";
            // 
            // lblEmailTo
            // 
            this.lblEmailTo.AutoSize = true;
            this.lblEmailTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailTo.Location = new System.Drawing.Point(24, 35);
            this.lblEmailTo.Name = "lblEmailTo";
            this.lblEmailTo.Size = new System.Drawing.Size(29, 17);
            this.lblEmailTo.TabIndex = 49;
            this.lblEmailTo.Text = "To:";
            // 
            // txtEmailTo
            // 
            this.txtEmailTo.Location = new System.Drawing.Point(92, 35);
            this.txtEmailTo.Name = "txtEmailTo";
            this.txtEmailTo.Size = new System.Drawing.Size(165, 20);
            this.txtEmailTo.TabIndex = 1;
            // 
            // lblEmailFrom
            // 
            this.lblEmailFrom.AutoSize = true;
            this.lblEmailFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailFrom.Location = new System.Drawing.Point(24, 62);
            this.lblEmailFrom.Name = "lblEmailFrom";
            this.lblEmailFrom.Size = new System.Drawing.Size(44, 17);
            this.lblEmailFrom.TabIndex = 51;
            this.lblEmailFrom.Text = "From:";
            // 
            // txtEmailFrom
            // 
            this.txtEmailFrom.Location = new System.Drawing.Point(92, 61);
            this.txtEmailFrom.Name = "txtEmailFrom";
            this.txtEmailFrom.Size = new System.Drawing.Size(165, 20);
            this.txtEmailFrom.TabIndex = 2;
            // 
            // lblEmailSubject
            // 
            this.lblEmailSubject.AutoSize = true;
            this.lblEmailSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailSubject.Location = new System.Drawing.Point(24, 91);
            this.lblEmailSubject.Name = "lblEmailSubject";
            this.lblEmailSubject.Size = new System.Drawing.Size(59, 17);
            this.lblEmailSubject.TabIndex = 53;
            this.lblEmailSubject.Text = "Subject:";
            // 
            // txtEmailSubject
            // 
            this.txtEmailSubject.Location = new System.Drawing.Point(92, 91);
            this.txtEmailSubject.Name = "txtEmailSubject";
            this.txtEmailSubject.Size = new System.Drawing.Size(165, 20);
            this.txtEmailSubject.TabIndex = 3;
            // 
            // lblEmailMessage
            // 
            this.lblEmailMessage.AutoSize = true;
            this.lblEmailMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailMessage.Location = new System.Drawing.Point(24, 120);
            this.lblEmailMessage.Name = "lblEmailMessage";
            this.lblEmailMessage.Size = new System.Drawing.Size(69, 17);
            this.lblEmailMessage.TabIndex = 55;
            this.lblEmailMessage.Text = "Message:";
            // 
            // txtEmailMessage
            // 
            this.txtEmailMessage.Location = new System.Drawing.Point(27, 141);
            this.txtEmailMessage.Multiline = true;
            this.txtEmailMessage.Name = "txtEmailMessage";
            this.txtEmailMessage.Size = new System.Drawing.Size(319, 85);
            this.txtEmailMessage.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(41, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Send Email Message";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Location = new System.Drawing.Point(218, 244);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(115, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // emailPanel
            // 
            this.emailPanel.Controls.Add(this.btnClose);
            this.emailPanel.Controls.Add(this.button1);
            this.emailPanel.Controls.Add(this.txtEmailMessage);
            this.emailPanel.Controls.Add(this.lblEmailMessage);
            this.emailPanel.Controls.Add(this.txtEmailSubject);
            this.emailPanel.Controls.Add(this.lblEmailSubject);
            this.emailPanel.Controls.Add(this.txtEmailFrom);
            this.emailPanel.Controls.Add(this.lblEmailFrom);
            this.emailPanel.Controls.Add(this.txtEmailTo);
            this.emailPanel.Controls.Add(this.lblEmailTo);
            this.emailPanel.Controls.Add(this.lblEmailTitle);
            this.emailPanel.Location = new System.Drawing.Point(0, 99);
            this.emailPanel.Name = "emailPanel";
            this.emailPanel.Size = new System.Drawing.Size(369, 276);
            this.emailPanel.TabIndex = 60;
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(369, 397);
            this.Controls.Add(this.lblPhoneNumbers);
            this.Controls.Add(this.lblPhoneNumbersTitle);
            this.Controls.Add(this.cbSelectProfessor);
            this.Controls.Add(this.lblSelectProfessor);
            this.Controls.Add(this.emailPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ContactForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contact Form";
            this.emailPanel.ResumeLayout(false);
            this.emailPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSelectProfessor;
        private System.Windows.Forms.Label lblSelectProfessor;
        private System.Windows.Forms.Label lblPhoneNumbersTitle;
        private System.Windows.Forms.Label lblPhoneNumbers;
        private System.Windows.Forms.Label lblEmailTitle;
        private System.Windows.Forms.Label lblEmailTo;
        private System.Windows.Forms.TextBox txtEmailTo;
        private System.Windows.Forms.Label lblEmailFrom;
        private System.Windows.Forms.TextBox txtEmailFrom;
        private System.Windows.Forms.Label lblEmailSubject;
        private System.Windows.Forms.TextBox txtEmailSubject;
        private System.Windows.Forms.Label lblEmailMessage;
        private System.Windows.Forms.TextBox txtEmailMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel emailPanel;
    }
}