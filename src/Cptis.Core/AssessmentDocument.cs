using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class AssessmentDocument
    {
        /// <summary>
        /// Unique identifier for the assessment document record.
        /// </summary>
        public int AssessmentDocumentId { get; set; }

        /// <summary>
        /// Abuse report number associated with the document.
        /// </summary>
        public string AbuseReportNumber { get; set; }

        /// <summary>
        /// Abuse report sequence number associated with the document.
        /// </summary>
        public string AbuseReportSequenceNumber { get; set; }

        /// <summary>
        /// Registration sequence number linked to the document.
        /// </summary>
        public string RegistrationSequenceNumber { get; set; }

        /// <summary>
        /// Client identifier associated with the document.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// File name of the document.
        /// </summary>
        public string DocumentFileName { get; set; }

        /// <summary>
        /// Path to the document in the storage system.
        /// </summary>
        public string DocumentPath { get; set; }

        /// <summary>
        /// Date the document was created.
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Size of the document file in bytes.
        /// </summary>
        public long DocumentFileSize { get; set; }

        /// <summary>
        /// Display name of the document.
        /// </summary>
        public string DocumentName { get; set; }

        /// <summary>
        /// File type or extension of the document (e.g., PDF, DOCX).
        /// </summary>
        public string DocumentFileType { get; set; }

        /// <summary>
        /// Identifier of the related assessment.
        /// </summary>
        public int? AssessmentId { get; set; }

        /// <summary>
        /// Identifier of the related client demographic.
        /// </summary>
        public int? ClientDemographicId { get; set; }

        /// <summary>
        /// First name of the user who created the record.
        /// </summary>
        public string UserFirstName { get; set; }

        /// <summary>
        /// Last name of the user who created the record.
        /// </summary>
        public string UserLastName { get; set; }

        /// <summary>
        /// Indicates whether the document is marked as deleted.
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Navigation property for the related assessment.
        /// </summary>
        public Assessment Assessment { get; set; }

        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();

        /// <summary>
        /// Navigation property for the related client demographic.
        /// </summary>
        public ClientDemographic ClientDemographic { get; set; }
    }
}
