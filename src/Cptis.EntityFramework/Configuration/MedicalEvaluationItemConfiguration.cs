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
    public class MedicalEvaluationItemConfiguration : IEntityTypeConfiguration<MedicalEvaluationItem>
    {
        public void Configure(EntityTypeBuilder<MedicalEvaluationItem> builder)
        {
            // Table Name
            builder.ToTable("MedicalEvaluationItem");

            // Primary Key
            builder.HasKey(e => e.MedicalEvaluationItemId);

            builder.Audit(x => x.Audit);

            // Properties
            builder.Property(e => e.MedicalEvaluationItemId).IsRequired();
            builder.Property(e => e.MedicalEvaluationId).IsRequired();
            builder.Property(e => e.MedicalEvaluationCodeId).IsRequired();
            builder.Property(e => e.Comment).HasMaxLength(30);
            builder.Property(e => e.LoginIdCreate).IsRequired();
            builder.Property(e => e.LoginIdUpdate).IsRequired();
            builder.Property(e => e.CreateDate).HasColumnType("datetime");
            builder.Property(e => e.UpdateDate).HasColumnType("datetime");

            // Relationships
            builder.HasOne(e => e.MedicalEvaluation)
                .WithMany(m => m.MedicalEvaluationItems)
                .HasForeignKey(e => e.MedicalEvaluationId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.MedicalEvaluationCode)
                .WithMany()
                .HasForeignKey(e => e.MedicalEvaluationCodeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
