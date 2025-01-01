using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.EntityFramework.Configuration
{
    public class AssessmentObserverConfiguration : IEntityTypeConfiguration<AssessmentObserver>
    {
        public void Configure(EntityTypeBuilder<AssessmentObserver> builder)
        {
            // Table Name
            builder.ToTable("AssessmentObserver");

            builder.Audit(x => x.Audit);

            // Primary Key
            builder.HasKey(e => e.AssessmentObserverId);

            // Properties with Column Mappings
            builder.Property(e => e.AssessmentObserverId)
                .HasColumnName("AssessmentObserverId")
                .IsRequired();

            builder.Property(e => e.InterviewId)
                .HasColumnName("InterviewId");

            builder.Property(e => e.AbuseReportNumber)
                .HasColumnName("AbuseReportNumber")
                .HasMaxLength(30);

            builder.Property(e => e.AssessmentSequenceNumber)
                .HasColumnName("AssessmentSequenceNumber")
                .HasMaxLength(30);

            builder.Property(e => e.RegistrationSequenceNumber)
                .HasColumnName("RegistrationSequenceNumber")
                .HasMaxLength(30);

            builder.ComplexProperty(x => x.ClientId, options =>
            {
                options.Property(x => x.Value)
                    .HasColumnName("client_id")
                    .HasMaxLength(30);
            });

            builder.Property(e => e.Name)
                .HasColumnName("Name")
                .HasMaxLength(100);

            builder.Property(e => e.Title)
                .HasColumnName("Title")
                .HasMaxLength(50);

            builder.Property(e => e.Agency)
                .HasColumnName("Agency")
                .HasMaxLength(100);

            builder.Property(e => e.CreateDate)
                .HasColumnName("CreateDate");

            builder.Property(e => e.UpdateDate)
                .HasColumnName("UpdateDate");

            builder.Property(e => e.AssessmentId)
                .HasColumnName("AssessmentId");

            builder.Property(e => e.ClientDemographicId)
                .HasColumnName("ClientDemographicId");

            // Relationships
            builder.HasOne(e => e.Assessment)
                .WithMany(a => a.AssessmentObservers)
                .HasForeignKey(e => e.AssessmentId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(e => e.ClientDemographic)
                .WithMany(c => c.AssessmentObservers)
                .HasForeignKey(e => e.ClientDemographicId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }

}
