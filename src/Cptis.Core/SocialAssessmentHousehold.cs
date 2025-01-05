using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    /// <summary>
    /// Represents the household details in a social assessment.
    /// </summary>
    public class SocialAssessmentHousehold
    {
        /// <summary>
        /// Unique identifier for the household record in the social assessment.
        /// </summary>
        public int SocialAssessmentHouseholdId { get; set; }

        /// <summary>
        /// Identifier for the associated social assessment.
        /// </summary>
        public int SocialAssessmentId { get; set; }

        /// <summary>
        /// Associated abuse report number.
        /// </summary>
        public string AbuseReportNumber { get; set; }

        /// <summary>
        /// Sequence number for the assessment.
        /// </summary>
        public string AssessmentSequenceNumber { get; set; }

        /// <summary>
        /// Sequence number for the registration.
        /// </summary>
        public string RegistrationSequenceNumber { get; set; }

        /// <summary>
        /// Identifier for the client involved in the social assessment.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// First name of the household member.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of the household member.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Birth date of the household member.
        /// </summary>
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Relationship of the household member to the client.
        /// </summary>
        public string Relationship { get; set; }

        /// <summary>
        /// Date the record was created.
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Date the record was last updated.
        /// </summary>
        public DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Navigation property for the associated social assessment.
        /// </summary>
        public virtual SocialAssessment SocialAssessment { get; set; }
    }

}
