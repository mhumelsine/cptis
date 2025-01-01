using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.EntityFramework.Configuration
{
    public class AbuseReportLinkConfiguration : IEntityTypeConfiguration<AbuseReportLink>
    {
        public void Configure(EntityTypeBuilder<AbuseReportLink> builder)
        {
            builder.ToTable("AbuseReportLink");

            builder.HasKey(e => e.AbuseReportLinkId);

            builder.Property(e => e.CreateDate);
            builder.Audit(x => x.Audit);

            builder.HasOne(e => e.AbuseReport)
                .WithMany(e => e.LinkedReports)
                .HasForeignKey(e => e.AbuseReportId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(e => e.LinkedAbuseReport)
                .WithMany(e => e.LinkedByReports)
                .HasForeignKey(e => e.LinkedAbuseReportId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
