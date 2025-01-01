using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class NursingAssessmentLab
    {
        /// <summary>
        /// Unique identifier for the lab record.
        /// </summary>
        public int NursingAssessmentLabId { get; set; }

        /// <summary>
        /// Reference to the associated Nursing Assessment.
        /// </summary>
        public int NursingAssessmentId { get; set; }

        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();

        /// <summary>
        /// Name or type of the lab test.
        /// </summary>
        public string Lab { get; set; }

        /// <summary>
        /// Additional comments about the lab test.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Navigation property to the associated Nursing Assessment.
        /// </summary>
        public NursingAssessment NursingAssessment { get; set; }
    }

}
