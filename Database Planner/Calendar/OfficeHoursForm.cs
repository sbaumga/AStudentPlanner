using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using Calendar;

namespace Planner {
    public partial class OfficeHoursForm : Form {

        //store list of all office hour periods
        private List<Appointment> periods = new List<Appointment>();

        public OfficeHoursForm() {
            InitializeComponent();

            //enable rounded corners and disable shadows
            officeHoursView.EnableRoundedCorners = true;
            officeHoursView.EnableShadows = false;

            //add event handle to resolve appointments
            officeHoursView.OnResolveAppointments += new EventHandler<ResolveAppointmentsEventArgs>(this.officeHoursView_OnResolveAppointments);
        }

        private void OfficeHoursForm_Load(object sender, EventArgs e) {

            //get list of office hours for professors teaching a current ongoing class
            SQLiteDataReader officeHour = Database.executeQuery("SELECT OfficeLocation, OnMonday, OnTuesday, OnWednesday, OnThursday, OnFriday, StartTime, EndTime, Title, LastName FROM OfficeHour NATURAL JOIN Professor WHERE ProfId IN (SELECT ProfID FROM ClassProfessor WHERE ClassID IN (SELECT ClassID FROM Class WHERE FinalLetterGrade IS NULL))");
			while (officeHour.Read() == true) {
                
                //determine for each day (Monday to Friday) whether to add an office hour period
                for (int i = 1; i < 6; i++) {
                    bool hasOfficeHour = Convert.ToBoolean(officeHour.GetString(i));
                    if (hasOfficeHour == true) {

                        //retrieve the office hour information and populate the appointment information
                        Appointment period = new Appointment();
                        DateTime startTime = officeHour.GetDateTime(6);
                        DateTime endTime = officeHour.GetDateTime(7);
                        period.StartDate = new DateTime(2011, 8, i, startTime.Hour, startTime.Minute, 0);
                        period.EndDate = new DateTime(2011, 8, i, endTime.Hour, endTime.Minute, 0);
                        period.Subject = (officeHour.GetValue(8) + " " + officeHour.GetString(9)).Trim() + "\n\n" + officeHour.GetValue(0);
                        period.Color = Color.Coral;
                        periods.Add(period);
                    }
                }
            }
            officeHour.Close();

            //update the office hours view
            officeHoursView.Invalidate();
        }

        private void officeHoursView_OnResolveAppointments(object sender, ResolveAppointmentsEventArgs args) {
            //resolve appointments on calendar view
            List<Appointment> appts = new List<Appointment>();
            foreach (Appointment appt in periods)
                if ((appt.StartDate >= args.StartDate) &&
                    (appt.StartDate <= args.EndDate))
                    appts.Add(appt);

            args.Appointments = appts;
        }
    }
}
