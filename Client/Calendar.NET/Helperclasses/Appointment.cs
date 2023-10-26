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

        /// <summary>
        /// Gets or Sets ContactID
        /// </summary>

        public long ContactID { get; set; }

        /// <summary>
        /// Gets or Sets Repetition
        /// </summary>

        public int Repetition { get; set; }

        /// <summary>
        /// Gets or Sets Topic
        /// </summary>

        public string Topic { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>

        public string Note { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>

        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>

        public DateTime EndTime { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>

        public string City { get; set; }

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
