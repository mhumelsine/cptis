using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.EntityFramework.Configuration
{
    public class AssessmentSTDConfiguration : IEntityTypeConfiguration<AssessmentSTD>
    {
        public void Configure(EntityTypeBuilder<AssessmentSTD> builder)
        {
            // Table Name
            builder.ToTable("AssessmentSTD");

            // Primary Key
            builder.HasKey(e => e.AssessmentStdId);

            builder.Audit(x => x.Audit);

            // Properties with Column Mappings
            builder.Property(e => e.AssessmentStdId)
                .HasColumnName("AssessmentStdId")
                .IsRequired();

            builder.Property(e => e.AssessmentId)
                .HasColumnName("AssessmentId")
                .IsRequired();

            builder.ComplexProperty(x => x.ClientId, options =>
            {
                options.Property(x => x.Value)
                    .HasColumnName("client_id")
                    .HasMaxLength(30);
            });

            builder.Property(e => e.AbuseReportNumber)
                .HasColumnName("AbuseReportNumber")
                .HasMaxLength(30);

            builder.Property(e => e.AssessmentSequenceNumber)
                .HasColumnName("AssessmentSequenceNumber")
                .HasMaxLength(30);

            builder.Property(e => e.SexualActivitySixtyDays)
                .HasColumnName("SexualActivitySixtyDays")
                .HasMaxLength(255);

            builder.Property(e => e.PregnancyTest)
                .HasColumnName("PregnancyTest")
                .HasMaxLength(255);

            builder.Property(e => e.ReferredTo)
                .HasColumnName("ReferredTo")
                .HasMaxLength(255);

            builder.Property(e => e.ServicesProvidedDate)
                .HasColumnName("ServicesProvidedDate");

            builder.Property(e => e.UpdateDate)
                .HasColumnName("UpdateDate");

            builder.Property(e => e.UserFirstName)
                .HasColumnName("UserFirstName")
                .HasMaxLength(30);

            builder.Property(e => e.UserLastName)
                .HasColumnName("UserLastName")
                .HasMaxLength(30);

            builder.Property(e => e.ProviderSignature)
                .HasColumnName("ProviderSignature")
                .HasMaxLength(255);

            builder.Property(e => e.ProviderSignatureDate)
                .HasColumnName("ProviderSignatureDate");

            // Relationships
            builder.HasOne(e => e.Assessment)
                .WithMany(a => a.AssessmentSTDs)
                .HasForeignKey(e => e.AssessmentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
