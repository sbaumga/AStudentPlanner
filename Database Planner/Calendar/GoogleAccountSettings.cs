using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Security.Cryptography;
using System.IO;

namespace Planner
{
    public partial class GoogleAccountSettings : Form
    {
        public GoogleAccountSettings()
        {
            InitializeComponent();

            txtUsername.Text = PlannerSettings.Default.Username;
            txtCalendarURL.Text = PlannerSettings.Default.CalendarURL;
            chkStorePassword.Checked = PlannerSettings.Default.StoredGoogleAccount;
            if (chkStorePassword.Checked == true) {
                byte[] salt = Encoding.Unicode.GetBytes("A+ Student Planner Developed By David Riggleman");
                string[] encryptedBytes = PlannerSettings.Default.Password.Split('-');
                byte[] encodedBytes = new byte[encryptedBytes.Length];
                for (int i = 0; i < encryptedBytes.Length; i++) {
                    encodedBytes[i] = Byte.Parse(encryptedBytes[i]);
                }
                byte[] decodedBytes = ProtectedData.Unprotect(encodedBytes, salt, DataProtectionScope.CurrentUser);
                txtEnterPassword.Text = Encoding.Unicode.GetString(decodedBytes);
                txtConfirmPassword.Text = Encoding.Unicode.GetString(decodedBytes);
            }
        }

        //exits entire application
        private void btnExitProgram_Click(object sender, EventArgs e) {
            Close();
        }

        private void chkStorePassword_CheckedChanged(object sender, EventArgs e) {
            if (chkStorePassword.Checked == true) {
                txtEnterPassword.Enabled = true;
                txtConfirmPassword.Enabled = true;
            }
            else {
                txtEnterPassword.Enabled = false;
                txtConfirmPassword.Enabled = false;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e) {
            StringBuilder url = new StringBuilder("https://www.google.com/calendar/feeds/");
            
            if (txtUsername.Text.Equals("") == false) {
                url.Append(txtUsername.Text);
            }
            else {               
                url.Append("username@gmail.com");
            }
            url.Append("/private/full");
            txtCalendarURL.Text = url.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            PlannerSettings.Default.Username = txtUsername.Text;
            PlannerSettings.Default.CalendarURL = txtCalendarURL.Text;
            if (chkStorePassword.Checked == true) {
                //make sure passwords match         
                if(txtEnterPassword.Text.Equals(txtConfirmPassword.Text) == false){
                    lblError.Visible = true;
                    return;
                }

                //encrypt password 
                byte[] salt = Encoding.Unicode.GetBytes("A+ Student Planner Developed By David Riggleman");
                byte[] password = Encoding.Unicode.GetBytes(txtConfirmPassword.Text);
                byte[] encryptedBytes = ProtectedData.Protect(password, salt, DataProtectionScope.CurrentUser);
                StringBuilder encryptedPass = new StringBuilder();
                foreach (byte b in encryptedBytes) {
                    encryptedPass.Append(b.ToString() + "-");
                }

                //remove last dash
                encryptedPass.Remove(encryptedPass.Length - 1, 1);
                PlannerSettings.Default.Password = encryptedPass.ToString();
                PlannerSettings.Default.StoredGoogleAccount = true;
            }
            else {
                PlannerSettings.Default.Password = null;
                PlannerSettings.Default.StoredGoogleAccount = false;
            }

            PlannerSettings.Default.Save();
            GC.Collect();
            Close();
        }

    }
}
