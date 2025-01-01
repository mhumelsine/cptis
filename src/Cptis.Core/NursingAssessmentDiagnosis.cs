using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class NursingAssessmentDiagnosis
    {
        /// <summary>
        /// Unique identifier for the diagnosis record.
        /// </summary>
        public int NursingAssessmentDiagnosisId { get; set; }

        /// <summary>
        /// Reference to the associated Nursing Assessment.
        /// </summary>
        public int NursingAssessmentId { get; set; }

        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();

        /// <summary>
        /// Code for the diagnosis.
        /// </summary>
        public string DiagnosisCode { get; set; }

        /// <summary>
        /// Additional comments about the diagnosis.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Navigation property to the associated Nursing Assessment.
        /// </summary>
        public NursingAssessment NursingAssessment { get; set; }
    }
}
