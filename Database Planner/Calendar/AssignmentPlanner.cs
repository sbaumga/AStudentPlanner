using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Calendar;
using System.Runtime.InteropServices;
using System.IO;
using Planner;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Threading;

namespace Planner
{
    public partial class AssignmentPlanner : Form
    {
        //used on multpile tabs to store professor and class ids for items in combo boxes
        private List<int> profId = new List<int>();
        private List<int> classId = new List<int>();

        //list of color to use for class events
        public static Color[] classColors = { Color.PaleVioletRed, Color.MediumOrchid, Color.Yellow, Color.LightGreen, Color.LightSkyBlue, Color.Wheat, Color.Goldenrod, Color.LightYellow, Color.DodgerBlue, Color.LightCoral };

        //determines how many upcoming events to show
        private int numEventsToShow = 3;

        //used for determining grade boundaries
        private List<string> letterGrades = new List<string>(){ "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-" };
        
        //used in editing grades for storing original text
        private string originalLabelText = null;
        private int currentEditIndex = -1;

        //stores the dates for which events have been loaded
        private DateTime eventsLoadedStartDate;
        private DateTime eventsLoadedEndDate;

        //check if datbase has been successfully opened
        private bool isDatabaseOpen = false;

        List<Appointment> calendarEvents = new List<Appointment>();

        public AssignmentPlanner() {
            InitializeComponent();

            rtxtUpcomingAssignments.Clear();
            rtxtCurrentGrades.Clear();
            lblSemesterGpaValue.ResetText();
            lblOverallGpaValue.ResetText();

            this.tsComboBoxDays.Width = 125;

            //set start date of calendar view to the current time
            calendarView.StartDate = DateTime.Now;

            //load all events from previous week and all events in upcoming two weeks
            eventsLoadedStartDate = DateTime.Now.AddDays(-7).Date;
            eventsLoadedEndDate = DateTime.Now.AddDays(14).Date;

            //set up event handlers for calendar view
            calendarView.OnSelectionChanged += new EventHandler<EventArgs>(dayView1_SelectionChanged);
            calendarView.OnResolveAppointments += new EventHandler<ResolveAppointmentsEventArgs>(this.dayView1_ResolveAppointments);

            calendarView.AppointmentSlotHeight = 20;

            //set the default calendar view to 3 days
            tsComboBoxDays.SelectedIndex = 1;
            tabControl1_Resize(null, null);

            //enable rounded corners and shadows
            calendarView.EnableRoundedCorners = true;
            calendarView.EnableShadows = true;

            GoogleCalendarSync.setActiveForm(this);
        }

        //hack to remove visual tabs
        private void tabControl1_Resize(object sender, EventArgs e) {
            Rectangle rect = new Rectangle(
             tabControl1.SelectedTab.Left,
             tabControl1.SelectedTab.Top,
             tabControl1.SelectedTab.Width,
             tabControl1.SelectedTab.Height);
            tabControl1.Region = new System.Drawing.Region(rect);
        }

        //when the entire form is resized, update the tab size information
        private void AssignmentPlanner_SizeChanged(object sender, EventArgs e) {
            tabControl1_Resize(sender, e);
        }

        //when the a tab is resized, update the tab size information
        private void tabPage1_Resize(object sender, EventArgs e) {
            tabControl1_Resize(sender, e);
        }

        //on load, try to connect to database
        private void AssignmentPlanner_Load(object sender, EventArgs e) {

            //check if application directory exists and if not, create it
            Util.createApplicationDirectoryIfNotExists();

            LoginForm loginF = new LoginForm();
            loginF.ShowDialog();

            //create database if it does not already exist
            if (Database.exists() == false) {
                //CreateDatabaseForm createDB = new CreateDatabaseForm();
                //createDB.ShowDialog();
                Database.createDatabase();
                isDatabaseOpen = true;

                AddSemesterForm addSemester = new AddSemesterForm(true);
                addSemester.ShowDialog();

                bool gotoNext = addSemester.gotoAddProfessorPage();
                if (gotoNext == true) {
                    AddProfessorForm addProf = new AddProfessorForm(true);
                    addProf.ShowDialog();
                    gotoNext = addProf.gotoAddClassPage();
                }
                if (gotoNext == true) {
                    AddClassForm addClass = new AddClassForm();
                    addClass.ShowDialog();
                }
            }
            else {
                //try first connecting without a password
                if (Database.connect(null) == false) {

                    //if it fails, prompt the user for a password
                    DatabasePasswordForm dbPasswordForm = new DatabasePasswordForm();
                    dbPasswordForm.ShowDialog();

                    //continue looping while user has entered incorrect password or
                    //  until user quits, which will then terminate the program
                    while (Database.connect(dbPasswordForm.password) == false) {
                        DialogResult retry = MessageBox.Show("Incorrect Database Password. Try Again?", "Incorrect Password", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                        if (retry == DialogResult.Retry) {
                            dbPasswordForm.ShowDialog();
                        }
                        else {
                            Environment.Exit(0);
                        }
                    }

                    //ensure database credentials are not stored in memory
                    dbPasswordForm.eraseCredentials();

                }

                isDatabaseOpen = true;

                if (PlannerSettings.Default.SyncEvents == true) {
                    GoogleCalendarSync.authenticate();
                }
            }

            enableDisableToolStripMenuItem.Checked = PlannerSettings.Default.SyncEvents;

            updateEvents();
            updateGrades();
            updateGPA();
            updateCalendar(eventsLoadedStartDate, eventsLoadedEndDate);

        }

        private void AssignmentPlanner_FormClosing(object sender, FormClosingEventArgs e) {
            //close the database connection when the form is closing
            Database.close();
        }

        public void updateStatus(string status) {
            tslStatus.Text = status;
        }

        #region taskbar

        //button to add an event
        private void tsAddTaskBtn_Click(object sender, EventArgs e) {
            //get the time current selected
            DateTime selectedDateTime = calendarView.SelectionStart;

            //before showing the form, set the start date and time 
            //  for the event if the date is valid
            AddEventForm form = new AddEventForm();
            if (selectedDateTime.Year > 2000) {
                form.setStartDate(selectedDateTime);
                form.setStartTime(selectedDateTime);
            }

            //show the form
            form.ShowDialog();

            //if a new event was saved, update the calendar view as well as the left panel
            Appointment newAppt = form.getnewEvent();
            if (newAppt != null) {
                calendarEvents.Add(newAppt);
                calendarView.Invalidate();
                updateLeftPanel();
            }           
        }

        //button to delete the current selected event
        private void tsDeleteTaskBtn_Click(object sender, EventArgs e) {
            //if no event is selected, do nothing
            if (calendarView.Selection == SelectionType.Appointment) {
                //display confirmation message
                DialogResult reallyDelete = MessageBox.Show("Are you sure you really want to delete this event?", "Really Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (reallyDelete == DialogResult.Yes) {
                    //get the event id from the selected appointments note field
                    string eventID = calendarView.SelectedAppointment.AppointmentId.ToString();

                    //delete from database
                    Database.modifyDatabase("DELETE FROM Event WHERE EventID = '" + eventID + "';");

                    if (PlannerSettings.Default.SyncEvents == true) {
                        GoogleCalendarSync.deleteEvent(calendarView.SelectedAppointment);
                    }


                    //remove item from calendar and update the left panel
                    calendarEvents.Remove(calendarView.SelectedAppointment);
                    calendarView.Invalidate();
                    updateLeftPanel();                   
                }
            }
        }

        //zoom in
        private void toolStripButton1_Click_1(object sender, EventArgs e) {
            if (calendarView.AppointmentSlotHeight < 75) {
                calendarView.AppointmentSlotHeight += 5;
            }
            //already at maximum
            else {
                calendarView.AppointmentSlotHeight = 80;
            }
        }

        //zoom out
        private void toolStripButton2_Click_1(object sender, EventArgs e) {
            if (calendarView.AppointmentSlotHeight > 15) {
                calendarView.AppointmentSlotHeight -= 5;
            }
            //already at minimum
            else {
                calendarView.AppointmentSlotHeight = 10;
            }
        }

        //resets the zoom to the default zoom
        private void tsResetZoomBtn_Click(object sender, EventArgs e) {
            calendarView.AppointmentSlotHeight = 20;
        }

        //launch form to current professors current office hours
        private void tsViewOfficeHoursBtn_Click(object sender, EventArgs e) {
            OfficeHoursForm form = new OfficeHoursForm();
            form.ShowDialog();
        }

        //launch form to view current schedule
        private void tsViewScheduleBtn_Click(object sender, EventArgs e) {
            ScheduleForm form = new ScheduleForm();
            form.ShowDialog();
        }

        //launch finals calculator form
        private void tsFinalsCalcBtn_Click(object sender, EventArgs e) {
            FinalsCalculatorForm form = new FinalsCalculatorForm();
            form.ShowDialog();
        }

        //allow user to change how many days to show on the calendar
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            int daysToShow;
            //numbers correlate to index position in drop down list
            switch (tsComboBoxDays.SelectedIndex) {
                case 0:
                    daysToShow = 1;
                    break;
                case 1:
                    daysToShow = 3;
                    break;
                case 2:
                    daysToShow = 5;
                    break;
                case 3:
                    daysToShow = 7;
                    break;
                default:
                    daysToShow = 3;
                    break;
            }
            //update number of days to show on the calendar view
            calendarView.DaysToShow = daysToShow;
        }

