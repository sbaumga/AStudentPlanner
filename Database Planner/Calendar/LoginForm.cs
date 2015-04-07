using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.SQLite;

namespace Planner
{
    public partial class LoginForm : Form
    {
        private String username = "username";
        private String password = "password";

        public LoginForm()
        {
            InitializeComponent();
        }

         //event handler for when the create database button is pressed
        private void btnLogin_Click(object sender, EventArgs e) {
            //TODO check against actual username and password
            if (txtUsername.Equals(username) && txtPassword.Equals(password))
            {
                //TODO connect to database
                Close();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {

            //do not allow user to exit form if username and password not matched
            e.Cancel = true;
            
        }


    }
}
