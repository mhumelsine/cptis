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
    public class NursingAssessmentPresentDuringExamConfiguration : IEntityTypeConfiguration<NursingAssessmentPresentDuringExam>
    {
        public void Configure(EntityTypeBuilder<NursingAssessmentPresentDuringExam> builder)
        {
            // Table name
            builder.ToTable("NursingAssessmentPresentDuringExam");

            // Primary Key
            builder.HasKey(pe => pe.NursingAssessmentPresentDuringExamId);

            builder.Audit(x => x.Audit);

            // Foreign Key Relationship
            builder.HasOne(pe => pe.NursingAssessment)
                .WithMany()
                .HasForeignKey(pe => pe.NursingAssessmentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Property configurations
            builder.Property(pe => pe.LastName)
                .HasMaxLength(50) // Maximum length for last name
                .IsRequired(false);

            builder.Property(pe => pe.FirstName)
                .HasMaxLength(50) // Maximum length for first name
                .IsRequired(false);

            builder.Property(pe => pe.Relationship)
                .HasMaxLength(50) // Maximum length for relationship
                .IsRequired(false);

            builder.Property(pe => pe.Description)
                .HasMaxLength(500) // Maximum length for description
                .IsRequired(false);

            builder.Property(pe => pe.CreateDate)
                .HasColumnType("datetime") // Date type column
                .IsRequired(false);

            builder.Property(pe => pe.UpdateDate)
                .HasColumnType("datetime") // Date type column
                .IsRequired(false);

            builder.Property(pe => pe.UserFirstName)
                .HasMaxLength(30) // Maximum length for the user first name
                .IsRequired(false);

            builder.Property(pe => pe.UserLastName)
                .HasMaxLength(30) // Maximum length for the user last name
                .IsRequired(false);

            builder.HasOne(e => e.NursingAssessment)
                .WithMany(n => n.NursingAssessmentPresentDuringExams)
                .HasForeignKey(e => e.NursingAssessmentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }

}
