using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class IntakeMaltreatment
    {
        public int IntakeMaltreatmentId { get; set; }
        public int IntakeId { get; set; }
        public string AbuseReportNumber { get; set; }
        public string AbuseReportSequenceNumber { get; set; }
        public string MaltreatmentCode { get; set; }
        public string MaltreatmentType { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();

        // Navigation property
        public Intake Intake { get; set; }
    }
}
