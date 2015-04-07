using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Planner {
    public partial class DatabaseEncryptionForm : Form {
        public DatabaseEncryptionForm() {
            InitializeComponent();
            chkEncryptDatabase.Checked = Database.encrypted;
            chkEncryptDatabase_CheckedChanged(null, null);
        }

        private void btnSave_Click(object sender, EventArgs e) {
            //if database is encrypted
            if (chkEncryptDatabase.Checked == true) {
                //check if passwords match
                if (txtPassword.Text.Equals(txtConfirmedPassword.Text) == false) {
                    Util.displayError("Passwords do not match", "Invalid Password");
                    return;
                }

                //if passwords match, change password
                Database.changePassword(txtPassword.Text);
            }
            //to permanently decrypt database, set password to null
            else {
                Database.changePassword(null);
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        //check if database should be encrypted
        private void chkEncryptDatabase_CheckedChanged(object sender, EventArgs e) {
            //if encrypting database, enable password fields
            if (chkEncryptDatabase.Checked == true) {
                txtPassword.Enabled = true;
                txtConfirmedPassword.Enabled = true;
            }
            //otherwise disable
            else {
                txtPassword.Enabled = false;
                txtConfirmedPassword.Enabled = false;
            }
        }

    }
}
