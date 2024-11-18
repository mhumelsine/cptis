using System.ComponentModel.DataAnnotations;

namespace cptis.domain.ClientDemographics
{  
    public class ClientDemographic
    {
        [Key]
        public int ClientDemographicId { get; set; }

        [Required, StringLength(9)]
        public string ClientId { get; set; }

        [StringLength(30)]
        public string LastName { get; set; }

        [StringLength(30)]
        public string FirstName { get; set; }

        [StringLength(4)]
        public string MiddleInitial { get; set; }

        [StringLength(2)]
        public string Suffix { get; set; }

        [StringLength(1)]
        public string Race { get; set; }

        [StringLength(1)]
        public string Sex { get; set; }

        [StringLength(2)]
        public string Ethnicity { get; set; }

        [StringLength(2)]
        public string Country { get; set; }

        public DateTime? BirthDate { get; set; }

        [StringLength(1)]
        public string Ver { get; set; } // <----- validate what this is and change it to make sense

        [StringLength(10)]
        public string FamilyId { get; set; }

        public DateTime? DeathDate { get; set; }

        [StringLength(30)]
        public string Address { get; set; }

        [StringLength(22)]
        public string City { get; set; }

        [StringLength(2)]
        public string State { get; set; }

        [StringLength(9)]
        public string Zip { get; set; }

        [StringLength(4)]
        public string County { get; set; }

        [StringLength(13)]
        public string Phone { get; set; }

        [StringLength(1)]
        public string Medicaid { get; set; }

        [StringLength(10)]
        public string MedicaidId { get; set; }

        [StringLength(1)]
        public string HmoStatus { get; set; }

        [StringLength(30)]
        public string ThirdParty { get; set; }

        [StringLength(13)]
        public string ThirdPartyId { get; set; }

        [StringLength(31)]
        public string PrimaryCarePhys { get; set; } // <-- change to sensible name

        [StringLength(9)]
        public string MediPass { get; set; }

        [StringLength(20)]
        public string UserFirstName { get; set; }

        [StringLength(30)]
        public string UserLastName { get; set; }

        [StringLength(255)]
        public string Comments { get; set; }

        [StringLength(30)]
        public string LastNameAka { get; set; }

        [StringLength(30)]
        public string FirstNameAka { get; set; }

        [StringLength(4)]
        public string MidInitAka { get; set; }// <-- change to sensible name

        [StringLength(1)]
        public string Disability { get; set; }

        [StringLength(2)]
        public string SatpRace { get; set; }// <-- change to sensible name

        [StringLength(255)]
        public string OtherSex { get; set; }

        [StringLength(255)]
        public string OtherRace { get; set; }

        [StringLength(30)]
        public string AddressOther { get; set; }

        [StringLength(22)]
        public string CityOther { get; set; }

        [StringLength(2)]
        public string StateOther { get; set; }

        [StringLength(9)]
        public string ZipOther { get; set; }

        [StringLength(2)]
        public string CountryOther { get; set; }

        [StringLength(30)]
        public string CountyOther { get; set; }

        [StringLength(1)]
        public string LicenseProfessional { get; set; }

        [StringLength(5)]
        public string LicenseType { get; set; }

        [StringLength(5)]
        public string LicenseType2 { get; set; }

        [StringLength(5)]
        public string LicenseType3 { get; set; }

        public DateTime CreateDate { get; set; }

        [Required, StringLength(20)]
        public string CreatedBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(20)]
        public string UpdatedBy { get; set; }
    }

}
