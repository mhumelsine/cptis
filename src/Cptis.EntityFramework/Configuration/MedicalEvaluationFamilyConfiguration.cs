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
    public class MedicalEvaluationFamilyConfiguration : IEntityTypeConfiguration<MedicalEvaluationFamily>
    {
        public void Configure(EntityTypeBuilder<MedicalEvaluationFamily> builder)
        {
            // Table Name
            builder.ToTable("MedicalEvaluationFamily");

            // Primary Key
            builder.HasKey(e => e.MedicalEvaluationFamilyId);

            builder.Audit(x => x.Audit);

            // Properties
            builder.Property(e => e.MedicalEvaluationFamilyId).IsRequired();
            builder.Property(e => e.Firstname).HasMaxLength(30);
            builder.Property(e => e.Lastname).HasMaxLength(30);
            builder.Property(e => e.Age).HasColumnType("int");
            builder.Property(e => e.Relationship).HasMaxLength(30);
            builder.Property(e => e.Problems).HasMaxLength(255);
            builder.Property(e => e.CreateDate).HasColumnType("datetime");
            builder.Property(e => e.UpdateDate).HasColumnType("datetime");

            // Relationships
            builder.HasOne(e => e.MedicalEvaluation)
                .WithMany(m => m.MedicalEvaluationFamilies)
                .HasForeignKey(e => e.MedicalEvaluationId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
