using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class AssessmentObserver
    {
        /// <summary>
        /// Unique identifier for the assessment observer record.
        /// </summary>
        public int AssessmentObserverId { get; set; }

        /// <summary>
        /// Interview ID associated with the observer.
        /// </summary>
        public int? InterviewId { get; set; }

        /// <summary>
        /// Abuse report number related to the observer's assessment.
        /// </summary>
        public string AbuseReportNumber { get; set; }

        /// <summary>
        /// Sequence number of the assessment associated with the observer.
        /// </summary>
        public string AssessmentSequenceNumber { get; set; }

        /// <summary>
        /// Registration sequence number related to the observer's assessment.
        /// </summary>
        public string RegistrationSequenceNumber { get; set; }

        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();

        /// <summary>
        /// Client identifier related to the observer's record.
        /// </summary>
        public ClientId ClientId { get; set; }

        /// <summary>
        /// Name of the observer.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Title or designation of the observer.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Agency associated with the observer.
        /// </summary>
        public string Agency { get; set; }

        /// <summary>
        /// Date when the observer record was created.
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Date when the observer record was last updated.
        /// </summary>
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// Assessment ID linked to the observer.
        /// </summary>
        public int? AssessmentId { get; set; }

        /// <summary>
        /// Client demographic ID linked to the observer.
        /// </summary>
        public int? ClientDemographicId { get; set; }

        /// <summary>
        /// Navigation property for the related assessment.
        /// </summary>
        public Assessment Assessment { get; set; }

        /// <summary>
        /// Navigation property for the related client demographic.
        /// </summary>
        public ClientDemographic ClientDemographic { get; set; }

        /// <summary>
        /// List of alleged and assessed maltreatments for registrations
        /// </summary>
        public ICollection<AssessmentSTDCrossRef> AssessmentSTDCrossRefs { get; set; }
    }
}
