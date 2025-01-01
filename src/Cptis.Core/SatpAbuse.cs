using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    /// <summary>
    /// Represents an instance of SATP Abuse information linked to an intake.
    /// </summary>
    public class SatpAbuse
    {
        /// <summary>
        /// Unique identifier for the SATP Abuse record.
        /// </summary>
        public int SatpAbuseId { get; set; }

        /// <summary>
        /// Identifier for the associated SATP intake.
        /// </summary>
        public int SatpIntakeId { get; set; }

        /// <summary>
        /// Type of abuse reported in the SATP intake.
        /// </summary>
        public string AbuseType { get; set; }

        /// <summary>
        /// Date the record was created.
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Date the record was last updated.
        /// </summary>
        public DateTime UpdateDate { get; set; }

        /// <summary>
        /// First name of the user who created or updated the record.
        /// </summary>
        public string UserFirstName { get; set; }

        /// <summary>
        /// Last name of the user who created or updated the record.
        /// </summary>
        public string UserLastName { get; set; }

        /// <summary>
        /// Indicates whether the record is deleted.
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Navigation property for the associated SATP intake.
        /// </summary>
        public SatpIntake SatpIntake { get; set; }
    }
}
