using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.EntityFramework.Configuration
{
    public class NursingAssessmentAdditionalInfoConfiguration : IEntityTypeConfiguration<NursingAssessmentAdditionalInfo>
    {
        public void Configure(EntityTypeBuilder<NursingAssessmentAdditionalInfo> builder)
        {
            // Table name
            builder.ToTable("NursingAssessmentAdditionalInfo");

            // Primary Key
            builder.HasKey(na => na.NursingAssessmentAdditionalInfoId);

            builder.Audit(x => x.Audit);

            // Foreign Key Relationship
            builder.HasOne(na => na.NursingAssessment)
                .WithMany()
                .HasForeignKey(na => na.NursingAssessmentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Property configurations
            builder.Property(na => na.FeedingStatus)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(na => na.FeedingComment)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(na => na.BathingStatus)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(na => na.BathingComment)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(na => na.ToiletingStatus)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(na => na.ToiletingComment)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(na => na.DressingStatus)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(na => na.DressingComment)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(na => na.MobilityStatus)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(na => na.MobilityComment)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(na => na.PlayStatus)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(na => na.PlayComment)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(na => na.SleepHabitStatus)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(na => na.SleepHabitComment)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(na => na.CommunicationStatus)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(na => na.CommunicationComment)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(na => na.CognitiveStatus)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(na => na.CognitiveComment)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(na => na.SocialEmotionalStatus)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(na => na.SocialEmotionalComment)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(na => na.DevelopmentalStatus)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(na => na.DevelopmentalComment)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(na => na.ChokeOnFoodStatus)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(na => na.ChokeOnFoodComment)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(na => na.PickyEaterStatus)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(na => na.PickyEaterComment)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(na => na.SpecialDietStatus)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(na => na.SpecialDietComment)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(na => na.CreateDate)
                .HasColumnType("datetime")
                .IsRequired(false);

            builder.Property(na => na.UpdateDate)
                .HasColumnType("datetime")
                .IsRequired(false);

            builder.Property(na => na.UserFirstName)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(na => na.UserLastName)
                .HasMaxLength(30)
                .IsRequired(false);
        }
    }
}