        #endregion

        #region toolstrip

        private void clearDatabaseToolStripMenuItem_Click(object sender, EventArgs e) {
            //display confirmation message
            DialogResult reallyDelete = MessageBox.Show("Are you sure you really want to reset the database? This will erase ALL information, including classes, professors, and events", "Really Reset Database?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (reallyDelete == DialogResult.Yes) {
                Database.close();

                //continue looping until file is unlocked and can be deleted
                while (true) {
                    try {
                        File.Delete(Database.DB_PATH);
                        break;
                    }
                    catch { /* occurs if file is locked */ }
                }

                //remove item from calendar
                calendarEvents.Clear();
                calendarView.Invalidate();
                rtxtCurrentGrades.Clear();
                rtxtUpcomingAssignments.Clear();
                lblOverallGpaValue.ResetText();
                lblSemesterGpaValue.ResetText();

                //show form to create a new database, going the steps of 
                //  also adding any professors and classes
                CreateDatabaseForm createDB = new CreateDatabaseForm();
                createDB.ShowDialog();
                AddProfessorForm addProf = new AddProfessorForm(true);
                addProf.ShowDialog();
                if (addProf.gotoAddClassPage() == true) {
                    AddClassForm addClass = new AddClassForm();
                    addClass.ShowDialog();
                }
                updateLeftPanel();
            }
        }

        private void deleteFinishedEventsToolStripMenuItem_Click(object sender, EventArgs e) {
            //display confirmation message
            DialogResult reallyDelete = MessageBox.Show("Are you sure you really want to delete all finished class events? This will remove all graded assignments and associated grading information for the past events associated with finished classes.", "Really Delete Finished Class Events?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (reallyDelete == DialogResult.Yes) {
                Database.modifyDatabase("DELETE FROM Event WHERE EndDateTime < DATETIME('now', 'localtime') AND EventID IN(SELECT EventID FROM GradedAssignment NATURAL JOIN Class WHERE FinalLetterGrade IS NOT NULL);");
                calendarEvents.Clear();

                //reset calendar view to default settings
                calendarView.StartDate = DateTime.Now;
                eventsLoadedStartDate = DateTime.Now.AddDays(-7).Date;
                eventsLoadedEndDate = DateTime.Now.AddDays(14).Date;
                GoogleCalendarSync.clearEventIDs();
                updateCalendar(eventsLoadedStartDate, eventsLoadedEndDate);
                updateLeftPanel();
            }
        }

        private void deleteFinishedGeneralEventsToolStripMenuItem_Click(object sender, EventArgs e) {
            //display confirmation message
            DialogResult reallyDelete = MessageBox.Show("Are you sure you really want to delete all finished general events? This will not delete any current class assignments or events.", "Really Delete Finished General Events?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (reallyDelete == DialogResult.Yes) {
                Database.modifyDatabase("DELETE FROM Event WHERE EndDateTime < DATETIME('now', 'localtime') AND EventID NOT IN(SELECT EventID FROM GradedAssignment);");
                calendarEvents.Clear();

                //reset calendar view to default settings
                calendarView.StartDate = DateTime.Now;
                eventsLoadedStartDate = DateTime.Now.AddDays(-7).Date;
                eventsLoadedEndDate = DateTime.Now.AddDays(14).Date;
                GoogleCalendarSync.clearEventIDs();
                updateCalendar(eventsLoadedStartDate, eventsLoadedEndDate);
                updateLeftPanel();
            }
        }

        //launch database encryption form
        private void databaseEncryptionToolStripMenuItem_Click(object sender, EventArgs e) {
            DatabaseEncryptionForm form = new DatabaseEncryptionForm();
            form.ShowDialog();
        }

        //exit program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }

