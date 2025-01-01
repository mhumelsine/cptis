using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.EntityFramework.Configuration
{
    public class MedicalEvaluationConfiguration : IEntityTypeConfiguration<MedicalEvaluation>
    {
        public void Configure(EntityTypeBuilder<MedicalEvaluation> builder)
        {
            // Table Name
            builder.ToTable("MedicalEvaluation");

            builder.Audit(x => x.Audit);

            // Primary Key
            builder.HasKey(e => e.MedicalEvaluationId);

            // Properties
            builder.Property(e => e.MedicalEvaluationId).IsRequired();
            builder.Property(e => e.AbuseReportNumber).HasMaxLength(30);
            builder.ComplexProperty(x => x.ClientId, options =>
            {
                options.Property(x => x.Value)
                    .HasColumnName("client_id")
                    .HasMaxLength(30);
            });
            builder.Property(e => e.AssessmentSequenceNumber).HasMaxLength(30);
            builder.Property(e => e.RegistrationSequenceNumber).HasMaxLength(30);
            builder.Property(e => e.EvaluationType).HasMaxLength(255);

            // Relationships
            builder.HasOne(e => e.AbuseReport)
                .WithMany()
                .HasForeignKey(e => e.AbuseReportId);

            builder.HasOne(e => e.ClientDemographic)
                .WithMany()
                .HasForeignKey(e => e.ClientDemographicId);

            builder.HasOne(e => e.Assessment)
                .WithMany()
                .HasForeignKey(e => e.AssessmentId);

            builder.HasOne(e => e.Registration)
                .WithMany()
                .HasForeignKey(e => e.RegistrationId);
        }
    }
}
