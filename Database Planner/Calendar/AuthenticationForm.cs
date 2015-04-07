using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Planner {
    public partial class AuthenticationForm : Form {

        public string username = null;
        public string password = null;
        public bool cancelled = false;
        
        public AuthenticationForm(String defaultUsername) {
            InitializeComponent();
            txtUsername.Text = defaultUsername;
            txtPassword.Focus();
        }

        //change title and message to allow for reuse of authentication form
        public void changeText(string text, string title){
            lblMessage.Text = text;
            this.Text = title;
        }

        //temporarily store username and password
        private void btnOK_Click(object sender, EventArgs e) {
            username = txtUsername.Text;
            password = txtPassword.Text;
            cancelled = false;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            cancelled = true;
            Close();
        }

        //ensure username and password are not stored in memory
        public void eraseCredentials() {
            username = null;
            password = null;
        }       
    }
}
