using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class AssessmentSTD
    {
        /// <summary>
        /// Unique identifier for the AssessmentSTD record.
        /// </summary>
        public int AssessmentStdId { get; set; }

        /// <summary>
        /// Identifier for the associated assessment.
        /// </summary>
        public int AssessmentId { get; set; }

        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();

        /// <summary>
        /// Identifier for the client.
        /// </summary>
        public ClientId ClientId { get; set; }

        /// <summary>
        /// Abuse report number related to the STD assessment.
        /// </summary>
        public string AbuseReportNumber { get; set; }

        /// <summary>
        /// Sequence number of the assessment.
        /// </summary>
        public string AssessmentSequenceNumber { get; set; }

        /// <summary>
        /// Information on sexual activity within sixty days.
        /// </summary>
        public string SexualActivitySixtyDays { get; set; }

        /// <summary>
        /// Information on pregnancy test status.
        /// </summary>
        public string PregnancyTest { get; set; }

        /// <summary>
        /// Referral information for the client.
        /// </summary>
        public string ReferredTo { get; set; }

        /// <summary>
        /// Date when services were provided.
        /// </summary>
        public DateTime? ServicesProvidedDate { get; set; }

        /// <summary>
        /// Date when the record was last updated.
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
        /// Signature of the provider who confirmed the record.
        /// </summary>
        public string ProviderSignature { get; set; }

        /// <summary>
        /// Date of the provider's signature.
        /// </summary>
        public DateTime? ProviderSignatureDate { get; set; }

        /// <summary>
        /// Navigation property for the related Assessment.
        /// </summary>
        public Assessment Assessment { get; set; }
    }
}
