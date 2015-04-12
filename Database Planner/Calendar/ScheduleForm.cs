using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Calendar;
using MySql.Data.MySqlClient;

namespace Planner {
    public partial class ScheduleForm : Form {

        private List<Appointment> classes = new List<Appointment>();

        public ScheduleForm() {
            InitializeComponent();

            //enable rounded corners and shadows
            scheduleView.EnableRoundedCorners = true;
            scheduleView.EnableShadows = true;

            scheduleView.OnResolveAppointments += new EventHandler<ResolveAppointmentsEventArgs>(this.scheduleView_OnResolveAppointments);
        }

        private void ScheduleForm_Load(object sender, EventArgs e) {
            //get the class information for each current ongoing class
            MySqlDataReader classHour = Database.executeQuery("SELECT ClassID, OnMonday, OnTuesday, OnWednesday, OnThursday, OnFriday, StartTime, EndTime, Name, Location, Title, LastName FROM ClassProfessorView WHERE FinalLetterGrade IS NULL");
            while (classHour.Read() == true) {

                //determine for each day (Monday to Friday) whether to add the class
                for (int i = 1; i < 6; i++) {
                    bool hasClass = Convert.ToBoolean(classHour.GetString(i));
                    if (hasClass == true) {

                        //retrieve the class information and populate the appointment information
                        Appointment classPeriod = new Appointment();
                        DateTime startTime = classHour.GetDateTime(6);
                        DateTime endTime = classHour.GetDateTime(7);
                        classPeriod.StartDate = new DateTime(2011, 8, i, startTime.Hour, startTime.Minute, 0);
                        classPeriod.EndDate = new DateTime(2011, 8, i, endTime.Hour, endTime.Minute, 0);
                        classPeriod.Subject = classHour.GetValue(8) + "\n" + classHour.GetValue(9) + "\n" + (classHour.GetValue(10) + " " + classHour.GetString(11)).Trim();
                        classPeriod.Color = AssignmentPlanner.classColors[classHour.GetInt32(0) % AssignmentPlanner.classColors.Length];
                        classes.Add(classPeriod);
                    }
                }
            }
            classHour.Close();

            //update the schedule view
            scheduleView.Invalidate();
        }

        private void scheduleView_OnResolveAppointments(object sender, ResolveAppointmentsEventArgs args) {
            //resolve appointments on calendar view
            List<Appointment> appts = new List<Appointment>();
            foreach (Appointment appt in classes)
                if ((appt.StartDate >= args.StartDate) &&
                    (appt.StartDate <= args.EndDate)) {
                    appts.Add(appt);
                }

            args.Appointments = appts;
        }

    }
}
