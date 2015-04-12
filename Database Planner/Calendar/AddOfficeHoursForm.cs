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
    public partial class AddOfficeHoursForm : Form
    {
        //office hours information
        private List<bool[]> officeHoursDays = new List<bool[]>();
        private List<DateTime> officeHoursStart = new List<DateTime>();
        private List<DateTime> officeHoursEnd = new List<DateTime>();

        public AddOfficeHoursForm()
        {
            InitializeComponent();
        }

        //allow other forms to get the added office hour days
        public List<bool[]> getOfficeHoursDays() {
            return officeHoursDays;
        }

        //allow other forms to get the added office hours start time
        public List<DateTime> getOfficeHoursStart() {
            return officeHoursStart;
        }

        //allow other forms to get the added office hours end time
        public List<DateTime> getOfficeHoursEnd() {
            return officeHoursEnd;
        }

        //save office hours
        private bool saveOfficeHours() {
            //ignore if no days are checked
            if (chkOfficeHoursMon.Checked == false && chkOfficeHoursTue.Checked == false && chkOfficeHoursWed.Checked == false
                    && chkOfficeHoursThu.Checked == false && chkOfficeHoursFri.Checked == false) {
                return true;
            }

            //ensure end time is later than start time
            if (dtOfficeHoursEnd.Value.TimeOfDay > dtOfficeHoursStart.Value.TimeOfDay == false) {
                Util.displayError("The end time must be later than the start time.", "Invalid Date");
                return false;
            }

            //determine which days were selected
            bool[] days = { chkOfficeHoursMon.Checked, chkOfficeHoursTue.Checked, chkOfficeHoursWed.Checked,
                 chkOfficeHoursThu.Checked, chkOfficeHoursFri.Checked};

            //add current values to lists
            officeHoursDays.Add(days);
            officeHoursStart.Add(dtOfficeHoursStart.Value);
            officeHoursEnd.Add(dtOfficeHoursEnd.Value);
            return true;
        }

        //save hours and return to professor page if successful
        private void btnOfficeHoursSave_Click(object sender, EventArgs e) {
            if (saveOfficeHours() == true) {
                //return to add professor page
                Close();
            }
        }

        //return to professor page
        private void btnOfficeHoursClose_Click(object sender, EventArgs e) {
            //return to add profess tab
            Close();
        }

        //reset form to default values
        private void lnkAddMoreOfficeHours_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            //reset form only if save was successful
            if (saveOfficeHours() == true) {
                chkOfficeHoursMon.Checked = false;
                chkOfficeHoursTue.Checked = false;
                chkOfficeHoursWed.Checked = false;
                chkOfficeHoursThu.Checked = false;
                chkOfficeHoursFri.Checked = false;
                dtOfficeHoursStart.Value = new DateTime(2000, 1, 1, 11, 0, 0);
                dtOfficeHoursEnd.Value = new DateTime(2000, 1, 1, 12, 0, 0);
            }
        }

        private void dtOfficeHoursStart_ValueChanged(object sender, EventArgs e) {
            //update end time to one hour after start time when user changes start time
            dtOfficeHoursEnd.Value = new DateTime(2000, 1, 1, (dtOfficeHoursStart.Value.Hour + 1) % 24, dtOfficeHoursStart.Value.Minute % 60, 0);
        }

    }
}
