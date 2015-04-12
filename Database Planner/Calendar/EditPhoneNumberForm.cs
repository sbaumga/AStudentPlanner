using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;
using MySql.Data.MySqlClient;

namespace Planner
{
    public partial class EditPhoneNumberForm : Form
    {
        //common variables for keeping track of the currently
        //  selected profId or classId
        private List<int> profId = new List<int>();
        private List<int> classId = new List<int>();
        private int currentProfId = -1;

        //variables for edit phone number tab
        private List<string> phoneNum = new List<string>();
        private List<string> phoneType = new List<string>();
        private int currentPhoneNum = 0;
        private bool useInsert = false;

        public EditPhoneNumberForm(int currentProf)
        {
            InitializeComponent();

            //assume we are editing existing information
            useInsert = false;
            currentProfId = currentProf;

            //dynamically add phone number and types to combo box
            MySqlDataReader phones = Database.executeQuery("SELECT PhoneNumber, Type FROM Phone WHERE ProfID = '" + currentProfId + "';");
            while (phones.Read() == true) {
                phoneNum.Add(phones.GetString(0));
                phoneType.Add(phones.GetString(1));
            }
            phones.Close();

            //if there is an existing phone number, populate form with details
            if (phoneNum.Count > 0) {
                txtPhoneNum.Text = phoneNum[currentPhoneNum];
                cbPhoneType.Text = phoneType[currentPhoneNum];
                lnkPreviousPhone.Enabled = true;
                lnkNextPhone.Enabled = true;
            }
        }

        //changes currently displayed phone number (increment or decrement)
        private void changePhoneNumber(bool goToNext, bool save) {
            bool success = true;

            //try to save existing phone information which may be have modified
            if (save) {
                ///check if save was succesful 
                success = savePhoneNumber();
            }

            //only continue if save was sucessful or there was no save
            if (success == true) {
                
                //after insert, reset variable back to false, indicating next
                //  save will be an UPDATE unless later changed
                useInsert = false;
                
                //if there are multiple phone numbers to cycle through
                if (phoneNum.Count > 0) {
                    if (goToNext == true) {
                        //increment (go to next)
                        currentPhoneNum = (currentPhoneNum + 1) % phoneNum.Count;
                    }
                    else {
                        //decrement (go to previous)
                        currentPhoneNum = (currentPhoneNum + phoneNum.Count - 1) % phoneNum.Count;
                    }

                    //update information on form
                    txtPhoneNum.Text = phoneNum[currentPhoneNum];
                    cbPhoneType.Text = phoneType[currentPhoneNum];
                }
            }
            else {
                displayMessage("Error Saving Phone Number", Color.DarkRed);
            }
        }

        //increment (go to next) phone number and save current info
        private void lnkNextPhone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            changePhoneNumber(true, true);
        }

