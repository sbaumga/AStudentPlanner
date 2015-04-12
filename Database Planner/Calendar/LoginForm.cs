using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Planner
{
    public partial class LoginForm : Form
    {
        private String username = "username";
        private String password = "password";
        private Timer timer = new Timer();

        public LoginForm()
        {
            InitializeComponent();
            timer.Interval = 5000;
            timer.Tick += new EventHandler(RemoveMessage);
        }

        private void RemoveMessage(Object sender, EventArgs e)
        {
            lblInvalid.Visible = false;
            timer.Stop();
        }

         //event handler for when the create database button is pressed
        private void btnLogin_Click(object sender, EventArgs e) {
            //TODO check against actual username and password
            if (txtUsername.Text.Equals(username) && txtPassword.Text.Equals(password))
            {
                //TODO connect to database
                Close();
            }
            else
            {
                lblInvalid.Visible = true;
                timer.Start();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!txtUsername.Text.Equals(username) || !txtPassword.Text.Equals(password))
            {
                //do not allow user to exit form if username and password not matched
                e.Cancel = true;
            }
        }

        //exits entire application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
