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
    public partial class AddSemesterForm : Form
    {

        //indicates when user is in process of creating database and initial tables
        private bool createDbProcess = false;
        private bool continueToAddProfessorPage = false;

        public AddSemesterForm()
        {
            InitializeComponent();

            //set semester id to one more than greatest id currently in database
            ctrSemester.Value = Int32.Parse(Database.executeScalarQuery("SELECT count(*) from Semester;").ToString()) + 1;

            //set start and end dates to current date
            dtSemesterStartDate.Value = DateTime.Now;
            dtSemesterEndDate.Value = DateTime.Now;
        }

        //determine what text to show on the buttons (different if in process of creating the database)
        public AddSemesterForm(bool createDB) : this() {
            if (createDB == true) {
                createDbProcess = true;
                btnSaveSemester.Text = "Save And Continue";
                btnCloseSemester.Text = "Save And Close";
            }
        }

        //indicate whether to not to continue to class page (if in process of creating
        public bool gotoAddProfessorPage() {
            return continueToAddProfessorPage;
        }

        private bool saveSemesterInfo() {
            //ensure a semester name was entered
            if (txtSemesterName.Text.Equals("")) {
                Util.displayRequiredFieldsError("Semester Name");
            }
            //ensure a semester with the same semester id does not already exist
            else if (Database.attributeExists("semesterID = '" + ctrSemester.Value + "'", "Semester")) {
                Util.displayError("The Entered Semester Number Already Exists", "Invalid Semester Number");
            }
            //ensure the end semester date occurs on or after the start semester date
            else if (dtSemesterEndDate.Value < dtSemesterStartDate.Value) {
                Util.displayError("The End Date Must Be Later Than The Start Date", "Invalid Semester Dates");
            }
            else {
                //update the semester fields in the database
                Database.modifyDatabase("INSERT INTO Semester VALUES('" + ctrSemester.Value + "',"
                    + Util.quote(txtSemesterName.Text) + ","
                    + "DATE('" + Database.getDate(dtSemesterStartDate.Value) + "'),"
                    + "DATE('" + Database.getDate(dtSemesterEndDate.Value) + "'))");
                return true;
            }
            return false;
        }

        private void btnSaveSemester_Click(object sender, EventArgs e) {
            //save semester information and close form if successful
            if (saveSemesterInfo() == true) {
                continueToAddProfessorPage = true;
                Close();
            }
        }

        private void btnCloseSemester_Click(object sender, EventArgs e) {
            if (createDbProcess == true) {
                if (saveSemesterInfo() == true) {
                    continueToAddProfessorPage = false;
                    Close();
                }
            }
            else {
                Close();
            }
        }

        private void lnkAddSemester_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if (saveSemesterInfo() == true) {
                //increment semester id and clear/reset all other values
                ctrSemester.Value++;
                txtSemesterName.ResetText();
                dtSemesterStartDate.Value = DateTime.Now;
                dtSemesterEndDate.Value = DateTime.Now;
            }
        }


    }
}
