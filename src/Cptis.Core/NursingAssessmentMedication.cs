using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class NursingAssessmentMedication
    {
        /// <summary>
        /// Unique identifier for the medication record.
        /// </summary>
        public int NursingAssessmentMedicationId { get; set; }

        /// <summary>
        /// Reference to the associated Nursing Assessment.
        /// </summary>
        public int NursingAssessmentId { get; set; }

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
        /// Route of administration for the medication (e.g., oral, intravenous).
        /// </summary>
        public string Route { get; set; }

        /// <summary>
        /// Frequency at which the medication is to be administered.
        /// </summary>
        public string Frequency { get; set; }

        /// <summary>
        /// Reason for prescribing the medication.
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// Timeframe or duration for which the medication is prescribed.
        /// </summary>
        public string Timeframe { get; set; }

        /// <summary>
        /// Name of the person or entity administering the medication.
        /// </summary>
        public string AdministeredBy { get; set; }

        /// <summary>
        /// The date and time the medication record was created.
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// The date and time the medication record was last updated.
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
