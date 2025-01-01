using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.EntityFramework.Configuration
{
    public class NursingAssessmentObservationConfiguration : IEntityTypeConfiguration<NursingAssessmentObservation>
    {
        public void Configure(EntityTypeBuilder<NursingAssessmentObservation> builder)
        {
            // Table name
            builder.ToTable("NursingAssessmentObservation");

            // Primary Key
            builder.HasKey(no => no.NursingAssessmentObservationId);

            builder.Audit(x => x.Audit);

            // Foreign Key Relationship
            builder.HasOne(no => no.NursingAssessment)
                .WithMany()
                .HasForeignKey(no => no.NursingAssessmentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Property configurations
            builder.Property(no => no.GeneralAppearance)
                .HasMaxLength(500) // Maximum length for general appearance
                .IsRequired(false);

            builder.Property(no => no.PhysicalAbuse)
                .HasMaxLength(500) // Maximum length for physical abuse
                .IsRequired(false);

            builder.Property(no => no.Bruises)
                .HasMaxLength(500) // Maximum length for bruises
                .IsRequired(false);

            builder.Property(no => no.Cuts)
                .HasMaxLength(500) // Maximum length for cuts
                .IsRequired(false);

            builder.Property(no => no.Burns)
                .HasMaxLength(500) // Maximum length for burns
                .IsRequired(false);

            builder.Property(no => no.Fracture)
                .HasMaxLength(500) // Maximum length for fractures
                .IsRequired(false);

            builder.Property(no => no.Other)
                .HasMaxLength(1000) // Maximum length for additional observations
                .IsRequired(false);

            builder.Property(no => no.CreateDate)
                .HasColumnType("datetime") // Date type column
                .IsRequired(false);

            builder.Property(no => no.UpdateDate)
                .HasColumnType("datetime") // Date type column
                .IsRequired(false);

            builder.Property(no => no.UserFirstName)
                .HasMaxLength(30) // Maximum length for the user first name
                .IsRequired(false);

            builder.Property(no => no.UserLastName)
                .HasMaxLength(30) // Maximum length for the user last name
                .IsRequired(false);
        }
    }
}
