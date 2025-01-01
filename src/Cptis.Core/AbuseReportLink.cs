using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class AbuseReportLink
    {
        public int AbuseReportLinkId { get; set; }
        public int AbuseReportId { get; set; }
        public int LinkedAbuseReportId { get; set; }
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();

        // Navigation properties
        public AbuseReport AbuseReport { get; set; }
        public AbuseReport LinkedAbuseReport { get; set; }
    }

}
