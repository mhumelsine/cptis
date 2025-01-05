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
    public class MedicalEvaluationAllergyConfiguration : IEntityTypeConfiguration<MedicalEvaluationAllergy>
    {
        public void Configure(EntityTypeBuilder<MedicalEvaluationAllergy> builder)
        {
            // Table Name
            builder.ToTable("MedicalEvaluationAllergy");

            // Primary Key
            builder.HasKey(e => e.MedicalEvaluationAllergyId);

            builder.Audit(x => x.Audit);

            // Properties
            builder.Property(e => e.MedicalEvaluationAllergyId).IsRequired();
            builder.Property(e => e.MedicalEvaluationId).IsRequired();
            builder.Property(e => e.Allergen).HasMaxLength(30);
            builder.Property(e => e.Reaction).HasMaxLength(30);
            builder.Property(e => e.CreateDate).HasColumnType("datetime");
            builder.Property(e => e.UpdateDate).HasColumnType("datetime");
            builder.Property(e => e.UserFirstName).HasMaxLength(30);
            builder.Property(e => e.UserLastName).HasMaxLength(30);

            // Relationships
            builder.HasOne(e => e.MedicalEvaluation)
                .WithMany(me => me.MedicalEvaluationAllergies)
                .HasForeignKey(e => e.MedicalEvaluationId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }

}
