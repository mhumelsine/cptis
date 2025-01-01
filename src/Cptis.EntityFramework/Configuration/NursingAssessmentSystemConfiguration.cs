using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.EntityFramework.Configuration
{
    public class NursingAssessmentSystemConfiguration : IEntityTypeConfiguration<NursingAssessmentSystem>
    {
        public void Configure(EntityTypeBuilder<NursingAssessmentSystem> builder)
        {
            // Table name
            builder.ToTable("NursingAssessmentSystem");

            // Primary Key
            builder.HasKey(e => e.NursingAssessmentSystemId);

            builder.Audit(x => x.Audit);

            // Properties
            builder.Property(e => e.EyeVisionStatus)
                .HasMaxLength(50);

            builder.Property(e => e.EyeVision)
                .HasMaxLength(255);

            builder.Property(e => e.EarHearingStatus)
                .HasMaxLength(50);

            builder.Property(e => e.EarHearing)
                .HasMaxLength(255);

            builder.Property(e => e.NoseThroatStatus)
                .HasMaxLength(50);

            builder.Property(e => e.NoseThroat)
                .HasMaxLength(255);

            builder.Property(e => e.OralDentalStatus)
                .HasMaxLength(50);

            builder.Property(e => e.OralDental)
                .HasMaxLength(255);

            builder.Property(e => e.RespiratoryStatus)
                .HasMaxLength(50);

            builder.Property(e => e.Respiratory)
                .HasMaxLength(255);

            builder.Property(e => e.CardioVascularStatus)
                .HasMaxLength(50);

            builder.Property(e => e.CardioVascular)
                .HasMaxLength(255);

            builder.Property(e => e.GastroIntestinalStatus)
                .HasMaxLength(50);

            builder.Property(e => e.GastroIntestinal)
                .HasMaxLength(255);

            builder.Property(e => e.GenitourinaryStatus)
                .HasMaxLength(50);

            builder.Property(e => e.Genitourinary)
                .HasMaxLength(255);

            builder.Property(e => e.EndocrineStatus)
                .HasMaxLength(50);

            builder.Property(e => e.Endocrine)
                .HasMaxLength(255);

            builder.Property(e => e.DermatologicStatus)
                .HasMaxLength(50);

            builder.Property(e => e.Dermatologic)
                .HasMaxLength(255);

            builder.Property(e => e.MusculoSkeletalStatus)
                .HasMaxLength(50);

            builder.Property(e => e.MusculoSkeletal)
                .HasMaxLength(255);

            builder.Property(e => e.HematologicStatus)
                .HasMaxLength(50);

            builder.Property(e => e.Hematologic)
                .HasMaxLength(255);

            builder.Property(e => e.NeurologicalStatus)
                .HasMaxLength(50);

            builder.Property(e => e.Neurological)
                .HasMaxLength(255);

            builder.Property(e => e.DevelopmentStatus)
                .HasMaxLength(50);

            builder.Property(e => e.Development)
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
                .WithMany(n => n.SystemAssessments)
                .HasForeignKey(e => e.NursingAssessmentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }

}
