namespace Planner {
    partial class OfficeHoursForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            Calendar.DrawTool drawTool1 = new Calendar.DrawTool();
            this.officeHoursView = new Calendar.DayView();
            this.SuspendLayout();
            // 
            // officeHoursView
            // 
            drawTool1.DayView = this.officeHoursView;
            this.officeHoursView.ActiveTool = drawTool1;
            this.officeHoursView.AllowInplaceEditing = false;
            this.officeHoursView.AmPmDisplay = true;
            this.officeHoursView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.officeHoursView.AppointmentHeightMode = Calendar.AppHeightDrawMode.EndHalfHourBlocksAll;
            this.officeHoursView.DaysToShow = 5;
            this.officeHoursView.DrawAllAppBorder = true;
            this.officeHoursView.EnableDurationDisplay = false;
            this.officeHoursView.EnableRoundedCorners = false;
            this.officeHoursView.EnableShadows = true;
            this.officeHoursView.EnableTimeIndicator = true;
            this.officeHoursView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.officeHoursView.Location = new System.Drawing.Point(10, 12);
            this.officeHoursView.MinHalfHourApp = false;
            this.officeHoursView.Name = "officeHoursView";
            this.officeHoursView.SelectionEnd = new System.DateTime(((long)(0)));
            this.officeHoursView.SelectionStart = new System.DateTime(((long)(0)));
            this.officeHoursView.Size = new System.Drawing.Size(762, 538);
            this.officeHoursView.StartDate = new System.DateTime(2011, 8, 1, 0, 0, 0, 0);
            this.officeHoursView.TabIndex = 33;
            this.officeHoursView.Text = "dayView1";
            this.officeHoursView.WorkingHourEnd = 17;
            this.officeHoursView.WorkingMinuteEnd = 0;
            this.officeHoursView.WorkingMinuteStart = 0;
            this.officeHoursView.OnResolveAppointments += new System.EventHandler<Calendar.ResolveAppointmentsEventArgs>(this.officeHoursView_OnResolveAppointments);
            // 
            // OfficeHoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.officeHoursView);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "OfficeHoursForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Office Hours";
            this.Load += new System.EventHandler(this.OfficeHoursForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Calendar.DayView officeHoursView;

    }
}