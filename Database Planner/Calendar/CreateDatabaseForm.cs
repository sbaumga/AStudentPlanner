using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace Planner
{
    public partial class CreateDatabaseForm : Form
    {
        public CreateDatabaseForm()
        {
            InitializeComponent();
        }

        //event handler for encyrpt database checkbox on create database tab
        private void chkEncrypt_CheckedChanged(object sender, EventArgs e) {
            //allow a user to enter a password if encrypting the database
            if (chkEncrypt.Checked == true) {
                txtEnterPassword.Enabled = true;
                txtConfirmPassword.Enabled = true;
            }
            //otherwise, the database doesn't need a password
            else {
                txtEnterPassword.Enabled = false;
                txtConfirmPassword.Enabled = false;

                //clear textbox and any error messages
                txtEnterPassword.ResetText();
                txtConfirmPassword.ResetText();
                lblError.ResetText();
            }
        }

        //event handler for when the create database button is pressed
        private void btnCreateDatabase_Click(object sender, EventArgs e) {
            //if encrypting the database, check if the passwords are equal and display error if they don't match
            if (chkEncrypt.Checked == true && txtEnterPassword.Text.Equals(txtConfirmPassword.Text) == false) {
                lblError.Visible = true;
            }
            //if not encrypting the database or the passwords match, create the database
            else {
                //display error message and quit if error creating database
                while (Database.createDatabase() == false) {
                    DialogResult result = MessageBox.Show("An Unexpected Error Occurred Creating the Database. Check the Error Log for more detailed information.", "Error Creating Database", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (result == DialogResult.Cancel) {
                        Environment.Exit(1);
                    }
                }

                //change the password (this action encrypts the database)
                if (chkEncrypt.Checked == true) {
//                    Database.changePassword(Util.escape(txtConfirmPassword.Text));    No more database password.
                }
                lblError.Visible = false;
                Close();
            }
        }

        //exits entire application
        private void btnExitProgram_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        private void CreateDatabaseForm_FormClosing(object sender, FormClosingEventArgs e) {
            /*//do not allow use to exit form if database has not been created
            if (File.Exists(Database.DB_PATH) == false){
                e.Cancel = true;
            }*/ // No more DB_PATH
        }

    }
}
