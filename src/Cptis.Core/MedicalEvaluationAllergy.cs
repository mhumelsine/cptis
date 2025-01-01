using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class MedicalEvaluationAllergy
    {
        /// <summary>
        /// Unique identifier for the medical evaluation allergy record.
        /// </summary>
        public int MedicalEvaluationAllergyId { get; set; }

        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();

        /// <summary>
        /// Foreign key referencing the medical evaluation.
        /// </summary>
        public int MedicalEvaluationId { get; set; }

        /// <summary>
        /// Name of the allergen.
        /// </summary>
        public string Allergen { get; set; }

        /// <summary>
        /// Reaction caused by the allergen.
        /// </summary>
        public string Reaction { get; set; }

        /// <summary>
        /// Date the record was created.
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Date the record was last updated.
        /// </summary>
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// First name of the user who created or updated the record.
        /// </summary>
        public string UserFirstName { get; set; }

        /// <summary>
        /// Last name of the user who created or updated the record.
        /// </summary>
        public string UserLastName { get; set; }

        /// <summary>
        /// Navigation property for the related MedicalEvaluation.
        /// </summary>
        public MedicalEvaluation MedicalEvaluation { get; set; }
    }
}
