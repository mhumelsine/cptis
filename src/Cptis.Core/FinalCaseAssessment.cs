using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    /// <summary>
    /// Represents the final assessment of a case.
    /// </summary>
    public class FinalCaseAssessment
    {
        /// <summary>
        /// Unique identifier for the final case assessment.
        /// </summary>
        public int FinalCaseAssessmentId { get; set; }

        /// <summary>
        /// Identifier for the associated client.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Abuse report number associated with the case.
        /// </summary>
        public string AbuseReportNumber { get; set; }

        /// <summary>
        /// Registration sequence number.
        /// </summary>
        public string RegistrationSequenceNumber { get; set; }

        /// <summary>
        /// Final assessment details or comments.
        /// </summary>
        public string FinalAssessment { get; set; }

        /// <summary>
        /// Date the record was last updated.
        /// </summary>
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// First name of the user who updated the record.
        /// </summary>
        public string UserFirstName { get; set; }

        /// <summary>
        /// Last name of the user who updated the record.
        /// </summary>
        public string UserLastName { get; set; }

        /// <summary>
        /// Identifier for the associated client demographic.
        /// </summary>
        public int? ClientDemographicId { get; set; }

        /// <summary>
        /// Identifier for the associated registration.
        /// </summary>
        public int? RegistrationId { get; set; }

        /// <summary>
        /// Navigation property for the associated client demographic.
        /// </summary>
        public virtual ClientDemographic ClientDemographic { get; set; }

        /// <summary>
        /// Navigation property for the associated registration.
        /// </summary>
        public virtual Registration Registration { get; set; }
    }
}
