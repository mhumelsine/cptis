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
    public class NursingAssessmentReferralConfiguration : IEntityTypeConfiguration<NursingAssessmentReferral>
    {
        public void Configure(EntityTypeBuilder<NursingAssessmentReferral> builder)
        {
            // Table name
            builder.ToTable("NursingAssessmentReferral");

            // Primary Key
            builder.HasKey(r => r.NursingAssessmentReferralId);

            builder.Audit(x => x.Audit);

            // Foreign Key Relationship
            builder.HasOne(r => r.NursingAssessment)
                .WithMany()
                .HasForeignKey(r => r.NursingAssessmentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Property configurations
            builder.Property(r => r.ReferralType)
                .HasMaxLength(50) // Maximum length for referral type
                .IsRequired(false);

            builder.Property(r => r.Name)
                .HasMaxLength(100) // Maximum length for name
                .IsRequired(false);

            builder.Property(r => r.CreateDate)
                .HasColumnType("datetime") // Date type column
                .IsRequired(false);

            builder.Property(r => r.UpdateDate)
                .HasColumnType("datetime") // Date type column
                .IsRequired(false);

            builder.Property(r => r.UserFirstName)
                .HasMaxLength(30) // Maximum length for the user first name
                .IsRequired(false);

            builder.Property(r => r.UserLastName)
                .HasMaxLength(30) // Maximum length for the user last name
                .IsRequired(false);

            builder.HasOne(e => e.NursingAssessment)
                .WithMany(n => n.NursingAssessmentReferrals)
                .HasForeignKey(e => e.NursingAssessmentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