        //launch form to add an event
        private void addEventToolStripMenuItem_Click(object sender, EventArgs e) {
            AddEventForm form = new AddEventForm();
            form.ShowDialog();

            //if the user saved the event, add it to the calendar view
            Appointment newAppt = form.getnewEvent();
            if (newAppt != null) {
                calendarEvents.Add(newAppt);
                calendarView.Invalidate();
                updateLeftPanel();
            }
        }

        //launch for to add a semester
        private void addSemesterToolStripMenuItem_Click(object sender, EventArgs e) {
            AddSemesterForm form = new AddSemesterForm();
            form.ShowDialog();
        }

        //launch form to add a class
        private void addClassToolStripMenuItem_Click(object sender, EventArgs e) {
            AddClassForm form = new AddClassForm();
            form.ShowDialog();
            updateLeftPanel();
        }

        //launch form to add a professor
        private void addProfessorToolStripMenuItem_Click(object sender, EventArgs e) {
            AddProfessorForm form = new AddProfessorForm();
            form.ShowDialog();
        }

        //launch form to edit a semester
        private void editSemesterToolStripMenuItem_Click(object sender, EventArgs e) {
            EditSemesterForm form = new EditSemesterForm();
            form.ShowDialog();
        }

        //lauch form to edit a class
        private void editClassToolStripMenuItem_Click(object sender, EventArgs e) {
            EditClassForm form = new EditClassForm();
            form.ShowDialog();
            updateLeftPanel();
        }

        //lauch form to edit a professor
        private void editProfessorToolStripMenuItem_Click(object sender, EventArgs e) {
            EditProfessorForm form = new EditProfessorForm();
            form.ShowDialog();
        }

        //launch form to edit an event
        private void editEventToolStripMenuItem_Click(object sender, EventArgs e) {
            EditEventForm form = new EditEventForm(calendarEvents);
            form.ShowDialog();
            calendarView.Invalidate();
            updateLeftPanel();
        }

        //launch form to contact professor
        private void contactProfessorToolStripMenuItem_Click(object sender, EventArgs e) {
            ContactForm form = new ContactForm(this);
            form.ShowDialog(this);
        }

        //launch form to change mail settings
        private void mailSettingsToolStripMenuItem_Click(object sender, EventArgs e) {
            MailSettingsForm form = new MailSettingsForm();
            form.ShowDialog(this);
        }

        //link for enabling syncing of events with Google calendar
        private void enableCalendarSyncToolStripMenuItem_Click(object sender, EventArgs e) {
            //if syncing of events is enabled
            if (enableDisableToolStripMenuItem.Checked == false) {
                enableDisableToolStripMenuItem.Checked = true;
                PlannerSettings.Default.SyncEvents = true;
                PlannerSettings.Default.Save();
                
                //try to authenticate current stored settings or launch a prompt
                GoogleCalendarSync.authenticate();

            }
            else {
                enableDisableToolStripMenuItem.Checked = false;
                PlannerSettings.Default.SyncEvents = false;
                PlannerSettings.Default.Save();
            }
        }

        //forces reathentication of Google Account information
        private void reauthenticateToolStripMenuItem_Click(object sender, EventArgs e) {
            GoogleCalendarSync.authenticate();
        }

        //link for changing Google Calendar sync settings
        private void googleCalendarSettingsToolStripMenuItem_Click(object sender, EventArgs e) {
            GoogleAccountSettings form = new GoogleAccountSettings();
            form.ShowDialog();
        }

        #endregion

        #region leftPanel

        //dynamically resizes left panel for the upcoming assignments and current grades panels
        public void resizeLeftPanel(double topPerc, double spacePerc, double bottomPerc) {
            int height = container.Height - 40;
            upcomingAssignmentsPanel.Height = (int)(height * topPerc);
            rtxtUpcomingAssignments.Height = upcomingAssignmentsPanel.Height - 20;
            rtxtUpcomingAssignments.Refresh();

            currentGradesPanel.Location = new Point(currentGradesPanel.Location.X, (int)(height * (topPerc + spacePerc)));
            currentGradesPanel.Height = (int)(height * bottomPerc);
            rtxtCurrentGrades.Height = currentGradesPanel.Height - 20;
            gradeInformationPanel.Location = new Point(gradeInformationPanel.Location.X, height);
        }

        //resize the left panel equally diving the upcoming assignments (49%) and the current grades (49%)
        private void container_Resize(object sender, EventArgs e) {
            resizeLeftPanel(0.49, 0.02, 0.49);
        }

        //updates all the information on the left panel of the main application form
        private void updateLeftPanel() {
            updateEvents();
            updateGrades();
            updateGPA();
        }

        //update list of upcoming assignments every minute
        private void upcomingAssignmentsTimer_Tick(object sender, EventArgs e) {
            //ensure database is currently open
            if (isDatabaseOpen == true) {
                updateEvents();
            }
        }

        //update the grades label
        private void updateGrades() {
            rtxtCurrentGrades.Clear();

            //get class information
            SQLiteDataReader classes = Database.executeQuery("SELECT Name, CurrentGrade, CurrentLetterGrade FROM Class WHERE FinalLetterGrade IS NULL ORDER BY Name;");
            while (classes.Read() == true) {
                rtxtCurrentGrades.AppendText(classes.GetString(0) + ": ");
                if (classes.IsDBNull(1) == false) {
                    rtxtCurrentGrades.AppendText(classes.GetDouble(1).ToString("F3") + "% (" + classes.GetString(2) + ")");
                }
                else {
                    rtxtCurrentGrades.AppendText("No Grade");
                }
                //update text box display all the user's current classes and grade for each class
                rtxtCurrentGrades.AppendText("\n");
            }
            classes.Close();
        }

        //update teh GPA label (both semester and overall gpa)
        private void updateGPA() {
            //reset labels
            lblSemesterGpaValue.ResetText();
            lblOverallGpaValue.ResetText();

            double currentCredits = 0;
            double currentPoints = 0;
            //if there are any current classes, get the number of current number of credits and points based on current grade information 
            if (Double.TryParse(Database.executeScalarQuery("SELECT SUM(Credits) From Class WHERE FinalLetterGrade IS NULL ANd CurrentLetterGrade IS NOT NULL;").ToString(), out currentCredits) == true) {
                if(Double.TryParse(Database.executeScalarQuery("SELECT SUM(Credits * Point) FROM Class c JOIN GradeLetterPoint g ON c.CurrentLetterGrade = g.GradeLetter WHERE FinalLetterGrade IS NULL AND CurrentLetterGrade IS NOT NULL;").ToString(), out currentPoints)){
                    lblSemesterGpaValue.Text = (currentPoints / (double)currentCredits).ToString("F4");
                }
            }

            double pastCredits = 0;
            double pastPoints = 0;

            //get the credit and grade information for any past classes
            if (Double.TryParse(Database.executeScalarQuery("SELECT SUM(Credits) FROM Class WHERE FinalLetterGrade IS NOT NULL;").ToString(), out pastCredits) == true) {
                Double.TryParse(Database.executeScalarQuery("SELECT SUM(Credits * Point) FROM Class c JOIN GradeLetterPoint g ON c.FinalLetterGrade = g.GradeLetter WHERE FinalLetterGrade IS NOT NULL;").ToString(), out pastPoints);
            }

            //if there is at least one current or past class, update the overall GPA value
            if (currentPoints != 0 || pastPoints != 0) {
                lblOverallGpaValue.Text = ((currentPoints + pastPoints) / (currentCredits + pastCredits)).ToString("F4");
            }
        }

