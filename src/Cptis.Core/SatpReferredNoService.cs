using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    /// <summary>
    /// Represents a record of services that were referred but not provided in the SATP program.
    /// </summary>
    public class SatpReferredNoService
    {
        /// <summary>
        /// Unique identifier for the SATP referred no service record.
        /// </summary>
        public int SatpReferredNoServiceId { get; set; }

        /// <summary>
        /// Office code associated with the referral.
        /// </summary>
        public string OfficeCode { get; set; }

        /// <summary>
        /// Record date for the referral.
        /// </summary>
        public DateTime RecordDate { get; set; }

        /// <summary>
        /// Number of referrals made.
        /// </summary>
        public int NumReferred { get; set; }

        /// <summary>
        /// Date when the record was created.
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Date when the record was last updated.
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
        /// Source of the referral.
        /// </summary>
        public string ReferralSource { get; set; }

        /// <summary>
        /// Indicates whether the record has been deleted.
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
