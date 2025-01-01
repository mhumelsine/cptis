using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.EntityFramework.Configuration
{
    public class NursingAssessmentSexualAbuseConfiguration : IEntityTypeConfiguration<NursingAssessmentSexualAbuse>
    {
        public void Configure(EntityTypeBuilder<NursingAssessmentSexualAbuse> builder)
        {
            // Table name
            builder.ToTable("NursingAssessmentSexualAbuse");

            // Primary Key
            builder.HasKey(e => e.NursingAssessmentSexualAbuseId);

            builder.Audit(x => x.Audit);

            // Properties
            builder.Property(e => e.PenileVaginal)
                .IsRequired();

            builder.Property(e => e.OralVaginal)
                .IsRequired();

            builder.Property(e => e.ForcedMasturbation)
                .IsRequired();

            builder.Property(e => e.PenileAnal)
                .IsRequired();

            builder.Property(e => e.OralAnal)
                .IsRequired();

            builder.Property(e => e.AllegedPerpCv)
                .IsRequired();

            builder.Property(e => e.DigitalVaginal)
                .IsRequired();

            builder.Property(e => e.ObjectVaginal)
                .IsRequired();

            builder.Property(e => e.Fellatio)
                .IsRequired();

            builder.Property(e => e.DigitalAnal)
                .IsRequired();

            builder.Property(e => e.ObjectAnal)
                .IsRequired();

            builder.Property(e => e.ExposureToPorn)
                .IsRequired();

            builder.Property(e => e.ForcedParticipationPorn)
                .IsRequired();

            builder.Property(e => e.Std)
                .HasMaxLength(30);

            builder.Property(e => e.OtherSexual)
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
                .WithMany(n => n.SexualAbuses)
                .HasForeignKey(e => e.NursingAssessmentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }

}
