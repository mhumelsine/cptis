using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    public class Provider
    {
        public int ProviderId { get; set; }
        public string ProviderCode { get; set; }
        public string ProviderFirstName { get; set; }
        public string ProviderLastName { get; set; }
        public string ProviderAddress { get; set; }
        public string ProviderAddress2 { get; set; }
        public string ProviderCity { get; set; }
        public string ProviderState { get; set; }
        public string ProviderZip { get; set; }
        public string ProviderCounty { get; set; }
        public PhoneNumber ProviderPhone { get; set; } = PhoneNumber.None;
        public string ProviderType { get; set; }
        public string CptOffice { get; set; }
        public string Active { get; set; }
        public DateTime? CmsApprovalDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string License { get; set; }
        public string EmploymentStatus { get; set; }
        public string EmploymentStatusDescription { get; set; }
        public string ProviderTitle { get; set; }
        public string ApprovedStaff { get; set; }
        public int? SecurityId { get; set; }
        public DateTime? TerminationDate { get; set; }
        /// <summary>
        /// Audit details about when the client was created and modified
        /// </summary>
        public Audit Audit { get; set; } = new();

        // Navigation properties
        public CptisUser SecurityUser { get; set; }
    }
}
