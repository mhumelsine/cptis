using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    /// <summary>
    /// Represents a specialized interview conducted as part of an assessment.
    /// </summary>
    public class SpecializedInterview
    {
        /// <summary>
        /// Unique identifier for the specialized interview.
        /// </summary>
        public int SpecializedInterviewId { get; set; }

        /// <summary>
        /// Associated abuse report number.
        /// </summary>
        public string AbuseReportNumber { get; set; }

        /// <summary>
        /// Identifier for the client associated with the interview.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Sequence number for the assessment.
        /// </summary>
        public string AssessmentSequenceNumber { get; set; }

        /// <summary>
        /// Sequence number for the registration.
        /// </summary>
        public string RegistrationSequenceNumber { get; set; }

        /// <summary>
        /// Identifier for the client's demographic record.
        /// </summary>
        public int ClientDemographicId { get; set; }

        /// <summary>
        /// Identifier for the associated registration.
        /// </summary>
        public int RegistrationId { get; set; }

        /// <summary>
        /// Identifier for the associated assessment.
        /// </summary>
        public int AssessmentId { get; set; }

        /// <summary>
        /// Name of the person interviewed.
        /// </summary>
        public string PersonInterviewed { get; set; }

        /// <summary>
        /// Birth date of the person interviewed.
        /// </summary>
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Recording method used during the interview.
        /// </summary>
        public string RecordingMethod { get; set; }

        /// <summary>
        /// Purpose of the interview.
        /// </summary>
        public string PurposeComment { get; set; }

        /// <summary>
        /// Summary of the interview.
        /// </summary>
        public string SummaryComment { get; set; }

        /// <summary>
        /// Comments on the safety during the interview.
        /// </summary>
        public string SafetyComment { get; set; }

        /// <summary>
        /// Impressions recorded from the interview.
        /// </summary>
        public string ImpressionsComment { get; set; }

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
        /// Relationship of the person interviewed to the client.
        /// </summary>
        public string Relationship { get; set; }

        /// <summary>
        /// CC recipients for the interview record.
        /// </summary>
        public string CC { get; set; }

        /// <summary>
        /// Name of the CPI associated with the interview.
        /// </summary>
        public string CpiName { get; set; }

        /// <summary>
        /// Type of the interview conducted.
        /// </summary>
        public string InterviewType { get; set; }

        /// <summary>
        /// Flag indicating if the record is deleted.
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Navigation property for the associated client demographic.
        /// </summary>
        public virtual ClientDemographic ClientDemographic { get; set; }

        /// <summary>
        /// Navigation property for the associated registration.
        /// </summary>
        public virtual Registration Registration { get; set; }

        /// <summary>
        /// Navigation property for the associated assessment.
        /// </summary>
        public virtual Assessment Assessment { get; set; }
    }
}
