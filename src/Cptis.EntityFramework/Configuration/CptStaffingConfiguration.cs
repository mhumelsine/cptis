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
    /// Configuration for the CptStaffing entity.
    /// </summary>
    public class CptStaffingConfiguration : IEntityTypeConfiguration<CptStaffing>
    {
        public void Configure(EntityTypeBuilder<CptStaffing> builder)
        {
            // Table name
            builder.ToTable("CptStaffing");

            // Primary key
            builder.HasKey(e => e.CptStaffingId);

            // Properties
            builder.Property(e => e.AbuseReportNumber)
                .HasMaxLength(50);

            builder.Property(e => e.ClientId)
                .HasMaxLength(50);

            builder.Property(e => e.AssessmentSequenceNumber)
                .HasMaxLength(50);

            builder.Property(e => e.RegistrationSequenceNumber)
                .HasMaxLength(50);

            builder.Property(e => e.Cpi)
                .HasMaxLength(100);

            builder.Property(e => e.CpiLead)
                .HasMaxLength(100);

            builder.Property(e => e.Position)
                .HasMaxLength(50);

            builder.Property(e => e.ConfidentialitySigned)
                .HasMaxLength(50);

            builder.Property(e => e.PurposeComment)
                .HasMaxLength(500);

            builder.Property(e => e.SummaryComment)
                .HasMaxLength(500);

            builder.Property(e => e.RiskComment)
                .HasMaxLength(500);

            builder.Property(e => e.BarriersComment)
                .HasMaxLength(500);

            builder.Property(e => e.PreparedBy)
                .HasMaxLength(100);

            builder.Property(e => e.ReviewedBy)
                .HasMaxLength(100);

            builder.Property(e => e.UserFirstName)
                .HasMaxLength(100);

            builder.Property(e => e.UserLastName)
                .HasMaxLength(100);

            builder.Property(e => e.CC)
                .HasMaxLength(200);

            // Relationships
            builder.HasOne(e => e.Assessment)
                .WithMany()
                .HasForeignKey(e => e.AssessmentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Registration)
                .WithMany()
                .HasForeignKey(e => e.RegistrationId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.ClientDemographic)
                .WithMany()
                .HasForeignKey(e => e.ClientDemographicId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
