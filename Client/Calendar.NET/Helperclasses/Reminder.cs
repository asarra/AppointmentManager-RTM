using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.NET
{
    public class Reminder
    {
        public long ReminderID { get; set; }

        /// <summary>
        /// Gets or Sets AppointmentID
        /// </summary>
        
        public long AppointmentID { get; set; }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        
        public string Time { get; set; }
    }
}
