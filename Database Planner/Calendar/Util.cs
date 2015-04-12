using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Planner {
    class Util {

        public static string DIR_PATH = (Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "\\A+ Student Planner\\");

        //creates directory in my documents for error log and database so admin privileges are not required
        public static void createApplicationDirectoryIfNotExists() {
            if (Directory.Exists(DIR_PATH) == false) {
                Directory.CreateDirectory(DIR_PATH);
            }
        }

        //log an error to file
        public static void logError(String errorMessage){
            File.AppendAllText(DIR_PATH + "Error.log", "\r\n" + DateTime.Now + ": " + errorMessage + "\r\n");
        }

        //display an error in the forn of a pop up message box
        public static void displayError(string text, string title) {
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        //display an error indicating a single field is required
        public static void displayRequiredFieldsError(string requiredField) {
            MessageBox.Show("The following field is required: " + requiredField, "Missing Required Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //display an error indicating multiple fields is required
        public static void displayRequiredFieldsError(string[] requiredFields){
            StringBuilder required = new StringBuilder();
            foreach(string field in requiredFields){
                required.Append("\n     " + field);
            }
            MessageBox.Show("The following fields are required" + required.ToString(), "Missing Required Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //escapes an attribute value and then quotes the value if not null or else returns null
        public static string quote(string text) {
            if (text == null || text.Trim().Equals("") == true) {
                return "null";
            }
            return "'" + escape(text) + "'";
        }

        //replaces all single quotes with double quotes (to prevent SQL injection or just invalid queries)
        public static string escape(string text) {            
            return text.Replace("'", "''");
        }

        //add a list of professors to a given combo box, storing their ids in the specified list
        public static void addProfessors(ComboBox cbProfs, List<int> profId, bool showFirstName, bool showAllProfs, string classID, string semesterID) {
            //clear out any existing items before adding new items
            profId.Clear();
            cbProfs.Items.Clear();

            //determine whether to return first name attribute
            string attributes = "ProfID, Title, FirstName, LastName";
            if (showFirstName == false)
                attributes = "ProfID, Title, LastName";

            //if specifying a class id, create appropriate query
            string whereClause = "1 = 1";
            string fromClause = "";
            if (classID != null) {
                whereClause += " AND ClassID = '" + classID + "'";
                fromClause = " NATURAL JOIN ClassProfessor";
            }

            if (semesterID != null) {
                whereClause += " AND EXISTS(SELECT * FROM ClassProfessor NATURAL JOIN Class WHERE ProfID = p.ProfID AND SemesterID = '" + semesterID + "')";
            }

            //dynamically add professors to combo box, also storing ProfId and Email in separate lists
            MySqlDataReader profs = Database.executeQuery("SELECT " + attributes + " FROM Professor p" + fromClause + " WHERE " + whereClause + " ORDER BY LastName;");
            while (profs.Read() == true) {
                profId.Add(profs.GetInt32(0));
                
                //determine whether or not to add first name to combo box
                if(showFirstName == true)
                    cbProfs.Items.Add((profs.GetValue(1) + " " + profs.GetValue(2) + " " + profs.GetString(3)).Trim());
                else
                    cbProfs.Items.Add((profs.GetValue(1) + " " + profs.GetString(2)).Trim());
            }
            profs.Close();

            if (showAllProfs) {
                cbProfs.Items.Insert(0, "All Professors");
            }
        }

        //add all letter grades to the given combo box
        public static void addLetterGrades(ComboBox cbGrades) {
            cbGrades.Items.Clear();

            MySqlDataReader grades = Database.executeQuery("SELECT GradeLetter FROM GradeLetterPoint;");
            while (grades.Read() == true) {
                cbGrades.Items.Add(grades.GetString(0));
            }
            grades.Close();
        }
        

        //add the returned semesters to the given combo box, storing the semester ids in the specified list
        public static void addSemesters(ComboBox cbSemesters, List<int> semesterId, bool showAllSemesters) {
            semesterId.Clear();
            cbSemesters.Items.Clear();

            //get semester information
            MySqlDataReader semesters = Database.executeQuery("SELECT SemesterID, Name FROM Semester ORDER BY SemesterID;");
            while (semesters.Read() == true) {
                semesterId.Add(semesters.GetInt32(0));
                cbSemesters.Items.Add(semesters.GetString(1));
            }
            semesters.Close();

            if (showAllSemesters) {
                cbSemesters.Items.Insert(0, "All Semesters");
            }
        }

        //add the returned classes to the given combo box, storing the class ids in the specified list
        public static void addClasses(ComboBox cbClasses, List<int> classId, bool showOnlyCurrent, bool showAllClasses, string profID, string semesterID) {
            //clear any existing items
            classId.Clear();
            cbClasses.Items.Clear();
                     
            //if a professor is selected, create query to get detailed information
            string whereClause = "1 = 1";
            string fromClause = "";
           
            //determine whether to show only current classes
            if(showOnlyCurrent){
                whereClause += " AND FinalLetterGrade IS NULL";
            }
            
            //filter by professor
            if (profID != null) {
                whereClause += " AND ProfID = '" + profID + "'";
                fromClause = "NATURAL JOIN ClassProfessor ";
            }

            if (semesterID != null) {
                whereClause += " AND SemesterID = '" + semesterID + "'";
            }
              
            //get class information
            MySqlDataReader classes = Database.executeQuery("SELECT ClassID, Name FROM Class " + fromClause + " WHERE " + whereClause + " ORDER BY Name;");
            while (classes.Read() == true) {
                classId.Add(classes.GetInt32(0));
                cbClasses.Items.Add(classes.GetString(1));
            }
            classes.Close();

            if (showAllClasses) {
                cbClasses.Items.Insert(0, "All Classes");
            }
        }

        //add list of different assignment types to the given combo box using different optional filters
        public static void addTypes(ComboBox cbTypes, string classID, bool showCurrentClasses, string profID) {
            //make sure to remove all existing items
            cbTypes.Items.Clear();

            //build where clause based on whether the filters are specified 
            string whereClause = "";
            if (showCurrentClasses == true && classID == null) {
                if (profID == null)
                    whereClause = "WHERE ClassID IN (SELECT ClassID FROM Class WHERE FinalLetterGrade IS NULL)";
                else
                    whereClause = "WHERE ClassID IN (SELECT ClassID FROM Class NATURAL JOIN ClassProfessor WHERE FinalLetterGrade IS NULL AND ProfId = '" + profID + "')";

            }
            else if (classID != null) {
                whereClause = "WHERE ClassID = '"  + classID + "'";
            }
            

            //dynamically add class grade categories to combo box
            MySqlDataReader types = Database.executeQuery("SELECT Type FROM GradeCategory " + whereClause + " ORDER BY Type;");
            while (types.Read() == true) {
                if (cbTypes.Items.Contains(types.GetString(0)) == false) {
                    cbTypes.Items.Add(types.GetString(0));
                }
            }
            types.Close();
        }

        //get the letter grade in a class when providing a grade (percentage) and the class id
        public static string getLetterGrade(double grade, int classID) {
            object letterGrade = Database.executeScalarQuery("SELECT GradeLetter FROM GradingScaleValue WHERE " + grade + " >= BottomPercentage AND ClassID = '" + classID + "' ORDER BY BottomPercentage DESC;");
            return letterGrade.ToString();
        }

       
    }
}
