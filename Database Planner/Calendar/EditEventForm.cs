using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Calendar;

namespace Planner {
    public partial class EditEventForm : Form {

        //store ids for the class and events to uniquely identify differnet entities
        private List<int> currentClassId = new List<int>();
        private List<int> allClassId = new List<int>();
        private List<int> eventId = new List<int>();


        //get list of current calendar events to edit and delete from
        private Dictionary<int, Appointment> eventsHash = new Dictionary<int, Appointment>();
        private List<Appointment> calendarEvents = new List<Appointment>();

        public EditEventForm() {
            InitializeComponent();

            //add list of all classes (both past and current) to combo box
            Util.addClasses(cbClassFilter, allClassId, false, true, null, null);   

            //add only current classes for when editing a graded assignment
            Util.addClasses(cbEventClass, currentClassId, true, false, null, null);

            //dynamically add list of possible events to edit
            MySqlDataReader events = Database.executeQuery("SELECT EventID, Title FROM Event ORDER BY Title");
            while (events.Read() == true) {
                eventId.Add(events.GetInt32(0));
                cbEvent.Items.Add(events.GetString(1));
            }
            events.Close();

            //set start and end date pickers to current date
            dtFilterDate.Value = DateTime.Now;
            dtEventStartDate.Value = DateTime.Now;
            dtEventEndDate.Value = DateTime.Now;
        }

        //hash the list of all current appointments in the calendar view indexed
        //  by the event id, which is stored in the appointment note
        public EditEventForm(List<Appointment> calendar) : this() {
            calendarEvents = calendar;
            foreach(Appointment appt in calendar){
                eventsHash.Add(appt.AppointmentId, appt);
            }
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
                dtEventEndDate.Value = dtEventStartDate.Value;
            }
        }

        //event handler for the checkbox that determines whether or not to use the
        //  date as a filter
        private void chkDateFilter_CheckedChanged(object sender, EventArgs e) {
            if (chkDateFilter.Checked == true) {
                dtFilterDate.Enabled = true;              
            }
            else {
                dtFilterDate.Enabled = false;
            }

            //update event list based on changed information
            updateEventList();
        }

        //when the user changes class, retrieve from database updated grade categories
        private void cbEventClass_SelectedIndexChanged(object sender, EventArgs e) {

            //if no class is selected, simply ignore
            if (cbEventClass.Text.Equals("")) {
                return;
            }
            
            //dynamically add class grade categories to combo box
            Util.addTypes(cbEventType, currentClassId[cbEventClass.SelectedIndex].ToString(), false, null);
        }

        //when the user changes the event type, determine what grading method is used (points or percentage)
        //  and take the appropriate action (enable/disable total points textbox)
        private void cbEventType_SelectedIndexChanged(object sender, EventArgs e) {
            
            //if no class is selected, simply ignore
            if (cbEventType.Text.Equals("")) {
                return;
            }
            
            //get the grading method currently selected grade category
            object gradingMethod = Database.executeScalarQuery("SELECT GradingMethod FROM GradeCategory WHERE ClassID = '" +
                currentClassId[cbEventClass.SelectedIndex] + "' AND Type = '" + cbEventType.Text + "';");

            //check if grading method is points based
            if (gradingMethod.Equals("Points")) {
                txtEventGradeTotalPoints.Enabled = true;
            }
            else {
                txtEventGradeTotalPoints.Enabled = false;
                //since assignment is a percentage, set total points to 100 (this makes calculating 
                //  overall grade easier later)
                txtEventGradeTotalPoints.Text = "100";
            }
        }

        //update end time to one hour after start time when user changes start time
        private void dtEventStartTime_ValueChanged(object sender, EventArgs e) {
            dtEventEndTime.Value = new DateTime(2000, 1, 1, (dtEventStartTime.Value.Hour + 1) % 24, dtEventStartTime.Value.Minute, 0);
        }
        
        //set end date to current date when user changes start date
        private void dtEventStartDate_ValueChanged(object sender, EventArgs e) {    
            dtEventEndDate.Value = dtEventStartDate.Value;
        }

        //when the user changes the date when that filter is enabled, update
        //  the event list
        private void dtFilterDate_ValueChanged(object sender, EventArgs e) {
            if (chkDateFilter.Checked == true) {
                updateEventList();           
            }
        }

