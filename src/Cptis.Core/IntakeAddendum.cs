using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class IntakeAddendum
    {
        public int IntakeAddendumId { get; set; }
        public int IntakeId { get; set; }
        public string IntakeAddendumSequenceNumber { get; set; }
        public string Addendum { get; set; }
        public string CoordinatorCompletingAddendum { get; set; }
        public string ClosureCode { get; set; }
        public DateTime? ClosureDate { get; set; }
        public DateTime? CptReferralDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string CreatedBy { get; set; }
        public bool IsDeleted { get; set; }
        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();


        // Navigation property
        public Intake Intake { get; set; }
    }
}
