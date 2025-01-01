using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    /// <summary>
    /// Represents a provider in the SATP program.
    /// </summary>
    public class SatpProvider
    {
        /// <summary>
        /// Unique identifier for the SATP provider.
        /// </summary>
        public int SatpProviderId { get; set; }

        /// <summary>
        /// First name of the provider.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of the provider.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Address of the provider.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Additional address information for the provider.
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// City where the provider is located.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// State where the provider is located.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// ZIP code for the provider's location.
        /// </summary>
        public string Zip { get; set; }

        /// <summary>
        /// Provider's phone number.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Alternative phone number for the provider.
        /// </summary>
        public string AltPhone { get; set; }

        /// <summary>
        /// County code associated with the provider.
        /// </summary>
        public string CountyCode { get; set; }

        /// <summary>
        /// Office code associated with the provider.
        /// </summary>
        public string OfficeCode { get; set; }

        /// <summary>
        /// Provider type code.
        /// </summary>
        public string ProviderTypeCode { get; set; }

        /// <summary>
        /// Indicates whether the provider is active.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Date the provider was created.
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Date the provider record was last updated.
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
        /// Provider's employment status.
        /// </summary>
        public string EmploymentStatus { get; set; }

        /// <summary>
        /// Description of the provider's employment status.
        /// </summary>
        public string EmploymentStatusDescription { get; set; }

        /// <summary>
        /// Provider's title.
        /// </summary>
        public string ProviderTitle { get; set; }
    }
}
