using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class NursingAssessmentEquipment
    {
        /// <summary>
        /// Unique identifier for the equipment record.
        /// </summary>
        public int NursingAssessmentEquipmentId { get; set; }

        /// <summary>
        /// Reference to the associated Nursing Assessment.
        /// </summary>
        public int NursingAssessmentId { get; set; }

        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();

        /// <summary>
        /// Name of the equipment used or required.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Frequency of usage or application of the equipment.
        /// </summary>
        public string Frequency { get; set; }

        /// <summary>
        /// Reason or purpose for using the equipment.
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// The date and time the equipment record was created.
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// The date and time the equipment record was last updated.
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
