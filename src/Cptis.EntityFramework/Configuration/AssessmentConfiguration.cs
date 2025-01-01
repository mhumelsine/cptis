using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.EntityFramework.Configuration
{
    public class AssessmentConfiguration : IEntityTypeConfiguration<Assessment>
    {
        public void Configure(EntityTypeBuilder<Assessment> builder)
        {
            builder.ToTable("Assessment");

            builder.HasKey(e => e.AssessmentId);
            builder.Audit(x => x.Audit);

            builder.ComplexProperty(x => x.ClientId, options =>
            {
                options.Property(x => x.Value)
                    .HasColumnName("client_id")
                    .HasMaxLength(30);
            });
            builder.Property(e => e.AbuseReportNumber).HasMaxLength(30);
            builder.Property(e => e.ProviderCode).HasMaxLength(30);
            builder.Property(e => e.ServiceType).HasMaxLength(30);
            builder.Property(e => e.Location).HasMaxLength(100);
            builder.Property(e => e.Comment).HasMaxLength(500);
            builder.Property(e => e.CptOffice).HasMaxLength(50);
            builder.Property(e => e.Telemedicine).HasMaxLength(30);
            builder.Property(e => e.RemoteSite).HasMaxLength(30);
            builder.Property(e => e.HubSite).HasMaxLength(30);
            builder.Property(e => e.MedicalExamPhysical).HasMaxLength(50);
            builder.Property(e => e.MedicalExamNeglect).HasMaxLength(50);
            builder.Property(e => e.MedicalExamSexual).HasMaxLength(50);
            builder.Property(e => e.ProviderType).HasMaxLength(50);
            builder.Property(e => e.County).HasMaxLength(30);
            builder.Property(e => e.CourtActivityType).HasMaxLength(50);
            builder.Property(e => e.WaitTime).HasMaxLength(30);
            builder.Property(e => e.UserFirstName).HasMaxLength(50);
            builder.Property(e => e.UserLastName).HasMaxLength(50);
            builder.Property(e => e.AssessmentType).HasMaxLength(30);
            builder.Property(e => e.DCFReason).HasMaxLength(50);
            builder.Property(e => e.PositiveFinding).HasMaxLength(50);
            builder.Property(e => e.ReferralSource).HasMaxLength(100);
            builder.Property(e => e.HandbookRequirementNotMet).HasMaxLength(50);
            builder.Property(e => e.RemoteProvider).HasMaxLength(50);
            builder.Property(e => e.CACFunding).HasMaxLength(50);
            builder.Property(e => e.OtherFunding).HasMaxLength(50);
            builder.Property(e => e.MedicallyComplex).HasMaxLength(50);
            builder.Property(e => e.PhysicianWithExpertise).HasMaxLength(50);
            builder.Property(e => e.CMSNetworkPhysician).HasMaxLength(50);
            builder.Property(e => e.MPCOther).HasMaxLength(50);
            builder.Property(e => e.UnableToComply).HasMaxLength(50);
            builder.Property(e => e.UnableToComplyDescription).HasMaxLength(255);
            builder.Property(e => e.Obesity).HasMaxLength(50);
            builder.Property(e => e.NutritionalCounseling).HasMaxLength(50);
            builder.Property(e => e.DCFNotified).HasMaxLength(50);
            builder.Property(e => e.ObesityDescribe).HasMaxLength(255);
            builder.Property(e => e.MPCOtherDescribe).HasMaxLength(255);
            builder.Property(e => e.MedicalNeglectSubstantiated).HasMaxLength(50);
            builder.Property(e => e.OnCall).HasMaxLength(50);
            builder.Property(e => e.MunchausenSyndrome).HasMaxLength(50);
            builder.Property(e => e.IsVoca).HasMaxLength(50);
            builder.Property(e => e.AssessmentSequenceNumber).HasMaxLength(30);
            builder.Property(e => e.RegistrationSequenceNumber).HasMaxLength(30);

            builder.HasOne(e => e.ClientDemographic)
                .WithMany()
                .HasForeignKey(e => e.ClientDemographicId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Registration)
                .WithMany()
                .HasForeignKey(e => e.RegistrationId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.AbuseReport)
                .WithMany()
                .HasForeignKey(e => e.AbuseReportId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
