using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    /// <summary>
    /// Represents a summary of a specialized interview conducted as part of an assessment.
    /// </summary>
    public class SpecializedInterviewSummary
    {
        /// <summary>
        /// Unique identifier for the specialized interview summary.
        /// </summary>
        public int SpecializedInterviewSummaryId { get; set; }

        /// <summary>
        /// Associated abuse report number.
        /// </summary>
        public string AbuseReportNumber { get; set; }

        /// <summary>
        /// Sequence number for the assessment.
        /// </summary>
        public string AssessmentSequenceNumber { get; set; }

        /// <summary>
        /// Identifier for the associated assessment.
        /// </summary>
        public int AssessmentId { get; set; }

        /// <summary>
        /// Sequence number for the registration.
        /// </summary>
        public string RegistrationSequenceNumber { get; set; }

        /// <summary>
        /// Identifier for the associated specialized interview.
        /// </summary>
        public int SpecializedInterviewId { get; set; }

        /// <summary>
        /// Identifier for the associated registration.
        /// </summary>
        public int RegistrationId { get; set; }

        /// <summary>
        /// Identifier for the client associated with the summary.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Identifier for the client's demographic record.
        /// </summary>
        public int ClientDemographicId { get; set; }

        /// <summary>
        /// Name of the person interviewed.
        /// </summary>
        public string PersonInterviewed { get; set; }

        /// <summary>
        /// Birth date of the person interviewed.
        /// </summary>
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Relationship of the person interviewed to the client.
        /// </summary>
        public string Relationship { get; set; }

        /// <summary>
        /// Date the interview was conducted.
        /// </summary>
        public DateTime? InterviewDate { get; set; }

        /// <summary>
        /// Location where the interview was conducted.
        /// </summary>
        public string InterviewLocation { get; set; }

        /// <summary>
        /// Summary of the interview.
        /// </summary>
        public string SummaryComment { get; set; }

        /// <summary>
        /// Date the record was created.
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Date the record was last updated.
        /// </summary>
        public DateTime? UpdatedDate { get; set; }

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

        /// <summary>
        /// Navigation property for the associated specialized interview.
        /// </summary>
        public virtual SpecializedInterview SpecializedInterview { get; set; }
    }
}
