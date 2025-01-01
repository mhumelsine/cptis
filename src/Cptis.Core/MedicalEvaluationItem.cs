using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class MedicalEvaluationItem
    {
        /// <summary>
        /// Unique identifier for the medical evaluation item.
        /// </summary>
        public int MedicalEvaluationItemId { get; set; }

        /// <summary>
        /// Identifier of the associated medical evaluation.
        /// </summary>
        public int MedicalEvaluationId { get; set; }

        /// <summary>
        /// Identifier of the associated medical evaluation code.
        /// </summary>
        public int MedicalEvaluationCodeId { get; set; }

        /// <summary>
        /// Additional comments for the medical evaluation item.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Login ID of the user who created the record.
        /// </summary>
        public int LoginIdCreate { get; set; }

        /// <summary>
        /// Login ID of the user who last updated the record.
        /// </summary>
        public int LoginIdUpdate { get; set; }

        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();

        /// <summary>
        /// Record creation date.
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Record last updated date.
        /// </summary>
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// Navigation property for the related MedicalEvaluation.
        /// </summary>
        public MedicalEvaluation MedicalEvaluation { get; set; }

        /// <summary>
        /// Navigation property for the related MedicalEvaluationCode.
        /// </summary>
        public MedicalEvaluationCode MedicalEvaluationCode { get; set; }
    }
}
