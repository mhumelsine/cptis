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
    public class NursingAssessmentConfiguration : IEntityTypeConfiguration<NursingAssessment>
    {
        public void Configure(EntityTypeBuilder<NursingAssessment> builder)
        {
            // Table name
            builder.ToTable("NursingAssessment");

            // Primary key
            builder.HasKey(na => na.NursingAssessmentId);

            builder.Audit(x => x.Audit);

            // Property configurations
            builder.Property(na => na.NursingAssessmentId)
                .ValueGeneratedOnAdd();

            builder.Property(na => na.NursingAssessmentNum)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(na => na.AbuseReportNumber)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.ComplexProperty(x => x.ClientId, options =>
            {
                options.Property(x => x.Value)
                    .HasColumnName("client_id")
                    .HasMaxLength(30);
            });

            builder.Property(na => na.AssessmentSequenceNumber)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(na => na.RegistrationSequenceNumber)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(na => na.AccompaniedBy)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(na => na.Relationship)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(na => na.CareGiverPresent)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(na => na.PcProviderFName)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(na => na.PcProviderLName)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(na => na.PcProviderAddress)
                .HasMaxLength(100)
                .IsRequired(false);

            builder.Property(na => na.PcCity)
                .HasMaxLength(50)
                .IsRequired(false);

            builder.Property(na => na.PcState)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(na => na.PcZip)
                .HasMaxLength(15)
                .IsRequired(false);

            builder.Property(na => na.PatientHistoryPer)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(na => na.AcuteMedicalComment)
                .HasMaxLength(500)
                .IsRequired(false);

            builder.Property(na => na.ChronicMedicalComment)
                .HasMaxLength(500)
                .IsRequired(false);

            builder.Property(na => na.Allergies)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(na => na.ClinicalHistory)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(na => na.Immunizations)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(na => na.Medication)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(na => na.Treatment)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(na => na.Equipment)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(na => na.Height)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(na => na.Weight)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(na => na.HeadCircumference)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(na => na.BMI)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(na => na.Photos)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(na => na.PhotoSteleMed)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(na => na.PhotosDigital)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(na => na.FdleKit)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(na => na.Diagrams)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(na => na.DiagramsHc)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(na => na.DiagramsGc)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(na => na.CrimesInfoGiven)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(na => na.NursingDiagnosis)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(na => na.MedicalReferral)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(na => na.MedicalReferralName)
                .HasMaxLength(100)
                .IsRequired(false);

            builder.Property(na => na.EarlyStepsReferral)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(na => na.EarlyStepsReferralName)
                .HasMaxLength(100)
                .IsRequired(false);

            builder.Property(na => na.OtherReferral)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(na => na.OtherReferralName)
                .HasMaxLength(100)
                .IsRequired(false);

            builder.Property(na => na.ProviderSignature)
                .HasMaxLength(100)
                .IsRequired(false);

            builder.Property(na => na.AssessmentDate)
                .HasColumnType("datetime")
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

            builder.Property(na => na.ProviderDate)
                .HasColumnType("datetime")
                .IsRequired(false);

            builder.Property(na => na.AbuseReportId)
                .IsRequired(false);

            builder.Property(na => na.ClientDemographicId)
                .IsRequired(false);

            builder.Property(na => na.AssessmentId)
                .IsRequired(false);

            builder.Property(na => na.RegistrationId)
                .IsRequired(false);

            builder.Property(na => na.IsDeleted)
                .IsRequired();

            // Relationships
            builder.HasOne(na => na.AbuseReport)
                .WithMany()
                .HasForeignKey(na => na.AbuseReportId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(na => na.ClientDemographic)
                .WithMany()
                .HasForeignKey(na => na.ClientDemographicId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(na => na.Assessment)
                .WithMany()
                .HasForeignKey(na => na.AssessmentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(na => na.Registration)
                .WithMany()
                .HasForeignKey(na => na.RegistrationId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
