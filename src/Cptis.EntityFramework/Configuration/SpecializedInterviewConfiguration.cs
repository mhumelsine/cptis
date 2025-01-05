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
    /// Configuration for the SpecializedInterview entity.
    /// </summary>
    public class SpecializedInterviewConfiguration : IEntityTypeConfiguration<SpecializedInterview>
    {
        public void Configure(EntityTypeBuilder<SpecializedInterview> builder)
        {
            // Table name
            builder.ToTable("SpecializedInterview");

            // Primary key
            builder.HasKey(e => e.SpecializedInterviewId);

            // Properties
            builder.Property(e => e.AbuseReportNumber)
                .HasMaxLength(50);

            builder.Property(e => e.ClientId)
                .HasMaxLength(50);

            builder.Property(e => e.AssessmentSequenceNumber)
                .HasMaxLength(50);

            builder.Property(e => e.RegistrationSequenceNumber)
                .HasMaxLength(50);

            builder.Property(e => e.PersonInterviewed)
                .HasMaxLength(100);

            builder.Property(e => e.RecordingMethod)
                .HasMaxLength(100);

            builder.Property(e => e.Relationship)
                .HasMaxLength(100);

            builder.Property(e => e.InterviewType)
                .HasMaxLength(50);

            builder.Property(e => e.CC)
                .HasMaxLength(100);

            builder.Property(e => e.CpiName)
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
        }
    }
}
