using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Planner
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            try {
                Application.Run(new AssignmentPlanner());
            }
            catch (Exception ex) {
                Util.displayError("An unexpected error occured. Check the error log for more information.", "Unexpected Error");
                Util.logError(ex.Message);
            }
        }
    }
}