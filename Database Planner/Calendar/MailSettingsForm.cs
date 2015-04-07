using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Planner {
    public partial class MailSettingsForm : Form {
        public MailSettingsForm() {
            InitializeComponent();

            //load saved settings
            rbUseMailClient.Checked = PlannerSettings.Default.UseDefaultClient;
            rbUseSetupServer.Checked = !(PlannerSettings.Default.UseDefaultClient);
            txtEmail.Text = PlannerSettings.Default.EmailAddress;
            txtSmtpPort.Text = PlannerSettings.Default.SmtpPort.ToString();
            txtSmtpServer.Text = PlannerSettings.Default.SmtpServer;
            chkRequiresAuthentication.Checked = PlannerSettings.Default.RequireAuthentication;
        }

        //save all entered settings
        private void btnSave_Click(object sender, EventArgs e) {
            int port;
            if (int.TryParse(txtSmtpPort.Text, out port) == false) {
                Util.displayError("Port number must be an integer value", "Invalid Port Number");
                return;
            }

            //update settings
            PlannerSettings.Default.UseDefaultClient = rbUseMailClient.Checked;
            PlannerSettings.Default.EmailAddress = txtEmail.Text;

            //only save smtp settings if user has that option checked
            if (rbUseMailClient.Checked == false) {             
                PlannerSettings.Default.SmtpPort = port;
                PlannerSettings.Default.SmtpServer = txtSmtpServer.Text;
                PlannerSettings.Default.RequireAuthentication = chkRequiresAuthentication.Checked;
            }

            //save settings to file
            PlannerSettings.Default.Save();
            Close();
        }

        //disable SMTP settings if using the default mail client
        private void rbUseMailClient_CheckedChanged(object sender, EventArgs e) {
            smtpSettingsPanel.Enabled = false;
        }

        //enable settings if using an outgoing mail server
        private void rbUseSetupServer_CheckedChanged(object sender, EventArgs e) {
            smtpSettingsPanel.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
