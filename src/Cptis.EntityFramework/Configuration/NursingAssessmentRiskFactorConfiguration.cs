using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.EntityFramework.Configuration
{
    public class NursingAssessmentRiskFactorConfiguration : IEntityTypeConfiguration<NursingAssessmentRiskFactor>
    {
        public void Configure(EntityTypeBuilder<NursingAssessmentRiskFactor> builder)
        {
            // Table name
            builder.ToTable("NursingAssessmentRiskFactor");

            // Primary Key
            builder.HasKey(e => e.NursingAssessmentRiskFactorId);

            builder.Audit(x => x.Audit);

            // Properties
            builder.Property(e => e.ChildUnder2)
                .IsRequired();

            builder.Property(e => e.SpecialNeeds)
                .IsRequired();

            builder.Property(e => e.CareGiverArrestHx)
                .IsRequired();

            builder.Property(e => e.ChildStatesFear)
                .IsRequired();

            builder.Property(e => e.PriorDcfReports)
                .IsRequired();

            builder.Property(e => e.HxOfViolence)
                .IsRequired();

            builder.Property(e => e.SeverityOfIncident)
                .IsRequired();

            builder.Property(e => e.ParentHxAbuse)
                .IsRequired();

            builder.Property(e => e.PriorCptReferrals)
                .IsRequired();

            builder.Property(e => e.ChildToYoung)
                .IsRequired();

            builder.Property(e => e.Isolation)
                .IsRequired();

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
                .WithMany(n => n.RiskFactors)
                .HasForeignKey(e => e.NursingAssessmentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }

}
