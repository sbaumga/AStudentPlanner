using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Calendar;

namespace Planner {
    public partial class AddEventForm : Form {

        //store the list of class ids
        private List<int> classId = new List<int>();

        //create a member variable for the appointment in the calendar view
        Appointment newAppt = null;
        
        public AddEventForm() {
            InitializeComponent();

            //dynamically add classes to combo box while storing class id's associated with class name
            Util.addClasses(cbEventClass, classId, true, false, null, null);

            //set start and end date pickers to current date
            dtEventStartDate.Value = DateTime.Now;
            dtEventEndDate.Value = DateTime.Now;
        }

        //method set the start date from another form
        public void setStartDate(DateTime date){
            dtEventStartDate.Value = date.Date;
            dtEventEndDate.Value = date.Date;
        }

        //method to set the start time from another form
        public void setStartTime(DateTime time) {
            dtEventStartTime.Value = time;
            dtEventEndTime.Value = time.AddHours(1);
        }

        //get the information from the saved event once the form is closed
        public Appointment getnewEvent() {
            return newAppt;
        }

        //event handler for when graded assignment checkbox is changed
        private void chkGradedAssignment_CheckedChanged(object sender, EventArgs e) {
            if (chkGradedAssignment.Checked == true) {
                eventInfoPanel.Enabled = true;
            }
            else {
                //do not allow user to change grade information if not a
                //  graded assignment
                eventInfoPanel.Enabled = false;
            }
        }

        //event handler for when the all day checkbox is changed
        private void chkAllDayEvent_CheckedChanged(object sender, EventArgs e) {
            //if it is an all day event, we don't care about the end date, so disable it
            if (chkAllDayEvent.Checked == true) {
                dtEventStartTime.Enabled = false;
                dtEventEndTime.Enabled = false;
            }
            else {
                dtEventStartTime.Enabled = true;
                dtEventEndTime.Enabled = true;

                //set the end date to the start date if not an all day event
                dtEventEndDate.Value = dtEventStartDate.Value;
            }
        }

        //close form without saving
        private void btnCloseEvent_Click(object sender, EventArgs e) {
            Close();
        }

        private bool saveEvent() {
            //ensure user entered a title since it is a required field
            if (txtEventTitle.Text.Equals("") == true) {
                Util.displayRequiredFieldsError("Event Title");
                return false;
            }

            //ensure start time is not later than end time (note this does not apply if an all day event)
            if (chkAllDayEvent.Checked == false && dtEventStartTime.Value.TimeOfDay > dtEventEndTime.Value.TimeOfDay) {
                Util.displayError("Invalid Start and End Times", "Error");
                return false;
            }

            //ensure start date is not later than end date (note this does not apply if an all day event)
            if (chkAllDayEvent.Checked == false && dtEventStartDate.Value > dtEventEndDate.Value) {
                Util.displayError("Invalid Start and End Dates", "Error");
                return false;
            }

            //get date in SQLite format
            string startDate = Database.getDate(dtEventStartDate.Value);
            string endDate = Database.getDate(dtEventEndDate.Value);

            //begin transaction
            Database.beginTransaction();

            //add basic event details database
            Database.modifyDatabase("INSERT INTO Event VALUES (null, " + Util.quote(txtEventTitle.Text) + ", " +
                Util.quote(txtEventDescription.Text) + ", " + Util.quote(txtLocation.Text) + ", DATETIME('" + startDate + " " + dtEventStartTime.Value.TimeOfDay + "'), DATETIME('" +
                endDate + " " + dtEventEndTime.Value.TimeOfDay + "'), '" + chkAllDayEvent.Checked + "', null);");

            //check if the event is a graded assignment
            if (chkGradedAssignment.Checked == true) {

                //get id of recently inserted event
                object eventID = Database.getInsertedID();

                double grade = Double.MaxValue;
                double gradeTotal = Double.MaxValue;

                //ensure an assignment name was given
                if (txtAssignmentName.Text.Equals("")) {
                    Util.displayRequiredFieldsError("Assignment Name");
                    return false;
                }

                //if a graded assignment, force user to select class and category
                if (cbEventClass.Text.Equals("") || cbEventType.Text.Equals("")) {
                    Util.displayError("Please select a value for both the class and assignment type", "Error");
                    return false;
                }

                //check that grade and total points are valid number (note that the grade can be empty)
                if ((txtEventGrade.Text.Equals("") == false && double.TryParse(txtEventGrade.Text, out grade) == false) || (txtEventGradeTotalPoints.Text.Equals("") == false && double.TryParse(txtEventGradeTotalPoints.Text, out gradeTotal) == false)) {
                    Util.displayError("Grade and Total Points must be valid decimal numbers", "Invalid Number");
                    return false;
                }

                //ensure grade and total points are positive
                if (grade < 0 || gradeTotal < 0) {
                    Util.displayError("Grade and Total Points must be positive", "Error");
                    return false;
                }

                //if the grade was an empty string, we need to insert null in the database; otherwise add
                //  user specified value
                string gradeVal = "null";
                if (txtEventGrade.Text.Equals("") == false) {
                    gradeVal = "'" + grade + "'";
                }

                //if the grade total was an empty string, we need to insert null into the database
                string gradeTotalVal = "null";
                if (txtEventGradeTotalPoints.Text.Equals("") == false) {
                    gradeTotalVal = "'" + gradeTotal + "'";
                }

                //add event details to database including all grade information
                Database.modifyDatabase("INSERT INTO GradedAssignment VALUES ('" + eventID + "', " + Util.quote(txtAssignmentName.Text) +
                   ", " + gradeVal + ", " + gradeTotalVal + ", '" + classId[cbEventClass.SelectedIndex] + "', '" + cbEventType.Text + "');");
            }

            //add event to calendar view
            newAppt = new Appointment();
            newAppt.StartDate = new DateTime(dtEventStartDate.Value.Year, dtEventStartDate.Value.Month, dtEventStartDate.Value.Day, dtEventStartTime.Value.Hour, dtEventStartTime.Value.Minute, 0);
            newAppt.EndDate = new DateTime(dtEventEndDate.Value.Year, dtEventEndDate.Value.Month, dtEventEndDate.Value.Day, dtEventEndTime.Value.Hour, dtEventEndTime.Value.Minute, 0);
            newAppt.Subject = txtEventTitle.Text;
            newAppt.Note = txtEventDescription.Text;
            newAppt.Location = txtLocation.Text;
            newAppt.AppointmentId = int.Parse(Database.getInsertedID().ToString()); //store unique event id in calendar appointment note
            newAppt.Color = Color.Honeydew;
            newAppt.BorderColor = Color.DarkBlue;
            if (chkAllDayEvent.Checked == true) {
                newAppt.AllDayEvent = true;
                newAppt.EndDate = newAppt.EndDate.AddDays(1);
                newAppt.Color = Color.Coral;
            }

            else if (chkGradedAssignment.Checked == true) {
                newAppt.Color = AssignmentPlanner.classColors[classId[cbEventClass.SelectedIndex] % AssignmentPlanner.classColors.Length];
            }

            if (PlannerSettings.Default.SyncEvents == true) {
                GoogleCalendarSync.addEvent(newAppt);
            }

            return true;
        }

