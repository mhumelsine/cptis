using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.EntityFramework.Configuration
{
    public class NursingAssessmentMedicationConfiguration : IEntityTypeConfiguration<NursingAssessmentMedication>
    {
        public void Configure(EntityTypeBuilder<NursingAssessmentMedication> builder)
        {
            // Table name
            builder.ToTable("NursingAssessmentMedication");

            // Primary Key
            builder.HasKey(nm => nm.NursingAssessmentMedicationId);

            builder.Audit(x => x.Audit);

            // Foreign Key Relationship
            builder.HasOne(nm => nm.NursingAssessment)
                .WithMany()
                .HasForeignKey(nm => nm.NursingAssessmentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Property configurations
            builder.Property(nm => nm.Name)
                .HasMaxLength(100) // Maximum length for the medication name
                .IsRequired(false);

            builder.Property(nm => nm.Dose)
                .HasMaxLength(50) // Maximum length for the dose
                .IsRequired(false);

            builder.Property(nm => nm.Route)
                .HasMaxLength(50) // Maximum length for the route
                .IsRequired(false);

            builder.Property(nm => nm.Frequency)
                .HasMaxLength(50) // Maximum length for the frequency
                .IsRequired(false);

            builder.Property(nm => nm.Reason)
                .HasMaxLength(200) // Maximum length for the reason
                .IsRequired(false);

            builder.Property(nm => nm.Timeframe)
                .HasMaxLength(100) // Maximum length for the timeframe
                .IsRequired(false);

            builder.Property(nm => nm.AdministeredBy)
                .HasMaxLength(100) // Maximum length for administered by
                .IsRequired(false);

            builder.Property(nm => nm.CreateDate)
                .HasColumnType("datetime") // Date type column
                .IsRequired(false);

            builder.Property(nm => nm.UpdateDate)
                .HasColumnType("datetime") // Date type column
                .IsRequired(false);

            builder.Property(nm => nm.UserFirstName)
                .HasMaxLength(30) // Maximum length for the user first name
                .IsRequired(false);

            builder.Property(nm => nm.UserLastName)
                .HasMaxLength(30) // Maximum length for the user last name
                .IsRequired(false);
        }
    }
}
