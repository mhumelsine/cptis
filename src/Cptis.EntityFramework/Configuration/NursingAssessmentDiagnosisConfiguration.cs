using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.EntityFramework.Configuration
{
    public class NursingAssessmentDiagnosisConfiguration : IEntityTypeConfiguration<NursingAssessmentDiagnosis>
    {
        public void Configure(EntityTypeBuilder<NursingAssessmentDiagnosis> builder)
        {
            // Table name
            builder.ToTable("NursingAssessmentDiagnosis");

            // Primary Key
            builder.HasKey(e => e.NursingAssessmentDiagnosisId);

            builder.Audit(x => x.Audit);

            // Properties
            builder.Property(e => e.DiagnosisCode)
                .HasMaxLength(50)
                .IsRequired(false);

            builder.Property(e => e.Comment)
                .HasMaxLength(255)
                .IsRequired(false);

            // Relationships
            builder.HasOne(e => e.NursingAssessment)
                .WithMany(n => n.Diagnoses)
                .HasForeignKey(e => e.NursingAssessmentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
