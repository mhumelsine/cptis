using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    /// <summary>
    /// Represents a CPT staffing record.
    /// </summary>
    public class CptStaffing
    {
        /// <summary>
        /// Unique identifier for the CPT staffing record.
        /// </summary>
        public int CptStaffingId { get; set; }

        /// <summary>
        /// Abuse report number associated with the staffing.
        /// </summary>
        public string AbuseReportNumber { get; set; }

        /// <summary>
        /// Client identifier.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Assessment sequence number.
        /// </summary>
        public string AssessmentSequenceNumber { get; set; }

        /// <summary>
        /// Registration sequence number.
        /// </summary>
        public string RegistrationSequenceNumber { get; set; }

        /// <summary>
        /// Identifier for the associated assessment.
        /// </summary>
        public int? AssessmentId { get; set; }

        /// <summary>
        /// Identifier for the associated registration.
        /// </summary>
        public int? RegistrationId { get; set; }

        /// <summary>
        /// Identifier for the associated client demographic.
        /// </summary>
        public int? ClientDemographicId { get; set; }

        /// <summary>
        /// Name of the Child Protective Investigator (CPI).
        /// </summary>
        public string Cpi { get; set; }

        /// <summary>
        /// Name of the lead CPI.
        /// </summary>
        public string CpiLead { get; set; }

        /// <summary>
        /// Position of the attendee in the staffing.
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Indicates if confidentiality was signed.
        /// </summary>
        public string ConfidentialitySigned { get; set; }

        /// <summary>
        /// Comment describing the purpose of the staffing.
        /// </summary>
        public string PurposeComment { get; set; }

        /// <summary>
        /// Summary comment for the staffing.
        /// </summary>
        public string SummaryComment { get; set; }

        /// <summary>
        /// Comment describing risk factors.
        /// </summary>
        public string RiskComment { get; set; }

        /// <summary>
        /// Comment describing barriers encountered.
        /// </summary>
        public string BarriersComment { get; set; }

        /// <summary>
        /// Name of the person who prepared the staffing.
        /// </summary>
        public string PreparedBy { get; set; }

        /// <summary>
        /// Date the staffing was prepared.
        /// </summary>
        public DateTime? PreparedDate { get; set; }

        /// <summary>
        /// Name of the person who reviewed the staffing.
        /// </summary>
        public string ReviewedBy { get; set; }

        /// <summary>
        /// Date the staffing was reviewed.
        /// </summary>
        public DateTime? ReviewedDate { get; set; }

        /// <summary>
        /// Date the record was created.
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Date the record was last updated.
        /// </summary>
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// First name of the user who created or updated the record.
        /// </summary>
        public string UserFirstName { get; set; }

        /// <summary>
        /// Last name of the user who created or updated the record.
        /// </summary>
        public string UserLastName { get; set; }

        /// <summary>
        /// Date the staffing took place.
        /// </summary>
        public DateTime? StaffingDate { get; set; }

        /// <summary>
        /// Additional CC information for the staffing.
        /// </summary>
        public string CC { get; set; }

        /// <summary>
        /// Indicates if the record is marked as deleted.
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Navigation property for the associated assessment.
        /// </summary>
        public virtual Assessment Assessment { get; set; }

        /// <summary>
        /// Navigation property for the associated registration.
        /// </summary>
        public virtual Registration Registration { get; set; }

        /// <summary>
        /// Navigation property for the associated client demographic.
        /// </summary>
        public virtual ClientDemographic ClientDemographic { get; set; }

        /// <summary>
        /// List of attendees asociated with the cpt staffing assessment.
        /// </summary>
        public ICollection<CptStaffingAttendee> CptStaffingAttendees { get; set; }

        /// <summary>
        /// List of family asociated with the cpt staffing assessment.
        /// </summary>
        public ICollection<CptStaffingFamily> CptStaffingFamily { get; set; }
    }
}
