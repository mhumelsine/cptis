using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    /// <summary>
    /// Represents a client's demographic information.
    /// </summary>
    public class ClientDemographic
    {
        /// <summary>
        /// Unique identifier for the client demographic.
        /// </summary>
        public int ClientDemographicId { get; set; }

        /// <summary>
        /// Unique identifier for the client.
        /// </summary>
        public ClientId ClientId { get; set; }

        /// <summary>
        /// Last name of the client.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// First name of the client.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Middle initial of the client.
        /// </summary>
        public string MiddleInitial { get; set; }

        /// <summary>
        /// Suffix for the client's name.
        /// </summary>
        public string Suffix { get; set; }

        /// <summary>
        /// Race of the client.
        /// </summary>
        public string Race { get; set; }

        /// <summary>
        /// Sex of the client.
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// Ethnicity of the client.
        /// </summary>
        public string Ethnicity { get; set; }

        /// <summary>
        /// Country of origin for the client.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Birth date of the client.
        /// </summary>
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Method used to verify the birth date.
        /// </summary>
        public string BirthDateVerification { get; set; }

        /// <summary>
        /// Date of the client's death, if applicable.
        /// </summary>
        public DateTime? DeathDate { get; set; }

        /// <summary>
        /// Medicaid status of the client.
        /// </summary>
        public string Medicaid { get; set; }

        /// <summary>
        /// Medicaid ID for the client.
        /// </summary>
        public string MedicaidId { get; set; }

        /// <summary>
        /// Health maintenance organization (HMO) status.
        /// </summary>
        public string HmoStatus { get; set; }

        /// <summary>
        /// Primary care physician for the client.
        /// </summary>
        public string PrimaryCarePhys { get; set; }

        /// <summary>
        /// First name of the user who created or updated the record.
        /// </summary>
        public string UserFirstName { get; set; }

        /// <summary>
        /// Last name of the user who created or updated the record.
        /// </summary>
        public string UserLastName { get; set; }

        /// <summary>
        /// Additional comments about the client.
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// Alternate last name for the client.
        /// </summary>
        public string LastNameAka { get; set; }

        /// <summary>
        /// Alternate first name for the client.
        /// </summary>
        public string FirstNameAka { get; set; }

        /// <summary>
        /// Alternate middle initial for the client.
        /// </summary>
        public string MidInitAka { get; set; }

        /// <summary>
        /// Indicates if the client has a disability.
        /// </summary>
        public string Disability { get; set; }

        /// <summary>
        /// Race information used for SATP purposes.
        /// </summary>
        public string SatpRace { get; set; }

        /// <summary>
        /// Additional sex information about the client.
        /// </summary>
        public string OtherSex { get; set; }

        /// <summary>
        /// Additional race information about the client.
        /// </summary>
        public string OtherRace { get; set; }

        /// <summary>
        /// Date the record was created.
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// User who created the record.
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Date the record was last updated.
        /// </summary>
        public DateTime UpdateDate { get; set; }

        /// <summary>
        /// User who last updated the record.
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Indicates if the record is deleted.
        /// </summary>
        public bool IsDeleted { get; set; }

        //Navigation Properties
        /// <summary>
        /// Related Phone numbers.
        /// </summary>
        public ICollection<ClientPhone> ClientPhones { get; set; }

        /// <summary>
        /// Related Addresses.
        /// </summary>
        public ICollection<ClientAddress> ClientAddresses { get; set; }
    }
}
