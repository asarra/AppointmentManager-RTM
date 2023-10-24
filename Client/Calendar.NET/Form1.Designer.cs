namespace Calendar.NET
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.calendar1 = new Calendar.NET.Calendar.NET.Calendar();
            this.createContactButton = new System.Windows.Forms.Button();
            this.newAppointmentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calendar1
            // 
            this.calendar1.AllowEditingEvents = false;
            this.calendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calendar1.BackColor = System.Drawing.Color.Transparent;
            this.calendar1.CalendarDate = new System.DateTime(2023, 10, 20, 13, 16, 0, 0);
            this.calendar1.CalendarView = CalendarViews.Month;
            this.calendar1.DateHeaderFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.calendar1.DayOfWeekFont = new System.Drawing.Font("Arial", 10F);
            this.calendar1.DaysFont = new System.Drawing.Font("Arial", 10F);
            this.calendar1.DayViewTimeFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.calendar1.DimDisabledEvents = true;
            this.calendar1.HighlightCurrentDay = true;
            this.calendar1.Location = new System.Drawing.Point(16, 15);
            this.calendar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calendar1.Name = "calendar1";
            this.calendar1.ShowArrowControls = true;
            this.calendar1.ShowDashedBorderOnDisabledEvents = true;
            this.calendar1.ShowDateInHeader = true;
            this.calendar1.ShowDisabledEvents = false;
            this.calendar1.ShowEventTooltips = true;
            this.calendar1.ShowTodayButton = true;
            this.calendar1.Size = new System.Drawing.Size(952, 612);
            this.calendar1.TabIndex = 0;
            this.calendar1.TodayFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            // 
            // createContactButton
            // 
            this.createContactButton.Location = new System.Drawing.Point(957, 116);
            this.createContactButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createContactButton.Name = "createContactButton";
            this.createContactButton.Size = new System.Drawing.Size(100, 58);
            this.createContactButton.TabIndex = 1;
            this.createContactButton.Text = "CreateContact";
            this.createContactButton.UseVisualStyleBackColor = true;
            this.createContactButton.Click += new System.EventHandler(this.createContactButton_Click);
            // 
            // newAppointmentButton
            // 
            this.newAppointmentButton.Location = new System.Drawing.Point(957, 219);
            this.newAppointmentButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newAppointmentButton.Name = "newAppointmentButton";
            this.newAppointmentButton.Size = new System.Drawing.Size(100, 28);
            this.newAppointmentButton.TabIndex = 2;
            this.newAppointmentButton.Text = "New Appointment";
            this.newAppointmentButton.UseVisualStyleBackColor = true;
            this.newAppointmentButton.Click += new System.EventHandler(this.newAppointmentButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1073, 652);
            this.Controls.Add(this.newAppointmentButton);
            this.Controls.Add(this.createContactButton);
            this.Controls.Add(this.calendar1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button createContactButton;
        private Calendar.NET.Calendar calendar1;
        private System.Windows.Forms.Button newAppointmentButton;
    }
}

