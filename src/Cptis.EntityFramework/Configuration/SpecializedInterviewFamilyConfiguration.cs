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
    /// Configuration for the SpecializedInterviewFamily entity.
    /// </summary>
    public class SpecializedInterviewFamilyConfiguration : IEntityTypeConfiguration<SpecializedInterviewFamily>
    {
        public void Configure(EntityTypeBuilder<SpecializedInterviewFamily> builder)
        {
            // Table name
            builder.ToTable("SpecializedInterviewFamily");

            // Primary key
            builder.HasKey(e => e.SpecializedInterviewFamilyId);

            // Properties
            builder.Property(e => e.AbuseReportNumber)
                .HasMaxLength(50);

            builder.Property(e => e.ClientId)
                .HasMaxLength(50);

            builder.Property(e => e.AssessmentSequenceNumber)
                .HasMaxLength(50);

            builder.Property(e => e.RegistrationSequenceNumber)
                .HasMaxLength(50);

            builder.Property(e => e.FirstName)
                .HasMaxLength(100);

            builder.Property(e => e.LastName)
                .HasMaxLength(100);

            builder.Property(e => e.Relationship)
                .HasMaxLength(100);

            // Relationships
            builder.HasOne(e => e.SpecializedInterview)
                .WithMany()
                .HasForeignKey(e => e.SpecializedInterviewId)
                .OnDelete(DeleteBehavior.Cascade);

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
