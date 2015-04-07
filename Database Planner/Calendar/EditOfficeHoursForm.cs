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
    public partial class EditOfficeHoursForm : Form
    {
        private int currentProfId = -1;

        //office hours information
        private List<bool[]> officeHoursDays = new List<bool[]>();
        private List<DateTime> officeHoursStart = new List<DateTime>();
        private List<DateTime> officeHoursEnd = new List<DateTime>();
        private List<int> officeHoursId = new List<int>();
        private int currentOfficeHour = 0;

        private bool useInsert = false;

        public EditOfficeHoursForm(int currentProf)
        {
            InitializeComponent();
            currentProfId = currentProf;

            //dynamically retrieve all office hours information and store in lists
            SQLiteDataReader hours = Database.executeQuery("SELECT * FROM OfficeHour WHERE ProfID = '" + currentProfId + "';");
            while (hours.Read() == true) {
                officeHoursId.Add(hours.GetInt32(0));
                bool[] days = { Convert.ToBoolean(hours.GetString(1)), Convert.ToBoolean(hours.GetString(2)), Convert.ToBoolean(hours.GetString(3)), Convert.ToBoolean(hours.GetString(4)), Convert.ToBoolean(hours.GetString(5)) };
                officeHoursDays.Add(days);
                officeHoursStart.Add(hours.GetDateTime(6));
                officeHoursEnd.Add(hours.GetDateTime(7));
            }
            hours.Close();

            //if there is at least one office hour period, populate form with information from first value
            if (officeHoursDays.Count > 0) {
                chkOfficeHoursMon.Checked = officeHoursDays[0][0];
                chkOfficeHoursTue.Checked = officeHoursDays[0][1];
                chkOfficeHoursWed.Checked = officeHoursDays[0][2];
                chkOfficeHoursThu.Checked = officeHoursDays[0][3];
                chkOfficeHoursFri.Checked = officeHoursDays[0][4];
                dtOfficeHoursStart.Value = officeHoursStart[0];
                dtOfficeHoursEnd.Value = officeHoursEnd[0];
            }
        }
   

        //update end time to one hour after start time when user changes start time
        private void dtOfficeHoursStart_ValueChanged(object sender, EventArgs e) {      
            dtOfficeHoursEnd.Value = new DateTime(2000, 1, 1, (dtOfficeHoursStart.Value.Hour + 1) % 24, dtOfficeHoursStart.Value.Minute % 60, 0);
        }

        //return to edit professor tab without saving
        private void btnOfficeHoursClose_Click(object sender, EventArgs e) {
            Close();
        }

        //deletes office hour period information from database
        private void btnDeleteOfficeHours_Click(object sender, EventArgs e) {
            //displays confirmation message
            DialogResult reallyDelete = MessageBox.Show("Are you sure you really want to delete this office hour?", "Really Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reallyDelete == DialogResult.Yes) {
                if (officeHoursId.Count > 0) {
                    //delete from database
                    Database.modifyDatabase("DELETE FROM OfficeHour WHERE OfficeHoursID = '" + officeHoursId[currentOfficeHour] + "';");

                    //remove items from lists
                    officeHoursId.RemoveAt(currentOfficeHour);
                    officeHoursDays.RemoveAt(currentOfficeHour);
                    officeHoursStart.RemoveAt(currentOfficeHour);
                    officeHoursEnd.RemoveAt(currentOfficeHour);

                    //reset office hours form
                    resetOfficeHoursForm();

                    //decrement (go to previous) office hours period without saving (since form will be empty)
                    changeOfficeHours(false, false);
                }
            }
        }

        //reset all controls on form to default values
        private void resetOfficeHoursForm() {
            chkOfficeHoursMon.Checked = false;
            chkOfficeHoursTue.Checked = false;
            chkOfficeHoursWed.Checked = false;
            chkOfficeHoursThu.Checked = false;
            chkOfficeHoursFri.Checked = false;
            dtOfficeHoursStart.Value = new DateTime(2000, 1, 1, 11, 00, 0);
            dtOfficeHoursEnd.Value = new DateTime(2000, 1, 1, 12, 00, 0);
        }

        //save office hours information
        private void btnOfficeHoursSave_Click(object sender, EventArgs e) {
            //return to edit professor tab if save was successful
            if (saveOfficeHours() == true) {
                Close();
            }
        }

        //save office hours, returing true if sucessful and false if there is an error
        private bool saveOfficeHours() {
            //ignore if one day is checked
            if (chkOfficeHoursMon.Checked == false && chkOfficeHoursTue.Checked == false && chkOfficeHoursWed.Checked == false
                    && chkOfficeHoursThu.Checked == false && chkOfficeHoursFri.Checked == false) {
                return true;
            }

            //ensure end time is later than start time
            if (dtOfficeHoursEnd.Value.TimeOfDay > dtOfficeHoursStart.Value.TimeOfDay == false) {
                Util.displayError("The end time must be later than the start time.", "Invalid Date");
                displayMessage("Error Saving Office Hour Period", Color.DarkRed);
                return false;
            }

            //check if we should insert new value into database
            if (useInsert == true || officeHoursDays.Count == 0) {
                //add new value to database
                Database.modifyDatabase("INSERT INTO OfficeHour VALUES(null, '" + chkOfficeHoursMon.Checked + "', '" + chkOfficeHoursTue.Checked + "', '" +
                    chkOfficeHoursWed.Checked + "', '" + chkOfficeHoursThu.Checked + "', '" + chkOfficeHoursFri.Checked + "', TIME('" + dtOfficeHoursStart.Value.TimeOfDay + "'), TIME('" +
                    dtOfficeHoursEnd.Value.TimeOfDay + "'), '" + currentProfId + "');");

                //get id of inserted office hour period and store in list
                object insertId = Database.getInsertedID();
                officeHoursId.Add(Convert.ToInt32(insertId));

                //store current information in lists
                bool[] days = { chkOfficeHoursMon.Checked, chkOfficeHoursTue.Checked, chkOfficeHoursWed.Checked, chkOfficeHoursThu.Checked, chkOfficeHoursFri.Checked };
                officeHoursDays.Add(days);
                officeHoursStart.Add(dtOfficeHoursStart.Value);
                officeHoursEnd.Add(dtOfficeHoursEnd.Value);
                
                //reset current office hour pointer and assume next action will be an update
                currentOfficeHour = officeHoursDays.Count - 1;
                useInsert = false;
            }
            //otherwise, we update an existing value
            else {
                //get current start and end times
                string startTime = dtOfficeHoursStart.Value.TimeOfDay.ToString();
                string endTime = dtOfficeHoursEnd.Value.TimeOfDay.ToString();
                
                //update information in database
                Database.modifyDatabase("UPDATE OfficeHour SET OnMonday = '" + chkOfficeHoursMon.Checked + "', OnTuesday = '" + chkOfficeHoursTue.Checked + "', OnWednesday = '" +
                    chkOfficeHoursWed.Checked + "', OnThursday = '" + chkOfficeHoursThu.Checked + "', OnFriday = '" + chkOfficeHoursFri.Checked + "', StartTime = TIME('" + startTime + "'), EndTime = TIME('" +
                    endTime + "') WHERE OfficeHoursID = '" + officeHoursId[currentOfficeHour] + "';");

                //update lists
                officeHoursDays[currentOfficeHour][0] = chkOfficeHoursMon.Checked;
                officeHoursDays[currentOfficeHour][1] = chkOfficeHoursTue.Checked;
                officeHoursDays[currentOfficeHour][2] = chkOfficeHoursWed.Checked;
                officeHoursDays[currentOfficeHour][3] = chkOfficeHoursThu.Checked;
                officeHoursDays[currentOfficeHour][4] = chkOfficeHoursFri.Checked;
                officeHoursStart[currentOfficeHour] = dtOfficeHoursStart.Value;
                officeHoursEnd[currentOfficeHour] = dtOfficeHoursEnd.Value;
            }
            displayMessage("Office Hours Successfully Saved", Color.DarkGreen);
            return true;
        }

        //save current office hours and clear form to add new information
        private void lnkAddOfficeHours_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            //only continue if save is successful
            if (saveOfficeHours() == true) {
                //reset form
                resetOfficeHoursForm();

                //indicate next action will be an insert
                useInsert = true;
            }
        }

        //changes what offiice hours will be displayed
        private void changeOfficeHours(bool goToNext, bool save) {
            bool success = true;
            //check if we need to save current information
            if (save) {
                //check if save is successful
                success = saveOfficeHours();
            }
            if (success == true) {
                useInsert = false;
                
                //check if we have values to cycle through
                if (officeHoursDays.Count > 0) {
                    if (goToNext) {
                        //increment (go to next) current office hour information
                        currentOfficeHour = (currentOfficeHour + 1) % officeHoursDays.Count;
                    }
                    else {
                        //decrement (go to previous) current office hour information
                        currentOfficeHour = (currentOfficeHour + officeHoursDays.Count - 1) % officeHoursDays.Count;
                    }

                    //populate form with new information
                    chkOfficeHoursMon.Checked = officeHoursDays[currentOfficeHour][0];
                    chkOfficeHoursTue.Checked = officeHoursDays[currentOfficeHour][1];
                    chkOfficeHoursWed.Checked = officeHoursDays[currentOfficeHour][2];
                    chkOfficeHoursThu.Checked = officeHoursDays[currentOfficeHour][3];
                    chkOfficeHoursFri.Checked = officeHoursDays[currentOfficeHour][4];
                    dtOfficeHoursStart.Value = officeHoursStart[currentOfficeHour];
                    dtOfficeHoursEnd.Value = officeHoursEnd[currentOfficeHour];
                }
            }
        }

        //decrement (go to previous) office hours information and save current information
        private void lnkPreviousOfficeHours_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            changeOfficeHours(false, true);
        }

        //increment (go to next) office hours information and save current information
        private void lnkNextOfficeHours_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            changeOfficeHours(true, true);
        }

        //display message for specified time using given text and color
        private void displayMessage(string text, Color color) {
            timer1.Stop();
            timer1.Start();
            lblSaveStatus.Text = text;
            lblSaveStatus.ForeColor = color;
        }

        //on first timer tick, clear save status label and stop timer
        private void timer1_Tick_1(object sender, EventArgs e) {
            lblSaveStatus.Text = "";
            timer1.Stop();
        }
        

    }
}
