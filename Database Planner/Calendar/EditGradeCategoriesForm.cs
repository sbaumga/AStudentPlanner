using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using MySql.Data.MySqlClient;

namespace Planner
{
    public partial class EditGradeCategoriesForm : Form
    {
        private int currentClassId = -1;

        //add grade category information
        private List<string> category = new List<string>();
        private List<double> percentage = new List<double>();
        private List<string> type = new List<string>();

        //indicates how many rows are currently visible
        private int locationCounter = 1;

        //indicate which row will result in inserts into the database (all previous rows will be updates)
        private int locationToInsert = -1;

        public EditGradeCategoriesForm(int currentClass)
        {
            InitializeComponent();
            currentClassId = currentClass;

            //adds a default set of categories that user can choose from
            for (int i = 0; i < 15; i++) {
                ComboBox cb = (ComboBox)this.Controls["cbCategory" + i];
                cb.Items.Clear();
                cb.Items.AddRange(new string[] { "Homework", "Quizzes", "Tests", "Projects", "Labs", "Midterm", "Final" });
            }

            int currentCount = 0;

            //get a list of all the current category information for the selected class
            MySqlDataReader categories = Database.executeQuery("SELECT Type, Percentage, GradingMethod FROM GradeCategory WHERE ClassID = '" + currentClassId + "';");
            while (categories.Read() == true) {
                //populate current line with retrieved information
                
                //get category information
                this.Controls["cbCategory" + currentCount].Text = categories.GetString(0);
                category.Add(categories.GetString(0));

                //get percentage information
                this.Controls["txtPercentage" + currentCount].Text = categories.GetDouble(1).ToString();
                percentage.Add(categories.GetDouble(1));

                //determine what grading method was used and update row
                if (categories.GetString(2).Equals("Points")) {
                    RadioButton points = (RadioButton) this.Controls["gradingMethod" + currentCount + "Panel"].Controls["rbPoints" + currentCount];
                    points.Checked = true;
                    type.Add("Points");
                }
                else {
                    RadioButton perc = (RadioButton) this.Controls["gradingMethod" + currentCount + "Panel"].Controls["rbPercentage" + currentCount];
                    perc.Checked = true;
                    type.Add("Percentage");
                }

                currentCount++;
                //if the next line is not already visible, then add the line
                if (currentCount > locationCounter) {
                    lnkAddCategory_LinkClicked(null, null);
                }
            }
            categories.Close();

            //set the location of where to insert (everything before this point is a database update)
            locationToInsert = currentCount;
        }

        //event to add an additional line on the edit category page
        private void lnkAddCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if (locationCounter > 14) {
                Util.displayError("Too Many Categories. A maximum of 15 categories are currently only supported.", "Too Many Categories");
                return;
            }

            //show the next line (set the visible property to true)
            this.Controls["cbCategory" + locationCounter].Visible = true;
            this.Controls["txtPercentage" + locationCounter].Visible = true;
            this.Controls["gradingMethod" + locationCounter + "Panel"].Visible = true;
            this.Controls["btnDeleteCategory" + locationCounter].Visible = true;
            locationCounter++;

            //move buttons down
            lnkAddCategory.Location = new Point(lnkAddCategory.Location.X, lnkAddCategory.Location.Y + 27);
            btnCategorySave.Location = new Point(btnCategorySave.Location.X, btnCategorySave.Location.Y + 27);
            btnCategoryClose.Location = new Point(btnCategoryClose.Location.X, btnCategoryClose.Location.Y + 27);

            //resize form
            this.Height += 27;
        }