        //update the list of upcoming events
        private void updateEvents() {
            rtxtUpcomingAssignments.Clear();

            //get event information
            SQLiteDataReader events = Database.executeQuery("SELECT Title, StartDateTime, IsAllDay FROM Event WHERE StartDateTime > DATETIME('now', 'localtime') ORDER BY StartDateTime");
            for (int i = 0; i < numEventsToShow; i++) {
                if (events.Read() == true) {
                    bool allDayEvent = Convert.ToBoolean(events.GetString(2));
                    rtxtUpcomingAssignments.AppendText(events.GetDateTime(1).ToString("dddd, MMMM d"));
                    if (allDayEvent == false) {
                        rtxtUpcomingAssignments.AppendText(events.GetDateTime(1).ToString(", yyyy h:mm tt"));
                    }
                    rtxtUpcomingAssignments.AppendText("\n     " + events.GetString(0));

                    //if not the last event, add new lines
                    if (i != (numEventsToShow - 1)) {
                        rtxtUpcomingAssignments.AppendText("\n\n");
                    }
                }
            }
            events.Close();
        }

        #endregion

        #region calendarViewTab

        //enable calendar options when on appropriate tab
        private void tabViewCalendar_Enter(object sender, EventArgs e) {
            monthCalendar.Enabled = true;
            tsComboBoxDays.Enabled = true;
        }

        //update the tool strip label in the bottom right corner with the date and time of the last selected appointment
        private void dayView1_SelectionChanged(object sender, EventArgs e) {
            if (calendarView.Selection == SelectionType.DateRange) {
                toolStripStatusLabel2.Text = "Selected Date: " + calendarView.SelectionStart.ToString() + " to " + calendarView.SelectionEnd.ToString();
            }
            else if (calendarView.Selection == SelectionType.Appointment) {
                toolStripStatusLabel2.Text = "Selected Date: " + calendarView.SelectedAppointment.StartDate.ToString() + " to " + calendarView.SelectedAppointment.EndDate.ToString();
            }
        }

        //resolve appointments on calendar view
        private void dayView1_ResolveAppointments(object sender, ResolveAppointmentsEventArgs args) {
            List<Appointment> appts = new List<Appointment>();
            foreach (Appointment appt in calendarEvents)
                if ((appt.StartDate >= args.StartDate) &&
                    (appt.StartDate <= args.EndDate))
                    appts.Add(appt);

            args.Appointments = appts;
        }

        //update selection
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e) {
            calendarView.StartDate = monthCalendar.SelectionStart;
            
            //load any previously unloaded past events
            if (monthCalendar.SelectionStart.Date < eventsLoadedStartDate.Date) {
                updateCalendar(monthCalendar.SelectionStart.AddDays(-7), eventsLoadedStartDate.AddDays(-1));
                eventsLoadedStartDate = monthCalendar.SelectionStart.AddDays(-7);
            }

            //load any previously unloaded future events
            else if (monthCalendar.SelectionStart.Date > eventsLoadedEndDate.Date) {
                updateCalendar(eventsLoadedEndDate.AddDays(1), monthCalendar.SelectionStart.AddDays(14));
                eventsLoadedEndDate = monthCalendar.SelectionStart.AddDays(14);
            }
        }

        //change the main tab to the calendar page
        private void btnViewCalendar_Click(object sender, EventArgs e) {
            tabControl1.SelectedTab = tabViewCalendar;
        }

        //event handler for when the calendar view is double clicked
        private void calendarView_MouseDoubleClick(object sender, MouseEventArgs e) {
            Appointment selectedAppt = calendarView.GetAppointmentAt(e.X, e.Y);
            //if an appointment was selected bring up the edit event form, populating
            //  the form with the event information using the eventID stored in the
            //  appointment's note field
            if (selectedAppt != null) {
                int eventID = selectedAppt.AppointmentId;
                EditEventForm form = new EditEventForm(calendarEvents);
                form.loadEvent(eventID);
                form.ShowDialog();
                calendarView.Invalidate();
                updateLeftPanel();
            }
        }

        //when an event is moved update thde database
        private void calendarView_OnAppointmentMove(object sender, AppointmentEventArgs e) {

            if (PlannerSettings.Default.SyncEvents == true) {
                GoogleCalendarSync.updateEvent(e.Appointment);
            }
            
            //update database
            Database.modifyDatabase("UPDATE Event SET StartDateTime = DATETIME('" + Database.getDateTime(e.Appointment.StartDate) + "'), EndDateTime = DATETIME('" + Database.getDateTime(e.Appointment.EndDate) + "') WHERE EventID = '" + e.Appointment.AppointmentId + "';");

            updateEvents();
        }

