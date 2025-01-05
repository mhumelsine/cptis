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
    public class NursingAssessmentEquipmentConfiguration : IEntityTypeConfiguration<NursingAssessmentEquipment>
    {
        public void Configure(EntityTypeBuilder<NursingAssessmentEquipment> builder)
        {
            // Table name
            builder.ToTable("NursingAssessmentEquipment");

            // Primary Key
            builder.HasKey(ne => ne.NursingAssessmentEquipmentId);

            // Foreign Key Relationship
            builder.HasOne(ne => ne.NursingAssessment)
                .WithMany()
                .HasForeignKey(ne => ne.NursingAssessmentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Audit(x => x.Audit);

            // Property configurations
            builder.Property(ne => ne.Name)
                .HasMaxLength(100) // Maximum length for the equipment name
                .IsRequired(false);

            builder.Property(ne => ne.Frequency)
                .HasMaxLength(50) // Maximum length for the frequency
                .IsRequired(false);

            builder.Property(ne => ne.Reason)
                .HasMaxLength(200) // Maximum length for the reason
                .IsRequired(false);

            builder.Property(ne => ne.CreateDate)
                .HasColumnType("datetime") // Date type column
                .IsRequired(false);

            builder.Property(ne => ne.UpdateDate)
                .HasColumnType("datetime") // Date type column
                .IsRequired(false);

            builder.Property(ne => ne.UserFirstName)
                .HasMaxLength(30) // Maximum length of the user first name
                .IsRequired(false);

            builder.Property(ne => ne.UserLastName)
                .HasMaxLength(30) // Maximum length of the user last name
                .IsRequired(false);

            builder.HasOne(e => e.NursingAssessment)
                .WithMany(n => n.NursingAssessmentEquipments)
                .HasForeignKey(e => e.NursingAssessmentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
