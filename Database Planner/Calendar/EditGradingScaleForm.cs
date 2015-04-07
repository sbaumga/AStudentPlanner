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
    public partial class EditGradingScaleForm : Form
    {
        private int currentClassId = -1;

        public EditGradingScaleForm(int currentClass)
        {
            InitializeComponent();
            currentClassId = currentClass;

            //get current grading scale for the current class
            SQLiteDataReader grades = Database.executeQuery("SELECT GradeLetter, BottomPercentage FROM GradingScaleValue WHERE ClassID = '" + currentClassId + "' AND GradeLetter != 'F';");
            while (grades.Read() == true) {
                String grade = "ctr" + grades.GetString(0);
                grade = grade.Replace("-", "Minus");
                grade = grade.Replace("+", "Plus");
                NumericUpDown gradeValue = (NumericUpDown) this.Controls[grade];
                gradeValue.Value = grades.GetDecimal(1);
            }
            grades.Close();
        }

        //return to edit class form without saving
        private void btnCloseGradingScale_Click(object sender, EventArgs e) {
            Close();
        }

        //save grading scale information
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
            
            //grading scale information
            decimal[] gradingScale = new decimal[11];
            string[] gradeLetter = {"A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-"};

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

            //insert grading scale
            for (int i = 0; i < gradingScale.Length; i++) {
                Database.modifyDatabase("UPDATE GradingScaleValue SET BottomPercentage = '" + gradingScale[i] + "' WHERE ClassID = '" + currentClassId + "' AND GradeLetter = '" + gradeLetter[i] + "';");
            }
        }
    }
}