        //a function that updates the list of all events based on the given criteria
        private void updateEventList() {

            //clear all events
            eventId.Clear();
            cbEvent.Items.Clear();

            StringBuilder query = new StringBuilder("SELECT e.EventID, Title FROM Event e");

            if (cbClassFilter.SelectedIndex == -1) {
                query.Append(" LEFT OUTER JOIN GradedAssignment g ON e.EventID = g.EventID");
            }
            else {
                query.Append(" NATURAL JOIN GradedAssignment");
            }

            //convert the date value in the datetimepicker into SQLite format
            string date = Database.getDate(dtFilterDate.Value);
            if (chkDateFilter.Checked == true) {
                query.Append(" WHERE DATETIME('" + date + " 00:00:00') < StartDateTime AND DATETIME('" + date + " 23:59:59') > EndDateTime");
            }

            //determine if a class has been selected
            if (cbClassFilter.SelectedIndex > 0) {
                if(query.ToString().Contains("WHERE")){
                    query.Append(" AND");
                }
                else{
                    query.Append(" WHERE");
                }
                query.Append(" ClassID = '" + allClassId[cbClassFilter.SelectedIndex - 1] + "' ");
            }

            query.Append(" ORDER BY Title");

            //dynamically add list of possible events to edit          
            MySqlDataReader events = Database.executeQuery(query.ToString());
            while (events.Read() == true) {
                eventId.Add(events.GetInt32(0));
                cbEvent.Items.Add(events.GetString(1));
            }
            events.Close();

            //update the save and delete buttons (will disable since no event will be choosen)
            updateButtons();
        }

        //updates the save and delete buttons
        private void updateButtons() {
            //if no event is selected, disable
            if (cbEvent.Text.Equals("")) {
                btnSaveCloseEvent.Enabled = false;
                btnDeleteEvent.Enabled = false;
            }
            //otherwise, enable
            else {
                btnSaveCloseEvent.Enabled = true;
                btnDeleteEvent.Enabled = true;
            }
        }

        public void loadEvent(int eventNum) {
            //dynamically get information about the selected event         
            MySqlDataReader events = Database.executeQuery("SELECT * FROM Event WHERE EventID = '" + eventNum + "';");

            //there should only be one event returned
            while (events.Read() == true) {
                //populate form with information retrieved from database
                txtEventTitle.Text = events.GetString(1);
                txtEventDescription.Text = events.GetValue(2).ToString();
                txtLocation.Text = events.GetValue(3).ToString();
                dtEventStartDate.Value = events.GetDateTime(4);
                dtEventStartTime.Value = events.GetDateTime(4);
                dtEventEndDate.Value = events.GetDateTime(5);
                dtEventEndTime.Value = events.GetDateTime(5);
                chkAllDayEvent.Checked = Convert.ToBoolean(events.GetString(6));
                chkAllDayEvent_CheckedChanged(null, null);
            }
            events.Close();

            //query to get information if a graded assignment
            MySqlDataReader graded = Database.executeQuery("SELECT * FROM GradedAssignment WHERE EventID = '"
                + eventNum + "';");

            //clear the existing grade information
            txtEventGrade.ResetText();
            txtEventGradeTotalPoints.ResetText();

            //get the grade information from the database (there should only be one result row returned)
            if (graded.Read() == true) {
                chkGradedAssignment.Checked = true;
                chkGradedAssignment_CheckedChanged(null, null);

                //set the name and grade information for the event
                txtAssignmentName.Text = graded.GetString(1);
                txtEventGrade.Text = graded.GetValue(2).ToString();
                txtEventGradeTotalPoints.Text = graded.GetValue(3).ToString();

                //set the current class associated with the grade assignment
                cbEventClass.SelectedIndex = currentClassId.IndexOf(graded.GetInt32(4));

                //add possible types to choose from based on current class
                Util.addTypes(cbEventType, currentClassId[cbEventClass.SelectedIndex].ToString(), false, null);

                //set the current event type for the drop down list
                cbEventType.Text = graded.GetString(5);
            }
            else {
                //reset all parts of the graded assignment portion of the event
                chkGradedAssignment.Checked = false;
                chkGradedAssignment_CheckedChanged(null, null);
                txtAssignmentName.ResetText();
                cbEventClass.SelectedIndex = -1;
                cbEventType.SelectedIndex = -1;
            }
            graded.Close();

            //set the selected event to the event with the given id (used if passing in event id
            //  into constructor when an event is double clicked)
            cbEvent.SelectedIndex = eventId.IndexOf(eventNum);

            //update save and delete buttons (will now be enabled since we have selected an event)
            updateButtons();

        }

