using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    /// <summary>
    /// Represents maltreatments associated with a SATP intake.
    /// </summary>
    public class SatpIntakeMaltreatment
    {
        /// <summary>
        /// Unique identifier for the SATP intake maltreatment record.
        /// </summary>
        public int SatpIntakeMaltreatmentId { get; set; }

        /// <summary>
        /// Identifier for the related SATP intake.
        /// </summary>
        public int SatpIntakeId { get; set; }

        /// <summary>
        /// Code representing the alleged maltreatment.
        /// </summary>
        public string AllegedMaltreatmentCode { get; set; }

        /// <summary>
        /// Type code associated with the maltreatment.
        /// </summary>
        public string TypeCode { get; set; }

        /// <summary>
        /// Date when the maltreatment record was created.
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Date when the maltreatment record was last updated.
        /// </summary>
        public DateTime UpdateDate { get; set; }

        /// <summary>
        /// First name of the user who created the maltreatment record.
        /// </summary>
        public string UserFirstName { get; set; }

        /// <summary>
        /// Last name of the user who created the maltreatment record.
        /// </summary>
        public string UserLastName { get; set; }
    }

}