        //save event and then close the form
        private void btnSaveCloseEvent_Click(object sender, EventArgs e) {
            if (saveEvent() == true) {
                //commit changes to database (end transaction)
                Database.commit();
                Close();
            }
            else {
                Database.abort();
            }
        }

        //when the user changes the event type, determine what grading method is used (points or percentage)
        //  and take the appropriate action (enable/disable total points textbox)
        private void cbEventType_SelectedIndexChanged(object sender, EventArgs e) {
               object gradingMethod = Database.executeScalarQuery("SELECT GradingMethod FROM GradeCategory WHERE ClassID = '" +
                   classId[cbEventClass.SelectedIndex] + "' AND Type = '" + cbEventType.Text + "';");

                //check if grading method is points based
                if (gradingMethod.Equals("Points")){
                    txtEventGradeTotalPoints.Text = "";
                    txtEventGradeTotalPoints.Enabled = true;
                }
                else {
                    txtEventGradeTotalPoints.Enabled = false;
                    //since assignment is a percentage, set total points to 100 (this makes calculating 
                    //  overall grade easier later)
                    txtEventGradeTotalPoints.Text = "100";
                }
        }

        //when the user changes class, retrieve from database updated grade categories
        private void cbEventClass_SelectedIndexChanged(object sender, EventArgs e) {
            Util.addTypes(cbEventType, classId[cbEventClass.SelectedIndex].ToString(), false, null);
        }

        private void dtEventStartTime_ValueChanged(object sender, EventArgs e) {
            //update end time to one hour after start time when user changes start time
            dtEventEndTime.Value = new DateTime(2000, 1, 1, (dtEventStartTime.Value.Hour + 1) % 24, dtEventStartTime.Value.Minute, 0);
        }

        private void dtEventStartDate_ValueChanged(object sender, EventArgs e) {
            //set end date to current date when user changes start date
            dtEventEndDate.Value = dtEventStartDate.Value;
        }

        //when the end date is changed, if the difference between the start and end dates span multiple days, automatically
        //  check the checkbox to indicate an all day event
        private void dtEventEndDate_ValueChanged(object sender, EventArgs e) {
            if (dtEventEndDate.Value.DayOfYear != dtEventStartDate.Value.DayOfYear) {
                chkAllDayEvent.Checked = true;
                chkAllDayEvent_CheckedChanged(null, null);
            }
        }
    }
}
