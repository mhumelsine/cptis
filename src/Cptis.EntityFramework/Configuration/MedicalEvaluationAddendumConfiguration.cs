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
    public class MedicalEvaluationAddendumConfiguration : IEntityTypeConfiguration<MedicalEvaluationAddendum>
    {
        public void Configure(EntityTypeBuilder<MedicalEvaluationAddendum> builder)
        {
            // Table Name
            builder.ToTable("MedicalEvaluationAddendum");

            // Primary Key
            builder.HasKey(e => e.MedicalEvaluationAddendumId);

            builder.Audit(x => x.Audit);

            // Property Configurations
            builder.Property(e => e.MedicalEvaluationAddendumId).IsRequired();

            builder.Property(e => e.MedicalEvaluationId).IsRequired();

            builder.Property(e => e.Addendum)
                .HasMaxLength(500) // Adjusted for potential large text content
                .IsRequired(false); // Allows null values

            builder.Property(e => e.PreparedBy)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(e => e.PreparedDate)
                .HasColumnType("datetime");

            builder.Property(e => e.CreateDate)
                .HasColumnType("datetime");

            builder.Property(e => e.UpdateDate)
                .HasColumnType("datetime");

            builder.Property(e => e.UserFirstName)
                .HasMaxLength(30);

            builder.Property(e => e.UserLastName)
                .HasMaxLength(30);

            // Relationships
            builder.HasOne(e => e.MedicalEvaluation)
                .WithMany(m => m.MedicalEvaluationAddendums)
                .HasForeignKey(e => e.MedicalEvaluationId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
