using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.EntityFramework.Configuration
{
    public class NursingAssessmentSocialHistoryConfiguration : IEntityTypeConfiguration<NursingAssessmentSocialHistory>
    {
        public void Configure(EntityTypeBuilder<NursingAssessmentSocialHistory> builder)
        {
            // Table name
            builder.ToTable("NursingAssessmentSocialHistory");

            // Primary Key
            builder.HasKey(e => e.NursingAssessmentSocialHistoryId);

            builder.Audit(x => x.Audit);

            // Properties
            builder.Property(e => e.ChildLivesWith)
                .HasMaxLength(255);

            builder.Property(e => e.EventsStatus)
                .HasMaxLength(50);

            builder.Property(e => e.Events)
                .HasMaxLength(255);

            builder.Property(e => e.BehavioralStatus)
                .HasMaxLength(50);

            builder.Property(e => e.Behavioral)
                .HasMaxLength(255);

            builder.Property(e => e.CaringForStatus)
                .HasMaxLength(50);

            builder.Property(e => e.CaringFor)
                .HasMaxLength(255);

            builder.Property(e => e.FamilyStrengthsStatus)
                .HasMaxLength(50);

            builder.Property(e => e.FamilyStrengths)
                .HasMaxLength(255);

            builder.Property(e => e.FamilySupportStatus)
                .HasMaxLength(50);

            builder.Property(e => e.FamilySupport)
                .HasMaxLength(255);

            builder.Property(e => e.FamilyEmploymentStatus)
                .HasMaxLength(50);

            builder.Property(e => e.FamilyEmployment)
                .HasMaxLength(255);

            builder.Property(e => e.HomeEnvironmentStatus)
                .HasMaxLength(50);

            builder.Property(e => e.HomeEnvironment)
                .HasMaxLength(255);

            builder.Property(e => e.TransportationStatus)
                .HasMaxLength(50);

            builder.Property(e => e.Transportation)
                .HasMaxLength(255);

            builder.Property(e => e.SchoolAndLearningStatus)
                .HasMaxLength(50);

            builder.Property(e => e.SchoolAndLearning)
                .HasMaxLength(255);

            builder.Property(e => e.CulturalStatus)
                .HasMaxLength(50);

            builder.Property(e => e.Cultural)
                .HasMaxLength(255);

            builder.Property(e => e.SubstanceAbuseStatus)
                .HasMaxLength(50);

            builder.Property(e => e.SubstanceAbuse)
                .HasMaxLength(255);

            builder.Property(e => e.CommunityServiceStatus)
                .HasMaxLength(50);

            builder.Property(e => e.CommunityService)
                .HasMaxLength(255);

            builder.Property(e => e.CreateDate)
                .HasColumnType("datetime");

            builder.Property(e => e.UpdateDate)
                .HasColumnType("datetime");

            builder.Property(e => e.UserFirstName)
                .HasMaxLength(30);

            builder.Property(e => e.UserLastName)
                .HasMaxLength(30);

            // Relationships
            builder.HasOne(e => e.NursingAssessment)
                .WithMany(n => n.SocialHistories)
                .HasForeignKey(e => e.NursingAssessmentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
