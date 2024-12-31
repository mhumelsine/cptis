using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.EntityFramework.Configuration
{
    public class IntakeMaltreatmentConfiguration : IEntityTypeConfiguration<IntakeMaltreatment>
    {
        public void Configure(EntityTypeBuilder<IntakeMaltreatment> builder)
        {
            builder.ToTable("IntakeMaltreatment");

            builder.HasKey(e => e.IntakeMaltreatmentId);

            builder.Property(e => e.AbuseReportNumber).HasMaxLength(15);
            builder.Property(e => e.AbuseReportSequenceNumber).HasMaxLength(2);
            builder.Property(e => e.MaltreatmentCode).HasMaxLength(10);
            builder.Property(e => e.MaltreatmentType).HasMaxLength(10);
            builder.Audit(x => x.Audit);

            builder.HasOne(e => e.Intake)
                .WithMany(i => i.IntakeMaltreatments)
                .HasForeignKey(e => e.IntakeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
