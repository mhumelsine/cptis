using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class NursingAssessmentObservation
    {
        /// <summary>
        /// Unique identifier for the observation record.
        /// </summary>
        public int NursingAssessmentObservationId { get; set; }

        /// <summary>
        /// Reference to the associated Nursing Assessment.
        /// </summary>
        public int NursingAssessmentId { get; set; }

        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();

        /// <summary>
        /// General appearance observations of the patient.
        /// </summary>
        public string GeneralAppearance { get; set; }

        /// <summary>
        /// Observations of physical abuse, if any.
        /// </summary>
        public string PhysicalAbuse { get; set; }

        /// <summary>
        /// Details about bruises observed on the patient.
        /// </summary>
        public string Bruises { get; set; }

        /// <summary>
        /// Details about cuts observed on the patient.
        /// </summary>
        public string Cuts { get; set; }

        /// <summary>
        /// Details about burns observed on the patient.
        /// </summary>
        public string Burns { get; set; }

        /// <summary>
        /// Details about fractures observed on the patient.
        /// </summary>
        public string Fracture { get; set; }

        /// <summary>
        /// Any other relevant observations not categorized above.
        /// </summary>
        public string Other { get; set; }

        /// <summary>
        /// The date and time the observation record was created.
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// The date and time the observation record was last updated.
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
