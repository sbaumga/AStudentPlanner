namespace Planner {
    partial class DatabaseEncryptionForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseEncryptionForm));
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtConfirmedPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmedPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkEncryptDatabase = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(12, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(339, 34);
            this.lblMessage.TabIndex = 13;
            this.lblMessage.Text = "Use this form to encrypt the database or change your existing password.";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Location = new System.Drawing.Point(197, 164);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(102, 164);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(78, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtConfirmedPassword
            // 
            this.txtConfirmedPassword.Location = new System.Drawing.Point(124, 121);
            this.txtConfirmedPassword.Name = "txtConfirmedPassword";
            this.txtConfirmedPassword.PasswordChar = '*';
            this.txtConfirmedPassword.Size = new System.Drawing.Size(180, 20);
            this.txtConfirmedPassword.TabIndex = 8;
            // 
            // lblConfirmedPassword
            // 
            this.lblConfirmedPassword.AutoSize = true;
            this.lblConfirmedPassword.Location = new System.Drawing.Point(24, 124);
            this.lblConfirmedPassword.Name = "lblConfirmedPassword";
            this.lblConfirmedPassword.Size = new System.Drawing.Size(94, 13);
            this.lblConfirmedPassword.TabIndex = 10;
            this.lblConfirmedPassword.Text = "Confirm Password:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(37, 93);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(81, 13);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "New Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(124, 90);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(180, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // chkEncryptDatabase
            // 
            this.chkEncryptDatabase.AutoSize = true;
            this.chkEncryptDatabase.Location = new System.Drawing.Point(66, 56);
            this.chkEncryptDatabase.Name = "chkEncryptDatabase";
            this.chkEncryptDatabase.Size = new System.Drawing.Size(111, 17);
            this.chkEncryptDatabase.TabIndex = 14;
            this.chkEncryptDatabase.Text = "Encrypt Database";
            this.chkEncryptDatabase.UseVisualStyleBackColor = true;
            this.chkEncryptDatabase.CheckedChanged += new System.EventHandler(this.chkEncryptDatabase_CheckedChanged);
            // 
            // DatabaseEncryptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 205);
            this.Controls.Add(this.chkEncryptDatabase);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtConfirmedPassword);
            this.Controls.Add(this.lblConfirmedPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DatabaseEncryptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Database Encryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtConfirmedPassword;
        private System.Windows.Forms.Label lblConfirmedPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkEncryptDatabase;
    }
}