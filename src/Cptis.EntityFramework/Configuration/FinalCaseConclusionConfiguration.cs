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
    /// Configuration for the FinalCaseConclusion entity.
    /// </summary>
    public class FinalCaseConclusionConfiguration : IEntityTypeConfiguration<FinalCaseConclusion>
    {
        public void Configure(EntityTypeBuilder<FinalCaseConclusion> builder)
        {
            // Table name
            builder.ToTable("FinalCaseConclusion");

            // Primary key
            builder.HasKey(e => e.FinalCaseConclusionId);

            // Properties
            builder.Property(e => e.ClientId)
                .HasMaxLength(50);

            builder.Property(e => e.AbuseReportNumber)
                .HasMaxLength(50);

            builder.Property(e => e.RegistrationSequenceNumber)
                .HasMaxLength(50);

            builder.Property(e => e.Conclusion)
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
