using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

//used for adding events to Google Calendar
using Google.GData.Calendar;
using Google.GData.Client;
using Google.GData.Extensions;
using Calendar;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading;

namespace Planner {
    class GoogleCalendarSync {

        private static Uri postUri;
        private static CalendarService service;
        private static bool authenticated = false;
        private static AssignmentPlanner planner;

        private static Object threadLock = new Object();

        private static Dictionary<int, string> eventIDs = new Dictionary<int, string>();

        public static void setActiveForm(AssignmentPlanner form) {
            planner = form;
        }

        public static void authenticate() {
            planner.updateStatus("Authenticating Google Calendar Account Info");
            string calendarURL = PlannerSettings.Default.CalendarURL;
            if(calendarURL.Equals("")){
                MessageBox.Show("No Calendar URL specified.", "Invalid Settings", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            postUri = new Uri(calendarURL);
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += delegate(object s, DoWorkEventArgs args){
                lock (threadLock) {
                    service = new CalendarService("A+StudentPlanner");
                    if (PlannerSettings.Default.StoredGoogleAccount == true) {

                        byte[] salt = Encoding.Unicode.GetBytes("A+ Student Planner Developed By David Riggleman");
                        string[] encryptedBytes = PlannerSettings.Default.Password.Split('-');
                        byte[] encodedBytes = new byte[encryptedBytes.Length];
                        for (int i = 0; i < encryptedBytes.Length; i++) {
                            encodedBytes[i] = Byte.Parse(encryptedBytes[i]);
                        }
                        byte[] decodedBytes = ProtectedData.Unprotect(encodedBytes, salt, DataProtectionScope.CurrentUser);
                        service.setUserCredentials(PlannerSettings.Default.Username, Encoding.Unicode.GetString(decodedBytes));

                        try {
                            EventQuery myQuery = new EventQuery(postUri.ToString());
                            EventFeed resultFeed = (EventFeed)service.Query(myQuery);
                            authenticated = true;
                        }
                        catch {
                            Util.displayError("Error authenticating Google Calendar Account. Check settings.", "Authentication Error");
                            authenticated = false;
                        }

                    }
                    else {
                        AuthenticationForm form = new AuthenticationForm(PlannerSettings.Default.Username);
                        form.changeText("Enter the credentials for your google account. \n(No information will be stored).", "Enter Google Account Credentials");
                        authenticated = false;
                        bool exit = false;
                        while (exit == false) {
                            form.ShowDialog();
                            if (form.cancelled == true) {
                                exit = true;
                            }
                            else {
                                try {
                                    service.setUserCredentials(form.username, form.password);
                                    EventQuery myQuery = new EventQuery(postUri.ToString());
                                    EventFeed resultFeed = (EventFeed)service.Query(myQuery);
                                    authenticated = true;
                                    exit = true;
                                }
                                catch {
                                    DialogResult retry = MessageBox.Show("Incorrect username or password. Try Again?", "Authentication Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                                    if (retry != DialogResult.Retry) {
                                        exit = true;
                                    }
                                }
                            } 
                        }
                        form.eraseCredentials();
                    }
                }
            };

            bw.RunWorkerCompleted += delegate(object s, RunWorkerCompletedEventArgs args) {
                if (authenticated == true) {                    
                    planner.updateStatus("Status: Google Authentication Successful");
                    planner.Refresh();                    
                }
                else {
                    planner.updateStatus("Status: Google Authentication Failed");
                    planner.Refresh();
                }               
            };

            //start thread
            bw.RunWorkerAsync();

        }

        public static bool isAuthenticated() {
            return authenticated;
        }

        public static void addEventIDs(int dbEventID, string googleEventID) {
            if (eventIDs.ContainsKey(dbEventID) == false) {
                eventIDs.Add(dbEventID, googleEventID);
            }
        }

        public static void deleteEventID(int dbEventID) {
            if (eventIDs.ContainsKey(dbEventID) == true) {
                eventIDs.Remove(dbEventID);
            }
        }

        public static void clearEventIDs() {
            eventIDs.Clear();
        }

        //add an event to google calendar
        public static void addEvent(Appointment appt) {
            if (authenticated == true) {

                Dictionary<int, string> insertedId = new Dictionary<int, string>();

                //create new thread for add event
                BackgroundWorker bw = new BackgroundWorker();
                bw.DoWork += delegate(object s, DoWorkEventArgs args) {
                    try {
                        //add event to Google Calendar
                        EventEntry entry = new EventEntry();

                        // Set the title and content of the entry.
                        entry.Title.Text = appt.Subject;
                        entry.Content.Content = appt.Note;

                        // Set a location for the event.
                        Where eventLocation = new Where();
                        eventLocation.ValueString = appt.Location;
                        entry.Locations.Add(eventLocation);

                        
                        When eventTime = new When(appt.StartDate, appt.EndDate);
                        entry.Times.Add(eventTime);

                        lock (threadLock) {
                            EventEntry insertedEntry = service.Insert(postUri, entry);
                            eventIDs.Add(appt.AppointmentId, insertedEntry.EventId);
                            insertedId.Add(appt.AppointmentId, insertedEntry.EventId);                           
                        }
                    }
                    catch (Exception e) {
                        Util.logError("Google Calendar Error: " + e.Message);
                    }
                };

                bw.RunWorkerCompleted += delegate(object s, RunWorkerCompletedEventArgs args) {
                    foreach (int apptId in insertedId.Keys) {
                        Database.modifyDatabase("UPDATE Event SET GoogleEventID = '" + insertedId[apptId] + "' WHERE EventID = '" + apptId + "';");
                    }
                };

                //start the thread
                bw.RunWorkerAsync();
            }
        }

        public static void mergeChanges(){
            if (authenticated == true) {
                SQLiteDataReader events = Database.executeQuery("SELECT GoogleEventID FROM EVENT WHERE GoogleEventID IS NOT NULL AND StartDateTime > DATETIME('now', 'localtime')");
                while (events.Read() == true) {
                    try {
                        EventQuery myQuery = new EventQuery(postUri.ToString() + "/" + events.GetString(0));
                        lock (threadLock) {
                            EventFeed resultFeed = (EventFeed)service.Query(myQuery);

                            //only update if an event is found
                            if (resultFeed.Entries.Count > 0) {
                                EventEntry calendar = (EventEntry)resultFeed.Entries[0];
                                Database.modifyDatabase("UPDATE Event SET Title = " + Util.quote(calendar.Title.Text) + ", Description = "
                                    + Util.quote(calendar.Content.Content) + ", Location = " + Util.quote(calendar.Locations[0].ValueString)
                                    + ", StartDateTime = DATETIME('" + Database.getDateTime(calendar.Times[0].StartTime) + "'), EndDateTime = DATETIME('"
                                    + Database.getDateTime(calendar.Times[0].EndTime) + "') WHERE GoogleEventID = '" + events.GetString(0) + "';");
                            }
                        }
                    }
                    catch (Exception e) {
                        Util.logError("Google Calendar Error: " + e.Message);
                    }
                }
                events.Close();
            }
        }

        public static void updateEvent(Appointment newAppt) {
            if (authenticated == true) {

                //create new thread for updating event
                BackgroundWorker bw = new BackgroundWorker();
                bw.DoWork += delegate(object s, DoWorkEventArgs args) {
                    lock (threadLock) {
                        try {
                            if (eventIDs.ContainsKey(newAppt.AppointmentId) == false) {
                                return;
                            }

                            EventQuery myQuery = new EventQuery(postUri.ToString() + "/" + eventIDs[newAppt.AppointmentId]);
                            EventFeed resultFeed = (EventFeed)service.Query(myQuery);

                            //only update if an event is found
                            if (resultFeed.Entries.Count > 0) {
                                EventEntry calendar = (EventEntry)resultFeed.Entries[0];
                                calendar.Title.Text = newAppt.Subject;
                                calendar.Content.Content = newAppt.Note;
                                calendar.Locations.Clear();

                                Where eventLocation = new Where();
                                eventLocation.ValueString = newAppt.Location;
                                calendar.Locations.Add(eventLocation);

                                When eventTime = new When(newAppt.StartDate, newAppt.EndDate);
                                calendar.Times.Clear();
                                calendar.Times.Add(eventTime);

                                calendar.Update();
                            }
                        }

                        catch (Exception e) {
                            Util.logError("Google Calendar Error: " + e.Message);
                        }
                    }
                };

                //start the thread
                bw.RunWorkerAsync();
            }
        }

        public static void deleteEvent(Appointment appt) {
            if (authenticated == true) {

                //create new thread for deleting events
                BackgroundWorker bw = new BackgroundWorker();
                bw.DoWork += delegate(object s, DoWorkEventArgs args) {
                    lock (threadLock) {
                        try {
                            if (eventIDs.ContainsKey(appt.AppointmentId) == false) {
                                return;
                            }

                            EventQuery myQuery = new EventQuery(postUri.ToString() + "/" + eventIDs[appt.AppointmentId]);
                            EventFeed resultFeed = (EventFeed)service.Query(myQuery);

                            //only delete if an event is found
                            if (resultFeed.Entries.Count > 0) {
                                resultFeed.Entries[0].Delete();
                            }

                            //ensure associated google event information tied to this event is removed
                            deleteEventID(appt.AppointmentId);
                        }

                        catch (Exception e) {
                            Util.logError("Google Calendar Error: " + e.Message);
                        }
                    }
                };

                //start the thread
                bw.RunWorkerAsync();
            }        
        }
    
    }
}
