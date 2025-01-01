using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.Core
{
    /// <summary>
    /// Represents demographic details of a family member.
    /// </summary>
    public class FamilyDemographic
    {
        /// <summary>
        /// Unique identifier for the family demographic.
        /// </summary>
        public int FamilyDemographicId { get; set; }

        /// <summary>
        /// Identifier for the associated client demographic.
        /// </summary>
        public int ClientDemographicId { get; set; }

        /// <summary>
        /// Unique identifier for the family member.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// Last name of the family member.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// First name of the family member.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Middle initial of the family member.
        /// </summary>
        public string MiddleInitial { get; set; }

        /// <summary>
        /// Suffix for the family member's name.
        /// </summary>
        public string Suffix { get; set; }

        /// <summary>
        /// Race of the family member.
        /// </summary>
        public string Race { get; set; }

        /// <summary>
        /// Sex of the family member.
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// Ethnicity of the family member.
        /// </summary>
        public string Ethnicity { get; set; }

        /// <summary>
        /// Birth date of the family member.
        /// </summary>
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Verification method for the birth date.
        /// </summary>
        public string BirthDateVerification { get; set; }

        /// <summary>
        /// Death date of the family member, if applicable.
        /// </summary>
        public DateTime? DeathDate { get; set; }

        /// <summary>
        /// Address of Family member
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Contact phone number for the family member.
        /// </summary>
        public PhoneNumber Phone { get; set; }

        /// <summary>
        /// Health maintenance organization (HMO) status of the family member.
        /// </summary>
        public string HmoStatus { get; set; }

        /// <summary>
        /// Primary care physician of the family member.
        /// </summary>
        public string PrimaryCarePhys { get; set; }

        /// <summary>
        /// Additional comments about the family member.
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// Alternate last name for the family member.
        /// </summary>
        public string LastNameAka { get; set; }

        /// <summary>
        /// Alternate first name for the family member.
        /// </summary>
        public string FirstNameAka { get; set; }

        /// <summary>
        /// Alternate middle initial for the family member.
        /// </summary>
        public string MidInitAka { get; set; }

        /// <summary>
        /// Disability information of the family member.
        /// </summary>
        public string Disability { get; set; }

        /// <summary>
        /// Race information used for SATP purposes.
        /// </summary>
        public string SatpRace { get; set; }

        /// <summary>
        /// Additional sex information about the family member.
        /// </summary>
        public string OtherSex { get; set; }

        /// <summary>
        /// Additional race information about the family member.
        /// </summary>
        public string OtherRace { get; set; }

        /// <summary>
        /// Address of Family member
        /// </summary>
        public Address AddressAlt { get; set; }

        /// <summary>
        /// Date the record was created.
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// Date the record was last updated.
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
        /// Indicates if the record is deleted.
        /// </summary>
        public bool IsDeleted { get; set; }
    }
}
