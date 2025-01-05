using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    /// <summary>
    /// Represents an attendee of a CPT staffing.
    /// </summary>
    public class CptStaffingAttendee
    {
        /// <summary>
        /// Unique identifier for the staffing attendee.
        /// </summary>
        public int CptStaffingAttendeeId { get; set; }

        /// <summary>
        /// Identifier for the associated CPT staffing.
        /// </summary>
        public int CptStaffingId { get; set; }

        /// <summary>
        /// Abuse report number associated with the attendee.
        /// </summary>
        public string AbuseReportNumber { get; set; }

        /// <summary>
        /// Registration sequence number.
        /// </summary>
        public string RegistrationSequenceNumber { get; set; }

        /// <summary>
        /// Assessment sequence number.
        /// </summary>
        public string AssessmentSequenceNumber { get; set; }

        /// <summary>
        /// Identifier for the associated client.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// First name of the attendee.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of the attendee.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Position or role of the attendee in the staffing.
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Date the record was created.
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Date the record was last updated.
        /// </summary>
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// Navigation property for the associated CPT staffing.
        /// </summary>
        public virtual CptStaffing CptStaffing { get; set; }
    }
}
