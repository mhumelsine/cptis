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
    /// Configuration for the SatpAbuse entity.
    /// </summary>
    public class SatpAbuseConfiguration : IEntityTypeConfiguration<SatpAbuse>
    {
        public void Configure(EntityTypeBuilder<SatpAbuse> builder)
        {
            // Table name
            builder.ToTable("SatpAbuse");

            // Primary key
            builder.HasKey(e => e.SatpAbuseId);

            // Properties
            builder.Property(e => e.AbuseType)
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(e => e.UserFirstName)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(e => e.UserLastName)
                .HasMaxLength(30)
                .IsRequired(false);

            builder.Property(e => e.IsDeleted)
                .IsRequired();

            // Relationships
            builder.HasOne(e => e.SatpIntake)
                .WithMany(si => si.SatpAbuses)
                .HasForeignKey(e => e.SatpIntakeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
