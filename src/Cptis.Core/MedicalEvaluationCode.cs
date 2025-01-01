using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class MedicalEvaluationCode
    {
        /// <summary>
        /// Unique identifier for the medical evaluation code.
        /// </summary>
        public int MedicalEvaluationCodeId { get; set; }

        /// <summary>
        /// Group to which the code belongs.
        /// </summary>
        public string Group { get; set; }

        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();

        /// <summary>
        /// Abbreviation for the medical evaluation code.
        /// </summary>
        public string Abbreviation { get; set; }

        /// <summary>
        /// Detailed description of the code.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Indicates whether more information is allowed for this code.
        /// </summary>
        public bool AllowMoreInfo { get; set; }

        /// <summary>
        /// Indicates whether the code is active.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Display order of the code.
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Date when the record was created.
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Date when the record was last updated.
        /// </summary>
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// Navigation property for related MedicalEvaluationItems.
        /// </summary>
        public ICollection<MedicalEvaluationItem> MedicalEvaluationItems { get; set; }
    }
}
