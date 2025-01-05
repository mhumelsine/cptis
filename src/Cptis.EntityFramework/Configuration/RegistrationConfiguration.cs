using Cptis.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cptis.EntityFramework.Configuration
{
    public class RegistrationConfiguration : IEntityTypeConfiguration<Registration>
    {
        public void Configure(EntityTypeBuilder<Registration> builder)
        {
            builder.ToTable("Registration");

            builder.HasKey(e => e.RegistrationId);
            builder.Audit(x => x.Audit);

            builder.Property(e => e.RegistrationSequenceNum).HasMaxLength(2);
            builder.Property(e => e.CaseNumber).HasMaxLength(11);
            builder.Property(e => e.CptOffice).HasMaxLength(5);
            builder.Property(e => e.County).HasMaxLength(2);
            builder.Property(e => e.CoordinatorCode).HasMaxLength(10);
            builder.Property(e => e.CaseCoordinator).HasMaxLength(100);
            builder.Property(e => e.ReferralSource).HasMaxLength(10);
            builder.Property(e => e.Comment).HasMaxLength(1000);
            builder.Property(e => e.OverallCptAssessment).HasMaxLength(5);
            builder.Property(e => e.UserFirstName).HasMaxLength(30);
            builder.Property(e => e.UserLastName).HasMaxLength(30);
            builder.Property(e => e.CPIName).HasMaxLength(30);
            builder.Property(e => e.Comments).HasMaxLength(1000);
            builder.Property(e => e.IsCrossTeam).HasMaxLength(5);
            builder.Property(e => e.CrossTeamOffice).HasMaxLength(5);
            builder.Property(e => e.CrossTeamCoordinatorCode).HasMaxLength(30);
            builder.Property(e => e.SecondReferralSource).HasMaxLength(5);
            builder.Property(e => e.AlternateAbuseReportNums).HasMaxLength(11);
            builder.Property(e => e.EarlyStepsReferred).HasMaxLength(5);
            builder.Property(e => e.EarlyStepsScreened).HasMaxLength(5);
            builder.Property(e => e.EarlyStepsCurrentlyEnrolled).HasMaxLength(5);
            builder.Property(e => e.EarlyStepsMeetsReferral).HasMaxLength(5);
            builder.Property(e => e.ReferredToSATP).HasMaxLength(5);
            builder.Property(e => e.EarlyStepsDevelopmentalDelayIdentified).HasMaxLength(5);
            builder.Property(e => e.EarlyStepsReferredOtherAgency).HasMaxLength(5);
            builder.Property(e => e.EarlyStepsReferredOtherAgencyName).HasMaxLength(100);
            builder.Property(e => e.NASDiagnosis).HasMaxLength(5);
            builder.Property(e => e.ReferredToSATPOtherAgencyReason).HasMaxLength(5);
            builder.Property(e => e.ReferredToSATPOtherAgencyName).HasMaxLength(100);
            builder.Property(e => e.EarlyInterventionAgencyName).HasMaxLength(100);
            builder.Property(e => e.EarlyInterventionVerified).HasMaxLength(5);
            builder.Property(e => e.EarlyInterventionDeclared).HasMaxLength(5);
            builder.Property(e => e.NASSuspected).HasMaxLength(5);
            builder.Property(e => e.NASConfirmed).HasMaxLength(5);
            builder.Property(e => e.SourceOfConfirmationSuspected).HasMaxLength(5);
            builder.Property(e => e.SourceOfConfirmationConfirmed).HasMaxLength(5);
            builder.Property(e => e.ReferralNotSubmittedReasonText).HasMaxLength(100);
            builder.Property(e => e.ScreenedVerified).HasMaxLength(5);
            builder.Property(e => e.ScreenedDeclared).HasMaxLength(5);
            builder.Property(e => e.ScreenedAgencyProvider).HasMaxLength(30);
            builder.Property(e => e.ScreenedDropDown).HasMaxLength(30);
            builder.Property(e => e.ReasonNotScreened).HasMaxLength(5);
            builder.Property(e => e.NotScreenedDropDown).HasMaxLength(5);
            builder.Property(e => e.OnCallCase).HasMaxLength(5);
            builder.Property(e => e.ReferredToSATPLocation).HasMaxLength(30);
            builder.Property(e => e.CreatedBy).HasMaxLength(30);
            builder.Property(e => e.UpdatedBy).HasMaxLength(30);

            builder.HasOne(e => e.Intake)
                .WithMany()
                .HasForeignKey(e => e.IntakeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.AbuseReport)
                .WithMany()
                .HasForeignKey(e => e.AbuseReportId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
