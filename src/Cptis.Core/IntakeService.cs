using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class IntakeService
    {
        /// <summary>
        /// The system assigned unique identifier for the intakeservice
        /// </summary>
        public int IntakeServiceId { get; set; }
        /// <summary>
        /// FK relation to the corresponding intake
        /// </summary>
        public int IntakeId { get; set; }
        /// <summary>
        /// The Abuse report number assigned to the case by DCF
        /// </summary>
        public string AbuseReportNumber { get; set; }
        /// <summary>
        /// The id of the specific abuse report in the context of the case
        /// </summary>
        public string AbuseReportSequenceNumber { get; set; }
        /// <summary>
        /// Code table reference to the type of service being offered.
        /// </summary>
        public string ServiceType { get; set; }
        /// <summary>
        /// The date the service is scheduled to happen
        /// </summary>
        public DateTime? ScheduledServiceDate { get; set; }
        /// <summary>
        /// Record Created Date
        /// </summary>
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// Record updated date
        /// </summary>
        public DateTime? UpdateDate { get; set; }
        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();


        // Navigation Property
        public Intake Intake { get; set; }
    }
}
