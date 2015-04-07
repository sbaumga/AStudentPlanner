using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Planner {
    public partial class DatabasePasswordForm : Form {
        
        public string password;
        
        public DatabasePasswordForm() {
            InitializeComponent();
        }

        //store password
        private void btnOK_Click(object sender, EventArgs e) {
            password = txtPassword.Text;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        //reset credentials to ensure password not stored in memory
        public void eraseCredentials() {
            password = null;
            GC.Collect();
        }

        //reset text if the wrong password is entered
        private void DatabasePasswordForm_Shown(object sender, EventArgs e) {
            txtPassword.ResetText();
        }

    }
}
