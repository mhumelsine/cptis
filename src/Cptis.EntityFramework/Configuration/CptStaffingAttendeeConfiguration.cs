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
    /// Configuration for the CptStaffingAttendee entity.
    /// </summary>
    public class CptStaffingAttendeeConfiguration : IEntityTypeConfiguration<CptStaffingAttendee>
    {
        public void Configure(EntityTypeBuilder<CptStaffingAttendee> builder)
        {
            // Table name
            builder.ToTable("CptStaffingAttendee");

            // Primary key
            builder.HasKey(e => e.CptStaffingAttendeeId);

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

            builder.Property(e => e.Position)
                .HasMaxLength(100);

            // Relationships
            builder.HasOne(e => e.CptStaffing)
                .WithMany()
                .HasForeignKey(e => e.CptStaffingId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
