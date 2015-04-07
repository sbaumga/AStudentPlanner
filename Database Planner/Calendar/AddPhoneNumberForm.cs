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
    public partial class AddPhoneNumberForm : Form
    {
        //phone information
        private List<string> phoneNumbers = new List<string>();
        private List<string> phoneTypes = new List<string>();      

        public AddPhoneNumberForm()
        {
            InitializeComponent();
        }

        //allows the add professor form to get the added phone numbers
        public List<string> getPhoneNumbers() {
            return phoneNumbers;
        }

        //allows the add professor form to get the added phone types
        public List<string> getPhoneTypes() {
            return phoneTypes;
        }

        //save the phone number values
        private bool savePhoneNum() {
            //if both fields are blank, just ignore (don't save)
            if (txtPhoneNum.Text.Equals("") && cbPhoneType.Text.Equals("")) {
                return true;
            }
            
            if (txtPhoneNum.Text.Equals("")) {
                Util.displayRequiredFieldsError("Phone Number");
                return false;
            }

            //check if phone number is already been added
            if (phoneNumbers.Contains(txtPhoneNum.Text)) {
                Util.displayError("You have already added this phone number.", "Duplicate Phone Number");
                return false;
            }

            phoneNumbers.Add(Util.escape(txtPhoneNum.Text));
            phoneTypes.Add(Util.escape(cbPhoneType.Text));
            return true;
        }

        //save the phone numbers and return to add professor tab unless there is an error
        private void btnSavePhoneNum_Click(object sender, EventArgs e) {
            if (savePhoneNum() == true) {
                Close();
            }
        }

        //return to add professor tab
        private void btnClosePhoneNum_Click(object sender, EventArgs e) {
            Close();
        }

        //save current phone number information and reset form
        private void lnkAddPhoneNumber_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            savePhoneNum();
            txtPhoneNum.ResetText();
            cbPhoneType.ResetText();
        }

    }
}
