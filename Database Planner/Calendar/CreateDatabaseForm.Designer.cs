namespace Planner
{
    partial class CreateDatabaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateDatabaseForm));
            this.txtEnterPassword = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnExitProgram = new System.Windows.Forms.Button();
            this.btnCreateDatabase = new System.Windows.Forms.Button();
            this.chkEncrypt = new System.Windows.Forms.CheckBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblEnterPassword = new System.Windows.Forms.Label();
            this.lblSecurity = new System.Windows.Forms.Label();
            this.lblNoDBFound = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEnterPassword
            // 
            this.txtEnterPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnterPassword.Enabled = false;
            this.txtEnterPassword.Location = new System.Drawing.Point(177, 120);
            this.txtEnterPassword.Name = "txtEnterPassword";
            this.txtEnterPassword.PasswordChar = '*';
            this.txtEnterPassword.Size = new System.Drawing.Size(113, 20);
            this.txtEnterPassword.TabIndex = 2;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Location = new System.Drawing.Point(83, 186);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(185, 13);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "Error: Passwords Do Not Match";
            this.lblError.Visible = false;
            // 
            // btnExitProgram
            // 
            this.btnExitProgram.AutoSize = true;
            this.btnExitProgram.Location = new System.Drawing.Point(189, 212);
            this.btnExitProgram.Name = "btnExitProgram";
            this.btnExitProgram.Size = new System.Drawing.Size(119, 23);
            this.btnExitProgram.TabIndex = 5;
            this.btnExitProgram.Text = "Exit Program";
            this.btnExitProgram.UseVisualStyleBackColor = true;
            this.btnExitProgram.Click += new System.EventHandler(this.btnExitProgram_Click);
            // 
            // btnCreateDatabase
            // 
            this.btnCreateDatabase.AutoSize = true;
            this.btnCreateDatabase.Location = new System.Drawing.Point(34, 212);
            this.btnCreateDatabase.Name = "btnCreateDatabase";
            this.btnCreateDatabase.Size = new System.Drawing.Size(135, 23);
            this.btnCreateDatabase.TabIndex = 4;
            this.btnCreateDatabase.Text = "Create Database";
            this.btnCreateDatabase.UseVisualStyleBackColor = true;
            this.btnCreateDatabase.Click += new System.EventHandler(this.btnCreateDatabase_Click);
            // 
            // chkEncrypt
            // 
            this.chkEncrypt.AutoSize = true;
            this.chkEncrypt.Location = new System.Drawing.Point(118, 89);
            this.chkEncrypt.Name = "chkEncrypt";
            this.chkEncrypt.Size = new System.Drawing.Size(111, 17);
            this.chkEncrypt.TabIndex = 1;
            this.chkEncrypt.Text = "Encrypt Database";
            this.chkEncrypt.UseVisualStyleBackColor = true;
            this.chkEncrypt.CheckedChanged += new System.EventHandler(this.chkEncrypt_CheckedChanged);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmPassword.Enabled = false;
            this.txtConfirmPassword.Location = new System.Drawing.Point(177, 153);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(113, 20);
            this.txtConfirmPassword.TabIndex = 3;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(27, 154);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(142, 17);
            this.lblConfirmPassword.TabIndex = 3;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // lblEnterPassword
            // 
            this.lblEnterPassword.AutoSize = true;
            this.lblEnterPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterPassword.Location = new System.Drawing.Point(27, 121);
            this.lblEnterPassword.Name = "lblEnterPassword";
            this.lblEnterPassword.Size = new System.Drawing.Size(126, 17);
            this.lblEnterPassword.TabIndex = 2;
            this.lblEnterPassword.Text = "Enter Password:";
            // 
            // lblSecurity
            // 
            this.lblSecurity.AutoSize = true;
            this.lblSecurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurity.Location = new System.Drawing.Point(27, 89);
            this.lblSecurity.Name = "lblSecurity";
            this.lblSecurity.Size = new System.Drawing.Size(72, 17);
            this.lblSecurity.TabIndex = 1;
            this.lblSecurity.Text = "Security:";
            // 
            // lblNoDBFound
            // 
            this.lblNoDBFound.AutoSize = true;
            this.lblNoDBFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoDBFound.Location = new System.Drawing.Point(12, 9);
            this.lblNoDBFound.Name = "lblNoDBFound";
            this.lblNoDBFound.Size = new System.Drawing.Size(325, 68);
            this.lblNoDBFound.TabIndex = 0;
            this.lblNoDBFound.Text = "No database found. The following will create \r\na new database. If the database al" +
                "ready exists, \r\nensure \"Planner.s3db\" is located in the application\r\nprogram dir" +
                "ectory in My Documents.";
            this.lblNoDBFound.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CreateDatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(350, 251);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnExitProgram);
            this.Controls.Add(this.lblNoDBFound);
            this.Controls.Add(this.btnCreateDatabase);
            this.Controls.Add(this.txtEnterPassword);
            this.Controls.Add(this.chkEncrypt);
            this.Controls.Add(this.lblSecurity);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.lblEnterPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateDatabaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateDatabaseForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnterPassword;
        private System.Windows.Forms.Button btnExitProgram;
        private System.Windows.Forms.Button btnCreateDatabase;
        private System.Windows.Forms.CheckBox chkEncrypt;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblEnterPassword;
        private System.Windows.Forms.Label lblSecurity;
        private System.Windows.Forms.Label lblNoDBFound;
        private System.Windows.Forms.Label lblError;




    }
}