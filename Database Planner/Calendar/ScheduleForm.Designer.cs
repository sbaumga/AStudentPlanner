namespace Planner {
    partial class ScheduleForm {
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
            this.scheduleView = new Calendar.DayView();
            this.SuspendLayout();
            // 
            // scheduleView
            // 
            drawTool1.DayView = this.scheduleView;
            this.scheduleView.ActiveTool = drawTool1;
            this.scheduleView.AllowInplaceEditing = false;
            this.scheduleView.AllowNew = false;
            this.scheduleView.AmPmDisplay = true;
            this.scheduleView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.scheduleView.AppointmentHeightMode = Calendar.AppHeightDrawMode.EndHalfHourBlocksAll;
            this.scheduleView.DaysToShow = 5;
            this.scheduleView.DrawAllAppBorder = true;
            this.scheduleView.EnableDurationDisplay = false;
            this.scheduleView.EnableRoundedCorners = false;
            this.scheduleView.EnableShadows = true;
            this.scheduleView.EnableTimeIndicator = true;
            this.scheduleView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.scheduleView.Location = new System.Drawing.Point(7, 12);
            this.scheduleView.MinHalfHourApp = false;
            this.scheduleView.Name = "scheduleView";
            this.scheduleView.SelectionEnd = new System.DateTime(((long)(0)));
            this.scheduleView.SelectionStart = new System.DateTime(((long)(0)));
            this.scheduleView.Size = new System.Drawing.Size(765, 538);
            this.scheduleView.StartDate = new System.DateTime(2011, 8, 1, 0, 0, 0, 0);
            this.scheduleView.TabIndex = 34;
            this.scheduleView.Text = "dayView1";
            this.scheduleView.WorkingHourEnd = 17;
            this.scheduleView.WorkingMinuteEnd = 0;
            this.scheduleView.WorkingMinuteStart = 0;
            this.scheduleView.OnResolveAppointments += new System.EventHandler<Calendar.ResolveAppointmentsEventArgs>(this.scheduleView_OnResolveAppointments);
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.scheduleView);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Current Schedule";
            this.Load += new System.EventHandler(this.ScheduleForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Calendar.DayView scheduleView;
    }
}