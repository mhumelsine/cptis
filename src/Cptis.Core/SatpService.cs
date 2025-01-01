using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    /// <summary>
    /// Represents a service provided under the SATP program.
    /// </summary>
    public class SatpService
    {
        /// <summary>
        /// Unique identifier for the SATP service record.
        /// </summary>
        public int SatpServicesId { get; set; }

        /// <summary>
        /// Identifier of the related SATP intake.
        /// </summary>
        public int SatpIntakeId { get; set; }

        /// <summary>
        /// Identifier of the related client demographic.
        /// </summary>
        public int ClientDemographicId { get; set; }

        /// <summary>
        /// Case number associated with the service.
        /// </summary>
        public string CaseNumber { get; set; }

        /// <summary>
        /// Law enforcement report number associated with the service.
        /// </summary>
        public string LawEnforcementReportNum { get; set; }

        /// <summary>
        /// Identifier of the provider who offered the service.
        /// </summary>
        public string ProviderId { get; set; }

        /// <summary>
        /// Date the service was provided.
        /// </summary>
        public DateTime ServiceDate { get; set; }

        /// <summary>
        /// Code for the type of service provided.
        /// </summary>
        public string ServiceTypeCode { get; set; }

        /// <summary>
        /// Code for the funding source of the service.
        /// </summary>
        public string FundingSourceCode { get; set; }

        /// <summary>
        /// Start time of the service.
        /// </summary>
        public string BeginTime { get; set; }

        /// <summary>
        /// End time of the service.
        /// </summary>
        public string EndTime { get; set; }

        /// <summary>
        /// Number of service units provided.
        /// </summary>
        public int NumUnits { get; set; }

        /// <summary>
        /// Code for the location where the service was provided.
        /// </summary>
        public string LocationCode { get; set; }

        /// <summary>
        /// Identifier of the related SATP comments record.
        /// </summary>
        public int SatpCommentsId { get; set; }

        /// <summary>
        /// Date when the record was created.
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Date when the record was last updated.
        /// </summary>
        public DateTime UpdateDate { get; set; }

        /// <summary>
        /// First name of the user who created or updated the record.
        /// </summary>
        public string UserFirstName { get; set; }

        /// <summary>
        /// Last name of the user who created or updated the record.
        /// </summary>
        public string UserLastName { get; set; }

        /// <summary>
        /// Other funding information for the service.
        /// </summary>
        public string OtherFunding { get; set; }

        /// <summary>
        /// Identifier for the group associated with the service.
        /// </summary>
        public int GroupId { get; set; }
    }

}
