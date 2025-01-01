using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.EntityFramework.Configuration
{
    public class AssessmentDocumentConfiguration : IEntityTypeConfiguration<AssessmentDocument>
    {
        public void Configure(EntityTypeBuilder<AssessmentDocument> builder)
        {
            // Table Name
            builder.ToTable("AssessmentDocument");

            builder.Audit(x => x.Audit);

            // Primary Key
            builder.HasKey(e => e.AssessmentDocumentId);

            // Properties with Column Mappings
            builder.Property(e => e.AssessmentDocumentId)
                .HasColumnName("AssessmentDocumentId")
                .IsRequired();

            builder.Property(e => e.AbuseReportNumber)
                .HasColumnName("AbuseReportNumber")
                .HasMaxLength(30);

            builder.Property(e => e.AbuseReportSequenceNumber)
                .HasColumnName("AbuseReportSequenceNumber")
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

            builder.Property(e => e.DocumentFileName)
                .HasColumnName("DocumentFileName")
                .HasMaxLength(255);

            builder.Property(e => e.DocumentPath)
                .HasColumnName("DocumentPath")
                .HasMaxLength(255);

            builder.Property(e => e.CreateDate)
                .HasColumnName("CreateDate")
                .IsRequired();

            builder.Property(e => e.DocumentFileSize)
                .HasColumnName("DocumentFileSize")
                .IsRequired();

            builder.Property(e => e.DocumentName)
                .HasColumnName("DocumentName")
                .HasMaxLength(255);

            builder.Property(e => e.DocumentFileType)
                .HasColumnName("DocumentFileType")
                .HasMaxLength(50);

            builder.Property(e => e.AssessmentId)
                .HasColumnName("AssessmentId");

            builder.Property(e => e.ClientDemographicId)
                .HasColumnName("ClientDemographicId");

            builder.Property(e => e.UserFirstName)
                .HasColumnName("UserFirstName")
                .HasMaxLength(30);

            builder.Property(e => e.UserLastName)
                .HasColumnName("UserLastName")
                .HasMaxLength(30);

            builder.Property(e => e.IsDeleted)
                .HasColumnName("IsDeleted")
                .IsRequired();

            // Relationships
            builder.HasOne(e => e.Assessment)
                .WithMany(a => a.AssessmentDocuments)
                .HasForeignKey(e => e.AssessmentId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(e => e.ClientDemographic)
                .WithMany(c => c.AssessmentDocuments)
                .HasForeignKey(e => e.ClientDemographicId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