        //a method for when an event is selected
        private void cbEvent_SelectedIndexChanged(object sender, EventArgs e) {
            loadEvent(eventId[cbEvent.SelectedIndex]);           
        }

        //updates list of possible events when another class is chosen
        private void cbClassFilter_SelectedIndexChanged(object sender, EventArgs e) {
            updateEventList();
        }

        private bool saveEvent() {
            //current get event id
            int currentEventId = eventId[cbEvent.SelectedIndex];

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
            Database.modifyDatabase("UPDATE Event SET Title = " + Util.quote(txtEventTitle.Text) + ", Description = " +
                Util.quote(txtEventDescription.Text) + ", Location = " + Util.quote(txtLocation.Text) + ", StartDateTime = DATETIME('" + startDate + " " + dtEventStartTime.Value.TimeOfDay + "'), EndDateTime = DATETIME('" +
                endDate + " " + dtEventEndTime.Value.TimeOfDay + "'), IsAllDay = '" + chkAllDayEvent.Checked + "' "
                + " WHERE EventID = '" + currentEventId + "';");



            //check if the event is a graded assignment
            if (chkGradedAssignment.Checked == true) {

                //ensure a valid assignment name has been entered
                if (txtAssignmentName.Equals("") == true) {
                    Util.displayRequiredFieldsError("Assignment Name");
                    Database.abort();
                    return false;
                }

                double grade = Double.MaxValue;
                double gradeTotal = Double.MaxValue;

                //if a graded assignment, force user to select class and category
                if (cbEventClass.Text.Equals("") || cbEventType.Text.Equals("")) {
                    Util.displayError("Please select a value for both the class and assignment type", "Error");
                    Database.abort();
                    return false;
                }

                //check that grade and total points are valid number (note that the grade can be empty)
                if ((txtEventGrade.Text.Equals("") == false && double.TryParse(txtEventGrade.Text, out grade) == false) || (txtEventGradeTotalPoints.Text.Equals("") == false && double.TryParse(txtEventGradeTotalPoints.Text, out gradeTotal) == false)) {
                    Util.displayError("Grade and Total Points must be valid decimal numbers", "Invalid Number");
                    Database.abort();
                    return false;
                }

                //ensure grade and total points are positive
                if (grade < 0 || gradeTotal < 0) {
                    Util.displayError("Grade and Total Points must be positive", "Error");
                    Database.abort();
                    return false;
                }

                //if the graded assignment already exists, simply update database
                if (Database.attributeExists("EventID = '" + currentEventId + "'", "GradedAssignment") == true) {
                    //add event details to database including all grade information
                    Database.modifyDatabase("UPDATE GradedAssignment SET AssignmentName = " + Util.quote(txtAssignmentName.Text) +
                       ", Grade = " + Util.quote(txtEventGrade.Text) + ", GradeTotalWorth = " + Util.quote(txtEventGradeTotalPoints.Text) + ", ClassId = '" + currentClassId[cbEventClass.SelectedIndex] + "', Type = '" + cbEventType.Text + "' " +
                       "WHERE EventID = '" + currentEventId + "';");
                }
                //otherwise insert into database
                else {
                    //add event details to database including all grade information
                    Database.modifyDatabase("INSERT INTO GradedAssignment VALUES ('" + currentEventId + "', " + Util.quote(txtAssignmentName.Text) +
                       ", " + Util.quote(txtEventGrade.Text) + ", " + Util.quote(txtEventGradeTotalPoints.Text) + ", '" + currentClassId[cbEventClass.SelectedIndex] + "', '" + cbEventType.Text + "');");
                }
            }
            else {
                //delete graded assignment portion of event
                Database.modifyDatabase("DELETE FROM GradedAssignment WHERE EventID = '" + currentEventId + "';");
            }

            //get event in calendar that has the specified event id
            bool containsEvent = eventsHash.ContainsKey(currentEventId);
            Appointment appt;
            if (containsEvent == true) {
                appt = eventsHash[currentEventId];
            }
            else {
                appt = new Appointment();
            }

            //update appointment information
            appt.StartDate = new DateTime(dtEventStartDate.Value.Year, dtEventStartDate.Value.Month, dtEventStartDate.Value.Day, dtEventStartTime.Value.Hour, dtEventStartTime.Value.Minute, 0);
            appt.EndDate = new DateTime(dtEventEndDate.Value.Year, dtEventEndDate.Value.Month, dtEventEndDate.Value.Day, dtEventEndTime.Value.Hour, dtEventEndTime.Value.Minute, 0);
            appt.Subject = txtEventTitle.Text;
            appt.Note = txtEventDescription.Text;
            appt.Location = txtLocation.Text;
            appt.Color = Color.Honeydew;

            //determine whether event is an all day event and update appointment
            if (chkAllDayEvent.Checked == true) {
                appt.AllDayEvent = true;
                appt.EndDate = appt.EndDate.AddDays(1);
                appt.Color = Color.Coral;
            }
            else if (chkGradedAssignment.Checked == true) {
                appt.AllDayEvent = false;
                appt.Color = AssignmentPlanner.classColors[currentClassId[cbEventClass.SelectedIndex] % AssignmentPlanner.classColors.Length];
            }
            else {
                appt.AllDayEvent = false;
            }

            if (PlannerSettings.Default.SyncEvents == true) {
                GoogleCalendarSync.updateEvent(appt);
            }

            //commit changes to database (end transaction)
            Database.commit();

            return true;
        }


