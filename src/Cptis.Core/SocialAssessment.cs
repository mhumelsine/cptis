using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    /// <summary>
    /// Represents the social assessment conducted during an evaluation process.
    /// </summary>
    public class SocialAssessment
    {
        /// <summary>
        /// Unique identifier for the social assessment.
        /// </summary>
        public int SocialAssessmentId { get; set; }

        /// <summary>
        /// Associated abuse report number.
        /// </summary>
        public string AbuseReportNumber { get; set; }

        /// <summary>
        /// Identifier for the client involved in the social assessment.
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
        /// Identifier for the client demographic associated with the assessment.
        /// </summary>
        public int? ClientDemographicId { get; set; }

        /// <summary>
        /// Identifier for the assessment associated with the social assessment.
        /// </summary>
        public int? AssessmentId { get; set; }

        /// <summary>
        /// Identifier for the registration associated with the social assessment.
        /// </summary>
        public int? RegistrationId { get; set; }

        /// <summary>
        /// Comments about the client’s history.
        /// </summary>
        public string HistoryComment { get; set; }

        /// <summary>
        /// Comments about the client’s family history.
        /// </summary>
        public string FamilyHistoryComment { get; set; }

        /// <summary>
        /// Comments about family functioning.
        /// </summary>
        public string FamilyFunctioningComment { get; set; }

        /// <summary>
        /// Comments about risks identified during the assessment.
        /// </summary>
        public string RiskComment { get; set; }

        /// <summary>
        /// Comments about impressions formed during the assessment.
        /// </summary>
        public string ImpressionComment { get; set; }

        /// <summary>
        /// Comments about recommendations from the assessment.
        /// </summary>
        public string RecommendationsComment { get; set; }

        /// <summary>
        /// Name of the person who prepared the assessment record.
        /// </summary>
        public string PreparedBy { get; set; }

        /// <summary>
        /// Date the assessment record was prepared.
        /// </summary>
        public DateTime? PreparedDate { get; set; }

        /// <summary>
        /// Name of the person who reviewed the assessment record.
        /// </summary>
        public string ReviewedBy { get; set; }

        /// <summary>
        /// Date the assessment record was reviewed.
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
        /// Additional comments related to the social assessment.
        /// </summary>
        public string CC { get; set; }

        /// <summary>
        /// Name of the child protective investigator (CPI) associated with the assessment.
        /// </summary>
        public string CpiName { get; set; }

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
