/*
 * Swagger Appointment managment - RTM - OpenAPI 3.1
 *
 * This is the OpenAPI 3.1 specification of Appointment managment - RTM.
 *
 * The version of the OpenAPI document: 0.1
 * Contact: mehmet-ali.asar@protonmail.com
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using AppointmentManagement.API.Converters;

namespace AppointmentManagement.API.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class APPOINTMENT : IEquatable<APPOINTMENT>
    {
        /// <summary>
        /// Gets or Sets AppointmentID
        /// </summary>
        [Required]
        [DataMember(Name="AppointmentID", EmitDefaultValue=true)]
        public long AppointmentID { get; set; }

        /// <summary>
        /// Gets or Sets ContactID
        /// </summary>
        [Required]
        [DataMember(Name="ContactID", EmitDefaultValue=true)]
        public long ContactID { get; set; }

        /// <summary>
        /// Gets or Sets Repetition
        /// </summary>
        [Required]
        [DataMember(Name="Repetition", EmitDefaultValue=true)]
        public int Repetition { get; set; }

        /// <summary>
        /// Gets or Sets Topic
        /// </summary>
        [Required]
        [DataMember(Name="Topic", EmitDefaultValue=true)]
        public string Topic { get; set; }

        /// <summary>
        /// Gets or Sets Note
        /// </summary>
        [DataMember(Name="Note", EmitDefaultValue=true)]
        public string Note { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [Required]
        [DataMember(Name="StartTime", EmitDefaultValue=true)]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name="EndTime", EmitDefaultValue=true)]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [Required]
        [MaxLength(50)]
        [DataMember(Name="City", EmitDefaultValue=true)]
        public string City { get; set; }

        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class APPOINTMENT {\n");
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

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((APPOINTMENT)obj);
        }

        /// <summary>
        /// Returns true if APPOINTMENT instances are equal
        /// </summary>
        /// <param name="other">Instance of APPOINTMENT to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(APPOINTMENT other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AppointmentID == other.AppointmentID ||
                    AppointmentID != null &&
                    AppointmentID.Equals(other.AppointmentID)
                ) && 
                (
                    ContactID == other.ContactID ||
                    ContactID != null &&
                    ContactID.Equals(other.ContactID)
                ) && 
                (
                    Repetition == other.Repetition ||
                    Repetition != null &&
                    Repetition.Equals(other.Repetition)
                ) && 
                (
                    Topic == other.Topic ||
                    Topic != null &&
                    Topic.Equals(other.Topic)
                ) && 
                (
                    Note == other.Note ||
                    Note != null &&
                    Note.Equals(other.Note)
                ) && 
                (
                    StartTime == other.StartTime ||
                    StartTime != null &&
                    StartTime.Equals(other.StartTime)
                ) && 
                (
                    EndTime == other.EndTime ||
                    EndTime != null &&
                    EndTime.Equals(other.EndTime)
                ) && 
                (
                    City == other.City ||
                    City != null &&
                    City.Equals(other.City)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (AppointmentID != null)
                    hashCode = hashCode * 59 + AppointmentID.GetHashCode();
                    if (ContactID != null)
                    hashCode = hashCode * 59 + ContactID.GetHashCode();
                    if (Repetition != null)
                    hashCode = hashCode * 59 + Repetition.GetHashCode();
                    if (Topic != null)
                    hashCode = hashCode * 59 + Topic.GetHashCode();
                    if (Note != null)
                    hashCode = hashCode * 59 + Note.GetHashCode();
                    if (StartTime != null)
                    hashCode = hashCode * 59 + StartTime.GetHashCode();
                    if (EndTime != null)
                    hashCode = hashCode * 59 + EndTime.GetHashCode();
                    if (City != null)
                    hashCode = hashCode * 59 + City.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(APPOINTMENT left, APPOINTMENT right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(APPOINTMENT left, APPOINTMENT right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
