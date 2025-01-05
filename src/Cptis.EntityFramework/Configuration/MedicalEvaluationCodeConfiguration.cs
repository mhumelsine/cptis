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
    public class MedicalEvaluationCodeConfiguration : IEntityTypeConfiguration<MedicalEvaluationCode>
    {
        public void Configure(EntityTypeBuilder<MedicalEvaluationCode> builder)
        {
            // Table Name
            builder.ToTable("MedicalEvaluationCode");

            // Primary Key
            builder.HasKey(e => e.MedicalEvaluationCodeId);

            builder.Audit(x => x.Audit);

            // Properties
            builder.Property(e => e.MedicalEvaluationCodeId).IsRequired();
            builder.Property(e => e.Group).HasMaxLength(30);
            builder.Property(e => e.Abbreviation).HasMaxLength(30);
            builder.Property(e => e.Description).HasMaxLength(30);
            builder.Property(e => e.AllowMoreInfo).IsRequired();
            builder.Property(e => e.Active).IsRequired();
            builder.Property(e => e.Order).IsRequired();
            builder.Property(e => e.CreateDate).HasColumnType("datetime");
            builder.Property(e => e.UpdateDate).HasColumnType("datetime");

            // Relationships
            builder.HasMany(e => e.MedicalEvaluationItems)
                .WithOne(ei => ei.MedicalEvaluationCode)
                .HasForeignKey(ei => ei.MedicalEvaluationCodeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
