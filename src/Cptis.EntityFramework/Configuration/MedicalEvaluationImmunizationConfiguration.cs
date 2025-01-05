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
    public class MedicalEvaluationImmunizationConfiguration : IEntityTypeConfiguration<MedicalEvaluationImmunization>
    {
        public void Configure(EntityTypeBuilder<MedicalEvaluationImmunization> builder)
        {
            // Table Name
            builder.ToTable("MedicalEvaluationImmunization");

            // Primary Key
            builder.HasKey(e => e.MedicalEvaluationImmunizationId);

            builder.Audit(x => x.Audit);

            // Properties
            builder.Property(e => e.MedicalEvaluationImmunizationId).IsRequired();
            builder.Property(e => e.Immunization).HasMaxLength(30).IsRequired();
            builder.Property(e => e.CreateDate).HasColumnType("datetime");
            builder.Property(e => e.UpdateDate).HasColumnType("datetime");
            builder.Property(e => e.UserFirstName).HasMaxLength(30);
            builder.Property(e => e.UserLastName).HasMaxLength(30);

            // Relationships
            builder.HasOne(e => e.MedicalEvaluation)
                .WithMany(m => m.MedicalEvaluationImmunizations)
                .HasForeignKey(e => e.MedicalEvaluationId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