        //method that saves all the currently entered categories and associated information
        private void btnCategorySave_Click(object sender, EventArgs e) {
            double sum = 0;

            //check if user has entered one but not both of the required fields (not the use of
            // XOR; two empty fields are allowed and this entry is simply ignored)
            for (int i = 0; i < locationCounter; i++) {
                if (this.Controls["cbCategory" + i].Text.Equals("") == true ^
                   this.Controls["txtPercentage" + i].Text.Equals("") == true) {
                    Util.displayRequiredFieldsError(new string[] { "Category", "Percentage" });
                    return;
                }
            }

            //ensure no duplicates exist
            if (duplicateTypeCheck() == false) {
                Util.displayError("Two categories cannot have the same name", "Duplicate Grade Categories");
                return;
            }

            //calculate sum
            for (int i = 0; i < locationCounter; i++) {
                if (this.Controls["cbCategory" + i].Text.Equals("") == false &&
                    this.Controls["txtPercentage" + i].Text.Equals("") == false) {

                    double categoryPercentage;
                    if (double.TryParse(this.Controls["txtPercentage" + i].Text, out categoryPercentage) == false) {
                        Util.displayError("Each category percentage must be a valid decimal", "Invalid Category Percentage");
                        return;
                    }

                    //store running sum
                    sum += categoryPercentage;
                }
            }

            //check if sum of categories adds up to 100%
            if (Math.Abs(100 - sum) > 0.001) {
                Util.displayError("Sum of Category Percentages do not add up to 100", "Error");
                return;
            }

            Database.beginTransaction();

            //perform update on existing grades
            for (int i = 0; i < locationToInsert; i++) {
                if (this.Controls["cbCategory" + i].Text.Equals("") == true &&
                   this.Controls["txtPercentage" + i].Text.Equals("") == true) {
                    continue;
                }

                //get currently entered information for the specified line
                string gradeType = Util.quote(this.Controls["cbCategory" + i].Text);
                double percentage = double.Parse(this.Controls["txtPercentage" + i].Text);
                string method = "Percentage";
                RadioButton points = (RadioButton)this.Controls["gradingMethod" + i + "Panel"].Controls["rbPoints" + i];
                if (points.Checked == true) {
                    method = "Points";
                }

                //modify database
                Database.modifyDatabase("UPDATE GradeCategory SET Type = " + gradeType + ", Percentage = '" + percentage + "', GradingMethod = '"
                    + method + "' WHERE ClassID = '" + currentClassId + "' AND Type = '" + category[i] + "';");

            }

            //insert new grade categories
            for (int i = locationToInsert; i < locationCounter; i++) {
                if (this.Controls["cbCategory" + i].Text.Equals("") == true &&
                   this.Controls["txtPercentage" + i].Text.Equals("") == true) {
                    continue;
                }

                //get currently entered information for the specified line
                string category = Util.quote(this.Controls["cbCategory" + i].Text);
                double percentage = double.Parse(this.Controls["txtPercentage" + i].Text);
                string method = "Percentage";
                RadioButton points = (RadioButton)this.Controls["gradingMethod" + i + "Panel"].Controls["rbPoints" + i];
                if (points.Checked == true) {
                    method = "Points";
                }

                //add new values into database
                Database.modifyDatabase("INSERT INTO GradeCategory VALUES(" + category + ", '" + currentClassId + "', '" +
                    percentage + "', null, '" + method + "');");
            }

            Database.commit();

            //return to edit class tab
            Close();
        }

