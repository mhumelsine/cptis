using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class MedicalEvaluationFamily
    {
        /// <summary>
        /// Unique identifier for the medical evaluation family record.
        /// </summary>
        public int MedicalEvaluationFamilyId { get; set; }

        /// <summary>
        /// Identifier of the associated medical evaluation.
        /// </summary>
        public int MedicalEvaluationId { get; set; }

        /// <summary>
        /// First name of the family member.
        /// </summary>
        public string Firstname { get; set; }

        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();


        /// <summary>
        /// Last name of the family member.
        /// </summary>
        public string Lastname { get; set; }

        /// <summary>
        /// Age of the family member.
        /// </summary>
        public int? Age { get; set; }

        /// <summary>
        /// Relationship of the family member to the patient.
        /// </summary>
        public string Relationship { get; set; }

        /// <summary>
        /// Description of problems reported for the family member.
        /// </summary>
        public string Problems { get; set; }

        /// <summary>
        /// Record creation date.
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Last updated date for the record.
        /// </summary>
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// Navigation property for the related MedicalEvaluation.
        /// </summary>
        public MedicalEvaluation MedicalEvaluation { get; set; }
    }
}
