using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.EntityFramework.Configuration
{
    /// <summary>
    /// Configuration for the ClientDemographic entity.
    /// </summary>
    public class ClientDemographicConfiguration : IEntityTypeConfiguration<ClientDemographic>
    {
        public void Configure(EntityTypeBuilder<ClientDemographic> builder)
        {
            // Table name
            builder.ToTable("ClientDemographic");

            // Primary key
            builder.HasKey(e => e.ClientDemographicId);

            // Properties
            builder.Property(e => e.ClientId)
                .HasMaxLength(30);

            builder.Property(e => e.LastName)
                .HasMaxLength(30);

            builder.Property(e => e.FirstName)
                .HasMaxLength(30);

            builder.Property(e => e.MiddleInitial)
                .HasMaxLength(1);

            builder.Property(e => e.Suffix)
                .HasMaxLength(10);

            builder.Property(e => e.Race)
                .HasMaxLength(30);

            builder.Property(e => e.Sex)
                .HasMaxLength(10);

            builder.Property(e => e.Ethnicity)
                .HasMaxLength(30);

            builder.Property(e => e.Country)
                .HasMaxLength(30);

            builder.Property(e => e.BirthDateVerification)
                .HasMaxLength(30);

            builder.Property(e => e.Medicaid)
                .HasMaxLength(30);

            builder.Property(e => e.MedicaidId)
                .HasMaxLength(30);

            builder.Property(e => e.HmoStatus)
                .HasMaxLength(30);

            builder.Property(e => e.PrimaryCarePhys)
                .HasMaxLength(100);

            builder.Property(e => e.UserFirstName)
                .HasMaxLength(30);

            builder.Property(e => e.UserLastName)
                .HasMaxLength(30);

            builder.Property(e => e.Comments)
                .HasMaxLength(500);

            builder.Property(e => e.LastNameAka)
                .HasMaxLength(30);

            builder.Property(e => e.FirstNameAka)
                .HasMaxLength(30);

            builder.Property(e => e.MidInitAka)
                .HasMaxLength(1);

            builder.Property(e => e.Disability)
                .HasMaxLength(100);

            builder.Property(e => e.SatpRace)
                .HasMaxLength(30);

            builder.Property(e => e.OtherSex)
                .HasMaxLength(30);

            builder.Property(e => e.OtherRace)
                .HasMaxLength(30);

            builder.Property(e => e.CreatedBy)
                .HasMaxLength(30);

            builder.Property(e => e.UpdatedBy)
                .HasMaxLength(30);

            builder.Property(e => e.IsDeleted)
                .IsRequired();

            builder.HasMany(e => e.ClientPhone)
                .WithOne(e => e.ClientDemographic)
                .HasForeignKey(e => e.ClientPhoneId);

            builder.HasMany(e => e.ClientAddress)
                .WithOne(e => e.ClientDemographic)
                .HasForeignKey(e => e.ClientAddressId);
        }
    }
}
