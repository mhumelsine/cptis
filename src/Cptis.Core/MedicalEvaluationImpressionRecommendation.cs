using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class MedicalEvaluationImpressionRecommendation
    {
        /// <summary>
        /// Unique identifier for the impression recommendation record.
        /// </summary>
        public int MedicalEvaluationImpressionRecommendationId { get; set; }

        /// <summary>
        /// Identifier of the associated medical evaluation.
        /// </summary>
        public int MedicalEvaluationId { get; set; }

        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();

        /// <summary>
        /// Type of the recommendation or impression code.
        /// </summary>
        public string CodeType { get; set; }

        /// <summary>
        /// Value of the recommendation or impression code.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Additional comments or notes for the recommendation.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// ID of the user who created the record.
        /// </summary>
        public int? LoginIdCreate { get; set; }

        /// <summary>
        /// Record creation date.
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// ID of the user who last updated the record.
        /// </summary>
        public int? LoginIdUpdate { get; set; }

        /// <summary>
        /// Record last updated date.
        /// </summary>
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// Navigation property for the related MedicalEvaluation.
        /// </summary>
        public MedicalEvaluation MedicalEvaluation { get; set; }
    }
}
