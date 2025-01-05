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
    /// Configuration for the SocialAssessmentHousehold entity.
    /// </summary>
    public class SocialAssessmentHouseholdConfiguration : IEntityTypeConfiguration<SocialAssessmentHousehold>
    {
        public void Configure(EntityTypeBuilder<SocialAssessmentHousehold> builder)
        {
            // Table name
            builder.ToTable("SocialAssessmentHousehold");

            // Primary key
            builder.HasKey(e => e.SocialAssessmentHouseholdId);

            // Properties
            builder.Property(e => e.AbuseReportNumber)
                .HasMaxLength(50);

            builder.Property(e => e.AssessmentSequenceNumber)
                .HasMaxLength(50);

            builder.Property(e => e.RegistrationSequenceNumber)
                .HasMaxLength(50);

            builder.Property(e => e.ClientId)
                .HasMaxLength(50);

            builder.Property(e => e.FirstName)
                .HasMaxLength(100);

            builder.Property(e => e.LastName)
                .HasMaxLength(100);

            builder.Property(e => e.Relationship)
                .HasMaxLength(100);

            // Relationships
            builder.HasOne(e => e.SocialAssessment)
                .WithMany()
                .HasForeignKey(e => e.SocialAssessmentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }

}
