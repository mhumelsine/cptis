using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class AssessmentSTDCrossRef
    {
        /// <summary>
        /// Unique identifier for the STD cross-reference record.
        /// </summary>
        public int AssessmentSTDCrossRefId { get; set; }

        /// <summary>
        /// Identifier of the related STD assessment record.
        /// </summary>
        public int AssessmentSTDId { get; set; }

        /// <summary>
        /// Type of code associated with the STD cross-reference (e.g., diagnosis or service type).
        /// </summary>
        public string CodeType { get; set; }

        /// <summary>
        /// Value of the associated code.
        /// </summary>
        public string CodeValue { get; set; }

        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();

        /// <summary>
        /// Navigation property for the associated AssessmentSTD entity.
        /// </summary>
        public AssessmentSTD AssessmentSTD { get; set; }
    }
}
