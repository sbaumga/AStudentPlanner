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
    public partial class AddGradingScaleForm : Form
    {
        //grading scale information
        private decimal[] gradingScale = new decimal[11];
        private string[] gradeLetter = {"A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-"};

        public AddGradingScaleForm()
        {
            InitializeComponent();

            //initialize grading scale to default 90-80-70-60
            gradingScale[0] = ctrA.Value = 93;
            gradingScale[1] = ctrAminus.Value = 90;
            gradingScale[2] = ctrBplus.Value = 87;
            gradingScale[3] = ctrB.Value = 83;
            gradingScale[4] = ctrBminus.Value = 80;
            gradingScale[5] = ctrCplus.Value = 77;
            gradingScale[6] = ctrC.Value = 73;
            gradingScale[7] = ctrCminus.Value = 70;
            gradingScale[8] = ctrDplus.Value = 67;
            gradingScale[9] = ctrD.Value = 63;
            gradingScale[10] = ctrDminus.Value = 60;
        }

        //allows other forms to get the recently added grading scale
        public decimal[] getGradingScale() {
            return gradingScale;
        }

        private void btnSaveGradingScale_Click(object sender, EventArgs e) {

            //ensure entered grading scale is valid
            if (ctrA.Value <= ctrAminus.Value || ctrAminus.Value <= ctrBplus.Value ||
               ctrBplus.Value <= ctrB.Value || ctrB.Value <= ctrBminus.Value ||
               ctrBminus.Value <= ctrCplus.Value || ctrCplus.Value <= ctrC.Value ||
               ctrC.Value <= ctrCminus.Value || ctrCminus.Value <= ctrDplus.Value ||
               ctrDplus.Value <= ctrD.Value || ctrD.Value <= ctrDminus.Value) {
                Util.displayError("Each letter grade value must be higher than the preceding value.",
                    "Invalid Grading Scale");
                return;
            }

            //store grading scale information
            gradingScale[0] = ctrA.Value;
            gradingScale[1] = ctrAminus.Value;
            gradingScale[2] = ctrBplus.Value;
            gradingScale[3] = ctrB.Value;
            gradingScale[4] = ctrBminus.Value;
            gradingScale[5] = ctrCplus.Value;
            gradingScale[6] = ctrC.Value;
            gradingScale[7] = ctrCminus.Value;
            gradingScale[8] = ctrDplus.Value;
            gradingScale[9] = ctrD.Value;
            gradingScale[10] = ctrDminus.Value;          
            Close();
        }

        private void btnCloseGradingScale_Click(object sender, EventArgs e) {
            //return to add class page
            Close();
        }

    }
}
