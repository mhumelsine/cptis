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
    /// Configuration for the SocialAssessment entity.
    /// </summary>
    public class SocialAssessmentConfiguration : IEntityTypeConfiguration<SocialAssessment>
    {
        public void Configure(EntityTypeBuilder<SocialAssessment> builder)
        {
            // Table name
            builder.ToTable("SocialAssessment");

            // Primary key
            builder.HasKey(e => e.SocialAssessmentId);

            // Properties
            builder.Property(e => e.AbuseReportNumber)
                .HasMaxLength(50);

            builder.Property(e => e.ClientId)
                .HasMaxLength(50);

            builder.Property(e => e.AssessmentSequenceNumber)
                .HasMaxLength(50);

            builder.Property(e => e.RegistrationSequenceNumber)
                .HasMaxLength(50);

            builder.Property(e => e.HistoryComment)
                .HasMaxLength(1000);

            builder.Property(e => e.FamilyHistoryComment)
                .HasMaxLength(1000);

            builder.Property(e => e.FamilyFunctioningComment)
                .HasMaxLength(1000);

            builder.Property(e => e.RiskComment)
                .HasMaxLength(1000);

            builder.Property(e => e.ImpressionComment)
                .HasMaxLength(1000);

            builder.Property(e => e.RecommendationsComment)
                .HasMaxLength(1000);

            builder.Property(e => e.PreparedBy)
                .HasMaxLength(100);

            builder.Property(e => e.ReviewedBy)
                .HasMaxLength(100);

            builder.Property(e => e.UserFirstName)
                .HasMaxLength(50);

            builder.Property(e => e.UserLastName)
                .HasMaxLength(50);

            builder.Property(e => e.CC)
                .HasMaxLength(1000);

            builder.Property(e => e.CpiName)
                .HasMaxLength(100);

            // Relationships
            builder.HasOne(e => e.ClientDemographic)
                .WithMany()
                .HasForeignKey(e => e.ClientDemographicId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Assessment)
                .WithMany()
                .HasForeignKey(e => e.AssessmentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Registration)
                .WithMany()
                .HasForeignKey(e => e.RegistrationId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
