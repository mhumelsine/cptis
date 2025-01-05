using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cptis.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cptis.EntityFramework.Configuration
{
    /// <summary>
    /// Configuration for the SatpIntake entity.
    /// </summary>
    public class SatpIntakeConfiguration : IEntityTypeConfiguration<SatpIntake>
    {
        public void Configure(EntityTypeBuilder<SatpIntake> builder)
        {
            // Table name
            builder.ToTable("SatpIntake");

            // Primary key
            builder.HasKey(e => e.SatpIntakeId);

            // Properties
            builder.Property(e => e.CaseNumber).HasMaxLength(30);
            builder.Property(e => e.LawEnforcementReportNumber).HasMaxLength(30);
            builder.Property(e => e.OfficeCode).HasMaxLength(30);
            builder.Property(e => e.ReportsObtainedCode).HasMaxLength(30);
            builder.Property(e => e.ProviderCode).HasMaxLength(30);
            builder.Property(e => e.CountyCode).HasMaxLength(30);
            builder.Property(e => e.ReferralSourceCode).HasMaxLength(30);
            builder.Property(e => e.AbuseTypeCode).HasMaxLength(30);
            builder.Property(e => e.ClientTypeCode).HasMaxLength(30);
            builder.Property(e => e.VictimPerpRelationCode).HasMaxLength(30);
            builder.Property(e => e.TerminationReasonCode).HasMaxLength(30);
            builder.Property(e => e.IdVoca).HasMaxLength(30);
            builder.Property(e => e.VictimStatus).HasMaxLength(30);
            builder.Property(e => e.UserFirstName).HasMaxLength(30);
            builder.Property(e => e.UserLastName).HasMaxLength(30);
            builder.Property(e => e.Comments).HasMaxLength(500);

            // Relationships
            builder.HasOne<ClientDemographic>()
                .WithMany()
                .HasForeignKey(e => e.ClientDemographicId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<SatpComment>()
                .WithMany()
                .HasForeignKey(e => e.SummaryCommentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<SatpComment>()
                .WithMany()
                .HasForeignKey(e => e.OtherCommentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<SatpComment>()
                .WithMany()
                .HasForeignKey(e => e.OtherReferralSourceCommentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
