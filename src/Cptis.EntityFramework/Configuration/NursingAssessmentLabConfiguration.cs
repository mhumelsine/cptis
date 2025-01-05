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
    public class NursingAssessmentLabConfiguration : IEntityTypeConfiguration<NursingAssessmentLab>
    {
        public void Configure(EntityTypeBuilder<NursingAssessmentLab> builder)
        {
            // Table name
            builder.ToTable("NursingAssessmentLab");

            // Primary Key
            builder.HasKey(e => e.NursingAssessmentLabId);

            builder.Audit(x => x.Audit);

            // Properties
            builder.Property(e => e.Lab)
                .HasMaxLength(100)
                .IsRequired(false);

            builder.Property(e => e.Comment)
                .HasMaxLength(255)
                .IsRequired(false);

            // Relationships
            builder.HasOne(e => e.NursingAssessment)
                .WithMany(n => n.NursingAssessmentLabs)
                .HasForeignKey(e => e.NursingAssessmentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
