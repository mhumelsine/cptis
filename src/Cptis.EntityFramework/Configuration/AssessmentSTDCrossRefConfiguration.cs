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
    public class AssessmentSTDCrossRefConfiguration : IEntityTypeConfiguration<AssessmentSTDCrossRef>
    {
        public void Configure(EntityTypeBuilder<AssessmentSTDCrossRef> builder)
        {
            // Table Name
            builder.ToTable("AssessmentSTDCrossRef");

            builder.Audit(x => x.Audit);

            // Primary Key
            builder.HasKey(e => e.AssessmentSTDCrossRefId);

            // Properties with Column Mappings
            builder.Property(e => e.AssessmentSTDCrossRefId)
                .HasColumnName("AssessmentSTDCrossRefId")
                .IsRequired();

            builder.Property(e => e.AssessmentSTDId)
                .HasColumnName("AssessmentSTDId")
                .IsRequired();

            builder.Property(e => e.CodeType)
                .HasColumnName("CodeType")
                .HasMaxLength(30) // Assuming varchar is limited to 30 characters
                .IsRequired();

            builder.Property(e => e.CodeValue)
                .HasColumnName("CodeValue")
                .HasMaxLength(30) // Assuming varchar is limited to 30 characters
                .IsRequired();

            // Relationships
            builder.HasOne(e => e.AssessmentSTD)
                .WithMany(a => a.AssessmentSTDCrossRefs)
                .HasForeignKey(e => e.AssessmentSTDId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
