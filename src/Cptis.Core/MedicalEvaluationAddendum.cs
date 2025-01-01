using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class MedicalEvaluationAddendum
    {
        /// <summary>
        /// Unique identifier for the addendum associated with a medical evaluation.
        /// </summary>
        public int MedicalEvaluationAddendumId { get; set; }

        /// <summary>
        /// Foreign key linking to the related medical evaluation.
        /// </summary>
        public int MedicalEvaluationId { get; set; }

        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();

        /// <summary>
        /// The text content of the addendum.
        /// </summary>
        public string Addendum { get; set; }

        /// <summary>
        /// Name of the person who prepared the addendum.
        /// </summary>
        public string PreparedBy { get; set; }

        /// <summary>
        /// Date when the addendum was prepared.
        /// </summary>
        public DateTime? PreparedDate { get; set; }

        /// <summary>
        /// The date and time the addendum record was created.
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// The date and time the addendum record was last updated.
        /// </summary>
        public DateTime? UpdateDate { get; set; }

        /// <summary>
        /// The first name of the user who created or updated the record.
        /// </summary>
        public string UserFirstName { get; set; }

        /// <summary>
        /// The last name of the user who created or updated the record.
        /// </summary>
        public string UserLastName { get; set; }

        /// <summary>
        /// Navigation property to the associated MedicalEvaluation.
        /// </summary>
        public MedicalEvaluation MedicalEvaluation { get; set; }
    }
}
