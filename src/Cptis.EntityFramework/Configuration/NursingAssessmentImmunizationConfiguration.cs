using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.EntityFramework.Configuration
{
    public class NursingAssessmentImmunizationConfiguration : IEntityTypeConfiguration<NursingAssessmentImmunization>
    {
        public void Configure(EntityTypeBuilder<NursingAssessmentImmunization> builder)
        {
            // Table name
            builder.ToTable("NursingAssessmentImmunization");

            // Primary Key
            builder.HasKey(ni => ni.NursingAssessmentImmunizationsId);

            builder.Audit(x => x.Audit);

            // Foreign Key Relationship
            builder.HasOne(ni => ni.NursingAssessment)
                .WithMany()
                .HasForeignKey(ni => ni.NursingAssessmentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Property configurations
            builder.Property(ni => ni.Vaccine)
                .HasMaxLength(100) // Maximum length for the vaccine name
                .IsRequired(false);

            builder.Property(ni => ni.Reason)
                .HasMaxLength(200) // Maximum length for the reason
                .IsRequired(false);

            builder.Property(ni => ni.CreateDate)
                .HasColumnType("datetime") // Date type column
                .IsRequired(false);

            builder.Property(ni => ni.UpdateDate)
                .HasColumnType("datetime") // Date type column
                .IsRequired(false);

            builder.Property(ni => ni.UserFirstName)
                .HasMaxLength(30) // Maximum length of the user first name
                .IsRequired(false);

            builder.Property(ni => ni.UserLastName)
                .HasMaxLength(30) // Maximum length of the user last name
                .IsRequired(false);
        }
    }
}