        //decrement (go to previous) phone number and save current info
        private void lnkPreviousPhone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            changePhoneNumber(false, true);
        }

        //close tab without saving and go back to edit professor tab
        private void btnClosePhoneNum_Click(object sender, EventArgs e) {
            Close();
        }

        //deletes currently selected phone number from database
        private void btnDeletePhoneNum_Click(object sender, EventArgs e) {
            //display confirmation message
            DialogResult reallyDelete = MessageBox.Show("Are you sure you really want to delete this phone number?", "Really Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reallyDelete == DialogResult.Yes) {
                if (phoneNum.Count > 0) {
                    //delete from database and from lists
                    Database.modifyDatabase("DELETE FROM Phone WHERE ProfID = '" + currentProfId + "' AND PhoneNumber = '" + phoneNum[currentPhoneNum] + "';");
                    phoneNum.RemoveAt(currentPhoneNum);
                    phoneType.RemoveAt(currentPhoneNum);

                    //if there are not two items or more, there is nothing to cycle through
                    if (phoneNum.Count < 1) {
                        lnkPreviousPhone.Enabled = false;
                        lnkNextPhone.Enabled = false;
                    }

                    //result form
                    resetPhoneNumberForm();

                    //decrement (go to previous) phone number without saving current information (which will just be blank)
                    changePhoneNumber(false, false);
                }
            }
        }

        //saves the phone number, returning true if successful and false if there is an error
        private bool savePhoneNumber() {
            //require phone number if a phone type is currently entered
            if (txtPhoneNum.Text.Equals("") && cbPhoneType.Text.Equals("") == false) {
                Util.displayRequiredFieldsError("Phone Number");
                return false;
            }

            //if both fields are blank, just ignore (don't save)
            if (txtPhoneNum.Text.Equals("") && cbPhoneType.Text.Equals("")) {
                return true;
            }

            //if simply updating existing value
            if (useInsert == false && phoneNum.Count != 0) {
                //ensure a second instance of the phone number doesn't already exist
                if (phoneNum.Contains(txtPhoneNum.Text) && phoneNum.IndexOf(txtPhoneNum.Text) != currentPhoneNum) {
                    Util.displayError("This professor has already been assigned this phone number.", "Duplicate Phone Numbers");
                    return false;
                }
                else {
                    //update database
                    Database.modifyDatabase("UPDATE Phone SET PhoneNumber = " + Util.quote(txtPhoneNum.Text) + ", Type = " + Util.quote(cbPhoneType.Text)
                        + " WHERE ProfId = '" + currentProfId + "' AND PhoneNumber = '" + phoneNum[currentPhoneNum] + "';");
                    
                    //update information in lists (needed for cycling through)
                    phoneNum[currentPhoneNum] = txtPhoneNum.Text;
                    phoneType[currentPhoneNum] = cbPhoneType.Text;
                }
            }
            //if inserting new value
            else {
                //ensure phone number doesn't already exist
                if (phoneNum.Contains(txtPhoneNum.Text) == true) {
                    Util.displayError("This professor has already been assigned this phone number.", "Duplicate Phone Numbers");
                }
                else {
                    //add to database
                    Database.modifyDatabase("INSERT INTO Phone VALUES(" + Util.quote(txtPhoneNum.Text) + ", '" + currentProfId + "', " + Util.quote(cbPhoneType.Text) + ");");
                    
                    //add to lists and update current phone number pointer
                    phoneNum.Add(txtPhoneNum.Text);
                    phoneType.Add(cbPhoneType.Text);
                    currentPhoneNum = phoneNum.Count - 1;

                    if (phoneNum.Count > 0) {
                        lnkPreviousPhone.Enabled = true;
                        lnkNextPhone.Enabled = true;
                    }
                }
                //after inserting, assume next operation will be an update
                useInsert = false;
            }
            displayMessage("Phone Number Successfully Saved", Color.DarkGreen);
            return true;
        }

        //saves a phone number and returns to edit professor tab
        private void btnSavePhoneNum_Click(object sender, EventArgs e) {
            //if save successful, return to edit professor tab
            if (savePhoneNumber() == true) {
                Close();
            }
            else {
                displayMessage("Error Saving Phone Number", Color.DarkRed);
            }
        }

        //adds another professor if the existing save was successful and resets the current form
        private void lnkAddAnotherPhoneNumber_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if (savePhoneNumber() == true) {
                resetPhoneNumberForm();
                useInsert = true;
            }
            else {
                displayMessage("Error Saving Phone Number", Color.DarkRed);
            }
        }

        //resets form by clearing both the phone number and phone type text boxes
        private void resetPhoneNumberForm() {
            txtPhoneNum.ResetText();
            cbPhoneType.ResetText();
        }

        //display message for specified time using given text and color
        private void displayMessage(string text, Color color) {
            timer1.Stop();
            timer1.Start();
            lblSaveStatus.Text = text;
            lblSaveStatus.ForeColor = color;
        }

        //on first timer tick, clear save status label and stop timer
        private void timer1_Tick(object sender, EventArgs e) {
            lblSaveStatus.Text = "";
            timer1.Stop();
        }


    }
}
