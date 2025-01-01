using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    /// <summary>
    /// Represents abuse cases linked to a SATP intake.
    /// </summary>
    public class SatpLinkedAbuse
    {
        /// <summary>
        /// Unique identifier for the SATP linked abuse record.
        /// </summary>
        public int SatpLinkedAbuseId { get; set; }

        /// <summary>
        /// Case number associated with the linked abuse.
        /// </summary>
        public string CaseNumber { get; set; }

        /// <summary>
        /// Law enforcement report number associated with the linked abuse.
        /// </summary>
        public string LawEnforcementReportNum { get; set; }

        /// <summary>
        /// Identifier for the related SATP intake.
        /// </summary>
        public int SatpIntakeId { get; set; }

        /// <summary>
        /// Date when the linked abuse record was created.
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Date when the linked abuse record was last updated.
        /// </summary>
        public DateTime UpdateDate { get; set; }

        /// <summary>
        /// First name of the user who created or updated the linked abuse record.
        /// </summary>
        public string UserFirstName { get; set; }

        /// <summary>
        /// Last name of the user who created or updated the linked abuse record.
        /// </summary>
        public string UserLastName { get; set; }
    }
}
