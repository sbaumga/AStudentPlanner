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
    public partial class EditProfessorForm : Form
    {
        //common variables for keeping track of the currently
        //  selected profId or classId
        private List<int> profId = new List<int>();
        private List<int> classId = new List<int>();
        private int currentProfId = -1;
        private int currentClassId = -1;

        public EditProfessorForm()
        {
            InitializeComponent();

            //dynamically add classes to combo box while storing class id's associated with class name
            Util.addClasses(cbEditProfessorFilter, classId, false, true, null, null);

            //dynamically add profs to combo box while storing prof id's associated with prof information
            Util.addProfessors(cbEditProfessor, profId, true, false, null, null);
        }

        //move to add phone numbers tab and resize form
        private void lnkEditPhoneNum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            EditPhoneNumberForm form = new EditPhoneNumberForm(currentProfId);
            form.ShowDialog();
        }

        //move to office hours tab and resize form
        private void lnkEditOfficeHours_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            EditOfficeHoursForm form = new EditOfficeHoursForm(currentProfId);
            form.ShowDialog();
        }

        //method to update buttons (enable/disable) when editing a professor (a professor
        //  must be currently selected in order to be able to save, delete, edit phone numbers,
        //  or edit office hours)
        private void updateProfessorButtons() {
            //checks if any professor has been selected
            if (cbEditProfessor.Text.Equals("")) {
                btnSaveProfessor.Enabled = false;
                btnDeleteProfessor.Enabled = false;
                lnkEditPhoneNum.Enabled = false;
                lnkEditOfficeHours.Enabled = false;
            }
            else {
                btnSaveProfessor.Enabled = true;
                btnDeleteProfessor.Enabled = true;
                lnkEditPhoneNum.Enabled = true;
                lnkEditOfficeHours.Enabled = true;
            }
        }

        //populates professor information upon selecting a professor from the drop down
        //  list of available professors to choose
        private void cbEditProfessor_SelectedIndexChanged(object sender, EventArgs e) {


            //update the buttons (enable all buttons and links) and clear message status
            updateProfessorButtons();
            lblSaveStatus.Text = "";

            //get the current profId
            currentProfId = profId[cbEditProfessor.SelectedIndex];

            //dynamically populate professor information
            SQLiteDataReader selectedProf = Database.executeQuery("SELECT * FROM Professor WHERE ProfID = '" + currentProfId + "';");

            //only one item should be returned
            if (selectedProf.Read() == true) {
                //check whether the non-required fields are null, and if they are not, then populate
                //  the information on the form

                //professor title
                txtProfessorTitle.Text = selectedProf.GetValue(1).ToString();

                //professor first name
                txtProfessorFName.Text = selectedProf.GetValue(2).ToString();

                //field is required, so we don't need to check if it is null
                txtProfessorLName.Text = selectedProf.GetString(3);

                //professor email
                txtProfessorEmail.Text = selectedProf.GetValue(4).ToString();

                //professor office location
                txtProfessorOfficeLoc.Text = selectedProf.GetValue(5).ToString();

            }
            selectedProf.Close();
        }

        //method to delete currently selected professor
        private void btnDeleteProfessor_Click(object sender, EventArgs e) {         
            //display confirmation message
            DialogResult reallyDelete = MessageBox.Show("Are you sure you really want to delete this professor?", "Really Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reallyDelete == DialogResult.Yes) {
                //delete from database
                Database.modifyDatabase("DELETE FROM Professor WHERE ProfID = '" + profId[cbEditProfessor.SelectedIndex] + "';");
                Close();
            }
        }

        //method for when the professor filter (selecting a class) drop down list is changed
        private void cbEditProfessorFilter_SelectedIndexChanged(object sender, EventArgs e) {
            if (cbEditProfessorFilter.SelectedIndex > 0) {
                currentClassId = classId[cbEditProfessorFilter.SelectedIndex - 1];
                Util.addProfessors(cbEditProfessor, profId, true, false, currentClassId.ToString(), null);
            }
            else {
                Util.addProfessors(cbEditProfessor, profId, true, false, null, null);
            }

            //update buttons (will disable buttons and links since drop down list of professors will
            //  be repopulated) as well as clear message status
            lblSaveStatus.Text = "";
            updateProfessorButtons();
        }

        //closes professor form without saving
        private void btnCloseProfessor_Click(object sender, EventArgs e) {
            Close();
        }

        //saves professor information to the database
        private void btnSaveProfessor_Click(object sender, EventArgs e) {
            //ensure user has entered a last name (a required field)
            if (txtProfessorLName.Text.Equals("")) {
                Util.displayRequiredFieldsError("Last Name");
                displayMessage("Error Saving Professor Information", Color.DarkRed);
                return;
            }

            //update the professor fields in the database
            Database.modifyDatabase("UPDATE Professor SET Title = " + Util.quote(txtProfessorTitle.Text) + ", FirstName = " + Util.quote(txtProfessorFName.Text)
                + ", LastName = " + Util.quote(txtProfessorLName.Text) + ", Email = " + Util.quote(txtProfessorEmail.Text) + ", OfficeLocation = " + Util.quote(txtProfessorOfficeLoc.Text) + " "
                + "WHERE ProfID = '" + profId[cbEditProfessor.SelectedIndex] + "';");

            displayMessage("Professor Information Successfully Saved", Color.DarkGreen);
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

    }
}
