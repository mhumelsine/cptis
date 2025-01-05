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
    /// Configuration for the FinalCaseAssessment entity.
    /// </summary>
    public class FinalCaseAssessmentConfiguration : IEntityTypeConfiguration<FinalCaseAssessment>
    {
        public void Configure(EntityTypeBuilder<FinalCaseAssessment> builder)
        {
            // Table name
            builder.ToTable("FinalCaseAssessment");

            // Primary key
            builder.HasKey(e => e.FinalCaseAssessmentId);

            // Properties
            builder.Property(e => e.ClientId)
                .HasMaxLength(50);

            builder.Property(e => e.AbuseReportNumber)
                .HasMaxLength(50);

            builder.Property(e => e.RegistrationSequenceNumber)
                .HasMaxLength(50);

            builder.Property(e => e.FinalAssessment)
                .HasMaxLength(500);

            builder.Property(e => e.UserFirstName)
                .HasMaxLength(50);

            builder.Property(e => e.UserLastName)
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
