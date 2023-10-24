using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Calendar.NET;

namespace Calendar.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            calendar1.CalendarDate = new DateTime(2023, 10, 20, 15, 30, 0);
            calendar1.CalendarView = CalendarViews.Month;
            calendar1.AllowEditingEvents = true;
            var ce = new CustomEvent
                {
                    IgnoreTimeComponent = false,
                    EventText = "Dinner",
                    Date = new DateTime(2023, 10, 20, 15, 30, 0),
                    EventLengthInHours = 2f,
                    RecurringFrequency = RecurringFrequencies.None,
                    EventFont = new Font("Verdana", 12, FontStyle.Regular),
                    Enabled = true,
                    EventColor = Color.FromArgb(120, 255, 120),
                    EventTextColor = Color.Black,
                    ThisDayForwardOnly=true
                };
            calendar1.AddEvent(ce);
        }

       

        private void calendar1_Load(object sender, EventArgs e)
        {
            
        }

        private void createContactButton_Click(object sender, EventArgs e)
        {
            ContactForm contact = new ContactForm();
            contact.Show();
            
        }

        private void newAppointmentButton_Click(object sender, EventArgs e)
        {
            EventDetails details = new EventDetails();
            details.Show();
        }
    }
}