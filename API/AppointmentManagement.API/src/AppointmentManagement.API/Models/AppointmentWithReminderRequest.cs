using System;

namespace AppointmentManagement.API.Models
{
    public class AppointmentWithReminderRequest
    {
        // Properties for Appointment
        public long AppointmentID { get; set; }
        public long ContactID { get; set; }
        public int Repetition { get; set; }
        public string Topic { get; set; }
        public string Note { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string City { get; set; }

        // Properties for Reminder
        public long ReminderID { get; set; }
        public DateTime ReminderTime { get; set; }
        public DateTime Time { get; set; }
    }

}
