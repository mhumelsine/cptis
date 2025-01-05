using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    /// <summary>
    /// Represents a family member involved in a CPT staffing.
    /// </summary>
    public class CptStaffingFamily
    {
        /// <summary>
        /// Unique identifier for the CPT staffing family record.
        /// </summary>
        public int CptStaffingFamilyId { get; set; }

        /// <summary>
        /// Identifier for the associated CPT staffing.
        /// </summary>
        public int CptStaffingId { get; set; }

        /// <summary>
        /// Abuse report number associated with the family member.
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
        /// First name of the family member.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of the family member.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Birth date of the family member.
        /// </summary>
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Relation of the family member to the client.
        /// </summary>
        public string Relation { get; set; }

        /// <summary>
        /// Date the record was created.
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Date the record was last updated.
        /// </summary>
        public DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Navigation property for the associated CPT staffing.
        /// </summary>
        public virtual CptStaffing CptStaffing { get; set; }
    }
}
