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
    public class NursingAssessmentAllergyConfiguration : IEntityTypeConfiguration<NursingAssessmentAllergy>
    {
        public void Configure(EntityTypeBuilder<NursingAssessmentAllergy> builder)
        {
            // Table name
            builder.ToTable("NursingAssessmentAllergy");

            builder.Audit(x => x.Audit);

            // Primary Key
            builder.HasKey(na => na.NursingAssessmentAllergyId);

            // Foreign Key Relationship
            builder.HasOne(na => na.NursingAssessment)
                .WithMany()
                .HasForeignKey(na => na.NursingAssessmentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Property configurations
            builder.Property(na => na.Allergen)
                .HasMaxLength(30) // Maximum length of the allergen name
                .IsRequired(false);

            builder.Property(na => na.Reaction)
                .HasMaxLength(200) // Maximum length of the reaction description
                .IsRequired(false);

            builder.Property(na => na.CreateDate)
                .HasColumnType("datetime") // Date type column
                .IsRequired(false);

            builder.Property(na => na.UpdateDate)
                .HasColumnType("datetime") // Date type column
                .IsRequired(false);

            builder.Property(na => na.UserFirstName)
                .HasMaxLength(30) // Maximum length of the user first name
                .IsRequired(false);

            builder.Property(na => na.UserLastName)
                .HasMaxLength(30) // Maximum length of the user last name
                .IsRequired(false);
        }
    }
}
