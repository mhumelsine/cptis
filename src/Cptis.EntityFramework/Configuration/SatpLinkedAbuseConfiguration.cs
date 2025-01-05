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
    /// <summary>
    /// Configuration for the SatpLinkedAbuse entity.
    /// </summary>
    public class SatpLinkedAbuseConfiguration : IEntityTypeConfiguration<SatpLinkedAbuse>
    {
        public void Configure(EntityTypeBuilder<SatpLinkedAbuse> builder)
        {
            // Table name
            builder.ToTable("SatpLinkedAbuse");

            // Primary key
            builder.HasKey(e => e.SatpLinkedAbuseId);

            // Properties
            builder.Property(e => e.CaseNumber)
                .HasMaxLength(30);

            builder.Property(e => e.LawEnforcementReportNum)
                .HasMaxLength(30);

            builder.Property(e => e.UserFirstName)
                .HasMaxLength(30);

            builder.Property(e => e.UserLastName)
                .HasMaxLength(30);

            builder.Property(e => e.CreateDate)
                .IsRequired();

            builder.Property(e => e.UpdateDate)
                .IsRequired();

            // Relationships
            builder.HasOne<SatpIntake>()
                .WithMany()
                .HasForeignKey(e => e.SatpIntakeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
