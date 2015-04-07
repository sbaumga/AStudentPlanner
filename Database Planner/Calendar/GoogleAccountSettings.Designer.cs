namespace Planner
{
    partial class GoogleAccountSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoogleAccountSettings));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblNoDBFound = new System.Windows.Forms.Label();
            this.lblCalendarURL = new System.Windows.Forms.Label();
            this.txtCalendarURL = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.txtEnterPassword = new System.Windows.Forms.TextBox();
            this.chkStorePassword = new System.Windows.Forms.CheckBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblEnterPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Location = new System.Drawing.Point(225, 269);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(167, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close Without Saving";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnExitProgram_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(54, 269);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save and Close";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblNoDBFound
            // 
            this.lblNoDBFound.AutoSize = true;
            this.lblNoDBFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoDBFound.Location = new System.Drawing.Point(23, 168);
            this.lblNoDBFound.Name = "lblNoDBFound";
            this.lblNoDBFound.Size = new System.Drawing.Size(347, 34);
            this.lblNoDBFound.TabIndex = 0;
            this.lblNoDBFound.Text = "Change the Calendar URL below if necessary  for the \r\nGoogle Calendar you wish to" +
                " add events to.";
            this.lblNoDBFound.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCalendarURL
            // 
            this.lblCalendarURL.AutoSize = true;
            this.lblCalendarURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendarURL.Location = new System.Drawing.Point(21, 214);
            this.lblCalendarURL.Name = "lblCalendarURL";
            this.lblCalendarURL.Size = new System.Drawing.Size(109, 17);
            this.lblCalendarURL.TabIndex = 9;
            this.lblCalendarURL.Text = "Calendar URL";
            // 
            // txtCalendarURL
            // 
            this.txtCalendarURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCalendarURL.Location = new System.Drawing.Point(24, 234);
            this.txtCalendarURL.Name = "txtCalendarURL";
            this.txtCalendarURL.Size = new System.Drawing.Size(413, 20);
            this.txtCalendarURL.TabIndex = 11;
            this.txtCalendarURL.Text = "https://www.google.com/calendar/feeds/username@gmail.com/private/full\r\n";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Location = new System.Drawing.Point(79, 141);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(185, 13);
            this.lblError.TabIndex = 21;
            this.lblError.Text = "Error: Passwords Do Not Match";
            this.lblError.Visible = false;
            // 
            // txtEnterPassword
            // 
            this.txtEnterPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnterPassword.Enabled = false;
            this.txtEnterPassword.Location = new System.Drawing.Point(173, 75);
            this.txtEnterPassword.Name = "txtEnterPassword";
            this.txtEnterPassword.PasswordChar = '*';
            this.txtEnterPassword.Size = new System.Drawing.Size(168, 20);
            this.txtEnterPassword.TabIndex = 15;
            // 
            // chkStorePassword
            // 
            this.chkStorePassword.AutoSize = true;
            this.chkStorePassword.Location = new System.Drawing.Point(79, 45);
            this.chkStorePassword.Name = "chkStorePassword";
            this.chkStorePassword.Size = new System.Drawing.Size(237, 17);
            this.chkStorePassword.TabIndex = 14;
            this.chkStorePassword.Text = "Store Password (Password will be encrypted)";
            this.chkStorePassword.UseVisualStyleBackColor = true;
            this.chkStorePassword.CheckedChanged += new System.EventHandler(this.chkStorePassword_CheckedChanged);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.Enabled = false;
            this.txtConfirmPassword.Location = new System.Drawing.Point(173, 108);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(168, 20);
            this.txtConfirmPassword.TabIndex = 17;
            // 
            // lblEnterPassword
            // 
            this.lblEnterPassword.AutoSize = true;
            this.lblEnterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterPassword.Location = new System.Drawing.Point(39, 75);
            this.lblEnterPassword.Name = "lblEnterPassword";
            this.lblEnterPassword.Size = new System.Drawing.Size(126, 17);
            this.lblEnterPassword.TabIndex = 16;
            this.lblEnterPassword.Text = "Enter Password:";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(23, 109);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(142, 17);
            this.lblConfirmPassword.TabIndex = 18;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Location = new System.Drawing.Point(171, 12);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(221, 20);
            this.txtUsername.TabIndex = 22;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(21, 12);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(142, 17);
            this.lblUsername.TabIndex = 23;
            this.lblUsername.Text = "Username (Email):";
            // 
            // GoogleAccountSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(464, 309);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtEnterPassword);
            this.Controls.Add(this.chkStorePassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.lblEnterPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.txtCalendarURL);
            this.Controls.Add(this.lblCalendarURL);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblNoDBFound);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoogleAccountSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Google Calendar Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblNoDBFound;
        private System.Windows.Forms.Label lblCalendarURL;
        private System.Windows.Forms.TextBox txtCalendarURL;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtEnterPassword;
        private System.Windows.Forms.CheckBox chkStorePassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblEnterPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;




    }
}