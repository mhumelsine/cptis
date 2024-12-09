using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using cptis.domain.ClientDemographics;

namespace cptis.infrastructure.Database.Configurations
{
    public class ClientDemographicConfiguration : IEntityTypeConfiguration<ClientDemographic>
    {
        public void Configure(EntityTypeBuilder<ClientDemographic> builder)
        {
            builder.ToTable("ClientDemographic");

            builder.HasKey(c => c.ClientDemographicId);

            builder.Property(c => c.ClientId)
                .IsRequired()
                .HasMaxLength(9);

            builder.Property(c => c.LastName)
                .HasMaxLength(30);

            builder.Property(c => c.FirstName)
                .HasMaxLength(30);

            builder.Property(c => c.MiddleInitial)
                .HasMaxLength(4);

            builder.Property(c => c.Suffix)
                .HasMaxLength(2);

            builder.Property(c => c.Race)
                .HasMaxLength(1);

            builder.Property(c => c.Sex)
                .HasMaxLength(1);

            builder.Property(c => c.Ethnicity)
                .HasMaxLength(2);

            builder.Property(c => c.Country)
                .HasMaxLength(2);

            builder.Property(c => c.BirthDate)
                .HasColumnType("datetime");

            builder.Property(c => c.Ver)
                .HasMaxLength(1);

            builder.Property(c => c.FamilyId)
                .HasMaxLength(10);

            builder.Property(c => c.DeathDate)
                .HasColumnType("datetime");

            builder.Property(c => c.Address)
                .HasMaxLength(30);

            builder.Property(c => c.City)
                .HasMaxLength(22);

            builder.Property(c => c.State)
                .HasMaxLength(2);

            builder.Property(c => c.Zip)
                .HasMaxLength(9);

            builder.Property(c => c.County)
                .HasMaxLength(4);

            builder.Property(c => c.Phone)
                .HasMaxLength(13);

            builder.Property(c => c.Medicaid)
                .HasMaxLength(1);

            builder.Property(c => c.MedicaidId)
                .HasMaxLength(10);

            builder.Property(c => c.HmoStatus)
                .HasMaxLength(1);

            builder.Property(c => c.ThirdParty)
                .HasMaxLength(30);

            builder.Property(c => c.ThirdPartyId)
                .HasMaxLength(13);

            builder.Property(c => c.PrimaryCarePhys)
                .HasMaxLength(31);

            builder.Property(c => c.MediPass)
                .HasMaxLength(9);

            builder.Property(c => c.UserFirstName)
                .HasMaxLength(20);

            builder.Property(c => c.UserLastName)
                .HasMaxLength(30);

            builder.Property(c => c.Comments)
                .HasMaxLength(255);

            builder.Property(c => c.LastNameAka)
                .HasMaxLength(30);

            builder.Property(c => c.FirstNameAka)
                .HasMaxLength(30);

            builder.Property(c => c.MidInitAka)
                .HasMaxLength(4);

            builder.Property(c => c.Disability)
                .HasMaxLength(1);

            builder.Property(c => c.SatpRace)
                .HasMaxLength(2);

            builder.Property(c => c.OtherSex)
                .HasMaxLength(255);

            builder.Property(c => c.OtherRace)
                .HasMaxLength(255);

            builder.Property(c => c.AddressOther)
                .HasMaxLength(30);

            builder.Property(c => c.CityOther)
                .HasMaxLength(22);

            builder.Property(c => c.StateOther)
                .HasMaxLength(2);

            builder.Property(c => c.ZipOther)
                .HasMaxLength(9);

            builder.Property(c => c.CountryOther)
                .HasMaxLength(2);

            builder.Property(c => c.CountyOther)
                .HasMaxLength(30);

            builder.Property(c => c.LicenseProfessional)
                .HasMaxLength(1);

            builder.Property(c => c.LicenseType)
                .HasMaxLength(5);

            builder.Property(c => c.LicenseType2)
                .HasMaxLength(5);

            builder.Property(c => c.LicenseType3)
                .HasMaxLength(5);

            builder.Property(c => c.CreateDate)
                .IsRequired()
                .HasDefaultValueSql("getdate()");

            builder.Property(c => c.CreatedBy)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(c => c.UpdateDate)
                .HasColumnType("datetime");

            builder.Property(c => c.UpdatedBy)
                .HasMaxLength(20);
        }
    }
}
