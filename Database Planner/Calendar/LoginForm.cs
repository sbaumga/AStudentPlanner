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
        private Timer timer1 = new Timer();
        private Timer timer2 = new Timer();

        public LoginForm()
        {
            InitializeComponent();
            txtUsername.KeyDown += CheckIfEnter;
            txtPassword.KeyDown += CheckIfEnter;
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(FlashMessage);
            timer2.Interval = 5000;
            timer2.Tick += new EventHandler(FadeMessage);

         

        }

        private void CheckIfEnter(Object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
        }

        private void FlashMessage(Object sender, EventArgs e) {
            lblInvalid.ForeColor = Color.Red;
            timer1.Stop();
        }

        private void FadeMessage(Object sender, EventArgs e)
        {
            lblInvalid.Visible = false;
            timer2.Stop();
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
                lblInvalid.ForeColor = Color.HotPink;
                timer1.Start();
                timer2.Start();
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
