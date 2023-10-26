using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.NET
{
    public class APPOINTMENT
    {
        /// <summary>
        /// Gets or Sets AppointmentID
        /// </summary>

        public long AppointmentID { get; set; }
        public long ContactID { get; set; }
        public int Repetition { get; set; }
        public string Topic { get; set; }
        public string Note { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string City { get; set; }

        // Properties for Reminder
        //public long ReminderID { get; set; }
        //public string ReminderTime { get; set; }
        //public string Time { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("  APPOINTMENT {\n");
            sb.Append("  AppointmentID: ").Append(AppointmentID).Append("\n");
            sb.Append("  ContactID: ").Append(ContactID).Append("\n");
            sb.Append("  Repetition: ").Append(Repetition).Append("\n");
            sb.Append("  Topic: ").Append(Topic).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
