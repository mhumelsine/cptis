using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cptis.EntityFramework.Configuration
{
    /// <summary>
    /// Configuration for the SatpService entity.
    /// </summary>
    public class SatpServiceConfiguration : IEntityTypeConfiguration<SatpService>
    {
        public void Configure(EntityTypeBuilder<SatpService> builder)
        {
            // Table name
            builder.ToTable("SatpService");

            // Primary key
            builder.HasKey(e => e.SatpServicesId);

            // Properties
            builder.Property(e => e.CaseNumber)
                .HasMaxLength(30);

            builder.Property(e => e.LawEnforcementReportNum)
                .HasMaxLength(30);

            builder.Property(e => e.ProviderId)
                .HasMaxLength(30);

            builder.Property(e => e.ServiceTypeCode)
                .HasMaxLength(30);

            builder.Property(e => e.FundingSourceCode)
                .HasMaxLength(30);

            builder.Property(e => e.BeginTime)
                .HasMaxLength(10);

            builder.Property(e => e.EndTime)
                .HasMaxLength(10);

            builder.Property(e => e.LocationCode)
                .HasMaxLength(30);

            builder.Property(e => e.UserFirstName)
                .HasMaxLength(30);

            builder.Property(e => e.UserLastName)
                .HasMaxLength(30);

            builder.Property(e => e.OtherFunding)
                .HasMaxLength(100);

            // Required fields
            builder.Property(e => e.ServiceDate)
                .IsRequired();

            builder.Property(e => e.CreateDate)
                .IsRequired();

            builder.Property(e => e.UpdateDate)
                .IsRequired();

            builder.Property(e => e.NumUnits)
                .IsRequired();
        }
    }
}
