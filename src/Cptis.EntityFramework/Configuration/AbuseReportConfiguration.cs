using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cptis.Core;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Cptis.EntityFramework.Configuration
{
    public class AbuseReportConfiguration : IEntityTypeConfiguration<AbuseReport>
    {
        public void Configure(EntityTypeBuilder<AbuseReport> builder)
        {
            builder.ToTable("AbuseReport");

            builder.HasKey(e => e.AbuseReportId);
            builder.Audit(x => x.Audit);

            builder.Property(e => e.AbuseReportNumber).HasMaxLength(30);
            builder.Property(e => e.AbuseReportSequenceNumber).HasMaxLength(30);
            builder.Property(e => e.CptExceptionReason).HasMaxLength(30);
            builder.Property(e => e.CptOffice).HasMaxLength(30);
            builder.Property(e => e.MandatoryReferralCriteria).HasMaxLength(30);
            builder.Property(e => e.MedicalReviewRequired).HasMaxLength(30);
            builder.Property(e => e.DistrictAreaUnit).HasMaxLength(30);
            builder.Property(e => e.ArCounty).HasMaxLength(30);
            builder.Property(e => e.Comments).HasMaxLength(30);
            builder.Property(e => e.UserFirstName).HasMaxLength(30);
            builder.Property(e => e.UserLastName).HasMaxLength(30);
            builder.Property(e => e.CrossTeam).HasMaxLength(30);
            builder.Property(e => e.ReasonReferralDeclined).HasMaxLength(30);
            builder.Property(e => e.IsVocaCase).HasMaxLength(30);
            builder.Property(e => e.Linked).HasMaxLength(30);
            builder.Property(e => e.ExceptReason).HasMaxLength(30);
            builder.Property(e => e.LinkedToIntake).HasMaxLength(30);
            builder.Property(e => e.IsRestrictedCase).HasMaxLength(30);
            builder.Property(e => e.HasAttestation).HasMaxLength(30);
            builder.Property(e => e.PreparedBy).HasMaxLength(30);
            builder.Property(e => e.CptMedicalOffice).HasMaxLength(30);
            builder.Property(e => e.CreateBy).HasMaxLength(30);
            builder.Property(e => e.UpdatedBy).HasMaxLength(30);

            builder.HasMany(e => e.LinkedReports)
                .WithOne(e => e.AbuseReport)
                .HasForeignKey(e => e.AbuseReportId);

        }
    }
}
