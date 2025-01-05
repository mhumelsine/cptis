using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Cptis.Core;

namespace Cptis.EntityFramework.Configuration
{
    /// <summary>
    /// Configuration for the FamilyDemographic entity.
    /// </summary>
    public class FamilyDemographicConfiguration : IEntityTypeConfiguration<FamilyDemographic>
    {
        public void Configure(EntityTypeBuilder<FamilyDemographic> builder)
        {
            // Table name
            builder.ToTable("FamilyDemographic");

            // Primary key
            builder.HasKey(e => e.FamilyDemographicId);

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

            builder.Property(e => e.BirthDateVerification)
                .HasMaxLength(30);

            builder.Address(x => x.Address);

            builder.Property(e => e.Phone)
                .HasMaxLength(30);

            builder.Property(e => e.PrimaryCarePhys)
                .HasMaxLength(100);

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

            builder.Property(e => e.UserFirstName)
                .HasMaxLength(30);

            builder.Property(e => e.UserLastName)
                .HasMaxLength(30);

            builder.Address(x => x.AddressAlt);

            builder.Property(e => e.IsDeleted)
                .IsRequired();

            // Relationships
            builder.HasOne<ClientDemographic>()
                .WithMany()
                .HasForeignKey(e => e.ClientDemographicId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
