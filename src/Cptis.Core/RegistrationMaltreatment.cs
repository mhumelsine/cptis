using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class RegistrationMaltreatment
    {
        /// <summary>
        /// The system assigned unique identifier for the Registration Maltreatment
        /// </summary>
        public int RegistrationMaltreatmentId { get; set; }
        /// <summary>
        /// The Client ID of the client
        /// </summary>
        public ClientId ClientId { get; set; }
        /// <summary>
        /// The Abuse report number designated by DCF
        /// </summary>
        public string AbuseReportNum { get; set; }
        /// <summary>
        /// The registration sequence number of the corresponding registration
        /// </summary>
        public string RegistrationSequenceNumber { get; set; }
        /// <summary>
        /// The sequence number uniquely identifying this maltreatment for a particular registration
        /// </summary>
        public string MaltreatmentSequenceNumber { get; set; }
        /// <summary>
        /// Designates if the Maltreatment is alleged or assessed
        /// </summary>
        public string MaltreatmentType { get; set; }
        /// <summary>
        /// The code table value corresponding to the maltreatment description
        /// </summary>
        public string MaltreatmentCode { get; set; }
        /// <summary>
        /// designates if the maltreatment was abuse, neglect, or threatened harm
        /// </summary>
        public string MaltreatmentTypeFinding { get; set; }
        /// <summary>
        /// FK to corresponding registration in the registration table.
        /// </summary>
        public int RegistrationId { get; set; }
        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();

        // Navigation Properties
        /// <summary>
        /// The corresponding registration that the maltreatment belongs to
        /// </summary>
        public Registration Registration { get; set; }
    }
}
