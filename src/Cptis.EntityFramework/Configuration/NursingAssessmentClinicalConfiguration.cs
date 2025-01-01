using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.EntityFramework.Configuration
{
    public class NursingAssessmentClinicalConfiguration : IEntityTypeConfiguration<NursingAssessmentClinical>
    {
        public void Configure(EntityTypeBuilder<NursingAssessmentClinical> builder)
        {
            // Table name
            builder.ToTable("NursingAssessmentClinical");

            // Primary Key
            builder.HasKey(nc => nc.NursingAssessmentClinicalId);

            builder.Audit(x => x.Audit);

            // Foreign Key Relationship
            builder.HasOne(nc => nc.NursingAssessment)
                .WithMany()
                .HasForeignKey(nc => nc.NursingAssessmentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Property configurations
            builder.Property(nc => nc.Service)
                .HasMaxLength(100) // Maximum length of the service description
                .IsRequired(false);

            builder.Property(nc => nc.NumOccurences)
                .IsRequired(false);

            builder.Property(nc => nc.Reason)
                .HasMaxLength(200) // Maximum length of the reason description
                .IsRequired(false);

            builder.Property(nc => nc.CreateDate)
                .HasColumnType("datetime") // Date type column
                .IsRequired(false);

            builder.Property(nc => nc.UpdateDate)
                .HasColumnType("datetime") // Date type column
                .IsRequired(false);

            builder.Property(nc => nc.UserFirstName)
                .HasMaxLength(30) // Maximum length of the user first name
                .IsRequired(false);

            builder.Property(nc => nc.UserLastName)
                .HasMaxLength(30) // Maximum length of the user last name
                .IsRequired(false);
        }
    }
}
