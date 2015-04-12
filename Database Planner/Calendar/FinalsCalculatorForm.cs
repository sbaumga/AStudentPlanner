using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Planner {
    public partial class FinalsCalculatorForm : Form {

        //used to store grade information associated with different classes
        private List<int> classId = new List<int>();
        private List<string> gradeLetter = new List<string>();
        private List<double> gradePerc = new List<double>();

        public FinalsCalculatorForm() {
            InitializeComponent();
        }

        //calculates needed grade on final in order to get desired grade in class
        private void btnCalculate_Click(object sender, EventArgs e) {
            double currentGrade, finalWorth, desiredGrade;
            lblGradeNeededValue.Text = "";

            //parse text, ensuring values can be parsed as doubles
            if (double.TryParse(txtCurrentGrade.Text, out currentGrade) == false) {
                Util.displayError("Current grade is not a valid number", "Invalid Number");
                return;
            }
            if (double.TryParse(txtFinalExamPercentage.Text, out finalWorth) == false) {
                Util.displayError("Final exam percentage is not a valid number", "Invalid Number");
                return;
            }
            if (double.TryParse(txtDesiredPercentage.Text, out desiredGrade) == false) {
                Util.displayError("Desired Percentage is not a valid number", "Invalid Number");
                return;
            }

            //check for invalid numbers
            if (currentGrade < 0) {
                Util.displayError("Current grade must be positive", "Error");
                return;
            }
            else if (finalWorth < 0 || finalWorth > 100) {
                Util.displayError("The final exam percentage must be between 0 and 100", "Error");
                return;
            }
            else if(desiredGrade < 0){
                Util.displayError("Desired grade must be positive", "Error");
                return;
            }

            //calculate needed greed
            double currentPoints = currentGrade * (1.00 - (finalWorth / 100));
            double gradeNeeded = (desiredGrade - currentPoints) / finalWorth;
            if (gradeNeeded < 0) {
                lblGradeNeededValue.Text = "< 0.0000%";
            }
            else {
                lblGradeNeededValue.Text = (Math.Round(gradeNeeded * 100, 4)).ToString("F3") + "%";
            }
            
        }

        private void FinalsCalculatorForm_Load(object sender, EventArgs e) {
            //add all current classes
            Util.addClasses(cbClass, classId, true, false, null, null);
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e) {

            txtDesiredPercentage.ResetText();
            txtCurrentGrade.ResetText();

            //get current grade in class
            object result = Database.executeScalarQuery("SELECT CurrentGrade FROM Class WHERE ClassID = '" + classId[cbClass.SelectedIndex] + "';");
            double currentGrade;
            if (Double.TryParse(result.ToString(), out currentGrade) == true) {
                txtCurrentGrade.Text = currentGrade.ToString("F4");
            }

            //try to get percentage that final is worth
            result = Database.executeScalarQuery("SELECT Percentage FROM GradeCategory WHERE (Type LIKE '%Final%') AND ClassID = '" + classId[cbClass.SelectedIndex] + "';");
            txtFinalExamPercentage.ResetText();
            
            //get final exam percentage worth
            txtFinalExamPercentage.Text = result + "";
            

            cbFinalLetterGrade.Items.Clear();

            //populate the desired grade percentage based on a selected latter grade
            MySqlDataReader grades = Database.executeQuery("SELECT GradeLetter, BottomPercentage FROM GradingScaleValue WHERE ClassID = '" + classId[cbClass.SelectedIndex] + "' ORDER BY BottomPercentage DESC");
            while (grades.Read() == true) {
                gradeLetter.Add(grades.GetString(0));
                cbFinalLetterGrade.Items.Add(grades.GetString(0));
                gradePerc.Add(grades.GetDouble(1));                   
            }
            grades.Close();
            cbFinalLetterGrade.Enabled = true;
        }

        //update the desired percentage
        private void cbFinalLetterGrade_SelectedIndexChanged(object sender, EventArgs e) {
            txtDesiredPercentage.Text = gradePerc[cbFinalLetterGrade.SelectedIndex].ToString();
        }
    }
}
