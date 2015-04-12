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
    public partial class EditClassForm : Form
    {
        //common variables for keeping track of the currently
        //  selected profId or classId
        private List<int> profId = new List<int>();
        private List<int> profFilterId = new List<int>();
        private List<int> classId = new List<int>();
        private List<int> semesterId = new List<int>();
        private List<int> semesterFilterId = new List<int>();
        private int currentClassId = -1;

        //used to indicate whether a class currently has a prof assigned 
        //  (used to determine whether to insert into or update database)
        private bool classHasProf = false;
        
        public EditClassForm()
        {
            InitializeComponent();

            Util.addProfessors(cbEditClassProfessorFilter, profFilterId, false, true, null, null);
            Util.addProfessors(cbClassProfessor, profId, false, false, null, null);
            

            Util.addClasses(cbEditClass, classId, false, false, null, null);
            Util.addSemesters(cbSemester, semesterId, false);
            Util.addSemesters(cbEditClassSemesterFilter, semesterFilterId, true);
        }


        //determines what action to take if class is finished
        private void chkClassFinished_CheckedChanged(object sender, EventArgs e) {
            //if class is finished, enable final letter grade drop down list
            if (chkClassFinished.Checked == true) {
                cbFinalLetterGrade.Enabled = true;
            }
            else {
                cbFinalLetterGrade.Enabled = false;
            }
        }

        //move to edit grading scale tab and resize form
        private void lnkGradingScale_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            
        }

        //method to update the list of the classes in the drop down list using the choosen professor
        private void cbEditClassFilter_SelectedIndexChanged(object sender, EventArgs e) {
            string profID = cbEditClassProfessorFilter.SelectedIndex > 0 ?  profFilterId[cbEditClassProfessorFilter.SelectedIndex - 1].ToString() : null;
            string semesterID = cbEditClassSemesterFilter.SelectedIndex > 0 ? semesterFilterId[cbEditClassSemesterFilter.SelectedIndex - 1].ToString() : null;
            Util.addClasses(cbEditClass, classId, false, false, profID, semesterID);

            //update buttons and links (will most likely disable)
            updateClassButtons();
        }

        //updates class buttons
        private void updateClassButtons() {
            //no no class is selected, disable ability to save, delete, edit grading
            //  scale, and edit grading categories
            if (cbEditClass.Text.Equals("")) {
                btnSaveClass.Enabled = false;
                btnDeleteClass.Enabled = false;
                lnkEditGradingScale.Enabled = false;
                lnkEditGradingCategories.Enabled = false;
            }
            else {
                btnSaveClass.Enabled = true;
                btnDeleteClass.Enabled = true;
                lnkEditGradingScale.Enabled = true;
                lnkEditGradingCategories.Enabled = true;
            }
        }

        //method for when the selected class changes
        private void cbEditClass_SelectedIndexChanged(object sender, EventArgs e) {
            //updates buttons and links (will most likely enable)
            updateClassButtons();

            //get current class id
            currentClassId = classId[cbEditClass.SelectedIndex];

            //database supports multiple professors but this application only supports a single professor per class
            MySqlDataReader classProf = Database.executeQuery("SELECT ProfID FROM ClassProfessor WHERE ClassID = '" + currentClassId + "';");

            //read single result
            if (classProf.Read() == true) {
                int classProfId = classProf.GetInt32(0);
                cbClassProfessor.SelectedIndex = profId.IndexOf(classProfId);
                classHasProf = true;
            }
            else {
                classHasProf = false;
                cbClassProfessor.SelectedIndex = -1;
            }
            classProf.Close();

            //dynamically populate class information
            MySqlDataReader selectedClass = Database.executeQuery("SELECT * FROM Class WHERE ClassID = '" + currentClassId + "';");

            //only one item should be returned
            if (selectedClass.Read() == true) {
                //populate form with information from database
                txtClassName.Text = selectedClass.GetString(1);
                ctrCredits.Value = selectedClass.GetDecimal(2);
                chkClassMonday.Checked = Convert.ToBoolean(selectedClass.GetString(3));
                chkClassTuesday.Checked = Convert.ToBoolean(selectedClass.GetString(4));
                chkClassWednesday.Checked = Convert.ToBoolean(selectedClass.GetString(5));
                chkClassThursday.Checked = Convert.ToBoolean(selectedClass.GetString(6));
                chkClassFriday.Checked = Convert.ToBoolean(selectedClass.GetString(7));

                //load semester if not null
                if (selectedClass.IsDBNull(8) == false) {
                    cbSemester.SelectedIndex = semesterId.IndexOf(selectedClass.GetInt32(8));
                }
                else {
                    cbSemester.SelectedIndex = -1;
                }

                dtClassStartTime.Value = selectedClass.GetDateTime(9);
                dtClassEndTime.Value = selectedClass.GetDateTime(10);

                //class location
                txtClassLocation.Text = selectedClass.GetValue(11).ToString();

                //dynamically add letter grades to drop down list
                MySqlDataReader letterGrades = Database.executeQuery("SELECT GradeLetter FROM GradingScaleValue WHERE ClassID ='" + currentClassId + "' ORDER BY BottomPercentage DESC;");
                cbFinalLetterGrade.Items.Clear();
                while (letterGrades.Read() == true) {
                    cbFinalLetterGrade.Items.Add(letterGrades.GetString(0));
                }
                letterGrades.Close();

                //determine whether the final letter grade is null (if it is, assume the class
                //  is not finished)
                if (selectedClass.IsDBNull(14) == false) {
                    chkClassFinished.Checked = true;
                    cbFinalLetterGrade.Text = selectedClass.GetString(14);
                }
                else {
                    chkClassFinished.Checked = false;
                    cbFinalLetterGrade.SelectedIndex = -1;
                }
            }
            selectedClass.Close();
        }

        //update end time to one hour after start time when user changes start time
        private void dtClassStartTime_ValueChanged(object sender, EventArgs e) {
            dtClassEndTime.Value = new DateTime(2000, 1, 1, (dtClassStartTime.Value.Hour + 1) % 24, dtClassStartTime.Value.Minute % 60, 0);
        }

        //event handler for whether the class is finished
        private void chkClassFinished_CheckedChanged_1(object sender, EventArgs e) {
            //if class is finished allow user to enter final grade
            if (chkClassFinished.Checked == true) {
                cbFinalLetterGrade.Enabled = true;
            }
            else {
                cbFinalLetterGrade.Enabled = false;
                cbFinalLetterGrade.SelectedIndex = -1;
            }
        }

        //closes form without saving
        private void btnCloseClose_Click(object sender, EventArgs e) {
            Close();
        }

        //deletes a class from the database (will also delete any events associated with given class)
        private void btnDeleteClass_Click(object sender, EventArgs e) {
            //display confirmation
            DialogResult reallyDelete = MessageBox.Show("Are you sure you really want to delete this class? This will also delete "
                + "all events associated with this class.", "Really Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reallyDelete == DialogResult.Yes) {
                //delete from database
                Database.modifyDatabase("DELETE FROM Class WHERE ClassID = '" + currentClassId + "';");
                Close();
            }
        }

        private bool SaveClass() {
            //ensure at least one day is checked
            if (txtClassName.Text.Equals("") || (chkClassMonday.Checked == false && chkClassTuesday.Checked == false &&
                chkClassWednesday.Checked == false && chkClassThursday.Checked == false && chkClassFriday.Checked == false) ||
                (chkClassFinished.Checked == true && cbFinalLetterGrade.Text.Equals(""))) {
                Util.displayRequiredFieldsError(new string[] { "Class Name", "Days" });               
                return false;
            }

            //ensure start and end times are legal
            if (dtClassStartTime.Value.TimeOfDay > dtClassEndTime.Value.TimeOfDay) {
                Util.displayError("Invalid Start and End Times", "Error");
                return false;
            }

            //check that a valid letter grade has been entered
            if (chkClassFinished.Checked == true) {
                //make sure user has selected a value
                if (cbFinalLetterGrade.Equals("")) {
                    Util.displayError("Please select a valid letter grade for the class", "Invalid Letter Grade");
                    return false;
                }
            }
            else {
                object attr = Database.executeScalarQuery("SELECT Type FROM GradeCategory WHERE ClassID = '" + currentClassId + "'");
                if (attr == null && chkClassFinished.Checked == false) {
                    Util.displayRequiredFieldsError("Grading Categories");
                    return false;
                }
            }

            //check if a semester has been selected
            string semesterIdValue = "null";
            if (cbSemester.SelectedIndex >= 0) {
                semesterIdValue = "'" + semesterId[cbSemester.SelectedIndex] + "'";
            }

            //begin the database transaction
            Database.beginTransaction();
            Database.modifyDatabase("UPDATE Class SET Name = " + Util.quote(txtClassName.Text) + ", Credits = '" + ctrCredits.Value
                + "', OnMonday = '" + chkClassMonday.Checked + "', OnTuesday = '" + chkClassTuesday.Checked + "', OnWednesday = '" + chkClassWednesday.Checked
                + "', OnThursday = '" + chkClassThursday.Checked + "', OnFriday = '" + chkClassFriday.Checked + "', SemesterID = " + semesterIdValue
                + ", StartTime = TIME('" + dtClassStartTime.Value.TimeOfDay + "'), EndTime = TIME('"
                + dtClassEndTime.Value.TimeOfDay + "'), Location = " + Util.quote(txtClassLocation.Text)
                + ", FinalLetterGrade = " + Util.quote(cbFinalLetterGrade.Text) + " WHERE ClassID = '" + currentClassId + "';");

            //insert into database or update the class professor assignment
            if (cbClassProfessor.Text.Equals("") == false) {
                
                //if the assignment has not been already created
                if (classHasProf == false) {
                    Database.modifyDatabase("INSERT INTO ClassProfessor VALUES('" + profId[cbClassProfessor.SelectedIndex] + "', '" + currentClassId + "');");
                    classHasProf = true;
                }
                //else update the database
                else {
                    Database.modifyDatabase("UPDATE ClassProfessor SET ProfID = '" + profId[cbClassProfessor.SelectedIndex] + "' WHERE ClassID = '" + currentClassId + "';");
                }
            }

            //commit all inserts to database
            Database.commit();
            return true;
        }

        //save the class information
        private void btnSaveClass_Click(object sender, EventArgs e) {
            if (SaveClass() == true) {
                displayMessage("Class Information Successfully Saved", Color.DarkGreen);
            }
            else {
                displayMessage("Error Saving Class Information", Color.DarkRed);
            }
        }

        //display a message for the specified amount of time given the text and color
        private void displayMessage(string text, Color color) {
            timer1.Stop();
            timer1.Start();
            lblSaveStatus.Text = text;
            lblSaveStatus.ForeColor = color;
        }

        //clear the save status message once the first timer tick and stop the timer
        private void timer1_Tick(object sender, EventArgs e) {
            lblSaveStatus.Text = "";
            timer1.Stop();
        }

        //show the edit grading scale form (changes will be saved on that form so no action needs
        //  to be taken once the form is closed)
        private void lnkEditGradingScale_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            EditGradingScaleForm form = new EditGradingScaleForm(currentClassId);
            form.ShowDialog();
        }

        //show the edit grading categories form (changes will be saved on that form so no action needs
        //  to be taken once the form is closed)
        private void lnkEditGradingCategories_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            EditGradeCategoriesForm form = new EditGradeCategoriesForm(currentClassId);
            form.ShowDialog();
        }

        private void cbEditClassSemesterFilter_SelectedIndexChanged(object sender, EventArgs e) {
            string profID = cbEditClassProfessorFilter.SelectedIndex > 0 ? profFilterId[cbEditClassProfessorFilter.SelectedIndex - 1].ToString() : null;
            string semesterID = cbEditClassSemesterFilter.SelectedIndex > 0 ? semesterFilterId[cbEditClassSemesterFilter.SelectedIndex - 1].ToString() : null;
            Util.addClasses(cbEditClass, classId, false, false, profID, semesterID);
            Util.addProfessors(cbEditClassProfessorFilter, profFilterId, false, true, null, semesterID);

            //update buttons and links (will most likely disable)
            updateClassButtons();
        }
    }
}
