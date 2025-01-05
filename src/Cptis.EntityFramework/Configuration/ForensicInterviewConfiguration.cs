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
    /// Configuration for the ForensicInterview entity.
    /// </summary>
    public class ForensicInterviewConfiguration : IEntityTypeConfiguration<ForensicInterview>
    {
        public void Configure(EntityTypeBuilder<ForensicInterview> builder)
        {
            // Table name
            builder.ToTable("ForensicInterview");

            // Primary key
            builder.HasKey(e => e.ForensicInterviewId);

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

            builder.Property(e => e.InterviewRequestor)
                .HasMaxLength(100);

            builder.Property(e => e.Agency)
                .HasMaxLength(100);

            builder.Property(e => e.RecordingMethod)
                .HasMaxLength(100);

            builder.Property(e => e.PurposeComment)
                .HasMaxLength(1000);

            builder.Property(e => e.SafetyComment)
                .HasMaxLength(1000);

            builder.Property(e => e.InterviewFindingsComment)
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

            builder.Property(e => e.CPIName)
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
