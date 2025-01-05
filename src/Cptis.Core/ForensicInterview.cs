using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    /// <summary>
    /// Represents a forensic interview conducted during an assessment process.
    /// </summary>
    public class ForensicInterview
    {
        /// <summary>
        /// Unique identifier for the forensic interview.
        /// </summary>
        public int ForensicInterviewId { get; set; }

        /// <summary>
        /// Associated abuse report number.
        /// </summary>
        public string AbuseReportNumber { get; set; }

        /// <summary>
        /// Identifier for the client involved in the interview.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Identifier for the client demographic associated with the interview.
        /// </summary>
        public int? ClientDemographicId { get; set; }

        /// <summary>
        /// Sequence number for the assessment.
        /// </summary>
        public string AssessmentSequenceNumber { get; set; }

        /// <summary>
        /// Identifier for the assessment associated with the interview.
        /// </summary>
        public int? AssessmentId { get; set; }

        /// <summary>
        /// Sequence number for the registration.
        /// </summary>
        public string RegistrationSequenceNumber { get; set; }

        /// <summary>
        /// Identifier for the registration associated with the interview.
        /// </summary>
        public int? RegistrationId { get; set; }

        /// <summary>
        /// Name of the person interviewed.
        /// </summary>
        public string PersonInterviewed { get; set; }

        /// <summary>
        /// Birth date of the person interviewed.
        /// </summary>
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Name of the person or entity requesting the interview.
        /// </summary>
        public string InterviewRequestor { get; set; }

        /// <summary>
        /// Agency associated with the interview.
        /// </summary>
        public string Agency { get; set; }

        /// <summary>
        /// Method used for recording the interview.
        /// </summary>
        public string RecordingMethod { get; set; }

        /// <summary>
        /// Purpose of the interview.
        /// </summary>
        public string PurposeComment { get; set; }

        /// <summary>
        /// Safety-related comments during the interview.
        /// </summary>
        public string SafetyComment { get; set; }

        /// <summary>
        /// Findings from the interview.
        /// </summary>
        public string InterviewFindingsComment { get; set; }

        /// <summary>
        /// Name of the person who prepared the interview record.
        /// </summary>
        public string PreparedBy { get; set; }

        /// <summary>
        /// Date the interview record was prepared.
        /// </summary>
        public DateTime? PreparedDate { get; set; }

        /// <summary>
        /// Name of the person who reviewed the interview record.
        /// </summary>
        public string ReviewedBy { get; set; }

        /// <summary>
        /// Date the interview record was reviewed.
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
        /// First name of the user who created the record.
        /// </summary>
        public string UserFirstName { get; set; }

        /// <summary>
        /// Last name of the user who created the record.
        /// </summary>
        public string UserLastName { get; set; }

        /// <summary>
        /// Additional comments related to the interview.
        /// </summary>
        public string CC { get; set; }

        /// <summary>
        /// Name of the child protective investigator (CPI).
        /// </summary>
        public string CPIName { get; set; }

        /// <summary>
        /// Indicates if the record is marked as deleted.
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Navigation property for the associated client demographic.
        /// </summary>
        public virtual ClientDemographic ClientDemographic { get; set; }

        /// <summary>
        /// Navigation property for the associated assessment.
        /// </summary>
        public virtual Assessment Assessment { get; set; }

        /// <summary>
        /// Navigation property for the associated registration.
        /// </summary>
        public virtual Registration Registration { get; set; }
    }
}
