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
    public class MedicalEvaluationImpressionRecommendationConfiguration : IEntityTypeConfiguration<MedicalEvaluationImpressionRecommendation>
    {
        public void Configure(EntityTypeBuilder<MedicalEvaluationImpressionRecommendation> builder)
        {
            // Table Name
            builder.ToTable("MedicalEvaluationImpressionRecommendation");

            // Primary Key
            builder.HasKey(e => e.MedicalEvaluationImpressionRecommendationId);

            builder.Audit(x => x.Audit);

            // Properties
            builder.Property(e => e.MedicalEvaluationImpressionRecommendationId).IsRequired();
            builder.Property(e => e.CodeType).HasMaxLength(30).IsRequired();
            builder.Property(e => e.Code).HasMaxLength(30).IsRequired();
            builder.Property(e => e.Comment).HasMaxLength(255);
            builder.Property(e => e.LoginIdCreate);
            builder.Property(e => e.CreateDate).HasColumnType("datetime");
            builder.Property(e => e.LoginIdUpdate);
            builder.Property(e => e.UpdateDate).HasColumnType("datetime");

            // Relationships
            builder.HasOne(e => e.MedicalEvaluation)
                .WithMany(m => m.MedicalEvaluationImpressionRecommendations)
                .HasForeignKey(e => e.MedicalEvaluationId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
