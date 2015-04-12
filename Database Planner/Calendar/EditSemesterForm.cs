using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using MySql.Data.MySqlClient;

namespace Planner
{
    public partial class EditSemesterForm : Form
    {

        //common variables for keeping track of the currently
        //  selected semesterId
        private List<int> semesterId = new List<int>();

        public EditSemesterForm(){
            InitializeComponent();

            //set start and end dates to current date
            dtSemesterStartDate.Value = DateTime.Now;
            dtSemesterEndDate.Value = DateTime.Now;

            Util.addSemesters(cbEditSemester, semesterId, false);

            updateSemesterButtons();
        }

        //method to update buttons (enable/disable) when editing a semester (a semester
        //  must be currently selected in order to be able to save and delete semester
        //  information)
        private void updateSemesterButtons() {
            //checks if any semester has been selected
            if (cbEditSemester.Text.Equals("")) {
                btnSaveSemester.Enabled = false;
                btnDeleteSemester.Enabled = false;
            }
            else {
                btnSaveSemester.Enabled = true;
                btnDeleteSemester.Enabled = true;
            }
        }

        private bool saveSemester() {

            //ensure a semester name was entered
            if (txtSemesterName.Text.Equals("")) {
                Util.displayRequiredFieldsError("Semester Name");
            }
            //ensure a semester with the same semester id does not already exist
            else if(semesterId[cbEditSemester.SelectedIndex] != ctrSemesterNum.Value && Database.attributeExists("semesterID = '" + ctrSemesterNum.Value + "'", "Semester")){
                Util.displayError("The Entered Semester Number Already Exists", "Invalid Semester Number");
            }
            //ensure the end semester date occurs on or after the start semester date
            else if (dtSemesterEndDate.Value < dtSemesterStartDate.Value) {
                Util.displayError("The End Date Must Be Later Than The Start Date", "Invalid Semester Dates");
            }
            else {
                
                
                //update the semester fields in the database
                Database.modifyDatabase("UPDATE Semester SET Name = " + Util.quote(txtSemesterName.Text)
                    + ", StartDate = DATE('" + Database.getDate(dtSemesterStartDate.Value) + "')"
                    + ", StartDate = DATE('" + Database.getDate(dtSemesterEndDate.Value) + "')"
                    + " WHERE SemesterID = '" + semesterId[cbEditSemester.SelectedIndex] + "';");

                //update semester id if necessary
                if (semesterId[cbEditSemester.SelectedIndex] != ctrSemesterNum.Value) {
                    Database.modifyDatabase("UPDATE Semester SET SemesterID = '" + ctrSemesterNum.Value + "'"
                        + " WHERE SemesterID = '" + semesterId[cbEditSemester.SelectedIndex] + "';");
                }
                
                //refresh values in semester combobox
                int previousIndex = cbEditSemester.SelectedIndex;
                Util.addSemesters(cbEditSemester, semesterId, false);
                cbEditSemester.SelectedIndex = previousIndex;
                
                return true;
            }
            return false;
        }

        private void btnSaveSemester_Click(object sender, EventArgs e) {
            //try to save semester information
            if (saveSemester() == false) {
                displayMessage("Error Saving Semester Information", Color.DarkRed);
            }
            else {
                displayMessage("Professor Information Successfully Saved", Color.DarkGreen);
            }    
        }

        //method to delete currently selected semester
        private void btnDeleteSemester_Click(object sender, EventArgs e) {
            //display confirmation message
            DialogResult reallyDelete = MessageBox.Show("Are you sure you really want to delete this semester?", "Really Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reallyDelete == DialogResult.Yes) {
                //delete from database
                Database.modifyDatabase("DELETE FROM Semester WHERE SemesterID = '" + semesterId[cbEditSemester.SelectedIndex] + "';");
                Close();
            }
        }

        //closes semester form without saving
        private void btnCloseSemester_Click(object sender, EventArgs e) {
            Close();
        }
        
        private void displayMessage(string text, Color color) {
            timer1.Stop();
            timer1.Start();
            lblSaveStatus.Text = text;
            lblSaveStatus.ForeColor = color;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            lblSaveStatus.Text = "";
            timer1.Stop();
        }

        private void cbEditSemester_SelectedIndexChanged(object sender, EventArgs e) {
            //updates buttons and links (will most likely enable)
            updateSemesterButtons();

            //get current semester id
            int currentSemesterId = semesterId[cbEditSemester.SelectedIndex];

            //dynamically populate semester information
            MySqlDataReader selectedSemester = Database.executeQuery("SELECT * FROM Semester WHERE SemesterID = '" + currentSemesterId + "';");

            //only one item should be returned
            if (selectedSemester.Read() == true) {
                ctrSemesterNum.Value = selectedSemester.GetInt32(0);
                txtSemesterName.Text = selectedSemester.GetString(1);
                dtSemesterStartDate.Value = selectedSemester.GetDateTime(2);
                dtSemesterEndDate.Value = selectedSemester.GetDateTime(3);
            }

            selectedSemester.Close();
        }

        
    }
}