        private void updateCalendar(DateTime start, DateTime end) {
            updateStatus("Status: Loading Events");
            
            //use thread to update calendar view as it may take a while to retrieve events once the table increases in size over time
             BackgroundWorker bw = new BackgroundWorker();             
             bw.DoWork += delegate(object s, DoWorkEventArgs args) {
                 //get class information
                 SQLiteDataReader events = Database.executeQuery("SELECT Title, Description, Location, StartDateTime, EndDateTime, IsAllDay, e.EventID, ClassID, GoogleEventID FROM Event e LEFT OUTER JOIN GradedAssignment g ON e.EventID = g.EventID WHERE DATE(StartDateTime) >= DATE('" + Database.getDate(start) + "') AND DATE(StartDateTime) <= DATE('" + Database.getDate(end) + "');");
                 while (events.Read() == true) {
                     //create a new appointment from the event information stored in the database
                     Appointment appt = new Appointment();
                     appt.Subject = events.GetString(0);
                     appt.Note = events.GetValue(1).ToString();
                     appt.Location = events.GetValue(2).ToString();
                     appt.StartDate = events.GetDateTime(3);
                     appt.EndDate = events.GetDateTime(4);
                     appt.Color = Color.Honeydew;
                     appt.BorderColor = Color.DarkBlue;

                     //check if the event has an associated class id and if so use it to set the color
                     if (events.IsDBNull(7) == false) {
                         appt.Color = classColors[events.GetInt32(7) % classColors.Length];
                     }

                     //determine if the event is an all day event
                     if (Convert.ToBoolean(events.GetString(5)) == true) {
                         appt.AllDayEvent = true;
                         appt.EndDate = appt.EndDate.AddDays(1);
                         appt.Color = Color.Coral;
                     }
                     appt.AppointmentId = events.GetInt32(6);

                     //if the event has a Google Calendar ID, add it to the hash in order to keep the event synced
                     if (events.IsDBNull(8) == false) {
                         GoogleCalendarSync.addEventIDs(appt.AppointmentId, events.GetString(8));
                     }

                     //add the event to the list of calendar events
                     calendarEvents.Add(appt);
                 }
                 events.Close();
             };

             bw.RunWorkerCompleted += delegate(object s, RunWorkerCompletedEventArgs args) {
                 //refresh the calendar view
                 calendarView.Invalidate();
                 updateStatus("Status: All events loaded");
             };

             bw.RunWorkerAsync();
        }

        #endregion

        #region AssignmentReportTab

        //change the main tab to the assignment report page
        private void btnGenerateAssignmentReport_Click(object sender, EventArgs e) {           
            tabControl1.SelectedTab = tabGenerateAssignmentReport;
            monthCalendar.Enabled = false;
            tsComboBoxDays.Enabled = false;
            tvAssignmentReport.Nodes.Clear();
        }

        private void resetAssignmentFilters() {
            //add all professors, not showing first name
            Util.addProfessors(cbAssignmentProfessor, profId, false, true, null, null);

            //add just current classes
            Util.addClasses(cbAssignmentClass, classId, true, true, null, null);

            //show all assignment types for current classes
            Util.addTypes(cbAssignmentType, null, true, null);
            cbAssignmentType.Items.Insert(0, "All Types");
        }

        private void tabGenerateAssignmentReport_Enter(object sender, EventArgs e) {
            //reset all filters
            resetAssignmentFilters();

            //set the default assignment date to 14 days (2 weeks) from the current date
            DateTime date = DateTime.Now.AddDays(14);
            dtAssignmentDate.Value = new DateTime(date.Year, date.Month, date.Day, 23, 59, 59);
        }

        private void cbAssignmentProfessor_SelectedIndexChanged(object sender, EventArgs e) {
            if (cbAssignmentProfessor.SelectedIndex > 0) {
                //add all current classes taught by the selected professor
                Util.addClasses(cbAssignmentClass, classId, true, false, profId[cbAssignmentProfessor.SelectedIndex - 1].ToString(), null);              
                
                //add all assignment types for the current class taught by selected professor
                Util.addTypes(cbAssignmentType, null, true, profId[cbAssignmentProfessor.SelectedIndex - 1].ToString());                 
            }
            else {
                //add just current classes
                Util.addClasses(cbAssignmentClass, classId, true, false, null, null);

                //show all assignment types for current classes
                Util.addTypes(cbAssignmentType, null, true, null);
            }
            //allow user to select all classes and types
            cbAssignmentClass.Items.Insert(0, "All Classes");
            cbAssignmentType.Items.Insert(0, "All Types");                 
        }

        private void cbAssignmentClass_SelectedIndexChanged(object sender, EventArgs e) {
            if (cbAssignmentClass.SelectedIndex > 0) {
                //show all assignment types for the currently selected class
                Util.addTypes(cbAssignmentType, classId[cbAssignmentClass.SelectedIndex - 1].ToString(), false, null);
            }
            else {
                //show all assignment types for current classes
                Util.addTypes(cbAssignmentType, null, true, null);
            }
            //allow user to select all types
            cbAssignmentType.Items.Insert(0, "All Types");
        }

        //event handler when the date filter checkbox
        private void chkUseDateAsFilter_CheckedChanged(object sender, EventArgs e) {
            //if checked, allow the user to change the date
            if (chkUseDateAsFilter.Checked == true) {
                dtAssignmentDate.Enabled = true;
            }
            else {
                dtAssignmentDate.Enabled = false;
            }
        }

        private void btnAssignmentReport_Click(object sender, EventArgs e) {
            tvAssignmentReport.Nodes.Clear();

            //build query for getting all the event information
            StringBuilder query = new StringBuilder("SELECT Title, Description, StartDateTime FROM FullEventView e LEFT OUTER JOIN ClassProfessor c ON e.ClassID = c.ClassID WHERE StartDateTime > DATETIME('now', 'localtime')");

            //select just graded assignments
            if (cbAssignmentClass.SelectedIndex == 0 || cbAssignmentProfessor.SelectedIndex == 0) {
                query.Append(" AND AssignmentName IS NOT NULL");
            }

            //select just graded assignments
            if (cbAssignmentProfessor.SelectedIndex > 0) {
                query.Append(" AND ProfID = '" + profId[cbAssignmentProfessor.SelectedIndex - 1] + "'");
            }

            //get events only for selected class
            if (cbAssignmentClass.SelectedIndex > 0) {
                query.Append(" AND e.ClassID = '" + classId[cbAssignmentClass.SelectedIndex - 1] + "'");
            }

            //get events for specific assignment types
            if (cbAssignmentType.SelectedIndex > 0) {
                query.Append(" AND Type = '" + cbAssignmentType.Text + "'");
            }

            //if keywords are specified
            if (txtKeywords.Text.Equals("") == false) {
                query.Append(" AND (Title LIKE '%" + txtKeywords.Text + "%' OR Description LIKE '%" + txtKeywords.Text + "%' OR Location LIKE '%" + txtKeywords.Text + "%')");
            }

            //use date as a filter if checked
            if (chkUseDateAsFilter.Checked == true) {
                string startDate = Database.getDate(dtAssignmentDate.Value);
                query.Append(" AND StartDateTime < DATE('" + startDate + " " + dtAssignmentDate.Value.TimeOfDay + "')");
            }

            //order the events by start time
            query.Append(" ORDER BY StartDateTime");

            //get the list of events and populate the tree view
            SQLiteDataReader events = Database.executeQuery(query.ToString());
            while (events.Read() == true) {
                TreeNode eventName = new TreeNode(events.GetString(0));
                TreeNode eventDate = new TreeNode("Date: " + events.GetDateTime(2).ToString("dddd, MMMM d, yyyy"));
                eventName.Nodes.Add(eventDate);
                TreeNode eventTime = new TreeNode("Time: " + events.GetDateTime(2).ToString("h:mm tt"));
                eventName.Nodes.Add(eventTime);
                if (events.IsDBNull(1) == false) {
                    TreeNode eventDescription = new TreeNode("Description: " + events.GetString(1));
                    eventName.Nodes.Add(eventDescription);
                }

                //add entire event node to the treeview
                tvAssignmentReport.Nodes.Add(eventName);
                
            }
            events.Close();
            tvAssignmentReport.ExpandAll();
            if (tvAssignmentReport.GetNodeCount(false) > 0) {
                tvAssignmentReport.Nodes[0].EnsureVisible();
            }
        }

