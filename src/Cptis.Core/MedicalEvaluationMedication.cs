using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class MedicalEvaluationMedication
    {
        /// <summary>
        /// Unique identifier for the medical evaluation medication record.
        /// </summary>
        public int MedicalEvaluationMedicationId { get; set; }

        /// <summary>
        /// Identifier of the associated medical evaluation.
        /// </summary>
        public int MedicalEvaluationId { get; set; }

        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();

        /// <summary>
        /// Name of the medication.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Dosage of the medication.
        /// </summary>
        public string Dose { get; set; }

        /// <summary>
        /// Reason for administering the medication.
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Record creation date.
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Record last updated date.
        /// </summary>
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// First name of the user who created or last updated the record.
        /// </summary>
        public string UserFirstName { get; set; }

        /// <summary>
        /// Last name of the user who created or last updated the record.
        /// </summary>
        public string UserLastName { get; set; }

        /// <summary>
        /// Navigation property for the related MedicalEvaluation.
        /// </summary>
        public MedicalEvaluation MedicalEvaluation { get; set; }
    }
}
