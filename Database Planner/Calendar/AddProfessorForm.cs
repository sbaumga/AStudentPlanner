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
    public partial class AddProfessorForm : Form
    {
        //phone information
        AddPhoneNumberForm addPhoneNumber = new AddPhoneNumberForm();
        private List<string> phoneNumbers = new List<string>();
        private List<string> phoneTypes = new List<string>();

        //office hours information
        AddOfficeHoursForm addOfficeHours = new AddOfficeHoursForm();
        private List<bool[]> officeHoursDays = new List<bool[]>();
        private List<DateTime> officeHoursStart = new List<DateTime>();
        private List<DateTime> officeHoursEnd = new List<DateTime>();

        //indicates when user is in process of creating database and initial tables
        private bool createDbProcess = false;
        private bool continueToAddClassPage = false;

        public AddProfessorForm()
        {
            InitializeComponent();        
        }

        //determine what text to show on the buttons (different if in process of creating the database)
        public AddProfessorForm(bool createDB) : this() {
            if (createDB == true) {
                createDbProcess = true;
                btnSaveProfessor.Text = "Save And Continue";
                btnCloseProfessor.Text = "Save And Close";
            }
        }

        //indicate whether to not to continue to class page (if in process of creating
        public bool gotoAddClassPage() {
            return continueToAddClassPage;
        }

        //saves the current professor information and resets all the form controls
        //  if the save was sucessful
        private void btnAddAnotherProfessor_Click(object sender, EventArgs e) {
            if (saveProfessorInfo() == true) {
                txtProfessorTitle.Text = "";
                txtProfessorFName.Text = "";
                txtProfessorLName.Text = "";
                txtProfessorEmail.Text = "";
                txtProfessorOfficeLoc.Text = "";
                addPhoneNumber = new AddPhoneNumberForm();
                addOfficeHours = new AddOfficeHoursForm();
            }
        }

        //saves the current professor information and if successful, moves to
        //  the add class page (if in the create database process) or closes
        //  the form
        private void btnSaveProfessor_Click(object sender, EventArgs e) {
            if (saveProfessorInfo() == true) {
                continueToAddClassPage = true;
                Close();
            }
        }

        //save information (if in create database process) and close form
        private void btnCloseProfessor_Click(object sender, EventArgs e) {
            if (createDbProcess == true) {              
                if (saveProfessorInfo() == true) {
                    continueToAddClassPage = false;
                    Close();
                }
            }
            else {
                Close();
            }
        }

        //open add office hours form and once it is closed, get office hour information
        private void lnkAddOfficeHours_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            addOfficeHours.ShowDialog();
            officeHoursDays = addOfficeHours.getOfficeHoursDays();
            officeHoursStart = addOfficeHours.getOfficeHoursStart();
            officeHoursEnd = addOfficeHours.getOfficeHoursEnd();
        }

        //open phone number form and once it is closed, get phone number information
        private void lnkAddPhoneNum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {           
            addPhoneNumber.ShowDialog();
            phoneNumbers = addPhoneNumber.getPhoneNumbers();
            phoneTypes = addPhoneNumber.getPhoneTypes();
        }

        //saves professor information, returning true if successful or false if there was an error
        private bool saveProfessorInfo() {

            //ensure user has entered a last name (a required field)
            if (txtProfessorLName.Text.Equals("")) {
                Util.displayRequiredFieldsError("Last Name");
                return false;
            }

            //begin database transaction
            Database.beginTransaction();
            Database.modifyDatabase("INSERT INTO Professor VALUES (null, " + Util.quote(txtProfessorTitle.Text) + ", " + Util.quote(txtProfessorFName.Text)
                + ", " + Util.quote(txtProfessorLName.Text) + ", " + Util.quote(txtProfessorEmail.Text) + ", " + Util.quote(txtProfessorOfficeLoc.Text) + ");");

            //get the id of the value just inserted
            object profID = Database.getInsertedID();

            //insert phone hours
            for (int i = 0; i < phoneNumbers.Count; i++) {
                Database.modifyDatabase("INSERT INTO Phone VALUES('" + phoneNumbers[i] + "', '" + profID + "', '" + phoneTypes[i] + "');");
            }

            //insert office hours
            for (int i = 0; i < officeHoursDays.Count; i++) {
                string startTime = officeHoursStart[i].TimeOfDay.ToString();
                string endTime = officeHoursEnd[i].TimeOfDay.ToString();
                Database.modifyDatabase("INSERT INTO OfficeHour VALUES(null, '" + officeHoursDays[i][0] + "', '" + officeHoursDays[i][1] + "', '" +
                    officeHoursDays[i][2] + "', '" + officeHoursDays[i][3] + "', '" + officeHoursDays[i][4] + "', TIME('" + startTime + "'), TIME('" +
                    endTime + "'), '" + profID + "');");
            }

            //commit all inserts to database
            Database.commit();

            //clear all arrays after updating database
            phoneNumbers.Clear();
            phoneTypes.Clear();
            officeHoursStart.Clear();
            officeHoursEnd.Clear();
            officeHoursDays.Clear();

            return true;
        }
    }
}