        //clear the selected professor
        private void lnkClearProfessorFilter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            resetAssignmentFilters();
        }

        //clear the selected class
        private void lnkClearClassFilter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            cbAssignmentProfessor_SelectedIndexChanged(null, null);
        }

        //clear the selected assignment type
        private void lnkClearAssignmentType_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            cbAssignmentClass_SelectedIndexChanged(null, null);
        }

        #endregion

        #region GradeReportTab

        //change the main tab to the grade report page
        private void btnGenerateGradeReport_Click(object sender, EventArgs e) {          
            tabControl1.SelectedTab = tabGenerateGradeReport;
            monthCalendar.Enabled = false;
            tsComboBoxDays.Enabled = false;
            tvGradeReport.Nodes.Clear();

        }

        private void tabGenerateGradeReport_Enter(object sender, EventArgs e) {
            
            //add all professors, not showing first name
            Util.addProfessors(cbGradeProfessor, profId, false, true, null, null);

            //add just current classes
            Util.addClasses(cbGradeClass, classId, true,true, null, null);

            //add the possible letter grades for both the upper and lower grade bounds
            Util.addLetterGrades(cbGradeLowerBound);
            cbGradeLowerBound.Items.Insert(0, "");
            Util.addLetterGrades(cbGradeUpperBound);
            cbGradeUpperBound.Items.Insert(0, "");
        }

        private void chkIncludePastClasses_CheckedChanged(object sender, EventArgs e) {
            Util.addClasses(cbGradeClass, classId, !chkIncludePastClasses.Checked, true, null, null);
            cbGradeProfessor.SelectedIndex = -1;
        }

        private void cbGradeProfessor_SelectedIndexChanged(object sender, EventArgs e) {
            //add the classes (either current or past based on the checkbox) based on
            //  the currently selected professor
            if (cbGradeProfessor.SelectedIndex > 0) {
                Util.addClasses(cbGradeClass, classId, !chkIncludePastClasses.Checked, true, profId[cbGradeProfessor.SelectedIndex - 1].ToString(), null);
            }
            else {
                Util.addClasses(cbGradeClass, classId, !chkIncludePastClasses.Checked, true, null, null);
            }
        }

        private void btnGradeReport_Click(object sender, EventArgs e) {
            StringBuilder whereClause = new StringBuilder("WHERE (FinalLetterGrade IS NULL");

            //determine if to include past classes
            if (chkIncludePastClasses.Checked == true) {
                whereClause.Append(" OR FinalLetterGrade IS NOT NULL");
            }

            whereClause.Append(")");

            //if a professor is selected, add that as a filter
            if (cbGradeProfessor.SelectedIndex > 0) {
                whereClause.Append(" AND ProfID = '" + profId[cbGradeProfessor.SelectedIndex - 1] + "' ");
            }

            //if a class is selected, add that as a filter
            if (cbGradeClass.SelectedIndex > 0) {
                whereClause.Append(" AND ClassID = '" + classId[cbGradeClass.SelectedIndex - 1] + "' ");
            }

            //if a number of credits has been added, use that as a filter
            if (txtGradeCredits.Text.Equals("") == false) {
                double credits = 0;
                //ensure a valid number was entered
                if (double.TryParse(txtGradeCredits.Text, out credits) == false || credits < 0) {
                    Util.displayError("Please enter a valid decimal for the number of credits", "Invalid Number");
                    return;
                }
                //add to filter
                whereClause.Append(" AND Credits = '" + credits + "' ");
            }

            //ensure upper grade bound is greater than or equal to lower grade bound
            if (cbGradeUpperBound.Text.Equals("") == false && cbGradeLowerBound.Text.Equals("") == false) {
                if (cbGradeUpperBound.SelectedIndex > cbGradeLowerBound.SelectedIndex) {
                    Util.displayError("Grade upper bound must be greater than or equal to the grade lower bound.", "Invalid Grade Bounds");
                    return;
                }
            }

            //clear any current items in the tree
            tvGradeReport.Nodes.Clear();

            //dynamically add class grade categories to combo box
            SQLiteDataReader classes = Database.executeQuery("SELECT Name, CurrentGrade, CurrentLetterGrade, FinalLetterGrade, ClassID FROM ClassProfessorView " + whereClause + " ORDER BY Name;");
            while (classes.Read() == true) {
                //get the current class's id
                int currentClassId = classes.GetInt32(4);

                TreeNode className = null;

                if(classes.IsDBNull(3) == false){
                    //if current grade is lower than allowed lowest grade, then do not add it to report
                    if (cbGradeLowerBound.Text.Equals("") == false) {
                        if (letterGrades.IndexOf(classes.GetString(3)) > letterGrades.IndexOf(cbGradeLowerBound.Text)) {
                            continue;
                        }
                    }

                    //if current grade is higher than allowed highest grade, then do not add it to report
                    if (cbGradeUpperBound.Text.Equals("") == false) {
                        if (letterGrades.IndexOf(classes.GetString(3)) < letterGrades.IndexOf(cbGradeUpperBound.Text)) {
                            continue;
                        }
                    }

                    className = new TreeNode(classes.GetString(0) + ": " + classes.GetString(3));
                }

                //check if the class currently has a grade
                else if (classes.IsDBNull(1) == false) {

                    //if current grade is lower than allowed lowest grade, then do not add it to report
                    if (cbGradeLowerBound.Text.Equals("") == false) {
                        double bottomPerc = (double)Database.executeScalarQuery("SELECT BottomPercentage FROM GradingScaleValue WHERE ClassID = '" + currentClassId + "' AND GradeLetter = '" + cbGradeLowerBound.Text + "'");
                        if (classes.GetDouble(1) < bottomPerc) {
                            continue;
                        }
                    }

                    //if current grade is higher than allowed highest grade, then do not add it to report
                    if (cbGradeUpperBound.Text.Equals("") == false) {
                        double upperPerc = (double)Database.executeScalarQuery("SELECT BottomPercentage FROM GradingScaleValue WHERE ClassID = '" + currentClassId + "' AND GradeLetter = '" + cbGradeUpperBound.Text + "'");
                        if (classes.GetDouble(1) > upperPerc) {
                            continue;
                        }
                    }

                    className = new TreeNode(classes.GetString(0) + ": " + classes.GetDouble(1).ToString("F3") + "% (" + classes.GetString(2) + ")");
                }
                else {
                    className = new TreeNode(classes.GetString(0) + ": No Grade");
                }

                //get the list of grade categories associated with the class
                SQLiteDataReader categories = Database.executeQuery("SELECT Type, CategoryGrade FROM GradeCategory WHERE ClassID = '" + currentClassId + "' ORDER BY Percentage;");
                while (categories.Read() == true) {
                    TreeNode categoryName = null;
                    
                    //if there is a current grade for the category, display it; otherwise simply display 'No Grade'
                    if (categories.IsDBNull(1) == false) {
                        categoryName = new TreeNode(categories.GetString(0) + ": " + categories.GetDouble(1).ToString("F3") + "% (" + Util.getLetterGrade(categories.GetDouble(1), currentClassId) + ")");
                    }
                    else {
                        categoryName = new TreeNode(categories.GetString(0) + ": No Grade");
                    }

                    //get the list of grades in each grade category for the current class
                    SQLiteDataReader grades = Database.executeQuery("SELECT AssignmentName, Grade, GradeTotalWorth FROM FullEventView WHERE ClassID = '" + currentClassId + "' AND Type = '" + categories.GetString(0) + "' ORDER BY StartDateTime;");
                    while (grades.Read() == true) {
                        TreeNode assignment = null;

                        //if the assignment currently has a grade, calculate the grade percentage and add it to the tree view
                        if (grades.IsDBNull(1) == false) {
                            
                            //in case of extra credit
                            if (grades.GetDouble(2) == 0) {
                                assignment = new TreeNode(grades.GetString(0) + ": " + grades.GetDouble(1) + "/" + grades.GetDouble(2) + " (Extra Credit)");
                            }
                            else{
                                double gradePerc = grades.GetDouble(1) / grades.GetDouble(2) * 100;
                                assignment = new TreeNode(grades.GetString(0) + ": " + grades.GetDouble(1) + "/" + grades.GetDouble(2) + " (" + gradePerc.ToString("F2") + "%) " + Util.getLetterGrade(gradePerc, currentClassId));
                            }
                            
                        }
                        else {
                            assignment = new TreeNode(grades.GetString(0) + ": No Grade");
                        }
                        //add each assignment node to the category tree node
                        categoryName.Nodes.Add(assignment);
                    }
                    //add each category tree node to the class tree node
                    className.Nodes.Add(categoryName);
                }
                categories.Close();

                //add entire class node to the treeview
                tvGradeReport.Nodes.Add(className);
                
            }
            classes.Close();
            tvGradeReport.ExpandAll();
            if (tvGradeReport.GetNodeCount(false) > 0) {
                tvGradeReport.Nodes[0].EnsureVisible();
            }
        }

        #endregion

        #region EditGradesTab

        //change the main tab to the edit grades page
        private void btnEditGrades_Click(object sender, EventArgs e) {                     
            tabControl1.SelectedTab = tabEditGrades;
            monthCalendar.Enabled = false;
            tsComboBoxDays.Enabled = false;
            tvEditGrades.Nodes.Clear();
        }

        private void tabEditGrades_Enter(object sender, EventArgs e) {
            //add current classes to combo box
            Util.addClasses(cbEditGradesClass, classId, true, true, null, null);
            cbEditGradesClass.SelectedIndex = 0;
        }

        private void btnViewGrades_Click(object sender, EventArgs e) {
            //get the index of the currently selected class
            currentEditIndex = cbEditGradesClass.SelectedIndex;
                       
            StringBuilder whereClause = new StringBuilder(" WHERE FinalLetterGrade IS NULL ");
            if (cbEditGradesClass.SelectedIndex > 0) {
                whereClause.Append("AND ClassID = '" +  classId[cbEditGradesClass.SelectedIndex - 1] + "'");
            }

            //clear any current items in the tree
            tvEditGrades.Nodes.Clear();

            //dynamically add class grade categories to combo box
            SQLiteDataReader classes = Database.executeQuery("SELECT Name, CurrentGrade, CurrentLetterGrade, ClassID FROM Class " + whereClause + " ORDER BY Name;");
            while (classes.Read() == true) {
                int currentClassId = classes.GetInt32(3);

                TreeNode className = null;
                //if the class has a current grade, display it
                if (classes.IsDBNull(1) == false) {
                    className = new TreeNode(classes.GetString(0) + ": " + classes.GetDouble(1).ToString("F3") + "% (" + classes.GetString(2) + ")");
                }
                else {
                    className = new TreeNode(classes.GetString(0) + ": No Grade");
                }

                //get the list of grade categories for the current class
                SQLiteDataReader categories = Database.executeQuery("SELECT Type, CategoryGrade, GradingMethod FROM GradeCategory WHERE ClassID = '" + currentClassId + "' ORDER BY Percentage;");
                while (categories.Read() == true) {
                    TreeNode categoryName = null;
                    
                    //if the category has a grade, display it
                    if (categories.IsDBNull(1) == false) {
                        categoryName = new TreeNode(categories.GetString(0) + ": " + categories.GetDouble(1).ToString("F3") + "% (" + Util.getLetterGrade(categories.GetDouble(1), currentClassId) + ")");
                    }
                    else {
                        categoryName = new TreeNode(categories.GetString(0) + ": No Grade");
                    }
                    string gradingMethod = categories.GetString(2);

                    //get the list of grades for the current grade category for the current class
                    SQLiteDataReader grades = Database.executeQuery("SELECT AssignmentName, Grade, GradeTotalWorth, EventID FROM FullEventView WHERE ClassID = '" + currentClassId + "' AND Type = '" + categories.GetString(0) + "' ORDER BY StartDateTime;");
                    while (grades.Read() == true) {
                        TreeNode assignment = null;
                        if (grades.IsDBNull(1) == false) {
                            //display the grade in the appropriate format
                            if(gradingMethod.Equals("Points")){
                                assignment = new TreeNode(grades.GetString(0) + ": " + grades.GetDouble(1) + "/" + grades.GetDouble(2));
                            }
                            else{
                                double gradePerc = grades.GetDouble(1) / grades.GetDouble(2) * 100;
                                assignment = new TreeNode(grades.GetString(0) + ": " + gradePerc.ToString("F2") + "%");
                            }
                        }
                        else {
                            assignment = new TreeNode(grades.GetString(0) + ": No Grade");
                        }
                        //assign the graded assignment id and grading method to the treeview node so the grade can be uniquely
                        //  identified when updating the database
                        assignment.Tag = grades.GetInt32(3) + "," + gradingMethod; 
                        
                        //add graded assignment to the category tree node
                        categoryName.Nodes.Add(assignment);
                    }
                    //add category name to class tree node
                    className.Nodes.Add(categoryName);
                }
                categories.Close();

                //add entire class node to the treeview
                tvEditGrades.Nodes.Add(className);
                
            }
            classes.Close();
            tvEditGrades.ExpandAll();

            //if there are any grades to edit, enable the save and reset buttons
            if (tvEditGrades.Nodes.Count > 0) {
                btnSaveGrades.Enabled = true;
                btnResetGrades.Enabled = true;
                tvEditGrades.Nodes[0].EnsureVisible();
            }
            //else disable the save and reset buttons
            else {
                btnSaveGrades.Enabled = false;
                btnResetGrades.Enabled = false;
            }
        }

        private void tvEditGrades_BeforeLabelEdit(object sender, NodeLabelEditEventArgs e) {
            //do not allow overall class grade or category grades to be edited
            if (tvEditGrades.SelectedNode.Level < 2) {
                e.CancelEdit = true;
            }
            else {
                originalLabelText = e.Node.Text;
            }
        }

        private void tvEditGrades_AfterLabelEdit(object sender, NodeLabelEditEventArgs e) {
            //ensure that the user doesn't edit the assignment name and if so, cancel edid
            int index = originalLabelText.IndexOf(":");
            if(e.Label != null && e.Label.StartsWith(originalLabelText.Substring(0, index + 1)) == false){
                e.CancelEdit = true;
            }
        }

        private bool saveGrades() {
            Database.beginTransaction();

            //iterate through each graded assignment in the tree view
            foreach (TreeNode classes in tvEditGrades.Nodes) {
                foreach (TreeNode categories in classes.Nodes) {
                    foreach (TreeNode grades in categories.Nodes) {
                        //get the event id and grading method from the tree node tag
                        string eventID = grades.Tag.ToString().Split(',')[0];
                        string gradingMethod = grades.Tag.ToString().Split(',')[1];

                        //extract the grade information from the node
                        string gradeText = grades.Text.Remove(0, grades.Text.LastIndexOf(":") + 1);

                        //do not check validity or update assignments that currently have no grade
                        if (gradeText.Trim().Equals("No Grade") == true) {
                            Database.modifyDatabase("UPDATE GradedAssignment SET Grade = null WHERE EventID = '" + eventID + "';");
                            continue;
                        }

                        //if the grading method is point
                        if (gradingMethod.Equals("Points")) {
                            //first check format was valid                      
                            double grade, gradeWorth;
                            if (gradeText.Contains("/") == false || double.TryParse(gradeText.Split('/')[0], out grade) == false || double.TryParse(gradeText.Split('/')[1], out gradeWorth) == false){
                                Util.displayError("Grade must be in the format ##/## and consist of valid decimal numbers.\n\nYou Entered: " + gradeText, "Invalid Format");
                                return false;
                            }
   
                            //update database
                            Database.modifyDatabase("UPDATE GradedAssignment SET Grade = '" + grade + "', GradeTotalWorth = '" + gradeWorth + "' WHERE EventID = '" + eventID + "';");
                            
                        }
                        else {
                            //first check format was valid
                            double grade;
                            //remove percent sign and ensure number is valid
                            if (double.TryParse(gradeText.Split('%')[0], out grade) == false) {
                                Util.displayError("Grade must be in the format ##% and consist of a valid decimal number.\n\nYou Entered: " + gradeText, "Invalid Format");                             
                                return false;
                            }

                            //update the database
                            Database.modifyDatabase("UPDATE GradedAssignment SET Grade = '" + grade + "' WHERE EventID = '" + eventID + "';");
                        }
                    }
                }
            }
            Database.commit(); 
          
            //update left panel
            updateLeftPanel();

            //reset back to index when viewing grade in order to refresh information
            cbEditGradesClass.SelectedIndex = currentEditIndex;
            btnViewGrades_Click(null, null);

            return true;
        }

        //button to save grades
        private void btnSaveGrades_Click(object sender, EventArgs e) {
            if (saveGrades() == false) {
                Database.abort();
                displayMessage("Error Saving\nGrade Information", Color.DarkRed);
            }
            else {
                displayMessage("Grade Information\nSuccessfully Saved", Color.DarkGreen);
            }
        }

        private void btnResetGrades_Click(object sender, EventArgs e) {
            
            //reset the selected class to the index when view grades was last called
            cbEditGradesClass.SelectedIndex = currentEditIndex;

            //call view grades method to repopulate view using information from database
            btnViewGrades_Click(null, null);
        }

        //display message for the specified time using the given text and color
        private void displayMessage(string text, Color color) {
            editGradesTimer.Stop();
            editGradesTimer.Start();
            lblSaveStatus.Text = text;
            lblSaveStatus.ForeColor = color;
        }

        //on the timer tick, clear the text and stop the timer
        private void editGradesTimer_Tick(object sender, EventArgs e) {
            lblSaveStatus.Text = "";
            editGradesTimer.Stop();
        }

        #endregion

        private void mergeExternalChangesToolStripMenuItem_Click(object sender, EventArgs e) {
            //display confirmation message
            DialogResult reallyDelete = MessageBox.Show("This process may take a while depending on the size on total number of events. Continue?", "Merge Events?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reallyDelete == DialogResult.Yes) {
                this.Enabled = false;
                GoogleCalendarSync.mergeChanges();                
                this.Enabled = true;              
                updateLeftPanel();
                calendarEvents.Clear();
                eventsLoadedStartDate = DateTime.Now.AddDays(-7).Date;
                eventsLoadedEndDate = DateTime.Now.AddDays(14).Date;
                GoogleCalendarSync.clearEventIDs();
                updateCalendar(eventsLoadedStartDate, eventsLoadedEndDate);
                MessageBox.Show("All Events Successfully Synchronized and Updated", "Merge Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("A+ Student Planner Developed by David Riggleman\nCopyright 2011.\n\nCalendar View from DayView, distributed under the GPL License.\nhttp://calendar.codeplex.com/\n\nIcons From VisualPharm\nhttp://www.visualpharm.com", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}