        //save event and then close the form
        private void btnSaveCloseEvent_Click(object sender, EventArgs e) {
            if (saveEvent() == true) {
                displayMessage("Event Information Saved Successfully", Color.DarkGreen);
            }
            else {
                displayMessage("Error Saving Event Information", Color.DarkRed);
            }           
        }

        //close the form without saving
        private void btnCloseEvent_Click(object sender, EventArgs e) {
            Close();
        }

        //button to delete event from database
        private void btnDeleteEvent_Click(object sender, EventArgs e) {
            //display confirmation message
            DialogResult reallyDelete = MessageBox.Show("Are you sure you really want to delete this event?", "Really Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reallyDelete == DialogResult.Yes) {
                //delete from database
                Database.modifyDatabase("DELETE FROM Event WHERE EventID = '" + eventId[cbEvent.SelectedIndex] + "';");

                if (PlannerSettings.Default.SyncEvents == true) {
                    GoogleCalendarSync.deleteEvent(eventsHash[eventId[cbEvent.SelectedIndex]]);
                }

                //ensure associated google event information tied to this event is removed
                GoogleCalendarSync.deleteEventID(eventId[cbEvent.SelectedIndex]);

                //remove from calendar view
                calendarEvents.Remove(eventsHash[eventId[cbEvent.SelectedIndex]]);

                //close form if deleting event
                Close();
            }
        }

        //display message for specified period of time using given text and color
        private void displayMessage(string text, Color color) {
            timer1.Stop();
            timer1.Start();
            lblSaveStatus.Text = text;
            lblSaveStatus.ForeColor = color;
        }

        //on first timer tick, clear the save status label and stop the timer
        private void timer1_Tick_1(object sender, EventArgs e) {
            lblSaveStatus.Text = "";
            timer1.Stop();
        }

        //when the end date is changed, if the difference between the start and end dates span multiple days, automatically
        //  check the checkbox to indicate an all day event
        private void dtEventEndDate_ValueChanged(object sender, EventArgs e) {
            if (dtEventEndDate.Value.DayOfYear != dtEventStartDate.Value.DayOfYear) {
                chkAllDayEvent.Checked = true;
                chkAllDayEvent_CheckedChanged(null, null);
            }
        }

        private void lnkClearClassFilter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            cbClassFilter.SelectedIndex = -1;
        }

    }
}
