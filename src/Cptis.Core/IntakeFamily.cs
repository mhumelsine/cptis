using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class IntakeFamily
    {
        public int IntakeFamilyId { get; set; }
        public string AbuseReportNumber { get; set; }
        public string AbuseReportSequenceNumber { get; set; }
        public string ClientId { get; set; }
        public int FamilyDemographicId { get; set; }
        public int IntakeId { get; set; }
        public string AllegedPerpetrator { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();

        // Navigation properties
        public Intake Intake { get; set; }
        public FamilyDemographic FamilyDemographic { get; set; }
    }

}
