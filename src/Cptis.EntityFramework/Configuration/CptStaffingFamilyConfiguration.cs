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
    /// Configuration for the CptStaffingFamily entity.
    /// </summary>
    public class CptStaffingFamilyConfiguration : IEntityTypeConfiguration<CptStaffingFamily>
    {
        public void Configure(EntityTypeBuilder<CptStaffingFamily> builder)
        {
            // Table name
            builder.ToTable("CptStaffingFamily");

            // Primary key
            builder.HasKey(e => e.CptStaffingFamilyId);

            // Properties
            builder.Property(e => e.AbuseReportNumber)
                .HasMaxLength(50);

            builder.Property(e => e.RegistrationSequenceNumber)
                .HasMaxLength(50);

            builder.Property(e => e.AssessmentSequenceNumber)
                .HasMaxLength(50);

            builder.Property(e => e.ClientId)
                .HasMaxLength(50);

            builder.Property(e => e.FirstName)
                .HasMaxLength(100);

            builder.Property(e => e.LastName)
                .HasMaxLength(100);

            builder.Property(e => e.Relation)
                .HasMaxLength(100);

            // Relationships
            builder.HasOne(e => e.CptStaffing)
                .WithMany()
                .HasForeignKey(e => e.CptStaffingId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }

}
