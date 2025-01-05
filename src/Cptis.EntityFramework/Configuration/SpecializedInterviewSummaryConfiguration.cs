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
    /// Configuration for the SpecializedInterviewSummary entity.
    /// </summary>
    public class SpecializedInterviewSummaryConfiguration : IEntityTypeConfiguration<SpecializedInterviewSummary>
    {
        public void Configure(EntityTypeBuilder<SpecializedInterviewSummary> builder)
        {
            // Table name
            builder.ToTable("SpecializedInterviewSummary");

            // Primary key
            builder.HasKey(e => e.SpecializedInterviewSummaryId);

            // Properties
            builder.Property(e => e.AbuseReportNumber)
                .HasMaxLength(50);

            builder.Property(e => e.AssessmentSequenceNumber)
                .HasMaxLength(50);

            builder.Property(e => e.RegistrationSequenceNumber)
                .HasMaxLength(50);

            builder.Property(e => e.ClientId)
                .HasMaxLength(50);

            builder.Property(e => e.PersonInterviewed)
                .HasMaxLength(100);

            builder.Property(e => e.Relationship)
                .HasMaxLength(100);

            builder.Property(e => e.InterviewLocation)
                .HasMaxLength(100);

            // Relationships
            builder.HasOne(e => e.ClientDemographic)
                .WithMany()
                .HasForeignKey(e => e.ClientDemographicId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Registration)
                .WithMany()
                .HasForeignKey(e => e.RegistrationId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Assessment)
                .WithMany()
                .HasForeignKey(e => e.AssessmentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.SpecializedInterview)
                .WithMany()
                .HasForeignKey(e => e.SpecializedInterviewId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
