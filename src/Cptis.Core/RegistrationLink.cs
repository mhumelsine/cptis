using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class RegistrationLink
    {
        /// <summary>
        /// The system assigned unique identifier for the Registration Link
        /// </summary>
        public int RegistrationLinkId { get; set; }
        /// <summary>
        /// The abuse report number designated by DCF
        /// </summary>
        public string AbuseReportNumber { get; set; }
        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();
        /// <summary>
        /// The number assigned in the case of multiple abuse reports
        /// </summary>
        public string AbuseReportSequenceNumber { get; set; }
        /// <summary>
        /// The Client ID of the link
        /// </summary>
        public ClientId ClientId { get; set; } 
        /// <summary>
        /// The number assigned in the case of multiple registrations under the same case
        /// </summary>
        public string RegistrationSequenceNumber { get; set; }
        /// <summary>
        /// Date the record was created
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// FK to the corresponding Client Demographic table record
        /// </summary>
        public int ClientDemographicId { get; set; }
        /// <summary>
        /// FK to the corresponding intake table record
        /// </summary>
        public int IntakeId { get; set; }
        /// <summary>
        /// FK to the corresponding registration table record.
        /// </summary>
        public int RegistrationId { get; set; }

        // Navigation Properties
        /// <summary>
        /// corresponding client demographic record
        /// </summary>
        public ClientDemographic ClientDemographic { get; set; }
        /// <summary>
        /// corresponding registration record
        /// </summary>
        public Registration Registration { get; set; }
        /// <summary>
        /// corresponding Intake record
        /// </summary>
        public Intake Intake { get; set; }
    }
}
