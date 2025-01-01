using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class NursingAssessmentClinical
    {
        /// <summary>
        /// Unique identifier for the clinical service record.
        /// </summary>
        public int NursingAssessmentClinicalId { get; set; }

        /// <summary>
        /// Reference to the associated Nursing Assessment.
        /// </summary>
        public int NursingAssessmentId { get; set; }

        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();

        /// <summary>
        /// The name or type of the clinical service provided.
        /// </summary>
        public string Service { get; set; }

        /// <summary>
        /// Number of occurrences of the clinical service.
        /// </summary>
        public int? NumOccurences { get; set; }

        /// <summary>
        /// Reason or purpose for the clinical service.
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// The date and time the clinical record was created.
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// The date and time the clinical record was last updated.
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
        /// Navigation property to the associated Nursing Assessment.
        /// </summary>
        public NursingAssessment NursingAssessment { get; set; }
    }
}
