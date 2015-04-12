using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Diagnostics;
using System.Net;
using System.Threading;
using MySql.Data.MySqlClient;

namespace Planner {
    public partial class ContactForm : Form {

        //store the professors id and associated email address for populating destination email address
        private List<int> profId = new List<int>();
        private List<string> profEmail = new List<string>();
        private AssignmentPlanner parent;
        
        public ContactForm(AssignmentPlanner planner) {
            InitializeComponent();
            parent = planner;

            //populate user address from saved setting
            txtEmailFrom.Text = PlannerSettings.Default.EmailAddress;

            //dynamically add professors to combo box, also storing ProfId and Email in separate lists
            MySqlDataReader profs = Database.executeQuery("SELECT ProfID, Title, FirstName, LastName, Email FROM Professor ORDER BY LastName");           
            while (profs.Read() == true) {
                profId.Add(profs.GetInt32(0));
                cbSelectProfessor.Items.Add((profs.GetValue(1) + " " + profs.GetValue(2) + " " + profs.GetString(3)).Trim());
                profEmail.Add(profs.GetValue(4).ToString());
            }
            profs.Close();
        }

        private void button1_Click(object sender, EventArgs e) {
                
            //extract user entered information
            string MyFrom = txtEmailFrom.Text;
            string MyTo = txtEmailTo.Text;
            string MySubject = txtEmailSubject.Text;
            string MyMessage = txtEmailMessage.Text;

            //check if to open with default email client
            if (PlannerSettings.Default.UseDefaultClient == true) {
                //open in email client with entered fields already populated
                openMailClient(MyTo, MySubject, MyMessage);
            }
            else {
                string MySmtpMailServerName = PlannerSettings.Default.SmtpServer;
                //ex: "smtp.cedarville.edu" or "smtp.google.com"

                int MySmtpMailServerPort = PlannerSettings.Default.SmtpPort;
                //25 is the default for SMTP (587 for Google)

                SmtpClient MySmtpClient = new SmtpClient(MySmtpMailServerName, MySmtpMailServerPort);

                if (PlannerSettings.Default.RequireAuthentication == true) {
                    //get authentication details from user
                    AuthenticationForm credentials = new AuthenticationForm(PlannerSettings.Default.EmailAddress);
                    credentials.ShowDialog(this);

                    //configure credentials
                    MySmtpClient.EnableSsl = true;
                    MySmtpClient.Timeout = 3000;
                    MySmtpClient.UseDefaultCredentials = false;
                    MySmtpClient.Credentials = new NetworkCredential(credentials.username, credentials.password);
                    credentials.eraseCredentials();
                }

                //indicate message is in process of sending
                parent.updateStatus("Status: Message Sending...");

                //send message using new thread so it won't freeze main thread if there is an error
                String errorMessage = "";
                BackgroundWorker bw = new BackgroundWorker();
                bw.DoWork += delegate(object s, DoWorkEventArgs args){
                    try {
                        MySmtpClient.Send(MyFrom, MyTo, MySubject, MyMessage);
                    }
                    catch (Exception ex) {
                        errorMessage = ex.Message;
                    }
                };

                bw.RunWorkerCompleted += delegate(object s, RunWorkerCompletedEventArgs args) {
                    if (errorMessage.Equals("") == false) {
                        //display any errors with sending the message
                        Util.displayError(errorMessage, "Error");
                        parent.updateStatus("Status: Message Not Sent");
                        parent.Refresh();
                    }
                    else {
                        //update message status if message sent successfully
                            parent.updateStatus("Status: Message Successfully Sent");
                            parent.Refresh();
                    }
                };

                //start sending message
                bw.RunWorkerAsync();
            }
            
        }

        //opens the user's default mail client and populates the entered information
        public static void openMailClient(string address, string subject, string body) {

            StringBuilder mailto = new StringBuilder();
            mailto.Append("mailto:" + address);
            mailto.Append("?Subject=" + subject);
            mailto.Append("&Body=" + body);

            //execute the command (which will open the user's default mail client)
            Process.Start(mailto.ToString());
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void cbSelectProfessor_SelectedIndexChanged(object sender, EventArgs e) {
            //populate the email address to send to using the value stored in the database
            txtEmailTo.Text = profEmail[cbSelectProfessor.SelectedIndex];

            //reset form to original size
            this.Height = 425;
            emailPanel.Location = new Point(0, 99);
            
            //reset phone numbers label text
            lblPhoneNumbers.Text = "";

            //get the professors list of phone numbers and update the phone numbers section
            MySqlDataReader phoneNums = Database.executeQuery("SELECT Type, PhoneNumber FROM Phone WHERE ProfID = '" + profId[cbSelectProfessor.SelectedIndex] + "' ORDER BY Type");
            while (phoneNums.Read() == true) {
                if (phoneNums.GetString(0).Equals("") == false) {
                    lblPhoneNumbers.Text += phoneNums.GetString(0) + ": ";
                }
                lblPhoneNumbers.Text += phoneNums.GetString(1) + "\n";
                
                //resize form properly to fit additonal phone numbers
                this.Height += 10;
                emailPanel.Location = new Point(emailPanel.Location.X, emailPanel.Location.Y + 10);
            }

            //put focus on subject input text box (since all other information has already been entered)
            txtEmailSubject.Focus();
        }

    }
}
