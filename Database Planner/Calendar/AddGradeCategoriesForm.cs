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
    public partial class AddGradeCategoriesForm : Form
    {

        //add grade category information
        private List<string> category = new List<string>();
        private List<double> percentage = new List<double>();
        private List<string> method = new List<string>();

        //counter used to determine how many grade category fields to show
        private int locationCounter = 4;

        public AddGradeCategoriesForm()
        {
            InitializeComponent();

            //adds a default set of categories that user can choose from
            for (int i = 0; i < 15; i++) {
                ComboBox cb = (ComboBox) this.Controls["cbCategory" + i];
                cb.Items.Clear();
                cb.Items.AddRange(new string[] { "Homework", "Quizzes", "Tests", "Projects", "Labs", "Midterm", "Final" });
            }
        }

        //allows other forms to get the recently added grade categories
        public List<string> getCategories() {
            return category;
        }

        //allows other forms to get the recently added grade percentages
        public List<double> getPercentages() {
            return percentage;
        }

        //allows other forms to get the recently added grade
        public List<string> getMethods() {
            return method;
        }

        private void btnCategoryClose_Click(object sender, EventArgs e) {           
            //return to add class page
            Close();
        }

        //checks for whether duplicate grading categories exist, returning true if there are
        //  no duplicates, and false if there are duplicates
        private bool duplicateTypeCheck() {
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

        //save the category information
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

            //ensure no duplicate grade categories exist
            if (duplicateTypeCheck() == false) {
                Util.displayError("Two categories cannot have the same name", "Duplicate Grade Categories");
                return;
            }
            
            //store added information
            for (int i = 0; i < locationCounter; i++) { 
                if (this.Controls["cbCategory" + i].Text.Equals("") == false &&
                    this.Controls["txtPercentage" + i].Text.Equals("") == false) { 
                    category.Add(this.Controls["cbCategory" + i].Text);

                    double categoryPercentage;
                    if (double.TryParse(this.Controls["txtPercentage" + i].Text, out categoryPercentage) == false) {
                        Util.displayError("Each category percentage must be a valid decimal", "Invalid Category Percentage");
                        
                        //clear all values currently in lists and return
                        category.Clear();
                        percentage.Clear();
                        method.Clear();
                        return;
                    }

                    //store running sum
                    sum += categoryPercentage;                  
                    percentage.Add(categoryPercentage);

                    //get the type of grading method to use
                    RadioButton point = (RadioButton) this.Controls["gradingMethod" + i + "Panel"].Controls["rbPoints" + i];
                    RadioButton perc = (RadioButton)this.Controls["gradingMethod" + i + "Panel"].Controls["rbPercentage" + i];
                    if (point.Checked == true) {
                        method.Add(point.Text);
                    }
                    else {
                        method.Add(perc.Text);
                    }
                }           
            }

            //ensure sum of all categories adds up to 100
            if (Math.Abs(100 - sum) > 0.001) {
                Util.displayError("Sum of Category Percentages do not add up to 100", "Error");
                
                //clear all values currently in lists and return
                category.Clear();
                percentage.Clear();
                method.Clear();
                return;
            }

            Close();
        }

        private void lnkAddCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            //currently a max of only 15 categories is supported
            if (locationCounter > 14) {
                Util.displayError("Too Many Categories. A maximum of 15 categories are currently only supported.", "Too Many Categories");
                return;
            }

            //set the hidden controls to visible for the next line
            this.Controls["cbCategory" + locationCounter].Visible = true;
            this.Controls["txtPercentage" + locationCounter].Visible = true;
            this.Controls["gradingMethod" + locationCounter + "Panel"].Visible = true;
            locationCounter++;

            //move buttons down
            lnkAddCategory.Location = new Point(lnkAddCategory.Location.X, lnkAddCategory.Location.Y + 27);
            btnCategorySave.Location = new Point(btnCategorySave.Location.X, btnCategorySave.Location.Y + 27);
            btnCategoryClose.Location = new Point(btnCategoryClose.Location.X, btnCategoryClose.Location.Y + 27);

            //resize form
            this.Height += 27;
        }
    }
}
