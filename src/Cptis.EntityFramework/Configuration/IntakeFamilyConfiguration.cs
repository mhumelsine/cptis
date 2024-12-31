using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.EntityFramework.Configuration
{
    public class IntakeFamilyConfiguration : IEntityTypeConfiguration<IntakeFamily>
    {
        public void Configure(EntityTypeBuilder<IntakeFamily> builder)
        {
            builder.ToTable("IntakeFamily");

            builder.HasKey(e => e.IntakeFamilyId);

            builder.Property(e => e.AbuseReportNumber).HasMaxLength(30);
            builder.Property(e => e.AbuseReportSequenceNumber).HasMaxLength(30);
            builder.ComplexProperty(x => x.ClientId, options =>
            {
                options.Property(x => x.Value)
                    .HasColumnName("client_id")
                    .HasMaxLength(11);
            });
            builder.Property(e => e.AllegedPerpetrator).HasMaxLength(30);
            builder.Audit(x => x.Audit);

            builder.HasOne(e => e.Intake)
                .WithMany(i => i.IntakeFamilies)
                .HasForeignKey(e => e.IntakeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.FamilyDemographic)
                .WithMany()
                .HasForeignKey(e => e.FamilyDemographicId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
