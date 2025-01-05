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
    public class MedicalEvaluationMedicationConfiguration : IEntityTypeConfiguration<MedicalEvaluationMedication>
    {
        public void Configure(EntityTypeBuilder<MedicalEvaluationMedication> builder)
        {
            // Table Name
            builder.ToTable("MedicalEvaluationMedication");

            // Primary Key
            builder.HasKey(e => e.MedicalEvaluationMedicationId);

            builder.Audit(x => x.Audit);
            // Properties
            builder.Property(e => e.Name).HasMaxLength(30).IsRequired();
            builder.Property(e => e.Dose).HasMaxLength(30);
            builder.Property(e => e.Reason).HasMaxLength(255);
            builder.Property(e => e.CreateDate).HasColumnType("datetime");
            builder.Property(e => e.UpdateDate).HasColumnType("datetime");
            builder.Property(e => e.UserFirstName).HasMaxLength(30);
            builder.Property(e => e.UserLastName).HasMaxLength(30);

            // Relationships
            builder.HasOne(e => e.MedicalEvaluation)
                .WithMany(m => m.MedicalEvaluationMedications)
                .HasForeignKey(e => e.MedicalEvaluationId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
