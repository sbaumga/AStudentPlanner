namespace Planner {
    partial class MailSettingsForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailSettingsForm));
            this.txtSmtpPort = new System.Windows.Forms.TextBox();
            this.lblSmtpPort = new System.Windows.Forms.Label();
            this.txtSmtpServer = new System.Windows.Forms.TextBox();
            this.lblSmtpServer = new System.Windows.Forms.Label();
            this.lblMailSettings = new System.Windows.Forms.Label();
            this.rbUseMailClient = new System.Windows.Forms.RadioButton();
            this.rbUseSetupServer = new System.Windows.Forms.RadioButton();
            this.chkRequiresAuthentication = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.smtpSettingsPanel = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.smtpSettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSmtpPort
            // 
            this.txtSmtpPort.Location = new System.Drawing.Point(86, 38);
            this.txtSmtpPort.Name = "txtSmtpPort";
            this.txtSmtpPort.Size = new System.Drawing.Size(77, 20);
            this.txtSmtpPort.TabIndex = 4;
            this.txtSmtpPort.Text = "25";
            // 
            // lblSmtpPort
            // 
            this.lblSmtpPort.AutoSize = true;
            this.lblSmtpPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmtpPort.Location = new System.Drawing.Point(42, 39);
            this.lblSmtpPort.Name = "lblSmtpPort";
            this.lblSmtpPort.Size = new System.Drawing.Size(38, 17);
            this.lblSmtpPort.TabIndex = 58;
            this.lblSmtpPort.Text = "Port:";
            // 
            // txtSmtpServer
            // 
            this.txtSmtpServer.Location = new System.Drawing.Point(86, 9);
            this.txtSmtpServer.Name = "txtSmtpServer";
            this.txtSmtpServer.Size = new System.Drawing.Size(187, 20);
            this.txtSmtpServer.TabIndex = 3;
            this.txtSmtpServer.Text = "smtp.cedarville.edu";
            // 
            // lblSmtpServer
            // 
            this.lblSmtpServer.AutoSize = true;
            this.lblSmtpServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmtpServer.Location = new System.Drawing.Point(26, 9);
            this.lblSmtpServer.Name = "lblSmtpServer";
            this.lblSmtpServer.Size = new System.Drawing.Size(54, 17);
            this.lblSmtpServer.TabIndex = 56;
            this.lblSmtpServer.Text = "Server:";
            // 
            // lblMailSettings
            // 
            this.lblMailSettings.AutoSize = true;
            this.lblMailSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailSettings.Location = new System.Drawing.Point(9, 9);
            this.lblMailSettings.Margin = new System.Windows.Forms.Padding(0);
            this.lblMailSettings.Name = "lblMailSettings";
            this.lblMailSettings.Size = new System.Drawing.Size(101, 17);
            this.lblMailSettings.TabIndex = 55;
            this.lblMailSettings.Text = "Mail Settings";
            // 
            // rbUseMailClient
            // 
            this.rbUseMailClient.AutoSize = true;
            this.rbUseMailClient.Location = new System.Drawing.Point(44, 39);
            this.rbUseMailClient.Name = "rbUseMailClient";
            this.rbUseMailClient.Size = new System.Drawing.Size(132, 17);
            this.rbUseMailClient.TabIndex = 1;
            this.rbUseMailClient.TabStop = true;
            this.rbUseMailClient.Text = "Use Default Mail Client";
            this.rbUseMailClient.UseVisualStyleBackColor = true;
            this.rbUseMailClient.CheckedChanged += new System.EventHandler(this.rbUseMailClient_CheckedChanged);
            // 
            // rbUseSetupServer
            // 
            this.rbUseSetupServer.AutoSize = true;
            this.rbUseSetupServer.Location = new System.Drawing.Point(44, 62);
            this.rbUseSetupServer.Name = "rbUseSetupServer";
            this.rbUseSetupServer.Size = new System.Drawing.Size(155, 17);
            this.rbUseSetupServer.TabIndex = 2;
            this.rbUseSetupServer.TabStop = true;
            this.rbUseSetupServer.Text = "Setup Outgoing Mail Server";
            this.rbUseSetupServer.UseVisualStyleBackColor = true;
            this.rbUseSetupServer.CheckedChanged += new System.EventHandler(this.rbUseSetupServer_CheckedChanged);
            // 
            // chkRequiresAuthentication
            // 
            this.chkRequiresAuthentication.AutoSize = true;
            this.chkRequiresAuthentication.Location = new System.Drawing.Point(30, 71);
            this.chkRequiresAuthentication.Name = "chkRequiresAuthentication";
            this.chkRequiresAuthentication.Size = new System.Drawing.Size(139, 17);
            this.chkRequiresAuthentication.TabIndex = 5;
            this.chkRequiresAuthentication.Text = "Requires Authentication";
            this.chkRequiresAuthentication.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(29, 237);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save And Close";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.AutoSize = true;
            this.btnClose.Location = new System.Drawing.Point(162, 237);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close Without Saving";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // smtpSettingsPanel
            // 
            this.smtpSettingsPanel.Controls.Add(this.txtSmtpServer);
            this.smtpSettingsPanel.Controls.Add(this.lblSmtpServer);
            this.smtpSettingsPanel.Controls.Add(this.chkRequiresAuthentication);
            this.smtpSettingsPanel.Controls.Add(this.lblSmtpPort);
            this.smtpSettingsPanel.Controls.Add(this.txtSmtpPort);
            this.smtpSettingsPanel.Location = new System.Drawing.Point(12, 122);
            this.smtpSettingsPanel.Name = "smtpSettingsPanel";
            this.smtpSettingsPanel.Size = new System.Drawing.Size(289, 100);
            this.smtpSettingsPanel.TabIndex = 67;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(12, 96);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(80, 17);
            this.lblEmail.TabIndex = 59;
            this.lblEmail.Text = "Your Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(98, 96);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(187, 20);
            this.txtEmail.TabIndex = 60;
            // 
            // MailSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 272);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rbUseSetupServer);
            this.Controls.Add(this.rbUseMailClient);
            this.Controls.Add(this.lblMailSettings);
            this.Controls.Add(this.smtpSettingsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MailSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mail Settings";
            this.smtpSettingsPanel.ResumeLayout(false);
            this.smtpSettingsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSmtpPort;
        private System.Windows.Forms.Label lblSmtpPort;
        private System.Windows.Forms.TextBox txtSmtpServer;
        private System.Windows.Forms.Label lblSmtpServer;
        private System.Windows.Forms.Label lblMailSettings;
        private System.Windows.Forms.RadioButton rbUseMailClient;
        private System.Windows.Forms.RadioButton rbUseSetupServer;
        private System.Windows.Forms.CheckBox chkRequiresAuthentication;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel smtpSettingsPanel;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
    }
}