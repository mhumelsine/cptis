using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    /// <summary>
    /// Represents family member information associated with a specialized interview.
    /// </summary>
    public class SpecializedInterviewFamily
    {
        /// <summary>
        /// Unique identifier for the specialized interview family record.
        /// </summary>
        public int SpecializedInterviewFamilyId { get; set; }

        /// <summary>
        /// Identifier for the associated specialized interview.
        /// </summary>
        public int SpecializedInterviewId { get; set; }

        /// <summary>
        /// Associated abuse report number.
        /// </summary>
        public string AbuseReportNumber { get; set; }

        /// <summary>
        /// Client identifier associated with the specialized interview.
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
        /// Identifier for the associated assessment.
        /// </summary>
        public int AssessmentId { get; set; }

        /// <summary>
        /// Identifier for the associated registration.
        /// </summary>
        public int RegistrationId { get; set; }

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
        /// Relationship of the family member to the client.
        /// </summary>
        public string Relationship { get; set; }

        /// <summary>
        /// Date the record was created.
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Date the record was last updated.
        /// </summary>
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// Navigation property for the associated specialized interview.
        /// </summary>
        public virtual SpecializedInterview SpecializedInterview { get; set; }

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
