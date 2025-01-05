using Cptis.Core;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.EntityFramework.Configuration
{
    /// <summary>
    /// Configuration for the RegistrationFamily entity.
    /// </summary>
    public class RegistrationFamilyConfiguration : IEntityTypeConfiguration<RegistrationFamily>
    {
        public void Configure(EntityTypeBuilder<RegistrationFamily> builder)
        {
            // Table name
            builder.ToTable("RegistrationFamily");

            // Primary key
            builder.HasKey(e => e.RegistrationFamilyId);

            // Properties
            builder.Property(e => e.AllegedPerpetrator)
                .HasMaxLength(100);

            builder.Property(e => e.ClientId)
                .HasMaxLength(30);

            builder.Property(e => e.FamilyID)
                .HasMaxLength(30);

            builder.Property(e => e.CaseNumber)
                .HasMaxLength(30);

            builder.Property(e => e.RegistrationSequenceNumber)
                .HasMaxLength(30);

            builder.Property(e => e.Relation)
                .HasMaxLength(50);

            // Relationships
            builder.HasOne(e => e.ClientDemographic)
                .WithMany()
                .HasForeignKey(e => e.ClientDemographicId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Registration)
                .WithMany()
                .HasForeignKey(e => e.RegistrationId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
