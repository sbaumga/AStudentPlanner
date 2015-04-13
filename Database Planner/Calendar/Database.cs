﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Security;
using MySql.Data.MySqlClient;

namespace Planner {
    class Database {

        /* Old stuff that I'm ignoring entirely.
        public static String DB_PATH = Util.DIR_PATH + "Planner.s3db";

        //stores connection and transaction details
        private static SQLiteConnection connection;
        private static SQLiteTransaction transaction;
        */
        //store whether database is currently encrypted
        public static bool encrypted = false;
        
        //needed since database class can be accessed and called from multiple threads
        private static Object threadLock = new Object();
        
        private static MySqlConnection connection;
        private static MySqlTransaction transaction;

        //checks if the database exists, returning true if it does
        public static bool exists() {
            //return (File.Exists(DB_PATH));

            string connStr = "server=localhost;user=root;";
            connection = new MySqlConnection(connStr);
            MySqlCommand cmd;
            bool bRet = false;

            try
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = 'Planner'";
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                bRet = reader.HasRows;

            }
            catch (Exception ex) { return false; }

            return bRet;
        }

        //command to create a new database
        public static bool createDatabase() {
            string connStr = "server=localhost;user=root;";
            MySqlCommand cmd;

            lock (threadLock)
            {
                try
                {
                    connection = new MySqlConnection(connStr);
                    connection.Open();
                    cmd = connection.CreateCommand();
                    cmd.CommandText = "CREATE DATABASE IF NOT EXISTS `Planner`;";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex) { }

                connStr = "server=localhost;database=Planner;user=root;";


                try
                {
                    connection = new MySqlConnection(connStr);
                    connection.Open();
                    cmd = connection.CreateCommand();
                    cmd.CommandText = "CREATE TABLE Professor (" +
                                "ProfID     INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
                                "Title      TEXT," +
                                "FirstName  TEXT," +
                                "LastName   TEXT NOT NULL," +
                                "Email      TEXT UNIQUE ON CONFLICT FAIL," +
                                "OfficeLocation TEXT" +
                            ");" +
                            " " +
                            "CREATE TABLE Phone (" +
                                "PhoneNumber    TEXT    NOT NULL," +
                                "ProfID         INTEGER NOT NULL," +
                                "Type           TEXT," +
                                "PRIMARY KEY (PhoneNumber,ProfID)," +
                                "FOREIGN KEY (ProfID) REFERENCES Professor(ProfID) ON UPDATE CASCADE ON DELETE CASCADE" +
                            ");" +
                            " " +
                            "CREATE TABLE OfficeHour (" +
                                "OfficeHoursID  INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
                                "OnMonday   BOOLEAN DEFAULT 'FALSE' NOT NULL," +
                                "OnTuesday  BOOLEAN DEFAULT 'FALSE' NOT NULL," +
                                "OnWednesday BOOLEAN DEFAULT 'FALSE' NOT NULL," +
                                "OnThursday BOOLEAN DEFAULT 'FALSE' NOT NULL," +
                                "OnFriday   BOOLEAN DEFAULT 'FALSE' NOT NULL," +
                                "StartTime      TIME    NOT NULL," +
                                "EndTime        TIME    NOT NULL    CHECK(EndTime > StartTime)," +
                                "ProfID         INTEGER," +
                                "UNIQUE(OnMonday, OnTuesday, OnWednesday, OnThursday, OnFriday, StartTime, EndTime, ProfID) ON CONFLICT REPLACE," +
                                "FOREIGN KEY(ProfID) REFERENCES Professor(ProfID) ON UPDATE CASCADE ON DELETE CASCADE" +
                            ");" +
                            " " +
                            "CREATE TABLE Semester(" +
                                "SemesterID INTEGER NOT NULL PRIMARY KEY, " +
                                "Name       TEXT    NOT NULL," +
                                "StartDate  DATE    NOT NULL," +
                                "EndDate    DATE    NOT NULL    CHECK(EndDate >= StartDate)" +
                            ");" +
                            " " +
                            "CREATE TABLE Class (" +
                                "ClassID    INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," +
                                "Name       TEXT    NOT NULL," +
                                "Credits    FLOAT NOT NULL    CHECK(Credits >= 0.0)," +
                                "OnMonday   BOOLEAN DEFAULT 'FALSE' NOT NULL," +
                                "OnTuesday  BOOLEAN DEFAULT 'FALSE' NOT NULL," +
                                "OnWednesday BOOLEAN DEFAULT 'FALSE' NOT NULL," +
                                "OnThursday BOOLEAN DEFAULT 'FALSE' NOT NULL," +
                                "OnFriday   BOOLEAN DEFAULT 'FALSE' NOT NULL," +
                                "SemesterID INTEGER," +
                                "StartTime  TIME    NOT NULL," +
                                "EndTime    TIME    NOT NULL    CHECK(EndTime >= StartTime)," +
                                "Location   TEXT," +
                                "CurrentGrade FLOAT     CHECK(CurrentGrade >= 0.0), " +
                                "CurrentLetterGrade TEXT," +
                                "FinalLetterGrade TEXT," +
                                "UNIQUE(StartTime, EndTime, OnMonday, OnTuesday, OnWednesday, OnThursday, OnFriday, Location)," +
                                "FOREIGN KEY(CurrentLetterGrade) REFERENCES GradeLetterPoint(GradeLetter) ON DELETE SET NULL," +
                                "FOREIGN KEY(FinalLetterGrade) REFERENCES GradeLetterPoint(GradeLetter) ON DELETE SET NULL," +
                                "FOREIGN KEY(SemesterID) REFERENCES Semester(SemesterID) ON DELETE SET NULL" +
                            ");" +
                            "  " +
                            "CREATE TABLE ClassProfessor (" +
                                "ProfID	INTEGER NOT NULL," +
                                "ClassID INTEGER NOT NULL," +
                                "PRIMARY KEY(ProfID, ClassID)," +
                                "FOREIGN KEY (ProfID) REFERENCES Professor(ProfID) ON UPDATE CASCADE ON DELETE CASCADE," +
                                "FOREIGN KEY (ClassID) REFERENCES Class(ClassID) ON UPDATE CASCADE ON DELETE CASCADE" +
                            ");" +
                            "  " +
                            "CREATE TABLE Event (" +
                                "EventID     INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT," +
                                "Title          TEXT  NOT NULL," +
                                "Description    TEXT," +
                                "Location       TEXT," +
                                "StartDateTime  DATETIME NOT NULL," +
                                "EndDateTime    DATETIME NOT NULL   CHECK(EndDateTime >= StartDateTime)," +
                                "IsAllDay         BOOLEAN DEFAULT 'FALSE' NOT NULL," +
                                "GoogleEventID  TEXT" +
                        ");" +
                        "  " +
                        "CREATE TABLE GradedAssignment (" +
                            "EventID    INTEGER NOT NULL PRIMARY KEY," +
                            "AssignmentName TEXT    NOT NULL," +
                            "Grade           FLOAT    CHECK(Grade >= 0.0)," +
                            "GradeTotalWorth FLOAT    CHECK(GradeTotalWorth >= 0.0)," +
                            "ClassID        INTEGER NOT NULL," +
                            "Type           TEXT    NOT NULL," +
                            "FOREIGN KEY (EventID) REFERENCES Event(EventID) ON UPDATE CASCADE ON DELETE CASCADE," +
                            "FOREIGN KEY (Type, ClassID) REFERENCES GradeCategory(Type, ClassID) ON UPDATE CASCADE ON DELETE CASCADE" +
                        ");" +
                        "  " +
                        "CREATE TABLE GradeCategory (" +
                            "Type       TEXT     NOT NULL," +
                            "ClassID    INTEGER  NOT NULL," +
                            "Percentage FLOAT  DEFAULT '0.00' NOT NULL   CHECK(Percentage BETWEEN 0.0 AND 100.0)," +
                            "CategoryGrade FLOAT  CHECK(CategoryGrade >= 0.0)," +
                            "GradingMethod TEXT DEFAULT 'Points' NOT NULL," +
                            "PRIMARY KEY(Type, ClassID)," +
                            "FOREIGN KEY(ClassID) REFERENCES Class(ClassID) ON UPDATE CASCADE ON DELETE CASCADE" +
                        ");" +

                        " " +
                        "CREATE TABLE GradingScaleValue (" +
                            "GradeLetter		TEXT NOT NULL," +
                            "ClassID			INTEGER NOT NULL," +
                            "BottomPercentage	FLOAT NOT NULL    CHECK(BottomPercentage BETWEEN 0.0 AND 100.0)," +
                            "PRIMARY KEY(GradeLetter,ClassID)," +
                            "UNIQUE(ClassID, BottomPercentage) ON CONFLICT REPLACE," +
                            "FOREIGN KEY(GradeLetter) REFERENCES GradeLetterPoint(GradeLetter) ON UPDATE CASCADE ON DELETE CASCADE," +
                            "FOREIGN KEY(ClassID) REFERENCES Class(ClassID) ON UPDATE CASCADE ON DELETE CASCADE" +
                        ");" +
                        " " +
                        "CREATE TABLE GradeLetterPoint (" +
                            "GradeLetter	TEXT PRIMARY KEY NOT NULL," +
                            "Point			FLOAT UNIQUE NOT NULL    CHECK(Point >= 0.0)" +
                        ");" +
                        "  " +
                        "INSERT INTO GradeLetterPoint VALUES ('A', '4.0');" +
                        "INSERT INTO GradeLetterPoint VALUES ('A-', '3.70');" +
                        "INSERT INTO GradeLetterPoint VALUES ('B+', '3.30');" +
                        "INSERT INTO GradeLetterPoint VALUES ('B', '3.00');" +
                        "INSERT INTO GradeLetterPoint VALUES ('B-', '2.70');" +
                        "INSERT INTO GradeLetterPoint VALUES ('C+', '2.30');" +
                        "INSERT INTO GradeLetterPoint VALUES ('C', '2.00');" +
                        "INSERT INTO GradeLetterPoint VALUES ('C-', '1.70');" +
                        "INSERT INTO GradeLetterPoint VALUES ('D+', '1.30');" +
                        "INSERT INTO GradeLetterPoint VALUES ('D', '1.00');" +
                        "INSERT INTO GradeLetterPoint VALUES ('D-', '0.70');" +
                        "INSERT INTO GradeLetterPoint VALUES ('F', '0.00');" +
                        "  " +
                        "CREATE TRIGGER [Update_Grade_Category] " +
                        "AFTER UPDATE OF [Grade] " +
                        "ON [GradedAssignment] " +
                        "FOR EACH ROW " +
                        "BEGIN " +
                        "UPDATE GradeCategory SET CategoryGrade = (SELECT SUM(Grade) / SUM(GradeTotalWorth) * 100 FROM GradedAssignment WHERE Type = OLD.Type AND ClassID = OLD.ClassID AND Grade IS NOT NULL) WHERE Type = OLD.Type AND ClassID = OLD.ClassID; " +
                        "UPDATE GradeCategory SET CategoryGrade = (SELECT SUM(Grade) / SUM(GradeTotalWorth) * 100 FROM GradedAssignment WHERE Type = NEW.Type AND ClassID = NEW.ClassID AND Grade IS NOT NULL) WHERE Type = NEW.Type AND ClassID = NEW.ClassID; " +
                        "END;" +
                        "  " +
                        "CREATE TRIGGER [Insert_Grade_Category] " +
                        "AFTER INSERT " +
                        "ON [GradedAssignment] " +
                        "FOR EACH ROW " +
                        "BEGIN " +
                        "UPDATE GradeCategory SET CategoryGrade = (SELECT SUM(Grade) / SUM(GradeTotalWorth) * 100 FROM GradedAssignment WHERE Type = NEW.Type AND ClassID = NEW.ClassID AND Grade IS NOT NULL) WHERE Type = NEW.Type AND ClassID = NEW.ClassID; " +
                        "END;" +
                        "  " +
                        "CREATE TRIGGER [Delete_Grade_Category] " +
                        "AFTER DELETE " +
                        "ON [GradedAssignment] " +
                        "FOR EACH ROW " +
                        "BEGIN " +
                        "UPDATE GradeCategory SET CategoryGrade = (SELECT SUM(Grade) / SUM(GradeTotalWorth) * 100 FROM GradedAssignment WHERE Type = OLD.Type AND ClassID = OLD.ClassID AND Grade IS NOT NULL) WHERE Type = OLD.Type AND ClassID = OLD.ClassID; " +
                        "END;" +
                        "  " +
                        "CREATE TRIGGER [Update_Current_Grade] " +
                        "AFTER UPDATE OF [CategoryGrade] " +
                        "ON [GradeCategory] " +
                        "FOR EACH ROW " +
                        "BEGIN " +
                        "UPDATE Class SET CurrentGrade = (SELECT SUM(CategoryGrade * Percentage) / SUM(Percentage) FROM GradeCategory  WHERE ClassID = OLD.ClassID AND CategoryGrade IS NOT NULL) WHERE ClassID = OLD.ClassID; " +
                        "END;" +
                        "  " +
                        "CREATE TRIGGER [Insert_Current_Grade] " +
                        "AFTER INSERT " +
                        "ON [GradeCategory] " +
                        "FOR EACH ROW " +
                        "BEGIN " +
                        "UPDATE Class SET CurrentGrade = (SELECT SUM(CategoryGrade * Percentage) / SUM(Percentage) FROM GradeCategory  WHERE ClassID = NEW.ClassID AND CategoryGrade IS NOT NULL) WHERE ClassID = NEW.ClassID; " +
                        "END;" +
                        "  " +
                        "CREATE TRIGGER [Delete_Current_Grade] " +
                        "AFTER DELETE " +
                        "ON [GradeCategory] " +
                        "FOR EACH ROW " +
                        "BEGIN " +
                        "UPDATE Class SET CurrentGrade = (SELECT SUM(CategoryGrade * Percentage) / SUM(Percentage) FROM GradeCategory  WHERE ClassID = OLD.ClassID AND CategoryGrade IS NOT NULL) WHERE ClassID = OLD.ClassID; " +
                        "END;" +
                        "  " +
                        "CREATE TRIGGER [Update_Current_Letter_Grade] " +
                        "AFTER UPDATE OF [CurrentGrade] " +
                        "ON [Class] " +
                        "FOR EACH ROW " +
                        "BEGIN " +
                        "UPDATE Class SET CurrentLetterGrade = (SELECT GradeLetter FROM GradingScaleValue WHERE NEW.CurrentGrade >= BottomPercentage AND ClassID = NEW.ClassID ORDER BY BottomPercentage DESC) WHERE ClassID = NEW.ClassID;" +
                        "END;" +
                        "  " +
                        "CREATE VIEW  ClassProfessorView AS SELECT * FROM Class LEFT NATURAL JOIN ClassProfessor LEFT NATURAL JOIN Professor;" +
                        "CREATE VIEW FullEventView AS SELECT * FROM Event e LEFT OUTER JOIN GradedAssignment g ON e.EventID == g.EventID;" +
                        "  " +
                        "CREATE INDEX EventStartDateIndex ON Event(StartDateTime);" +
                        "CREATE INDEX EventEndDateIndex ON Event(EndDateTime);";

                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        //initiates the the beginning of the transaction (any subsequent database operations
        //  will be rolled back if any error occurs before the changes are committed)
        public static void beginTransaction() {
            lock (threadLock) {
                try {
                    transaction = connection.BeginTransaction();
                }
                catch (MySqlException error) {
                    Util.logError(error.Message);
                }
            }
        }

        //aborts current uncommitted changes
        public static void abort() {
            lock (threadLock) {
                try {
                    if (transaction != null && transaction.Connection != null) {
                        transaction.Rollback();
                    }
                }
                catch (MySqlException error) {
                    Util.logError(error.Message);
                }
            }
        }

        //commits all changes to the database, ending a transaction
        public static void commit() {
            lock (threadLock) {
                try {
                    transaction.Commit();
                }
                catch (MySqlException error) {
                    Util.logError(error.Message);
                }
            }
        }

        //converts date from a DateTime value into the date format for SQLite
        public static string getDate(DateTime dt) {
            return dt.Year + "-" + dt.Month.ToString().PadLeft(2, '0') + "-" + dt.Day.ToString().PadLeft(2, '0');
        }

        //converts from a DateTime value into the date time format for SQLite
        public static string getDateTime(DateTime dt) {
            return getDate(dt) + " " + dt.TimeOfDay;
        }

        //NOTE: We do not need this.
        //closes the connection
        public static void close() {
            lock (threadLock) {
                try {
                    connection.Close();
                }
                catch (MySqlException error) {
                    Util.logError(error.Message);
                }
            }
        }

        //modifies the database (INSERT, UPDATE, DELETE) and therefore only
        //  returns true or false if the query was successful
        public static bool modifyDatabase(String query) {
            string connStr = "server=localhost;database=Planner;user=root;";

            lock (threadLock)
            {
                try
                {
                    connection = new MySqlConnection(connStr);
                    MySqlCommand cmd;
                    connection.Open();
                    cmd = connection.CreateCommand();
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            
        }

        //get id of most recently inserted row
        public static object getInsertedID() {
            return executeScalarQuery("SELECT last_insert_rowid()");
        }

        //check whether an attribute with a certian value exists in the table
        public static bool attributeExists(string attributeValue, string table) {
            MySqlDataReader reader = executeQuery("SELECT * FROM " + table + " WHERE " + attributeValue + ";");
            bool itemExists = false;
            if (reader.HasRows) {
                itemExists = true;
            }
            reader.Close();
            return itemExists;
        }


        //executes a query that returns a single object
        public static object executeScalarQuery(String query) {
            string connStr = "server=localhost;database=Planner;user=root;";
            

            lock (threadLock)
                {
                try
                {
                    connection = new MySqlConnection(connStr);
                    MySqlCommand cmd;
                    connection.Open();
                    cmd = connection.CreateCommand();
                    cmd.CommandText = query;
                    object retObj = cmd.ExecuteScalar();
                    connection.Close();
                    return retObj;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        //executes a query that returns multiple results in the 
        //form of a data reader
        public static MySqlDataReader executeQuery(String query) {
            string connStr = "server=localhost;database=Planner;user=root;";

            lock (threadLock)
            {
                try
                {
                    connection = new MySqlConnection(connStr);
                    MySqlCommand cmd;
                    connection.Open();
                    cmd = connection.CreateCommand();
                    cmd.CommandText = query;
                    MySqlDataReader retObj = cmd.ExecuteReader();
                    connection.Close();
                    return retObj;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

    }
}
