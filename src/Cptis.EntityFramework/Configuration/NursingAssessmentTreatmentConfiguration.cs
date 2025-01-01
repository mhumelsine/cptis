using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.EntityFramework.Configuration
{
    public class NursingAssessmentTreatmentConfiguration : IEntityTypeConfiguration<NursingAssessmentTreatment>
    {
        public void Configure(EntityTypeBuilder<NursingAssessmentTreatment> builder)
        {
            // Table name
            builder.ToTable("NursingAssessmentTreatment");

            // Primary Key
            builder.HasKey(e => e.NursingAssessmentTreatmentId);

            builder.Audit(x => x.Audit);

            // Properties
            builder.Property(e => e.Name)
                .HasMaxLength(255)
                .IsRequired(false);

            builder.Property(e => e.Frequency)
                .HasMaxLength(50)
                .IsRequired(false);

            builder.Property(e => e.Reason)
                .HasMaxLength(255)
                .IsRequired(false);

            builder.Property(e => e.CreateDate)
                .HasColumnType("datetime");

            builder.Property(e => e.UpdateDate)
                .HasColumnType("datetime");

            builder.Property(e => e.UserFirstName)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(e => e.UserLastName)
                .HasMaxLength(30)
                .IsRequired(false);

            // Relationships
            builder.HasOne(e => e.NursingAssessment)
                .WithMany(n => n.Treatments)
                .HasForeignKey(e => e.NursingAssessmentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
