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
            this.createContactButton = new System.Windows.Forms.Button();
            this.newAppointmentButton = new System.Windows.Forms.Button();
            this.showContactsButton = new System.Windows.Forms.Button();
            this.Contacts = new System.Windows.Forms.ListView();
            this.deleteContactButton = new System.Windows.Forms.Button();
            this.idContact = new System.Windows.Forms.NumericUpDown();
            this.calendar1 = new Calendar.NET.Calendar.NET.Calendar();
            this.showContact = new System.Windows.Forms.Button();
            this.labelid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.idContact)).BeginInit();
            this.SuspendLayout();
            // 
            // createContactButton
            // 
            this.createContactButton.Location = new System.Drawing.Point(818, 74);
            this.createContactButton.Name = "createContactButton";
            this.createContactButton.Size = new System.Drawing.Size(188, 30);
            this.createContactButton.TabIndex = 1;
            this.createContactButton.Text = "CreateContact";
            this.createContactButton.UseVisualStyleBackColor = true;
            this.createContactButton.Click += new System.EventHandler(this.createContactButton_Click);
            // 
            // newAppointmentButton
            // 
            this.newAppointmentButton.Location = new System.Drawing.Point(818, 187);
            this.newAppointmentButton.Name = "newAppointmentButton";
            this.newAppointmentButton.Size = new System.Drawing.Size(188, 41);
            this.newAppointmentButton.TabIndex = 2;
            this.newAppointmentButton.Text = "New Appointment";
            this.newAppointmentButton.UseVisualStyleBackColor = true;
            this.newAppointmentButton.Click += new System.EventHandler(this.newAppointmentButton_Click);
            // 
            // showContactsButton
            // 
            this.showContactsButton.Location = new System.Drawing.Point(818, 234);
            this.showContactsButton.Name = "showContactsButton";
            this.showContactsButton.Size = new System.Drawing.Size(188, 28);
            this.showContactsButton.TabIndex = 3;
            this.showContactsButton.Text = "Show Contacts";
            this.showContactsButton.UseVisualStyleBackColor = true;
            this.showContactsButton.Click += new System.EventHandler(this.showContactsButton_Click);
            // 
            // Contacts
            // 
            this.Contacts.HideSelection = false;
            this.Contacts.Location = new System.Drawing.Point(818, 265);
            this.Contacts.Name = "Contacts";
            this.Contacts.Size = new System.Drawing.Size(188, 217);
            this.Contacts.TabIndex = 4;
            this.Contacts.UseCompatibleStateImageBehavior = false;
            // 
            // deleteContactButton
            // 
            this.deleteContactButton.Location = new System.Drawing.Point(818, 110);
            this.deleteContactButton.Name = "deleteContactButton";
            this.deleteContactButton.Size = new System.Drawing.Size(188, 30);
            this.deleteContactButton.TabIndex = 5;
            this.deleteContactButton.Text = "Delete Contact";
            this.deleteContactButton.UseVisualStyleBackColor = true;
            this.deleteContactButton.Click += new System.EventHandler(this.deleteContactButton_Click);
            // 
            // idContact
            // 
            this.idContact.Location = new System.Drawing.Point(1012, 130);
            this.idContact.Name = "idContact";
            this.idContact.Size = new System.Drawing.Size(34, 20);
            this.idContact.TabIndex = 7;
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
            this.calendar1.Location = new System.Drawing.Point(12, 12);
            this.calendar1.Name = "calendar1";
            this.calendar1.ShowArrowControls = true;
            this.calendar1.ShowDashedBorderOnDisabledEvents = true;
            this.calendar1.ShowDateInHeader = true;
            this.calendar1.ShowDisabledEvents = false;
            this.calendar1.ShowEventTooltips = true;
            this.calendar1.ShowTodayButton = true;
            this.calendar1.Size = new System.Drawing.Size(816, 497);
            this.calendar1.TabIndex = 0;
            this.calendar1.TodayFont = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            // 
            // showContact
            // 
            this.showContact.Location = new System.Drawing.Point(818, 146);
            this.showContact.Name = "showContact";
            this.showContact.Size = new System.Drawing.Size(188, 30);
            this.showContact.TabIndex = 8;
            this.showContact.Text = "Show Contact";
            this.showContact.UseVisualStyleBackColor = true;
            this.showContact.Click += new System.EventHandler(this.showContact_Click);
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(1013, 110);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(15, 13);
            this.labelid.TabIndex = 9;
            this.labelid.Text = "id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1058, 530);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.showContact);
            this.Controls.Add(this.idContact);
            this.Controls.Add(this.deleteContactButton);
            this.Controls.Add(this.Contacts);
            this.Controls.Add(this.showContactsButton);
            this.Controls.Add(this.newAppointmentButton);
            this.Controls.Add(this.createContactButton);
            this.Controls.Add(this.calendar1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.idContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button createContactButton;
        private Calendar.NET.Calendar calendar1;
        private System.Windows.Forms.Button newAppointmentButton;
        private System.Windows.Forms.Button showContactsButton;
        private System.Windows.Forms.ListView Contacts;
        private System.Windows.Forms.Button deleteContactButton;
        private System.Windows.Forms.NumericUpDown idContact;
        private System.Windows.Forms.Button showContact;
        private System.Windows.Forms.Label labelid;
    }
}

