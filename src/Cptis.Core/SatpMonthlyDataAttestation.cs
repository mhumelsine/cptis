using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    /// <summary>
    /// Represents monthly data attestation for the SATP program.
    /// </summary>
    public class SatpMonthlyDataAttestation
    {
        /// <summary>
        /// Unique identifier for the SATP monthly data attestation record.
        /// </summary>
        public int SatpMonthlyDataAttestationId { get; set; }

        /// <summary>
        /// Code representing the office associated with the attestation.
        /// </summary>
        public string OfficeCode { get; set; }

        /// <summary>
        /// Date of the record.
        /// </summary>
        public DateTime RecordDate { get; set; }

        /// <summary>
        /// Name of the program coordinator.
        /// </summary>
        public string ProgramCoordinator { get; set; }

        /// <summary>
        /// Date the attestation was created.
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Date the attestation was last updated.
        /// </summary>
        public DateTime UpdateDate { get; set; }

        /// <summary>
        /// First name of the user who created or updated the attestation.
        /// </summary>
        public string UserFirstName { get; set; }

        /// <summary>
        /// Last name of the user who created or updated the attestation.
        /// </summary>
        public string UserLastName { get; set; }

        /// <summary>
        /// Indicates whether the record has been marked as deleted.
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
