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
    public partial class AddClassForm : Form
    {
        //grading scale information
        AddGradingScaleForm addGradingScale = new AddGradingScaleForm();
        private decimal[] gradingScale = {93, 90, 87, 83, 80, 77, 73, 70, 67, 63, 60} ;
        private string[] gradeLetter = {"A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-"};

        //add grade category information
        AddGradeCategoriesForm addGradeCategories = new AddGradeCategoriesForm();
        private List<string> categories = new List<string>();
        private List<double> percentages = new List<double>();
        private List<string> methods = new List<string>();

        //list of professors id
        private List<int> profId = new List<int>();
        private List<int> semesterId = new List<int>();

        public AddClassForm()
        {
            InitializeComponent();

            //dynamically add professors to combo box
            Util.addProfessors(cbClassProfessor, profId, false, false, null, null);

            //dynamically add possible grades
            Util.addLetterGrades(cbFinalLetterGrade);

            //dynamically add possible semesters
            Util.addSemesters(cbSemester, semesterId, false);
        }

        //event handler for whether the class is finished
        private void chkClassFinished_CheckedChanged(object sender, EventArgs e) {
            //if class is finished allow user to enter final grade
            if (chkClassFinished.Checked == true) {
                cbFinalLetterGrade.Enabled = true;
            }
            else {
                cbFinalLetterGrade.Enabled = false;
                cbFinalLetterGrade.SelectedIndex = -1;
            }
        }

        //saves the class information, returning true if successful and false if there was an error
        private bool saveClass() {

            //ensure at least one day is checked
            if (txtClassName.Text.Equals("") || (chkClassMonday.Checked == false && chkClassTuesday.Checked == false) &&
                chkClassWednesday.Checked == false && chkClassThursday.Checked == false && chkClassFriday.Checked == false ||
                (chkClassFinished.Checked == true && cbFinalLetterGrade.Text.Equals(""))) {
                Util.displayRequiredFieldsError(new string[] { "Class Name", "Days" });
                return false;
            }

            //grade categories required if class is not finished
            if (chkClassFinished.Checked == false && categories.Count == 0) {
                Util.displayRequiredFieldsError("Grade Categories");
                return false;
            }

            //ensure start and end times are legal
            if (dtClassStartTime.Value.TimeOfDay > dtClassEndTime.Value.TimeOfDay) {
                Util.displayError("Invalid Start and End Times", "Error");
                return false;
            }

            //set current grade to null unless the class is finished, upon which get the entered grade
            string currentGrade = "null";
            if (chkClassFinished.Checked == true) {
                //make sure user has selected a value
                if (cbFinalLetterGrade.Equals("")) {
                    Util.displayError("Please select a valid letter grade for the class", "Invalid Letter Grade");
                    return false;
                }
                currentGrade = "'" + cbFinalLetterGrade.Text + "'";
            }

            //check if a semester has been selected
            string semesterIdValue = "null";
            if (cbSemester.SelectedIndex >= 0) {
                semesterIdValue = "'" + semesterId[cbSemester.SelectedIndex] + "'";
            }

            //begin database transaction
            Database.beginTransaction();
            Database.modifyDatabase("INSERT INTO Class VALUES (null, " + Util.quote(txtClassName.Text) + ", '" + ctrCredits.Value
                + "', '" + chkClassMonday.Checked + "', '" + chkClassTuesday.Checked + "', '" + chkClassWednesday.Checked
                + "', '" + chkClassThursday.Checked + "', '" + chkClassFriday.Checked + "'," + semesterIdValue
                + ", TIME('" + dtClassStartTime.Value.TimeOfDay + "'), TIME('"
                + dtClassEndTime.Value.TimeOfDay + "'), " + Util.quote(txtClassLocation.Text) + ", null, null," + currentGrade + ");");

            //get the id of the value just inserted
            object classID = Database.getInsertedID();

            //insert into database the class professor assignment
            if (cbClassProfessor.SelectedIndex >= 0) {
                Database.modifyDatabase("INSERT INTO ClassProfessor VALUES ('" + profId[cbClassProfessor.SelectedIndex] + "', '" + classID + "');");
            }

            //insert grading scale
            for (int i = 0; i < gradingScale.Length; i++) {
                Database.modifyDatabase("INSERT INTO GradingScaleValue VALUES('" + gradeLetter[i] + "', '" + classID + "', '" + gradingScale[i] + "');");
            }

            //add value for F
            Database.modifyDatabase("INSERT INTO GradingScaleValue VALUES('F', '" + classID + "', '0.00');");

            //insert grade category
            for (int i = 0; i < categories.Count; i++) {
                Database.modifyDatabase("INSERT INTO GradeCategory VALUES('" + categories[i] + "', '" + classID + "', '" +
                    percentages[i] + "', null, '" + methods[i] + "');");
            }

            //commit all inserts to database
            Database.commit();

            //clear all arrays after updating database
            categories.Clear();
            percentages.Clear();
            methods.Clear();

            return true;
        }

        private void btnSaveClass_Click(object sender, EventArgs e) {
            //save class information and close form if successful
            if (saveClass() == true) {
                Close();
            }
        }

        private void btnCloseClass_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnAddAnotherClass_Click(object sender, EventArgs e) {
            //reset form to default values if save was successful
            if (saveClass() == true) {
                txtClassName.ResetText();
                cbClassProfessor.SelectedIndex = -1;
                ctrCredits.Value = 0;
                chkClassMonday.Checked = false;
                chkClassTuesday.Checked = false;
                chkClassWednesday.Checked = false;
                chkClassThursday.Checked = false;
                chkClassFriday.Checked = false;
                txtClassLocation.ResetText();
                dtClassStartTime.Value = new DateTime(2000, 1, 1, 11, 0, 0);
                dtClassEndTime.Value = new DateTime(2000, 1, 1, 12, 0, 0);
                cbSemester.SelectedIndex = -1;
                cbFinalLetterGrade.SelectedItem = null;
                chkClassFinished.Checked = false;
                lnkAddGradingCategories.Enabled = true;
                addGradingScale = new AddGradingScaleForm();
                addGradeCategories = new AddGradeCategoriesForm();
            }
        }

        private void dtClassStartTime_ValueChanged(object sender, EventArgs e) {
            //update end time to one hour after start time when user changes start time
            dtClassEndTime.Value = new DateTime(2000, 1, 1, (dtClassStartTime.Value.Hour + 1) % 24, dtClassStartTime.Value.Minute % 60, 0);
        }

        private void lnkAddGradingScale_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            //show the grading scale form and once it is closed, get the grading scale information
            addGradingScale.ShowDialog();
            gradingScale = addGradingScale.getGradingScale();
        }

        private void lnkAddGradingCategories_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            //show the grade category form and once it is closed, get the grade category information
            addGradeCategories.ShowDialog();
            categories = addGradeCategories.getCategories();
            percentages = addGradeCategories.getPercentages();
            methods = addGradeCategories.getMethods();
        }

    }
}