        //deletes a single category from the database (if currently present)
        private void deleteCategoryLine(int lineNum) {

            //show confirmation message
            DialogResult reallyDelete = MessageBox.Show("Are you sure you really want to delete this grade category?", "Really Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reallyDelete == DialogResult.Yes) {

                //we need to remove from database
                if (lineNum < locationToInsert) {
                    //delete from database
                    Database.modifyDatabase("DELETE FROM GradeCategory WHERE ClassID = '" + currentClassId + "' AND Type = '" + category[lineNum] + "';");
                    
                    //delete from lists
                    category.RemoveAt(lineNum);
                    percentage.RemoveAt(lineNum);
                    type.RemoveAt(lineNum);
                    
                    //decrement location to insert (there the last item that requires an update is now one less)
                    locationToInsert--;
                }

                //shift all the information below the deleted line up one line
                for (int i = lineNum; i < locationCounter - 1; i++) {
                    this.Controls["cbCategory" + i].Text = this.Controls["cbCategory" + (i + 1)].Text;
                    this.Controls["txtPercentage" + i].Text = this.Controls["txtPercentage" + (i + 1)].Text;
                    RadioButton next = (RadioButton)this.Controls["gradingMethod" + (i + 1) + "Panel"].Controls["rbPoints" + (i + 1)];
                    RadioButton curr = (RadioButton)this.Controls["gradingMethod" + i + "Panel"].Controls["rbPoints" + i];
                    if (next.Checked == true && curr.Checked == false) {
                        curr.Checked = true;
                    }
                    if (next.Checked == false && curr.Checked == true) {
                        curr = (RadioButton)this.Controls["gradingMethod" + i + "Panel"].Controls["rbPercentage" + i];
                        curr.Checked = true;
                    }
                }
                //set last item to defaults
                this.Controls["cbCategory" + (locationCounter - 1)].Text = "";
                this.Controls["txtPercentage" + (locationCounter - 1)].Text = "";
                RadioButton last = (RadioButton)this.Controls["gradingMethod" + (locationCounter - 1) + "Panel"].Controls["rbPoints" + (locationCounter - 1)];
                last.Checked = true;
            }
            
        }

        //checks for whether duplicate grading categories exist, returning true if there are
        //  no duplicates, and false if there are duplicates
        private bool duplicateTypeCheck(){
            HashSet<String> types = new HashSet<string>();
            for (int i = 0; i < locationCounter; i++) {
                String text = this.Controls["cbCategory" + i].Text;
                if (text.Equals("") == false) {
                    if (types.Add(text) == false) {
                        return false;
                    }
                }
            }
            return true;
        }

        //prevent the user from closing without saving if the sum no longer equals 100
        //  (such as after deleting an item)
        private void btnCategoryClose_Click(object sender, EventArgs e) {
            //calculate sum
            double sum = 0;
            foreach(double val in percentage) {
                sum += val;
            }

            //check if sum equals 100
            if (Math.Abs(100 - sum) > 0.001) {
                Util.displayError("After deleting an item, the sum of category percentages no longer add up to 100", "Error");
                return;
            }
            //return to class tab
            Close();
        }


        //the following are event handlers for each of the delete buttons for deleting
        //  one of the grade categories and associated information

        private void btnDeleteCategory0_Click(object sender, EventArgs e) {
            deleteCategoryLine(0);
        }

        private void btnDeleteCategory1_Click(object sender, EventArgs e) {
            deleteCategoryLine(1);
        }
        
        private void btnDeleteCategory2_Click(object sender, EventArgs e) {
            deleteCategoryLine(2);
        }

        private void btnDeleteCategory3_Click(object sender, EventArgs e) {
            deleteCategoryLine(3);
        }

        private void btnDeleteCategory4_Click(object sender, EventArgs e) {
            deleteCategoryLine(4);
        }

        private void btnDeleteCategory5_Click(object sender, EventArgs e) {
            deleteCategoryLine(5);
        }

        private void btnDeleteCategory6_Click(object sender, EventArgs e) {
            deleteCategoryLine(6);
        }

        private void btnDeleteCategory7_Click(object sender, EventArgs e) {
            deleteCategoryLine(7);
        }

        private void btnDeleteCategory8_Click(object sender, EventArgs e) {
            deleteCategoryLine(8);
        }

        private void btnDeleteCategory9_Click(object sender, EventArgs e) {
            deleteCategoryLine(9);
        }

        private void btnDeleteCategory10_Click(object sender, EventArgs e) {
            deleteCategoryLine(10);
        }

        private void btnDeleteCategory11_Click(object sender, EventArgs e) {
            deleteCategoryLine(11);
        }

        private void btnDeleteCategory12_Click(object sender, EventArgs e) {
            deleteCategoryLine(12);
        }

        private void btnDeleteCategory13_Click(object sender, EventArgs e) {
            deleteCategoryLine(13);
        }

        private void btnDeleteCategory14_Click(object sender, EventArgs e) {
            deleteCategoryLine(14);
        }

    }
}
